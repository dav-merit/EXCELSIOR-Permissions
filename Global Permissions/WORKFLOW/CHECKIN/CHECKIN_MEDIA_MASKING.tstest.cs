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

    public class CHECKIN_MEDIA_MASKING : BaseWebAiiTest
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
                        Log.WriteLine(Global_Variables.CheckinSeries);
        }
    
        [CodedStep(@"[Permissions_Template_CodedStep1] : Enter password '' in 'PermissionsPasswordInput'")]
        public void Permissions_Template_CodedStep1()
        {
                        // Enter text '' in 'PermissionsPasswordInput'
                        Actions.SetText(Pages.ExcelsiorGlobalManagement4.PermissionsPasswordInput, Global_Variables.Password);
                                    
        }
    
        [CodedStep(@"[CHECKIN_SUBMIT_OVERRIDE_CodedStep] : Navigate to series in Checkin")]
        public void CHECKIN_SUBMIT_OVERRIDE_CodedStep()
        {
                        // Navigate to : ''
                        ActiveBrowser.NavigateTo(Global_Variables.CheckinSeries, true);
                        
        }
    
        [CodedStep(@"Desktop command: Drag & Drop CanvasTag to Window Target")]
        public void CHECKIN_MEDIA_MASKING_CodedStep()
        {
            // Desktop command: Drag & Drop CanvasTag to Window Target
            Pages.ExcelsiorSeriesFA17.CanvasTag.Wait.ForExists(30000);
            //ActiveBrowser.ResizeContent(-1920, 0, 1920, 937);
            ActiveBrowser.ScrollBy(0, 87);
            Pages.ExcelsiorSeriesFA17.CanvasTag.DragToWindowLocation(ArtOfTest.Common.OffsetReference.TopLeftCorner, 421, 215, true, ArtOfTest.Common.OffsetReference.TopLeftCorner, 425, 212, true);
            
        }
    
        [CodedStep(@"Desktop command: Drag & Drop CanvasTag to Window Target")]
        public void CHECKIN_MEDIA_MASKING_CodedStep1()
        {
            // Desktop command: Drag & Drop CanvasTag to Window Target
            Pages.ExcelsiorSeriesFA17.CanvasTag.Wait.ForExists(30000);
            ActiveBrowser.ResizeContent(-1920, 0, 1920, 937);
            ActiveBrowser.ScrollBy(0, 0);
            Pages.ExcelsiorSeriesFA17.CanvasTag.DragToWindowLocation(ArtOfTest.Common.OffsetReference.TopLeftCorner, 610, 302, true, ArtOfTest.Common.OffsetReference.TopLeftCorner, -677, 643, true);
            
        }
    }
}
