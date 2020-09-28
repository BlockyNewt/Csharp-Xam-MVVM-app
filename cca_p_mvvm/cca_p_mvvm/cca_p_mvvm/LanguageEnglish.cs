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

        HUB_FRAME_LABEL,
        HUB_CHANNEL_BUTTON,
        HUB_DM_BUTTON,
        HUB_PROFILE_BUTTON,
        HUB_CHANNEL_LABEL,
        HUB_PROFILE_EDIT_BUTTON,
        HUB_PROFILE_LOGOUT_BUTTON,
        HUB_CHANNEL_EVENT_ENTER,
        HUB_CHANNEL_EVENT_CANCEL,
        HUB_DM_EVENT_CHAT,
        HUB_DM_EVENT_PROFILE,
        HUB_DM_EVENT_DELETE,
        HUB_DM_EVENT_CANCEL,

        SETTING_FRAME_LABEL,
        SETTING_LANGUAGE_LABEL,
        SETTING_RADIO_ENG_BUTTON,
        SETTING_RADIO_JAP_BUTTON,
        SETTING_ACCEPT_BUTTON,
        SETTING_CLOSE_BUTTON,

        PROFILE_EDIT_CONFIRM_BUTTON,
        PROFILE_EDIT_CANCEL_BUTTON,
        PROFILE_EDIT_ALERT_TITLE,
        PROFILE_EDIT_ALERT_MESSAGE,
        PROFILE_EDIT_ALERT_BUTTON,
    }

    public class LanguageEnglish
    {
        public LanguageEnglish()
        {
            this.word_.Add(ENG_WORD.SIGN_IN_FRAME_LABEL, "Sign In");
            this.word_.Add(ENG_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER, "Username...");
            this.word_.Add(ENG_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER, "Password...");
            this.word_.Add(ENG_WORD.SIGN_IN_LOGIN_BUTTON, "Login");

            this.word_.Add(ENG_WORD.HUB_FRAME_LABEL, "Comsize");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_BUTTON, "Channel");
            this.word_.Add(ENG_WORD.HUB_DM_BUTTON, "DM");
            this.word_.Add(ENG_WORD.HUB_PROFILE_BUTTON, "Profile");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_LABEL, "#Channel");
            this.word_.Add(ENG_WORD.HUB_PROFILE_EDIT_BUTTON, "Edit");
            this.word_.Add(ENG_WORD.HUB_PROFILE_LOGOUT_BUTTON, "Logout");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_EVENT_ENTER, "Enter");
            this.word_.Add(ENG_WORD.HUB_CHANNEL_EVENT_CANCEL, "Cancel");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_CHAT, "Chat");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_PROFILE, "Profile");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_DELETE, "Delete");
            this.word_.Add(ENG_WORD.HUB_DM_EVENT_CANCEL, "Cancel");

            this.word_.Add(ENG_WORD.SETTING_FRAME_LABEL, "Settings");
            this.word_.Add(ENG_WORD.SETTING_LANGUAGE_LABEL, "Language");
            this.word_.Add(ENG_WORD.SETTING_RADIO_ENG_BUTTON, "English");
            this.word_.Add(ENG_WORD.SETTING_RADIO_JAP_BUTTON, "Japanese");
            this.word_.Add(ENG_WORD.SETTING_ACCEPT_BUTTON, "Accept");
            this.word_.Add(ENG_WORD.SETTING_CLOSE_BUTTON, "Close");

            this.word_.Add(ENG_WORD.PROFILE_EDIT_CONFIRM_BUTTON, "Confirm");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_CANCEL_BUTTON, "Cancel");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_ALERT_TITLE, "Error");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_ALERT_MESSAGE, "Firstname and or Lastname do not contain enough characters.");
            this.word_.Add(ENG_WORD.PROFILE_EDIT_ALERT_BUTTON, "Close");
        }

        private Dictionary<ENG_WORD, string> word_ = new Dictionary<ENG_WORD, string>();

        public Dictionary<ENG_WORD, string> Word
        {
            get
            {
                return this.word_;
            }
        }
    }
}
