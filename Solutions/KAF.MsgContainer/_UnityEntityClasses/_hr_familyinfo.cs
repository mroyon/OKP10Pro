using  KAF.MsgContainer.Abstract;
using  KAF.MsgContainer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KAF.MsgContainer;

namespace KAF.MsgContainer
{
    
    public  class _hr_familyinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_familyinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_familyinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string familyinfoList
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyinfoCreate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyinfoUpdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyinfoDetails
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relationshipid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("relationshipid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipidRequired
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("relationshipidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parenthrfamilyid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("parenthrfamilyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familynationalid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familynationalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyname1
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyname1Required
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyname2
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyname2Required
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname2Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyname3
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyname4
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyname5
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyname5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyfullname
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyfullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyfullnameRequired
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyfullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familygenderid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familygenderid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familygenderidRequired
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familygenderidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyreligionid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyreligionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familybloodgroupid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familybloodgroupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familybirthdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familybirthdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familybirthdocno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familybirthdocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familybirthdocdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familybirthdocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycountryid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familynationalityid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familynationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymaritalstatusid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familymaritalstatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycuraddressflatno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycuraddressflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycuraddresshouseno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycuraddresshouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycuraddressstreet
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycuraddressstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycuradrressblock
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycuradrressblock", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycurcountryid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycurcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycurgovnerid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycurgovnerid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycurareaid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familycurareaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymobile1
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familymobile1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familytelephone1
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familytelephone1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperaddressflatno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperaddressflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperaddresshouseno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperaddresshouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperaddressstreet
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperaddressstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperadrresspo
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperadrresspo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperadrressps
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperadrressps", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperaddressdist
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperaddressdist", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyperaddresscountryid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familyperaddresscountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymarriagedate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familymarriagedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymarriagedocno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familymarriagedocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymarriagedocdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familymarriagedocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marriagefiledescription
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("marriagefiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marriagefilepath
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("marriagefilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marriagefilename
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("marriagefilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marriagefiletype
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("marriagefiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marriagefileextension
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("marriagefileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marriageserialno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("marriageserialno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcedate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcedocno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcedocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcedocdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcedocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcefiledescription
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcefiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcefilepath
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcefilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcefilename
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcefilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcefiletype
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcefiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string divorcefileextension
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("divorcefileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fatherstatusid
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("fatherstatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isservedinmilitary
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("isservedinmilitary", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fathermilitarynokw
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("fathermilitarynokw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fathermilitarynobd
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("fathermilitarynobd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workplace
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("workplace", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workdesignation
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("workdesignation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathdocno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathdocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathdocdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathdocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathfiledescription
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathfilepath
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathfilename
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathfiletype
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familydeathfileextension
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("familydeathfileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string separetiondate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("separetiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string separetionreason
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("separetionreason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string separetiondocno
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("separetiondocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string separetiondocdate
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("separetiondocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_familyinfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
