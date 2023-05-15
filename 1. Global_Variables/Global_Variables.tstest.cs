using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestProject1
{

    public class Global_Variables : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]
//***************************************************Roles***************************************************
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxAdminxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String Username = "teststudio-admin";
    public static String Password = "@Eyekor2";
    public static String Name = "Admin, Test Studio";
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxPMxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String UsernamePM = "karate_projectmanager";
    public static String PasswordPM = "@Eyekor1";
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxVal_test_adminxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String PermissionsUsername = "valtestadmin";
    public static String PermissionsPassword = "@Eyekor1";
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxTechnicianxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String UnregisteredUserLastName = "Test Studio Unregistered User";        
    public static String UsernameTech = "karate_tech";
    public static String TechPassword1 = "@Eyekor1";        
    public static String TechPassword2 = "@Eyekor2";

//***************************************************Navigation URLs***************************************************
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxLOGIN / SUPPORTxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String URL = "https://excelsiorval.meritcro.com/#/login";
    public static String AddStudyPage = "https://excelsiorval.meritcro.com/#/studies/add";
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxGLOBAL LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  
    public static String GlobalURL = "https://excelsiorval.meritcro.com/#/manage";
    public static String GlobalPermissions = "https://excelsiorval.meritcro.com/#/manage;menu=global-permissions";
    public static String FailedProcessing = "https://excelsiorval.meritcro.com/#/manage;menu=failed-processing";
    public static String GlobalAuditTrail = "https://excelsiorval.meritcro.com/#/manage;menu=audit-trail";
    public static String GlobalUsers = "https://excelsiorval.meritcro.com/#/manage;menu=users";    
    public static String GlobalIdentityServer = "https://excelsiorval.meritcro.com/#/manage;menu=identity-servers";
    public static String GlobalDataCorrection = "https://excelsiorval.meritcro.com/#/manage;menu=data-correction";
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxSTUDY LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String Homepage = "https://excelsiorval.meritcro.com/#/studies";
    public static String StudyURL = "https://excelsiorval.meritcro.com/#/study/165;menu=Sites";    
    public static String TestingStudyURL = "https://excelsiorval.meritcro.com/#/study/350;menu=Sites";
    public static String StudyManageURL = "https://excelsiorval.meritcro.com/#/study/165/manage";
    public static String StudyManageURLCDISC = "https://excelsiorval.meritcro.com/#/study/275/manage";
    public static String ReadingCenterManage = "https://excelsiorval.meritcro.com/#/studyaffiliation/579/manage";
    public static String StudyJobs = "https://excelsiorval.meritcro.com/#/study/165/jobs";
    public static String StudySubjectLandingPage = "https://excelsiorval.meritcro.com/#/study/165;menu=SubjectManage";
    public static String StudyPermissions = "https://excelsiorval.meritcro.com/#/manage;menu=study-permissions";
    public static String Queries = "https://excelsiorval.meritcro.com/#/study/165;menu=Queries";
    public static String StudyTransfersPage = "https://excelsiorval.meritcro.com/#/study/165/transfers";
    public static String Document = "https://excelsiorval.meritcro.com/#/document/256";

    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxSITE LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String SiteURL = "https://excelsiorval.meritcro.com/#/site/10550;menu=SubjectManage";
    public static String NewSiteURL = "https://excelsiorval.meritcro.com/#/site/10551/manage";
    public static String SiteConfigURL = "https://excelsiorval.meritcro.com/#/site/10550/config";
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxSUBJECT LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String SubjectDashboard = "https://excelsiorval.meritcro.com/#/subject/72846";
    public static String SubjectwithOneActiveQueriedSeries = "https://excelsiorval.meritcro.com/#/subject/72924";
    public static String SubjectNoSeries = "https://excelsiorval.meritcro.com/#/subject/72923;timepoint=10898";  
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxCERTIFICATION LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String CompletedEquipmentCert = "https://excelsiorval.meritcro.com/#/equipment/31942"; //Multiple files
    public static String CompletedTechnicianCert = "https://excelsiorval.meritcro.com/#/technician/32386"; //Multiple files
    public static String CertificationwithQuery = "https://excelsiorval.meritcro.com/#/technician/32387";
    public static String UnassignedCertificationItem = "https://excelsiorval.meritcro.com/#/technician/32387";
    //-----------Multiple Files, Ready for Sign-off-----------
    public static String PendingTechCertification = "https://excelsiorval.meritcro.com/#/technician/32387";
    public static String PendingEquipmentCertification = "https://excelsiorval.meritcro.com/#/equipment/31943";
    //-----------Multiple active and inactive files-----------
    public static String EquipmentCert = "https://excelsiorval.meritcro.com/#/equipment/31945";
    //-----------Certification Form Ready for signoff---------
    public static String CertificationFormSignOff = "https://excelsiorval.meritcro.com/#/technician/32388";
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxCRFxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String CRFSeriesAnsweredQuery = "https://excelsiorval.meritcro.com/#/crf/105555";
    public static String AssignedCRFDMVSeries = "https://excelsiorval.meritcro.com/#/crf/105652";
    public static String CRFSubjectDashboard = "https://excelsiorqa.meritcro.com/#/subject/71055";
    public static String CRFSite = "https://excelsiorqa.meritcro.com/#/site/10154;menu=SubjectManage";
    public static String CRFStudyURL = "https://excelsiorqa.meritcro.com/#/study/93;menu=Sites";   
    public static String CRFDataIssueSeries = "https://excelsiorqa.meritcro.com/#/crf/106985";
    public static String CRFDataEntrySeriesUnassigned = "https://excelsiorqa.meritcro.com/#/crf/106599";
    public static String CRFDataEntrySeriesAssigned = "https://excelsiorqa.meritcro.com/#/crf/106644"; //Ready for Sign-off
    public static String CRFSDVSeriesAssigned = "https://excelsiorqa.meritcro.com/#/crf/105071";
    public static String CRFSDVSeriesAssignedReadyforSignoff = "https://excelsiorqa.meritcro.com/#/crf/105676";
    public static String CRFSubject = "https://excelsiorqa.meritcro.com/#/subject/71976;timepoint=10237";
    public static String CRFAssignedDataEntrywithString = "https://excelsiorqa.meritcro.com/#/crf/106986";
    public static String CRFAssignedDeterminationSeries = "https://excelsiorqa.meritcro.com/#/crf/107027";
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxQUERY LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx    
    public static String QuerySeparateAffiliation = "https://excelsiorqa.meritcro.com/#/series/105486";
    public static String CertQuerySeparateAffiliation = "https://excelsiorqa.meritcro.com/#/technician/31087";
    public static String QueryOwnAffiliation = "https://excelsiorqa.meritcro.com/#/series/105737";
    public static String CertQueryOwnAffiliation = "https://excelsiorqa.meritcro.com/#/technician/30996";
    
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxSERIES LEVELxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    //Assigned to valtestadmin
    public static String GradeSeries = "https://excelsiorqa.meritcro.com/#/series/103526";
    public static String CheckinSeries = "https://excelsiorqa.meritcro.com/#/series/106728"; 
    public static String CheckinSeriesReadyforSignoff = "https://excelsiorqa.meritcro.com/#/series/106684";
    public static String VerifySeries = "https://excelsiorqa.meritcro.com/#/series/104656";
    public static String SimultaneousGradeSeries = "https://excelsiorqa.meritcro.com/#/series/106567";
    public static String AssignedGradeSeriesReadytoSign = "https://excelsiorqa.meritcro.com/#/series/106987"; 
    public static String AnalysisSeries = "https://excelsiorqa.meritcro.com/#/series/104678";
    //--
    public static String CompletedHeidelbergOCT = "https://excelsiorqa.meritcro.com/#/series/104657";
    public static String CompletedFABothEyes = "https://excelsiorqa.meritcro.com/#/series/106659";
    public static String CompletedFANoMeasurements = "https://excelsiorqa.meritcro.com/#/series/105346";
    public static String EPDFSeries = "https://excelsiorqa.meritcro.com/#/series/106579";
    public static String UploadSerieswithFiles = "https://excelsiorval.meritcro.com/#/series/112149";
    public static String OCTWithAnalysisandLayers = "https://excelsiorqa.meritcro.com/#/series/106913";
    public static String SerieswithOverlay = "https://excelsiorqa.meritcro.com/#/series/105763";
    public static String SerieswithComment = "https://excelsiorval.meritcro.com/#/series/112149";
    public static String SerieswithQuery = "https://excelsiorval.meritcro.com/#/series/112151";
    public static String SerieswithNoQuery = "https://excelsiorval.meritcro.com/#/series/112150";
    public static String CertificationwithNoQuery = "https://excelsiorval.meritcro.com/#/equipment/31943";            

    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxPreclinicalxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public static String PreclinicalURL = "https://preclinicalval.meritcro.com/#/login";
    public static String PreclinicalHomepage = "https://preclinicalval.meritcro.com/#/studies";
    public static String PreclinicalStudy = "https://preclinicalval.meritcro.com/#/study/65";
    public static String PreclinicalStudyManageURL = "https://preclinicalval.meritcro.com/#/study/65/manage";
    public static String GlobalURLPreclinical = "https://preclinicalval.meritcro.com/#/manage";
    public static String PreclinicalSite = "https://preclinicalval.meritcro.com/#/site/73";
    public static String PreclinicalBookingView = "https://preclinicalval.meritcro.com/#/booking/73";
    public static String DataBookURL = "https://preclinicalval.meritcro.com/#/site/73;menu=DataBook";
        

