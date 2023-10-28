using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Net.NetworkInformation;

namespace KAF.AppConfiguration.Configuration
{
    public class UserMachineInfoHandler
    {
        public string GetMACAddress_WaySecond()
        {
            //sw.WriteLine(Server.HtmlEncode(Request.RequestType));
            //sw.WriteLine(Server.HtmlEncode(Request.UserHostAddress));
            //sw.WriteLine(Server.HtmlEncode(Request.UserHostName));
            //sw.WriteLine(Server.HtmlEncode(Request.HttpMethod));

            /*
             *  System.Web.HttpBrowserCapabilities browser = Request.Browser;
    string s = "Browser Capabilities\n"
        + "Type = "                    + browser.Type + "\n"
        + "Name = "                    + browser.Browser + "\n"
        + "Version = "                 + browser.Version + "\n"
        + "Major Version = "           + browser.MajorVersion + "\n"
        + "Minor Version = "           + browser.MinorVersion + "\n"
        + "Platform = "                + browser.Platform + "\n"
        + "Is Beta = "                 + browser.Beta + "\n"
        + "Is Crawler = "              + browser.Crawler + "\n"
        + "Is AOL = "                  + browser.AOL + "\n"
        + "Is Win16 = "                + browser.Win16 + "\n"
        + "Is Win32 = "                + browser.Win32 + "\n"
        + "Supports Frames = "         + browser.Frames + "\n"
        + "Supports Tables = "         + browser.Tables + "\n"
        + "Supports Cookies = "        + browser.Cookies + "\n"
        + "Supports VBScript = "       + browser.VBScript + "\n"
        + "Supports JavaScript = "     + 
            browser.EcmaScriptVersion.ToString() + "\n"
        + "Supports Java Applets = "   + browser.JavaApplets + "\n"
        + "Supports ActiveX Controls = " + browser.ActiveXControls 
              + "\n"
        + "Supports JavaScript Version = " +
            browser["JavaScriptVersion"] + "\n";

    TextBox1.Text = s;
             */
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress;
        }

        public string GetMACAddress_WayFirst()
        {
            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMOS.Get();
            string MACAddress = String.Empty;
            foreach (ManagementObject objMO in objMOC)
            {
                if (MACAddress == String.Empty) // only return MAC Address from first card   
                {
                    MACAddress = objMO["MacAddress"].ToString();
                }
                objMO.Dispose();
            }
            MACAddress = MACAddress.Replace(":", "");
            return MACAddress;
        }
    }
}
