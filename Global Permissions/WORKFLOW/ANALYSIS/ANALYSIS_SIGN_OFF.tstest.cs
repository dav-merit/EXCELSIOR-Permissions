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

    public class ANALYSIS_SIGN_OFF : BaseWebAiiTest
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
            Log.WriteLine(Global_Variables.AnalysisSeries);
        }
    
        [CodedStep(@"[Permissions_Template_CodedStep1] : Enter password '' in 'PermissionsPasswordInput'")]
        public void Permissions_Template_CodedStep1()
        {
            // Enter text '' in 'PermissionsPasswordInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement4.PermissionsPasswordInput, Global_Variables.Password);
                        
        }
    
        [CodedStep(@"Navigate to : ''")]
        public void ANALYSIS_SIGN_OFF_CodedStep()
        {
            // Navigate to : ''
            ActiveBrowser.NavigateTo(Global_Variables.AnalysisSeries, true);
            
        }
    
        [CodedStep(@"Enter text 'Test' in 'MatInput3Password'")]
        public void ANALYSIS_SIGN_OFF_CodedStep1()
        {
            // Enter text 'Test' in 'MatInput3Password'
            Actions.SetText(Pages.ExcelsiorSeriesFA19.MatInput3Password, "");
            Pages.ExcelsiorSeriesFA19.MatInput3Password.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.ExcelsiorSeriesFA19.MatInput3Password.Focus();
            Pages.ExcelsiorSeriesFA19.MatInput3Password.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("Test", 50, 100, true);
            
        }
    
        [CodedStep(@"Enter text '' in 'MatInput3Password'")]
        public void ANALYSIS_SIGN_OFF_CodedStep2()
        {
            // Enter text '' in 'MatInput3Password'
            Actions.SetText(Pages.ExcelsiorSeriesFA19.MatInput3Password, Global_Variables.Password);
            
        }
    }
}