//***************************************************TEST SPECIFIC TEXT STRINGS***************************************************    
    public static String WFRuleName = "5/25/2022,10.06.05 Test Workflow Rule";
    public static String GradingTemplateName = "Validation - Lock / Unlock Test";
    public static String GlobalGradingTemplate = "DAC Perimetry_shared";
    public static String ModelwithParam = "3D-OCT 2000";
    public static String EquipmentNoProcedures = "Test Studio No Assigned";
    public static String UserNoProducedures = "email3";
    public static String SharedUserNoProcedures = "testreg";
    public static String AssignedDocumentName = "Assigned to ValTestAdmin";
    public static String EndpointNames = "SRS-49852 test 2";
    public static String GradingTemplateNameCDISC = "CDISC Test Grading Template";
    public static String WFTemplateName = "Test Studio WF Template";
    public static String CRFTemplateName = "Test CRF 11Jul2022";
    public static String ExportTypeName = "Test Studio Export Type";
    public static String AnnouncementName = "Test Studio Announcement";
    public static String IdentityServerName = "Test Studio Identity Server";
    public static String GlobalEquipSerial = "987654";
    public static String CustomReportName = "Test Studio Custom Report";
    public static String PreclinicalGroupName = "Test Studio Group";
    public static String PreclinicalCohortName = "Test Studio Cohort";
    public static String GlobalProcedure = "FA";
    //--Affiliation that can be inactivated
    public static String AffiliationName = "Bangor OCT Clinic"; //Active, Testing Off
    //--Group ID of Series in Grade--
    public static String GroupIDNumber = "21668";



        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void Global_Variables_CodedStep()
        {
            
        }
    }
}
