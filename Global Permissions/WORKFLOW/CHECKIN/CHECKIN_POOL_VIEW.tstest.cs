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

    public class CHECKIN_POOL_VIEW : BaseWebAiiTest
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
    
        [CodedStep(@"[Permissions_Template_CodedStep] : New Coded Step to get Password")]
        public void Permissions_Template_CodedStep()
        {
            Log.WriteLine(Global_Variables.Password); 
            Log.WriteLine(Global_Variables.PermissionsPassword);            
            Log.WriteLine(Global_Variables.CheckinSeriesReadyforSignoff);
        }
    
        [CodedStep(@"[Permissions_Template_CodedStep1] : Enter password '' in 'PermissionsPasswordInput'")]
        public void Permissions_Template_CodedStep1()
        {
                        // Enter text '' in 'PermissionsPasswordInput'
                        Actions.SetText(Pages.ExcelsiorGlobalManagement4.PermissionsPasswordInput, Global_Variables.Password);
                        
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void CHECKIN_POOL_VIEW_CodedStep()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.CheckinSeriesReadyforSignoff, true);
            
        }
    
    
    
        [CodedStep(@"Enter text '' in 'CheckinPassword'")]
        public void CHECKIN_POOL_VIEW_CodedStep1()
        {
            // Enter text '' in 'CheckinPassword'
            Actions.SetText(Pages.ExcelsiorSeriesFA17.CheckinPassword, Global_Variables.PermissionsPassword);
            
        }
    
        [CodedStep(@"Enter text 'Test' in 'CheckinPassword'")]
        public void CHECKIN_POOL_VIEW_CodedStep2()
        {
            // Enter text 'Test' in 'CheckinPassword'
            Actions.SetText(Pages.ExcelsiorSeriesFA17.CheckinPassword, Global_Variables.PermissionsPassword);
            
        }
    }
}
