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
        SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_TITLE,
        SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_MESSAGE,
        SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_BUTTON,
        SIGN_IN_SAVE_USERNAME_BUTTON,

        CREATE_ACCOUNT_FIRST_NAME_LABEL,
        CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER,
        CREATE_ACCOUNT_LAST_NAME_LABEL,
        CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER,
        CREATE_ACCOUNT_USERNAME_LABEL,
        CREATE_ACCOUNT_USERNAME_PLACEHOLDER,
        CREATE_ACCOUNT_PASSWORD_LABEL,
        CREATE_ACCOUNT_PASSWORD_PLACEHOLDER,
        CREATE_ACCOUNT_EMAIL_LABEL,
        CREATE_ACCOUNT_EMAIL_PLACEHOLDER,
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
        CREATE_ACCOUNT_PASSWORD_ERROR_TITLE,
        CREATE_ACCOUNT_PASSWORD_ERROR_MESSAGE,
        CREATE_ACCOUNT_PASSWORD_ERROR_BUTTON,
        CREATE_ACCOUNT_FIELDS_ERROR_TITLE,
        CREATE_ACCOUNT_FIELDS_ERROR_MESSAGE,
        CREATE_ACCOUNT_FIELDS_ERROR_BUTTON,
        CREATE_ACCOUNT_USERNAME_ERROR_TITLE,
        CREATE_ACCOUNT_USERNAME_ERROR_MESSAGE,
        CREATE_ACCOUNT_USERNAME_ERROR_BUTTON,
        CREATE_ACCOUNT_EMAIL_ERROR_TITLE,
        CREATE_ACCOUNT_EMAIL_ERROR_MESSAGE,
        CREATE_ACCOUNT_EMAIL_ERROR_BUTTON,

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
        HUB_USER_LABEL,
        HUB_USER_EVENT_ADD,
        HUB_USER_EVENT_VIEW_PROFILE,
        HUB_USER_EVENT_BUTTON,

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
        SETTING_RADIO_CHRISTMAS_BUTTON,
        SETTING_CONNECTION_INFO_LABEL,
        SETTING_IP_LABEL,
        SETTING_PORT_LABEL,
        SETTING_CHANGE_BUTTON,
        SETTING_CONFIRM_BUTTON,
        SETTING_CANCEL_BUTTON,
        SETTING_INVALID_FORMAT_ERROR_TITLE,
        SETTING_INVALID_FORMAT_ERROR_MESSAGE,
        SETTING_INVALID_FORMAT_ERROR_BUTTON,

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
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_TITLE, "Error");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_MESSAGE, "This account is already logged in.");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_BUTTON, "Close");
            this.word_.Add(ENG_WORD.SIGN_IN_SAVE_USERNAME_BUTTON, "Save username");

            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL, "Firstname");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER, "Firstname...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL, "Lastname");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER, "Lastname...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_LABEL, "Username");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER, "Username...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_LABEL, "Password");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER, "Password...");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_EMAIL_LABEL, "Email");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_EMAIL_PLACEHOLDER, "Email...");
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
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_MESSAGE, "Passwords do not match. Please re - enter and try again.");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_BUTTON, "Close");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIELDS_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIELDS_ERROR_MESSAGE, "Not all fields have been filled out. Username, lastname, username, and password fields a required.");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_FIELDS_ERROR_BUTTON, "Close");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_ERROR_MESSAGE, "That username has already been taken.");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_USERNAME_ERROR_BUTTON, "Close");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_EMAIL_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_EMAIL_ERROR_MESSAGE, "That email is already in use or the format is invalid.");
            this.word_.Add(ENG_WORD.CREATE_ACCOUNT_EMAIL_ERROR_BUTTON, "Close");
           
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
            this.word_.Add(ENG_WORD.HUB_DM_BUTTON, "Chats");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_PROFILE, "Profile");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_DELETE, "Delete");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_CANCEL, "Cancel");
            this.word_.Add(ENG_WORD.HUB_USER_LABEL, "Users");
            this.word_.Add(ENG_WORD.HUB_USER_EVENT_ADD, "Add");
            this.word_.Add(ENG_WORD.HUB_USER_EVENT_VIEW_PROFILE, "View profile");
            this.word_.Add(ENG_WORD.HUB_USER_EVENT_BUTTON, "Close");

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
            this.word_.Add(ENG_WORD.SETTING_RADIO_CHRISTMAS_BUTTON, "Christmas");
            this.word_.Add(ENG_WORD.SETTING_CONNECTION_INFO_LABEL, "Connection Info");
            this.word_.Add(ENG_WORD.SETTING_IP_LABEL, "IP: ");
            this.word_.Add(ENG_WORD.SETTING_PORT_LABEL, "Port: ");
            this.word_.Add(ENG_WORD.SETTING_CHANGE_BUTTON, "Change");
            this.word_.Add(ENG_WORD.SETTING_CONFIRM_BUTTON, "Confirm");
            this.word_.Add(ENG_WORD.SETTING_CANCEL_BUTTON, "Cancel");
            this.word_.Add(ENG_WORD.SETTING_INVALID_FORMAT_ERROR_TITLE, "Error");
            this.word_.Add(ENG_WORD.SETTING_INVALID_FORMAT_ERROR_MESSAGE, "Inalid format.");
            this.word_.Add(ENG_WORD.SETTING_INVALID_FORMAT_ERROR_BUTTON, "Close");

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
