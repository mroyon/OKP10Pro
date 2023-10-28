using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KAF.AppConfiguration.Configuration
{
    [Serializable]
    public class BreadCrumb
    {
        //Declaring the properties

        public string _NavigationText;
        public string _NavigationURL;
        public string _PAGEID;
        public string _PAGEDESC;
        public string _PAGEURL;
        public string _PARENTPAGEID;
        public string _MENULEVEL;
        public string _TEXTID;
        public string _SHORTDESC;


        public BreadCrumb(string PAGEID, string PAGEDESC, string PAGEURL, string PARENTPAGEID, string MENULEVEL, string TEXTID, string SHORTDESC)
        {
            this._PAGEID = PAGEID;
            this._PAGEDESC = PAGEDESC;
            this._PAGEURL = PAGEURL;
            this._PARENTPAGEID = PARENTPAGEID;
            this._MENULEVEL = MENULEVEL;
            this._TEXTID = TEXTID;
            this._SHORTDESC = SHORTDESC;
        }

        public string PAGEID
        {
            get { return _PAGEID; }
            set { _PAGEID = value; }
        }
        
        public string PAGEDESC
        {
            get { return _PAGEDESC; }
            set { _PAGEDESC = value; }
        }

        public string PAGEURL
        {
            get { return _PAGEURL; }
            set { _PAGEURL = value; }
        }

        public string PARENTPAGEID
        {
            get { return _PARENTPAGEID; }
            set { _PARENTPAGEID = value; }
        }

        public string MENULEVEL
        {
            get { return _MENULEVEL; }
            set { _MENULEVEL = value; }
        }

        public string TEXTID
        {
            get { return _TEXTID; }
            set { _TEXTID = value; }
        }

        public string SHORTDESC
        {
            get { return _SHORTDESC; }
            set { _SHORTDESC = value; }
        }

        public string NavigationText
        {
            get { return _NavigationText; }
            set { _NavigationText = value; }
        }

        public string NavigationURL
        {
            get { return _NavigationURL; }
            set { _NavigationURL = value; }
        }

        public BreadCrumb()
        {

        }
    }
}
