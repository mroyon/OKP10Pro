using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace KAF.AppConfiguration.Configuration
{
    public partial class PostDataHelper
    {
        [Serializable]
        public class PostData : IEnumerable
        {
            private NameValueCollection values = new NameValueCollection();
            /// <summary>
            /// FormName
            /// </summary>
            public string FormName
            {
                get
                {
                    return this.Get("__TransferKAFDataEnd").ToString();
                }
                set
                {
                    this.Add("__TransferKAFDataEnd", value);
                }
            }
            /// <summary>
            /// Adds object to data collection
            /// </summary>
            /// <param name="key"></param>
            /// <param name="value"></param>
            public void Add(string key, object value)
            {
                if (value != null && value.GetType().IsSerializable)
                {
                    LosFormatter x = new LosFormatter();
                    StringWriter sw = new StringWriter();
                    x.Serialize(sw, value);
                    this.values.Set(key, sw.ToString());
                    return;
                }
                throw new ArgumentException("Invalid object for PostData", "value");
            }
            /// <summary>
            /// Get object from data collection
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public object Get(string key)
            {
                string tempValue = this.values[key];
                object result;
                if (tempValue == null)
                {
                    result = null;
                }
                else
                {
                    LosFormatter x = new LosFormatter();
                    StringReader sw = new StringReader(tempValue);
                    result = x.Deserialize(sw);
                }
                return result;
            }
            /// <summary>
            /// ctor
            /// </summary>
            public PostData()
            {
                this.FormName = "DefaultForm";
            }
            /// <summary>
            /// Gets serialized value, i.e.string
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            internal string GetRawData(string key)
            {
                return this.values[key];
            }
            /// <summary>
            /// Sets serialized value
            /// </summary>
            /// <param name="key"></param>
            /// <param name="value"></param>
            internal void SetRawData(string key, string value)
            {
                this.values[key] = value;
            }
            /// <summary>
            /// Clears all data except FormName
            /// </summary>
            public void Clear()
            {
                string fname = this.FormName;
                this.values.Clear();
                this.FormName = fname;
            }
            /// <summary>
            /// Checks if any value is present at key
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public bool HasObjectForKey(string key)
            {
                return !string.IsNullOrEmpty(this.values.Get(key));
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public IEnumerator GetEnumerator()
            {
                return this.values.GetEnumerator();
            }
        }
    }
}
