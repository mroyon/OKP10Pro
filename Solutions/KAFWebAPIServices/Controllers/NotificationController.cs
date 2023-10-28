using KAF.BusinessDataObjects;
using KAF.WebAPICommon.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KAFWebAPIServices.Controllers
{
    public class NotificationController : ApiController
    {

        public string _messageexchange = System.Configuration.ConfigurationManager.AppSettings["messageexchange"].ToString();
        public string _incomingqueue = System.Configuration.ConfigurationManager.AppSettings["incomingqueue"].ToString();
        public string _outgoingqueue = System.Configuration.ConfigurationManager.AppSettings["outgoingqueue"].ToString();


        [HttpPost]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/PostToQUEUE/{msg}")]
        public async Task<IHttpActionResult> PostToQUEUE(string msg)
        {
            try
            {
                await PushRabbit(msg, _incomingqueue);
                await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { result = "Done" });
        }

        [HttpPost]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/PopFromQUEUE")]
        public async Task<IHttpActionResult> PopFromQUEUE()
        {
            string msg = string.Empty;
            try
            {
                await PopRabbit("");
                await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { result = msg });
        }

        private async Task PushRabbit(string msg, string inqueue)
        {
            //IConnection connection = GetRabbitMqConnection();
            //IModel model = connection.CreateModel();
            //try
            //{
            //    model.ConfirmSelect();
            //    IBasicProperties basicProperties = model.CreateBasicProperties();
            //    model.BasicAcks += (sender, eventArgs) =>
            //    {
            //        string st = eventArgs.DeliveryTag.ToString();
            //    };
            //    var body = Encoding.UTF8.GetBytes(msg);
            //    model.BasicPublish(_messageexchange, inqueue, basicProperties, body);
            //    model.WaitForConfirmsOrDie();
            //    await Task.Delay(1).ConfigureAwait(true);
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    model.Dispose();
            //    connection.Dispose();
            //}
        }

        private async Task PopRabbit(string msg)
        {
        //    string message = string.Empty;
        //    IConnection connection = GetRabbitMqConnection();
        //    IModel model = connection.CreateModel();
        //    try
        //    {
        //        model.ExchangeDeclare(exchange: _messageexchange, type: "direct", durable: true);
        //        var queueDeclareResponse =  model.QueueDeclare(queue: _incomingqueue, durable: true, exclusive: false, autoDelete: false, arguments: null);
        //        var consumer = new EventingBasicConsumer(model);
        //        model.BasicConsume(_incomingqueue, true, consumer);
        //        model.BasicAcks += (sender, eventArgs) =>
        //        {

        //        };
        //        consumer.Received += (obj, ea) =>
        //        {
        //            var eventName = ea.RoutingKey;
        //            message = Encoding.UTF8.GetString(ea.Body);
        //            //await writetoConsole(message);
        //            PushRabbit(message, _outgoingqueue).Wait();
        //            //channel.BasicAck(ea.DeliveryTag, multiple: false);
        //        };
        //        await Task.Delay(1).ConfigureAwait(true);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        model.Dispose();
        //        connection.Dispose();
        //    }
        }

        private async Task writetoConsole(string message)
        {
            Console.WriteLine("MSG: " + message);
            await Task.Delay(1).ConfigureAwait(true);
        }

        //public IConnection GetRabbitMqConnection()
        //{
        //    ConnectionFactory connectionFactory = new ConnectionFactory();
        //    connectionFactory.HostName = System.Configuration.ConfigurationManager.AppSettings["rabbitmqhost"].ToString();
        //    connectionFactory.UserName = System.Configuration.ConfigurationManager.AppSettings["rabbitmquser"].ToString();
        //    connectionFactory.Password = System.Configuration.ConfigurationManager.AppSettings["rabbitmqpassword"].ToString();
        //    return connectionFactory.CreateConnection();
        //}
    }
}
