using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using KAFWebAdmin.MongoRepCollections.Repository;
using System.Web.Mvc;
using KAFWebAdmin.MongoRepCollections.MongoModel;

namespace KAFWebAdmin.Hubs
{
    public class ChatHub : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();

        private chMsgCollection _chtmsg = new chMsgCollection();

        private string IdentityName
        {
            get { return Context.User.Identity.Name; }
        }

        static ConcurrentDictionary<string, string> chatdic = new ConcurrentDictionary<string, string>();

        public void Send(string name, string message)
        {
            try
            {
                this._chtmsg.InsertContact(new MongoRepCollections.MongoModel.chtMsgModel()
                {
                    fromUserName = name,
                    toUserName = "all",
                    msg = message,
                    msgtype = "all",
                    Timestamp = DateTime.Now.Ticks.ToString()
                });
                Clients.All.broadcastMessage(name, message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SendToSpecific(string name, string message, string to)
        {
            // Call the broadcastMessage method to update clients.
            try
            {
                Clients.Caller.broadcastMessage(name, message);
                Clients.Client(chatdic[to]).broadcastMessage(name, message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Notify(string name, string id)
        {
            try
            {
                if (chatdic.ContainsKey(name))
                {
                    Clients.Caller.differentName();
                }
                else
                {
                    chatdic.TryAdd(name, id);
                    foreach (KeyValuePair<String, String> entry in chatdic)
                    {
                        Clients.Caller.online(entry.Key);
                    }
                    Clients.Others.enters(name);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override Task OnConnected()
        {
            //this.EnsureGroups();
            //this._chtmsg.InsertContact(new MongoRepCollections.MongoModel.chtMsgModel()
            //{
            //    fromUserName = name,
            //    toUserName = "",
            //    msg = message,
            //    msgtype = "all",
            //    Timestamp = DateTime.Now.Ticks.ToString()
            //});
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            try
            {
                var name = chatdic.FirstOrDefault(x => x.Value == Context.ConnectionId.ToString());
                string s;
                chatdic.TryRemove(name.Key, out s);
                return Clients.All.disconnected(name.Key);
            }
            catch (Exception ex)
            {
                return base.OnDisconnected(stopCalled);
            }
            finally
            {

            }
        }

        public override Task OnReconnected()
        {
            //var user = _Connections.Where(u => u.Username == IdentityName).First();
            //Clients.Caller.getProfileInfo(user.DisplayName, user.Avatar);
            return base.OnReconnected();
        }

        public async Task NewContosoChatMessage(string name)
        {
            try
            {
                List<chtMsgModel> objList = await _chtmsg.GetMSGForReConnect(name);
                string str = Newtonsoft.Json.JsonConvert.SerializeObject(objList, Newtonsoft.Json.Formatting.None);
                Clients.Caller.reloadmsg(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}