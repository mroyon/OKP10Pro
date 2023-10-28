using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Web;
using System.IO;
using System.Configuration;
using System.Collections.Generic;


namespace KAF.AppConfiguration.Configuration
{
    public static class Mailer
    {

        #region Constants Template Variables

        private const string VAR_FIRST_NAME = "[firstName]";
        private const string VAR_LAST_NAME = "[lastName]";

        private const string VAR_CITY = "[city]";
        private const string VAR_STATE = "[state]";
        private const string VAR_ZIP = "[zip]";
        private const string VAR_COUNTRY = "[country]";
        private const string VAR_PHONE = "[phone]";

        private const string VAR_CARD_TYPE = "[cardType]";
        private const string VAR_CARD_NUMBER = "[cardNumber]";
        private const string VAR_EXP_DATE = "[expDate]";

        private const string VAR_DATE = "[date]";
        private const string VAR_EMAIL = "[email]";
        private const string VAR_EMAIL2 = "[email2]";

        private const string VAR_VISITOR_NAME = "[name]";
        private const string VAR_SUBJECT = "[subject]";

        private const string VAR_COMPANY_NAME = "[companyName]";
        private const string VAR_LEAD_SOURCE = "[leadSource]";
        private const string VAR_CAMPAIGN_NAME = "[campaignName]";

        private const string VAR_STATUS = "[status]";
        private const string VAR_PREVIOUS_STATUS = "[previousStatus]";
        private const string VAR_NEW_STATUS = "[newStatus]";

        private const string VAR_CANDIDATE_NAME = "[candidateName]";
        private const string VAR_JOB_TITLE = "[jobTitle]";
        private const string VAR_JOB_LOCATION = "[jobLocation]";
        private const string VAR_JOB_EXPERIENCE = "[jobExperience]";
        private const string VAR_WORK_AUTHORIZATION = "[workAuthorization]";
        private const string VAR_SKILL_SET_DESCRIPTION = "[skillSetDescription]";
        private const string VAR_JOB_DESCRIPTION = "[jobDescription]";

        private const string VAR_CANDIDATEOVERVIEW_PERSONALINFO = "[personalInformation]";
        private const string VAR_CANDIDATEOVERVIEW_REMARKS = "[remarks]";
        private const string VAR_CANDIDATEOVERVIEW_ASSIGNEDMANAGERS = "[assignedManagers]";
        private const string VAR_CANDIDATEOVERVIEW_JOBCARTANDSTATUS = "[jobCartAndStatus]";
        private const string VAR_CANDIDATEOVERVIEW_ASSIGNEDASSESTEST = "[assignedAssesmentTests]";
        private const string VAR_CANDIDATEOVERVIEW_INTERVIEWSCHEDULE = "[interviewSchedule]";
        private const string VAR_CANDIDATEOVERVIEW_RESUMEDOCUMENTS = "[resumesAndDocuments]";
        private const string VAR_CANDIDATEOVERVIEW_OBJECTIVE = "[objective]";
        private const string VAR_CANDIDATEOVERVIEW_SUMMARY = "[summary]";
        private const string VAR_CANDIDATEOVERVIEW_JOBTITLE = "[jobTitle]";
        private const string VAR_CANDIDATEOVERVIEW_SKILLSET = "[skillSet]";
        private const string VAR_CANDIDATEOVERVIEW_EXPERIENCE = "[experience]";
        private const string VAR_CANDIDATEOVERVIEW_EDUCATION = "[education]";
        private const string VAR_CANDIDATEOVERVIEW_COPPYPASTERESUME = "[copyPastedResume]";

        private const string VAR_PASSPORTEXPIRED_DATE = "[PassportExpiredDate]";
        private const string VAR_MEMBER_NAME = "[MemberName]";
        private const string VAR_USER_NAME = "[username]";
        private const string VAR_SITE_NAME = "[SiteName]";
        private const string VAR_LOGIN_URL = "[LoninUrl]";



        #endregion

        #region Methods

        #endregion
    }
}
