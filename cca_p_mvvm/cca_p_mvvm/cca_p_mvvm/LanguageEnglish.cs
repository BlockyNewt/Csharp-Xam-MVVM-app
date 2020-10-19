using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace cca_p_mvvm
{
    public enum ENG_WORD
    {
        DEFAULT = 0,

        SIGN_IN_FRAME_LABEL,
        SIGN_IN_USERNAME_ENTRY_PLACEHOLDER,
        SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER,
        SIGN_IN_LOGIN_BUTTON,
        SIGN_IN_LOGIN_ERROR_CREDENTIALS_TITLE,
        SIGN_IN_LOGIN_ERROR_CREDENTIALS_MESSAGE,
        SIGN_IN_LOGIN_ERROR_CREDENTIALS_BUTTON,
        SIGN_IN_LOGIN_ERROR_CONNECTION_TITLE,
        SIGN_IN_LOGIN_ERROR_CONNECTION_MESSAGE,
        SIGN_IN_LOGIN_ERROR_CONNECTION_BUTTON,
        SIGN_IN_CREATE_ACCOUNT_BUTTON,

        CREATE_ACCOUNT_FIRST_NAME_LABEL,
        CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER,
        CREATE_ACCOUNT_LAST_NAME_LABEL,
        CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER,
        CREATE_ACCOUNT_USERNAME_LABEL,
        CREATE_ACCOUNT_USERNAME_PLACEHOLDER,
        CREATE_ACCOUNT_PASSWORD_LABEL,
        CREATE_ACCOUNT_PASSWORD_PLACEHOLDER,
        CREATE_ACCOUNT_PROFILE_PICTURE_LABEL,
        CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER,
        CREATE_ACCOUNT_PROFILE_BIO_LABEL,
        CREATE_ACCOUNT_PROFILE_BIO_PLACEHOLDER,
        CREATE_ACCOUNT_BACK_BUTTON,
        CREATE_ACCOUNT_NEXT_BUTTON,
        CREATE_ACCOUNT_CONFIRM_BUTTON,
        CREATE_ACCOUNT_CANCEL_BUTTON,
        CREATE_ACCOUNT_PROGRESS_BAR_TEXT,
        CREATE_ACCOUNT_CLEAR_BUTTON,
        CREATE_ACCOUNT_ERROR_TITLE,
        CREATE_ACCOUNT_ERROR_MESSAGE,
        CREATE_ACCOUNT_ERROR_BUTTON,

        HUB_FRAME_LABEL,
        HUB_CHANNEL_BUTTON,
        HUB_PROFILE_BUTTON,
        HUB_PROFILE_EDIT_BUTTON,
        HUB_PROFILE_LOGOUT_BUTTON,
        HUB_PROFILE_FULLNAME_LABEL,
        HUB_PROFILE_BIO_LABEL,
        HUB_CHANNEL_EVENT_ENTER,
        HUB_CHANNEL_EVENT_CANCEL,
        HUB_DM_EVENT_CHAT,
        HUB_DM_BUTTON,
        HUB_DM_EVENT_PROFILE,
        HUB_DM_EVENT_DELETE,
        HUB_DM_EVENT_CANCEL,

        VIEW_USER_PROFILE_FULLNAME_LABEL,
        VIEW_USER_PROFILE_BIO_LABEL,

        SETTING_FRAME_LABEL,
        SETTING_LANGUAGE_LABEL,
        SETTING_RADIO_ENG_BUTTON,
        SETTING_RADIO_JAP_BUTTON,
        SETTING_ACCEPT_BUTTON,
        SETTING_CLOSE_BUTTON,
        SETTING_APP_INFORMATION_LABEL,
        SETTING_APP_VERSION,
        SETTING_COLOR_DESIGN_LABEL,
        SETTING_RADIO_LIGHT_BUTTON,
        SETTING_RADIO_DARK_BUTTON,
        SETTING_RADIO_HALLOWEEN_BUTTON,

        PROFILE_EDIT_CONFIRM_BUTTON,
        PROFILE_EDIT_CANCEL_BUTTON,
        PROFILE_EDIT_ALERT_TITLE,
        PROFILE_EDIT_ALERT_MESSAGE,
        PROFILE_EDIT_ALERT_BUTTON,
        PROFILE_EDIT_PICTURE_LABEL,
        PROFILE_EDIT_FIRST_NAME,
        PROFILE_EDIT_LAST_NAME,
        PROFILE_EDIT_BIO_LABEL,
        PROFILE_EDIT_BIO_PLACEHOLDER,

        CHAT_SEND_BUTTON,
        CHAT_EDITOR_PLACEHOLDER,

        CONNECTION_ERROR_TITLE,
        CONNECTION_ERROR_MESSAGE,
        CONNECTION_ERROR_BUTTON
    }

    public class LanguageEnglish : BindableBase
    {
        public LanguageEnglish()
        {
            this.Is_English_Selected_ = true;

            this.word_.Add(ENG_WORD.SIGN_IN_FRAME_LABEL, "Sign In");
            this.word_.Add(ENG_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER, "Username...");
            this.word_.Add(ENG_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER, "Password...");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_BUTTON, "Login");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_TITLE, "Error");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_MESSAGE, "Username and or password are incorrect. Please try again.");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_BUTTON, "Close");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_TITLE, "Error");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_MESSAGE, "Could not connect to the server.");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_BUTTON, "Close");
            this.word_.Add(ENG_WORD.SIGN_IN_CREATE_ACCOUNT_BUTTON, "Create account");

            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL, "Firstname");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER, "Firstname...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL, "Lastname");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER, "Lastname...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_LABEL, "Username");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER, "Username...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_LABEL, "Password");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER, "Password...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_LABEL, "Profile Picture");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER, "URL...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PROFILE_BIO_LABEL, "Bio");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PROFILE_BIO_PLACEHOLDER, "Something about yourself or something you like...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_BACK_BUTTON, "Back");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_NEXT_BUTTON, "Next");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON, "Confirm");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_CLEAR_BUTTON, "Clear");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_CANCEL_BUTTON, "Cancel");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PROGRESS_BAR_TEXT, "Progress: ");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_ERROR_MESSAGE, "Passwords do not match. Please re - enter and try again.");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_ERROR_BUTTON, "Close");

            this.word_.Add(ENG_WORD.HUB_FRAME_LABEL, "Comsize Inc");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_BUTTON, "Channel");
            this.word_.Add(ENG_WORD.HUB_PROFILE_BUTTON, "Profile");
            this.word_.Add(ENG_WORD.HUB_PROFILE_EDIT_BUTTON, "Edit");
            this.word_.Add(ENG_WORD.HUB_PROFILE_LOGOUT_BUTTON, "Logout");
            this.word_.Add(ENG_WORD.HUB_PROFILE_FULLNAME_LABEL, "Fullname");
            this.word_.Add(ENG_WORD.HUB_PROFILE_BIO_LABEL, "Bio");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_EVENT_ENTER, "Enter");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_EVENT_CANCEL, "Cancel");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_CHAT, "Chat");
            this.word_.Add(ENG_WORD.HUB_DM_BUTTON, "Messages");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_PROFILE, "Profile");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_DELETE, "Delete");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_CANCEL, "Cancel");

            this.word_.Add(ENG_WORD.VIEW_USER_PROFILE_FULLNAME_LABEL, "Fullname");
            this.word_.Add(ENG_WORD.VIEW_USER_PROFILE_BIO_LABEL, "Bio");

            this.word_.Add(ENG_WORD.SETTING_FRAME_LABEL, "Settings");
            this.word_.Add(ENG_WORD.SETTING_LANGUAGE_LABEL, "Language");
            this.word_.Add(ENG_WORD.SETTING_RADIO_ENG_BUTTON, "English");
            this.word_.Add(ENG_WORD.SETTING_RADIO_JAP_BUTTON, "Japanese");
            this.word_.Add(ENG_WORD.SETTING_ACCEPT_BUTTON, "Accept");
            this.word_.Add(ENG_WORD.SETTING_CLOSE_BUTTON, "Close");
            this.word_.Add(ENG_WORD.SETTING_APP_INFORMATION_LABEL, "App Information");
            this.word_.Add(ENG_WORD.SETTING_APP_VERSION, "Version: ");
            this.word_.Add(ENG_WORD.SETTING_COLOR_DESIGN_LABEL, "Color-Scheme");
            this.word_.Add(ENG_WORD.SETTING_RADIO_LIGHT_BUTTON, "Light");
            this.word_.Add(ENG_WORD.SETTING_RADIO_DARK_BUTTON, "Dark");
            this.word_.Add(ENG_WORD.SETTING_RADIO_HALLOWEEN_BUTTON, "Halloween");

            this.word_.Add(ENG_WORD.PROFILE_EDIT_CONFIRM_BUTTON, "Confirm");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_CANCEL_BUTTON, "Cancel");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_ALERT_TITLE, "Error");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_ALERT_MESSAGE, "Values have not been entered for any of the fields.");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_ALERT_BUTTON, "Close");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_BIO_LABEL, "Bio");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_BIO_PLACEHOLDER, "Something about yourself or something you like...");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_PICTURE_LABEL, "Profile Picture");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_FIRST_NAME, "Firstname");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_LAST_NAME, "Lastname");

            this.Word.Add(ENG_WORD.CHAT_EDITOR_PLACEHOLDER, "Enter text here");
            this.Word.Add(ENG_WORD.CHAT_SEND_BUTTON, "Send");

            this.word_.Add(ENG_WORD.CONNECTION_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.CONNECTION_ERROR_MESSAGE, "Could not connect to the internet.");
            this.word_.Add(ENG_WORD.CONNECTION_ERROR_BUTTON, "Close");
        }

        private Dictionary<ENG_WORD, string> word_ = new Dictionary<ENG_WORD, string>();
        private bool is_English_Selected_;

        public Dictionary<ENG_WORD, string> Word
        {
            get
            {
                return this.word_;
            }
        }

        public bool Is_English_Selected_
        {
            get
            {
                return this.is_English_Selected_;
            }

            set
            {
                this.SetProperty(ref this.is_English_Selected_, value);
                this.RaisePropertyChanged("Is_English_Selected_");
            }
        }
    }
}
