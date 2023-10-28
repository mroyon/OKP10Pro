using System;
using System.Collections;
using System.Reflection;
using System.Web;
using System.Collections.Generic;
using System.Web.UI;
namespace KAF.AppConfiguration.Configuration
{
    public sealed class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            try
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                string description = value.ToString();
                FieldInfo fieldInfo = value.GetType().GetField(description);
                EnumDescriptionAttribute[] attributes = (EnumDescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(EnumDescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0)
                {
                    description = attributes[0].Description;
                }

                return description;
            }
            catch (Exception)
            {
                return string.Empty;
            }

        }

        public static IList ToList(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new Pair(StringHelper.Convert((int)Enum.Parse(type, value.ToString())), GetDescription(value)));
            }

            return list;
        }
    }


    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class EnumDescriptionAttribute : Attribute
    {
        private string _description;
        public string Description
        {
            get
            {
                return this._description;
            }
        }

        public EnumDescriptionAttribute(string description)
            : base()
        {
            this._description = description;
        }
    }
}
