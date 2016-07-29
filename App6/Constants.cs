using JhpDataSystem.model;
using System.Collections.Generic;

namespace JhpDataSystem
{
    public class Constants
    {
        //internal const string BUNDLE_ENTITYID = "bundl_entityid";
        internal const string BUNDLE_DATATOEDIT = "bundl_datatoedit";
        //internal const string BUNDLE_RECEDITSTAGE = "bundl_editstage";
        internal const string BUNDLE_SELECTEDCLIENT = "bundl_client";
        internal const string BUNDLE_SELECTEDRECORD_ID = "bundl_recordid";
        internal const string BUNDLE_SELECTEDRECORD = "bundl_recordsummary";

        internal const string FIELD_ENTITYID = "entityid";
        internal const string FIELD_ID = "id";

        internal const string SYS_FIELD_USERID = "sys_userid";
        internal const string SYS_FIELD_USERNAMES = "sys_usernames";
        internal const string SYS_FIELD_PASSWDHASH = "sys_pwdhash";

        internal const string SYS_FIELD_DATEEDITED = "sys_editdate";
        internal const string SYS_FIELD_DATECREATED = "sys_datecreated";
        internal const string SYS_FIELD_METADATA = "sys_metadata";

        public static string SYS_FIELD_FirstName = "sys_fname";
        internal static string SYS_FIELD_SurName = "sys_surname";
        internal static string SYS_FIELD_MaidenName = "sys_maidenname";
        internal static string SYS_FIELD_NRC = "sys_nrc";
        internal static string SYS_FIELD_ContactNumber = "sys_cellnumb";
        internal static string SYS_FIELD_HomeFacilityName = "sys_facname";
        internal static string SYS_FIELD_FACILITYID = "sys_facilityid";
        internal static string SYS_FIELD_SESSIONDATE = "sys_sessiondate";
        
        //VMMC
        internal const string FIELD_VMMC_DOB = "vm_date_of_birth";
        internal const string FIELD_VMMC_MCDATE = "vm_mc_date";
        internal const string FIELD_VMMC_DATEOFVISIT = "vm_registration_date";
        internal const string FIELD_VMMC_CARD_SERIAL = "vm_intakeform_serial";
        internal const string FIELD_VMMC_MCNUMBER = "vm_mc_number";

        internal const string FIELD_VMMC_CLIENTLASTNAME = "vm_last_name";
        internal const string FIELD_VMMC_CLIENTFIRSTNAME = "vm_first_name";

        internal const string FIELD_VMMC_CLIENTTEL = "vm_phone_number";
        //internal const string FIELD_VMMC_CLIENTPHYSICALADDR = "clientsphysicaladdress";

        internal static List<string> VMMC_IndexedFieldNames = new List<string>() {
                FIELD_VMMC_CLIENTLASTNAME,FIELD_VMMC_CLIENTFIRSTNAME,
                FIELD_VMMC_MCDATE,FIELD_VMMC_DOB,
                FIELD_ID,FIELD_ENTITYID,FIELD_VMMC_DATEOFVISIT,
                FIELD_VMMC_CARD_SERIAL,FIELD_VMMC_MCNUMBER,FIELD_VMMC_CLIENTTEL,
                //FIELD_VMMC_CLIENTPHYSICALADDR
        };


        //tables in the database

        internal const string FIELD_PPX_DEVSIZE = "ppxdevsize";
        internal const string FIELD_PPX_DEVSIZE_PREFIX = "prepexdevicesize";

        internal const string FIELD_PPX_DATEOFVISIT = "dateofvisit";
        internal const string FIELD_PPX_CARD_SERIAL = "cardserialnumber";
        internal const string FIELD_PPX_CLIENTIDNUMBER = "clientidnumber";
        internal const string FIELD_PPX_CLIENTNAME = "clientname";
        internal const string FIELD_PPX_DOB = "dob";
        internal const string FIELD_PPX_CLIENTTEL = "clienttel";
        internal const string FIELD_PPX_CLIENTPHYSICALADDR = "clientsphysicaladdress";
        internal const string FIELD_PPX_PLACEMENTDATE = "dateofplacement";
        internal static List<string> PP_IndexedFieldNames = new List<string>() {
            //FIELD_PLACEMENTDATE,
                FIELD_PPX_DEVSIZE,
                FIELD_ID,FIELD_ENTITYID,FIELD_PPX_DATEOFVISIT,
                FIELD_PPX_CARD_SERIAL,FIELD_PPX_CLIENTIDNUMBER,FIELD_PPX_CLIENTNAME,FIELD_PPX_DOB,FIELD_PPX_CLIENTTEL,
                FIELD_PPX_CLIENTPHYSICALADDR};

        internal const string LABEL_PPX_ACTIVITYLABEL = "Prepex Manager";
        
