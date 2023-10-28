namespace KAF.DataAccessObjects
{
    internal static class SqlConstants
    {
        public const string PRM_RETURN_CODE = "@ReturnKey";
        public const string PRM_ENTITY_ID = "@ID";
        public const string PRM_TOTAL_ROW = "@TotalRow";
        public const string PRM_TOTAL_PAGE = "@TotalPage";
        public const string PRM_COUNT = "@Count";

        public const int DB_STATUS_CODE_SUCCESS_ADD = 1001;
        public const int DB_STATUS_CODE_SUCCESS_UPDATE = 1002;
        public const int DB_STATUS_CODE_SUCCESS_DELETE = 1003;
        public const int DB_STATUS_CODE_SUCCESS_LOCK = 1004;
        public const int DB_STATUS_CODE_SUCCESS_OPERATION = 1005;
        public const int DB_STATUS_CODE_FAIL_OPERATION = -1;

        public const int DB_STATUS_CODE_ERROR_DUPLICATE_DATA = 2003;
        public const int DB_STATUS_CODE_ERROR_CHILD_EXISTS = 2004;

        public const int DB_STATUS_CODE_SETPRIMARYMANAGER = 3000;
        public const int DB_STATUS_CODE_CHANGEPRIMARYMANAGER = 3001;
        public const int DB_STATUS_CODE_NOTSETPRIMARYMANAGER = 3002;

        public const int DB_STATUS_CODE_DATAALREADYEXIST = -9999;
        public const int DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION = -9009;


        public const int DB_STATUS_CODE_REQUIRED_TRANS = 1;
        public const int DB_STATUS_CODE_DONOT_REQUIRED_TRANS = 2;

        //public const int DB_STATUS_CODE_ERROR_CHILD_EXISTS = 2004;
    }
}