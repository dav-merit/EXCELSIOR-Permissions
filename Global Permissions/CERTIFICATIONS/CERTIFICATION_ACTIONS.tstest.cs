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

    public class CERTIFICATION_ACTIONS : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

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
    
        [CodedStep(@"[Permissions_Template_CodedStep] : New Coded Step to get Password and other global variables")]
        public void Permissions_Template_CodedStep()
        {
            Log.WriteLine(Global_Variables.Password);           
            Log.WriteLine(Global_Variables.PermissionsUsername);
            Log.WriteLine(Global_Variables.UnassignedCertificationItem);
            Log.WriteLine(Global_Variables.CompletedEquipmentCert);
            Log.WriteLine(Global_Variables.CompletedTechnicianCert);
            Log.WriteLine(Global_Variables.PendingEquipmentCertification);
            Log.WriteLine(Global_Variables.PendingTechCertification);
            Log.WriteLine(Global_Variables.PermissionsPassword);
        }
    
        [CodedStep(@"[Permissions_Template_CodedStep1] : Enter password '' in 'PermissionsPasswordInput'")]
        public void Permissions_Template_CodedStep1()
        {
            // Enter text '' in 'PermissionsPasswordInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement4.PermissionsPasswordInput, Global_Variables.Password);
                        
        }
    
        [CodedStep(@"Enter text 'Test' in 'StudySearchInput'")]
        public void CERTIFICATION_ACTIONS_CodedStep()
        {
            // Enter text 'Test' in 'StudySearchInput'
            Actions.SetText(Pages.ExcelsiorStudy1Sandbox10.StudySearchInput, Global_Variables.PermissionsUsername);
            
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void CERTIFICATION_ACTIONS_CodedStep1()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.UnassignedCertificationItem, true);
            
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void CERTIFICATION_ACTIONS_CodedStep2()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.CompletedEquipmentCert, true);
            
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void CERTIFICATION_ACTIONS_CodedStep3()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.CompletedTechnicianCert, true);
            
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void CERTIFICATION_ACTIONS_CodedStep4()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.PendingEquipmentCertification, true);
            
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void CERTIFICATION_ACTIONS_CodedStep5()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.PendingTechCertification, true);
            
        }
    
        [CodedStep(@"Enter text '' in 'PasswordInput'")]
        public void CERTIFICATION_ACTIONS_CodedStep6()
        {
            // Enter text '' in 'PasswordInput'
            Actions.SetText(Pages.ExcelsiorSubject0030020.PasswordInput, Global_Variables.PermissionsPassword);
            
        }
    
    }
}