        internal const string SYS_KIND_DEVCONF = "sysdevconf";
        internal const string SYS_KIND_RECORDSUMMARY = "recordsummary";
        //UserId
        //Names
        //KnownBolg
        //


        internal const string KIND_PPX = "pp_client";

        internal const string KIND_PPX_CLIENTEVAL = "pp_client_eval";
        internal const string KIND_PPX_DEVICEREMOVAL = "pp_client_devicerem";
        internal const string KIND_PPX_POSTREMOVAL = "pp_client_postrem";
        internal const string KIND_PPX_UNSCHEDULEDVISIT = "pp_client_unsched";

        internal static Dictionary<string, string> PPX_KIND_DISPLAYNAMES =
            new Dictionary<string, string>() {
                { KIND_PPX_CLIENTEVAL,"A1. Client Evaluation" },
                 { KIND_PPX_DEVICEREMOVAL,"A3. Device Removal Visit" },
                  { KIND_PPX_POSTREMOVAL,"A4. Post Removal" },
                   { KIND_PPX_UNSCHEDULEDVISIT,"A2. Unscheduled Visit" }
            };

        internal const string KIND_PPX_CLIENTSUMMARY = "pp_clientsummary";
        
        internal const string KIND_PPX_CLIENT = "pp_client_parts";
        internal const string KIND_PPX_NEXTVIEW = "pp_nextview";

        internal const string KIND_VMMC_CLIENTSUMMARY = "vmmc_clientsummary";
        internal const string KIND_VMMC_POSTOP = "vmmc_postop";
        internal const string KIND_VMMC_REGANDPROCEDURE = "vmmc_regandproc";
        internal static Dictionary<string, string> VMMC_KIND_DISPLAYNAMES =
                new Dictionary<string, string>() {
                    { KIND_VMMC_POSTOP,"Post Operation" },
                     { KIND_VMMC_REGANDPROCEDURE,"Registration and Procedure" }
                };

        internal const string KIND_SITESESSION = "sitesession";
        internal const string KIND_SITEPROVIDER = "siteprovider";

        internal const string KIND_APPUSERS = "appusers";
        internal const string KIND_OUTTRANSPORT = "transport";
        internal const string KIND_FAILEDOUTTRANSPORT = "badtransport";

        public const string KIND_DEFAULT = "generalstore";
        public const string KIND_REGISTER = "kindRegister";
        //encryptionkey
        internal const string ASSET_NAME_APPNAME = "applicationname";
        internal const string ASSET_PROJECT_ID = "projectid";
        internal const string ASSET_NAME_SVC_ACCTEMAIL = "serviceaccountemail";
        internal const string ASSET_API_KEYFILE = "api_keys.json";
        internal const string ASSET_DATASTORE_APPKEY = "datastore_appkey";
        internal const string ASSET_P12KEYFILE = "p12keyfile";
        internal const string ASSET_ADMIN_HASH = "adminhash";
        internal const string ASSET_ADMIN_ENCRYPTIONKEY = "encryptionkey";

        internal static readonly List<string> ASSET_LIST = new List<string>(){
            ASSET_NAME_APPNAME , ASSET_PROJECT_ID, ASSET_NAME_SVC_ACCTEMAIL,
            ASSET_DATASTORE_APPKEY,
            ASSET_P12KEYFILE,ASSET_ADMIN_HASH,ASSET_ADMIN_ENCRYPTIONKEY
        };
        //
        internal const string API_KEYFILE = "api_keys.json";
        internal static System.Collections.Generic.List<string> 
            ENCRYPTED_ASSETS = new System.Collections.Generic.List<string>() { ASSET_DATASTORE_APPKEY };
        public const string DBSAVE_ERROR = "default error value";

        public const string MOTHER_OFBOLG = "Text to Encrypt. Do NOT CHANGE";
        public const string MOTHER_OFALLBOLGS = "ADMIN Text to Encrypt. Do NOT CHANGE";

        internal const string ADMIN_USERNAME = "admin";

        public static string SUPPORTADMIN_USERNAME = "support";

        //prepexreg_fields
        internal const string FILE_PPX_FIELDS = "ppx_fields.json";
        internal const string FILE_VMMC_FIELDS = "vmmc_fields.json";

        internal const string PP_VIEWS_1= "prepexreg1";
        internal const string PP_VIEWS_2 = "prepexreg2";
        internal const string PP_VIEWS_3 = "prepexreg3";
        internal const string PP_VIEWS_4 = "prepexreg4";

        internal const string DATEPICKER = "DatePicker";
        internal const string EDITTEXT = "EditText";
        internal const string CHECKBOX = "CheckBox";
        internal const string RADIOBUTTON = "RadioButton";

        internal const string DATE_BUTTON_PREFIX = "dtbtn_";
        internal const string DATE_TEXT_PREFIX = "dttxt_";
        internal const string LABEL_PREFIX = "sylbl_";

        internal const string DEFAULT_CHECKED = "1";



        //internal static 
    }
}