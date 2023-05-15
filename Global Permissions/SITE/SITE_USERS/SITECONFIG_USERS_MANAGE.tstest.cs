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

    public class SITECONFIG_USERS_MANAGE : BaseWebAiiTest
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
            Log.WriteLine(Global_Variables.UserNoProducedures);
            Log.WriteLine(Global_Variables.PermissionsPassword);
        }
    
        [CodedStep(@"[Permissions_Template_CodedStep1] : Enter password '' in 'PermissionsPasswordInput'")]
        public void Permissions_Template_CodedStep1()
        {
            // Enter text '' in 'PermissionsPasswordInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement4.PermissionsPasswordInput, Global_Variables.Password);
                        
        }
    
        [CodedStep(@"[SITECONFIG_EQUIPMENT_MANAGE_CodedStep2] : Enter Equipment name of equipment without procedures assigned in Search Input")]
        public void SITECONFIG_EQUIPMENT_MANAGE_CodedStep2()
        {
            // Enter text '' in 'GlobalSearchInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement3.GlobalSearchInput, Global_Variables.UserNoProducedures);
                                                            
        }
    
        [CodedStep(@"Enter text '' in 'PasswordInput'")]
        public void SITECONFIG_EQUIPMENT_MANAGE_CodedStep()
        {
            // Enter text '' in 'PasswordInput'
            Actions.SetText(Pages.ExcelsiorSubject0030020.PasswordInput, Global_Variables.PermissionsPassword);
                        
        }
    
        [CodedStep(@"Enter text '' in 'PasswordInput'")]
        public void SITECONFIG_EQUIPMENT_MANAGE_CodedStep1()
        {
            // Enter text '' in 'PasswordInput'
            Actions.SetText(Pages.ExcelsiorSubject0030020.PasswordInput, Global_Variables.PermissionsPassword);
                        
        }
    
        [CodedStep(@"Enter text '' in 'PasswordInput'")]
        public void SITECONFIG_EQUIPMENT_MANAGE_CodedStep3()
        {
            // Enter text '' in 'PasswordInput'
            Actions.SetText(Pages.ExcelsiorSubject0030020.PasswordInput, Global_Variables.PermissionsPassword);
                        
        }
                [CodedStep(@"[SITECONFIG_EQUIPMENT_MANAGE_CodedStep2] : Enter Equipment name of equipment without procedures assigned in Search Input")]
        public void SITECONFIG_EQUIPMENT_MANAGE_CodedStep4()
        {
            // Enter text '' in 'GlobalSearchInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement3.GlobalSearchInput, Global_Variables.SharedUserNoProcedures);
                                                            
        }
    
        [CodedStep(@"Wait for element 'DisabletoEnableButton' 'is' visible.")]
        public void SITECONFIG_USERS_MANAGE_CodedStep()
        {
            // Wait for element 'DisabletoEnableButton' 'is' visible.
            bool expextedValue = true;
            Pages.ExcelsiorSiteConfig.DisabletoEnableButton.Wait.ForCondition((a_0, a_1) => (((ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton)(a_0)).IsVisible() == expextedValue), false, null, 30000);
            
        }
    }
}
