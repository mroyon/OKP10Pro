using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KAF.ConstantTypes
{
    public static class clsSystemConstantTypes
    {

        public enum militarytype
        {
            Kuwaiti = 1,
            Delegate = 2
        }

        public enum LeaveModificationType
        {
            Cancel = 1,
            Extend = 2,
            Reduce=3
        }


        public enum ranktype
        {
            officer = 1,
            nonofficer = 2
        }

        public enum applicantTables
        {
            Reg_BasicInfo = 1,
            Reg_EducationInfo = 2,
            Reg_Familly_Father = 3,
            Reg_StudentFileStorage = 4,
            Reg_Familly_Mother = 5,
            Reg_Familly_Brother = 6,
            Reg_Familly_Sister = 7,
            Reg_Familly_Wife = 8,
            Reg_StudentFileStorage_Others = 9
        }

        public enum LetterStatus
        {
            Initiated = 1,
            PassportReceived = 2,
            VisaDemand = 3,
            VisaIssued = 4,
            VisaSent = 5,
            PTADemand = 6,
            PTAReceived = 7,
            FlightConfirmed = 8,
            Arrived = 9,
            FlightCancel = 10,
            FlightReIssued = 11,
            ProcessCompleted = 12
        }

        public enum LetterType
        {
            Replacement = 1,
            NewDemand = 2
        }

        /// <summary>   Gets color legend for process phase status identifier. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetColorLegendForProcessPhaseStatusID" type="string">
        /// GetColorLegendForProcessPhaseStatusID.
        /// </method>
        /// <param name="ppid" type="long"> The ppid to get color legend for process phase status identifier. </param>
        /// <param name="ssid" type="long"> The SSID to get color legend for process phase status identifier. </param>
        /// <returns>   The color legend for process phase status identifier. </returns>

       
        public static string GetColorLegendForProcessPhaseStatusID(long ppid, long ssid)
        {
            string colorCell = string.Empty;
            switch (ppid)
            {
                case (long)ProcessPhaseID.Registered:
                    colorCell = "#EFEFEF";
                    break;
                case (long)ProcessPhaseID.Submitted:
                    colorCell = "#A2A2EB";
                    break;
                case (long)ProcessPhaseID.Sub_Audited:
                case (long)ProcessPhaseID.Excep_Audited:
                case (long)ProcessPhaseID.Exem_Audited:
                case (long)ProcessPhaseID.Post_Audited:
                    if (ssid == (long)ProcessStatusID.New)
                        colorCell = "#E0A2EB";
                    else if ((ssid == (long)ProcessStatusID.Passed) || (ssid == (long)ProcessStatusID.Complete) || (ssid == (long)ProcessStatusID.Medical_Request_Sent))
                        colorCell = "#82EB75";
                    else if ((ssid == (long)ProcessStatusID.Failed) || (ssid == (long)ProcessStatusID.In_Complete))
                        colorCell = "#F08D98";
                    break;
                case (long)ProcessPhaseID.Sub_Medical:
                    if (ssid == (long)ProcessStatusID.New)
                        colorCell = "#E8E599";
                    else if ((ssid == (long)ProcessStatusID.Passed) || (ssid == (long)ProcessStatusID.Complete) || (ssid == (long)ProcessStatusID.Medical_Request_Sent))
                        colorCell = "#82EB75";
                    else if ((ssid == (long)ProcessStatusID.Failed) || (ssid == (long)ProcessStatusID.In_Complete))
                        colorCell = "#F08D98";
                    break;
                case (long)ProcessPhaseID.Postponed:
                case (long)ProcessPhaseID.Exempted:
                case (long)ProcessPhaseID.Exception:
                    if (ssid == (long)ProcessStatusID.New)
                        colorCell = "#E04343";
                    else if ((ssid == (long)ProcessStatusID.Passed) || (ssid == (long)ProcessStatusID.Complete) || (ssid == (long)ProcessStatusID.Medical_Request_Sent))
                        colorCell = "#DE9B9B";
                    else if ((ssid == (long)ProcessStatusID.Failed) || (ssid == (long)ProcessStatusID.In_Complete))
                        colorCell = "#DE3333";
                    break;
                case (long)ProcessPhaseID.Sub_Medical_Attand:
                case (long)ProcessPhaseID.Post_Officer_Review:
                case (long)ProcessPhaseID.Exem_Officer_Review:
                case (long)ProcessPhaseID.Excep_Officer_Review:
                    if (ssid == (long)ProcessStatusID.New)
                        colorCell = "#91C98B";
                    else if ((ssid == (long)ProcessStatusID.Passed) || (ssid == (long)ProcessStatusID.Complete) || (ssid == (long)ProcessStatusID.Medical_Request_Sent))
                        colorCell = "#57C94B";
                    else if ((ssid == (long)ProcessStatusID.Failed) || (ssid == (long)ProcessStatusID.In_Complete))
                        colorCell = "#DE3333";
                    break;
                case (long)ProcessPhaseID.Sub_Medical_Final:
                case (long)ProcessPhaseID.Post_Final:
                case (long)ProcessPhaseID.Exem_Final:
                case (long)ProcessPhaseID.Excep_Final:
                    if (ssid == (long)ProcessStatusID.New)
                        colorCell = "#DBEB75";
                    else if ((ssid == (long)ProcessStatusID.Passed) || (ssid == (long)ProcessStatusID.Complete) || (ssid == (long)ProcessStatusID.Medical_Request_Sent))
                        colorCell = "#82EB75";
                    else if ((ssid == (long)ProcessStatusID.Failed) || (ssid == (long)ProcessStatusID.In_Complete))
                        colorCell = "#DE3333";
                    break;
                default:
                    break;

            }
            return colorCell;
        }

        public enum delayGroup
        {
            Delay = 1,
            Exempt = 2,
            Except = 3,
            Accept = 4
        }

        public enum ProcessStatusID
        {
            New = 1,
            Passed = 2,
            Failed = 3,
            Waiting = 4,
            Reviewed = 10,
            Complete = 22,
            In_Complete = 23,
            Medical_Request_Sent = 24,
        }
        public enum ProcessPhaseID
        {
            Registered = 1,
            Submitted = 2,
            Sub_Audited = 3,
            Sub_Medical = 4,
            Sub_Medical_Attand = 5,
            Sub_Medical_Final = 6,
            Postponed = 7,
            Post_Audited = 8,
            Post_Officer_Review = 9,
            Post_Final = 10,
            Exempted = 11,
            Exem_Audited = 12,
            Exem_Officer_Review = 13,
            Exem_Final = 14,
            Exception = 15,
            Excep_Audited = 16,
            Excep_Officer_Review = 17,
            Excep_Final = 18
        }

        public enum relations
        {
            Father = 1,
            Mother = 2,
            Brother = 3,
            Sister = 4,
            Wife = 5,
            Uncle = 6,
            Aunty = 7,
            Spouse = 8
        }
        #region GET OPERATOR NAME

        #endregion

        public const string LoggedModeWeb = "WEB APPLICATION";
        public const string LoggedModeSMS = "SMS SERVICE";
        public const string LoggedModeUSSD = "WCF SERVICE";
        public const string LoggedModeUSSDBL = "WCF SERVICE BL";
        public const string LoggedModeWIN = "WIN SERVICE";
        public const string LoggedModeWAP = "WAP SERVICE";
        public const string LoggedModeWPF = "WPF SERVICE";

        public const string LoggedModePOS = "POS SERVICE";
        public const string LoggedModeATM = "ATM SERVICE";
        public const string LoggedModeCBS = "CBS SERVICE";

        public const string LoggedModeWINSMSService = "WIN SMS SERVICE";
        public const string LoggedModeWINREGService = "WIN REG SERVICE";
        public const string LoggedModeWINTRANService = "WIN TRAN SERVICE";

        public const string LoggedModeMobileApp = "MOBILEAPP SERVICE";


        public enum userCategory
        {
            Admin = 1,
            Student = 117
        }

        public enum EmailSMSPostingStatus
        {
            Delivered = 1,
            Failed = 2,
            Pending = 3,
        }


        public enum ProcessPhaseStatusID
        {
            New = 1,
            Viewed = 2,
            Passed = 3,
            Pending = 4,
            Failed = 5,
            Withelded = 6
        }


        public static string GetColorLegendForProcessPhaseStatusID(long ppid)
        {
            string colorcell = string.Empty;
            switch (ppid)
            {
                case (long)ProcessPhaseStatusID.New:
                    colorcell = "#6699ff";
                    break;
                case (long)ProcessPhaseStatusID.Failed:
                    colorcell = "#ff3300";
                    break;
                case (long)ProcessPhaseStatusID.Passed:
                    colorcell = "#00ff00";
                    break;
                case (long)ProcessPhaseStatusID.Pending:
                    colorcell = "#ebebe0";
                    break;
                case (long)ProcessPhaseStatusID.Viewed:
                    colorcell = "#d9d9d9";
                    break;
                case (long)ProcessPhaseStatusID.Withelded:
                    colorcell = "#993366";
                    break;
                default:
                    break;

            }
            return colorcell;
        }

        public const long UserStatus_UnAthorized = 1;
        public const long UserStatus_Authorized = 2;
        public const long UserStatus_Active = 3;
        public const long UserStatus_InActive = 4;
        public const long UserStatus_Created = 5;


        public const string SMSDirectionIn = "IN";
        public const string SMSDirectionOut = "OUT";
        public const string SMSDirectionNOWHERE = "NA";


        public const string Division = "Division";
        public const string District = "District";
        public const string Thana = "Thana";
        public const string PostOffice = "PostOffice";
        //public const string MaritalStatus = "MaritalStatus";

        public const string Gender = "Gender";
        public const string Male = "Male";
        public const string Female = "Female";

        public const string SIMtype = "SIMtype";
        public const string Prepaid = "Prepaid";
        public const string Postpaid = "Postpaid";




        public enum MaritalStatus
        {
            Married = 1,
            Divorced = 2,
            Widow = 3,
            Single = 4
        }
        public enum GenMessageBoxType
        {
            Inbox = 1,
            Draft = 2,
            SentItem = 3,
            Trash = 4
        }

        public enum SearchTagKey
        {
            ACTUAL = 1,
            RECHARGE = 2,
            CHARGE = 3,
            CHARGE_COM = 4,
            CHARGE_DISTRIBUTE_COM = 5,
            CHARGE_DISTRIBUTE = 6,
            CHARGE_VAT = 7,
            FEES = 8,
            FEES_COM = 9,
            FEES_DISTRIBUTE_COM = 10,
            FEES_DISTRIBUTE = 11,
            FEES_VAT = 12,
            REQUEST = 13
        }

        public enum Gen_CouponStatus
        {
            Created = 1,
            Assigned = 2,
            Used = 3
        }

        public enum WebOrSMSOrUSSD
        {
            Web = 1, //Created
            SMS = 2, //Bank Authorized
            USSD = 3
        }


        public enum useraccprofiletatus
        {
            Un_Athorized = 1, //Created
            Authorized = 2, //Bank Authorized
            Active = 3, // User send REG
            In_Active = 4,
            Dormant = 5
        }



        public const string RequiredNewPassword = "RequiredNewPassword";
        public const string PassExpire = "PassExpire";

        public const string PassMContainChar = "Password must contain atleast one lower case character.";
        public const string PassMContainUChar = "Password must contain atleast one upper case character.";
        public const string PassMContainNum = "Password must contain atleast one numeric/digit.";
        public const string PassMContainSPChar = "Password must contain atleast one special character.";

        public const string PassMinLength = "Password minimum length should be ";
        public const string PassMaxLength = "Password maximum length should be ";
        public const string LastPassword = "Current password matches with the last ";



        public enum Gen_family_relationship
        {
            [Display(Name = "أب")]
            Father = 7,
            [Display(Name = "أم")]
            Mother = 8,
            [Display(Name = "زوجة")]
            Wife = 9,
            [Display(Name = "ابن")]
            Son = 12,
            [Display(Name = "ابنة")]
            Daughter = 17
        }

        public enum Gen_family_InLaw_relationship
        {
            [Display(Name = "ووالد بالتبنى")]
            FatherInLaw = 19,
            [Display(Name = "حماة أم الزوجة")]
            MotherInLaw = 24
        }

        public enum Gen_Gender
        {
            [Display(Name = "ذكر")]
            Male = 1,
            [Display(Name = "أنثى")]
            Female = 2
        }

        public enum HR_Personal_Type
        {
            [Display(Name = "ضابط كويتي")]
            KuOfficer = 1,
            [Display(Name = "غير ضابط كويتي")]
            KuNonOfficer = 2,
            [Display(Name = "مندوب ضابط")]
            DelegatOfficer = 3,
            [Display(Name = "مندوب غير ضابط")]
            DelegateNonOfficer = 4,
            [Display(Name = "مدني")]
            Civil = 5


        }
        public enum HR_CourseTakenPlace
        {
            [Display(Name = "في الجيش الكويتي")]
            InKUwaitArmy = 1,
            [Display(Name = "خارج جيش الكويت")]
            OutsideKuwaitArmy = 2,
            [Display(Name = "خارج الكويت")]
            OutsideKuwait = 3

        }
        public enum HR_ExceptionalStatus
        {
            [Display(Name = "نشيط")]
            Active = 1,
            [Display(Name = "غير نشط")]
            InActive = 2
        }
        public enum HR_CivilEndServiceActionType
        {
            [Display(Name = "إعادة عقد")]
            ReContract = 1,
            [Display(Name = "نهاية الخدمة / إنهاء العقد")]
            ContractTermination = 2
        }

        public enum Gen_MedalForList
        {
            [Display(Name = "ضابط")]
            Officer = 1,
            [Display(Name = "ضابط صغار بتكليف / رتبة أخرى")]
            Jco_OR = 2,
            [Display(Name = "مدني")]
            Civil = 3
        }

        public enum Gen_NationalityDegree
        {
            [Display(Name = "الجنسية الأم درجة")]
            Mother_Nationality_Degree = 1,
            [Display(Name = "زوجة الجنسية درجة")]
            Wife_Nationality_Degree = 2
        }

        public enum Gen_ColorFor
        {
            [Display(Name = "عين")]
            Eye = 1,
            [Display(Name = "بشرة")]
            Skin = 2,
            [Display(Name = "شعر")]
            Hair = 3
        }

        public enum Priority
        {
            [Display(Name = "منخفض")]
            Low = 1,
            [Display(Name = "عادي")]
            Normal = 2,
            [Display(Name = "متوسط")]
            High = 3
        }

        public enum FatherStatusFor
        {
            [Display(Name = "الأب العسكرية")]
            Military_Father = 1,
            [Display(Name = "الأب الآخر")]
            Others_Father = 2
        }

        public enum MedalForColor
        {
            [Display(Name = "أسود")]
            Black = 1,
            [Display(Name = "أبيض")]
            White = 2,
            [Display(Name = "بنى")]
            Brown = 3,
            [Display(Name = "أخضر")]
            Green = 4,
            [Display(Name = "أزرق")]
            Blue = 5,
            [Display(Name = "بني غامق")]
            Dark_Brown = 6
        }

        public enum ACRFor
        {
            [Display(Name = "الجيش")]
            Military = 1,
            [Display(Name = "مدني")]
            Civil = 2
        }

        public enum PunishmentType
        {
            [Display(Name = "حكم")]
            حكم = 1,
            [Display(Name = "عقوبة")]
            عقوبة = 2
        }

        public enum FatherStatus
        {
            [Display(Name = "الآب")]
            Father = 1,
            [Display(Name = "آخر")]
            Other = 2
        }

        public enum ReportType
        {
            [Display(Name = "Civilian and Private Contracts System")]
            Civilian_and_Private_Contracts_System = 1,
            [Display(Name = "Delegates System")]
            Delegates_System = 2,
            [Display(Name = "Reinforcement and Packing System")]
            Reinforcement_and_Packing_System = 3,
            [Display(Name = "End Service System(Retirement of officer and non-officer)")]
            End_Service_System = 4,
            [Display(Name = "Row Officers System")]
            Row_Officers_System = 5,
            [Display(Name = "Officers System")]
            Officers_System = 6,
            [Display(Name = "Volunteers System")]
            Volunteers_System = 7,
            [Display(Name = "Recruitment System")]
            Recruitment_System = 8
        }

        public enum Group
        {
            [Display(Name = "Technical")]
            Technical = 1,
            [Display(Name = "Support")]
            Support = 2
        }

        public static string GetStats(long? statusid)
        {

            if (statusid == 1)
                return "Selected";
            else if (statusid == 2)
                return "Canceled";
            else if (statusid == 3)
                return "Active";
            else if (statusid == 4)
                return "Repatriated";
            else if (statusid == 5)
                return "Arrived";
            else if (statusid == 6)
                return "Dead";
            else
                return "";
        }

        public enum ServiceStatus
        {
            Selected = 1,
            Canceled = 2,
            Active = 3,
            Repatriated = 4,
            Arrived = 5,
            Dead = 6
        }
    }
}
