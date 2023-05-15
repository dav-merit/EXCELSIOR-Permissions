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

    public class User_Locked_Out : BaseWebAiiTest
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
            Log.WriteLine(Global_Variables.UsernameTech);
            Log.WriteLine(Global_Variables.TechPassword1);
            Log.WriteLine(Global_Variables.TechPassword2);
        }
    
    
        [CodedStep(@"Navigate to : 'https://excelsiorqa.meritcro.com/#/login'")]
        public void LoginHelper_CodedStep1()
        {
            // Navigate to : 'https://excelsiorqa.meritcro.com/#/login'
            ActiveBrowser.NavigateTo(Global_Variables.URL, true);
                        
        }
    
        [CodedStep(@"Enter text '' in 'UsernameInput'")]
        public void Helper_Login_Admin_CodedStep()
        {
            // Enter text '' in 'UsernameInput'
            Actions.SetText(Pages.ExcelsiorLogin0.UsernameInput, Global_Variables.UsernameTech);
                        
        }
    
        [CodedStep(@"Enter text '' in 'PasswordLogin'")]
        public void VariableTest_CodedStep2()
        {
            // Enter text '' in 'PasswordLogin'
            Actions.SetText(Pages.ExcelsiorLogin.PasswordLogin, Global_Variables.TechPassword2);
                        
        }
    
        [CodedStep(@"Enter text '' in 'GlobalSearchInput'")]
        public void GLOBAL_USERS_EDIT_Unable_CodedStep2()
        {
            // Enter text '' in 'GlobalSearchInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement3.GlobalSearchInput, Global_Variables.UsernameTech);
                                                
        }
    
        [CodedStep(@"Enter text '' in 'PasscodePasswordInput'")]
        public void Account_Passcode_Generated_CodedStep()
        {
            // Enter text '' in 'PasscodePasswordInput'
            Actions.SetText(Pages.ExcelsiorGlobalManagement10.PasscodePasswordInput, Global_Variables.Password);
                        
        }
    
        [CodedStep(@"Enter Username in 'ForgotPasswordUsernameInput'")]
        public void User_Locked_Out_CodedStep()
        {
            // Enter Username in 'ForgotPasswordUsernameInput'
            Actions.SetText(Pages.ForgotPassword.ForgotPasswordUsernameInput, Global_Variables.UsernameTech);
            
        }
    
    
        [CodedStep(@"Enter PW in 'ConfirmPasswordInput'")]
        public void User_Locked_Out_CodedStep2()
        {
            // Enter PW in 'ConfirmPasswordInput'
            Actions.SetText(Pages.ForgotPassword.ConfirmPasswordInput, Global_Variables.TechPassword1);
            
        }
    
        [CodedStep(@"Enter PW in 'NewPasswordInput'")]
        public void User_Locked_Out_CodedStep1()
        {
            // Enter PW in 'NewPasswordInput'
            Actions.SetText(Pages.ForgotPassword.NewPasswordInput, Global_Variables.TechPassword1);
            
        }
    }
}
