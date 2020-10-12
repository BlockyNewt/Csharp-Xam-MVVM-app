using ImTools;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace cca_p_mvvm
{
    public enum JAP_WORD
    {
        DEFAULT = 0,

        SIGN_IN_FRAME_LABEL,
        SIGN_IN_USERNAME_ENTRY_PLACEHOLDER,
        SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER,
        SIGN_IN_LOGIN_BUTTON,
        SIGN_IN_LOGIN_ERROR_TITLE,
        SIGN_IN_LOGIN_ERROR_MESSAGE,
        SIGN_IN_LOGIN_ERROR_BUTTON,
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
        CREATE_ACCOUNT_CLEAR_BUTTON,
        CREATE_ACCOUNT_CONFIRM_BUTTON,
        CREATE_ACCOUNT_CANCEL_BUTTON,
        CREATE_ACCOUNT_ERROR_TITLE,
        CREATE_ACCOUNT_ERROR_MESSAGE,
        CREATE_ACCOUNT_ERROR_BUTTON,

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
        SETTING_APP_INFORMATION_LABEL,
        SETTING_APP_VERSION_,

        PROFILE_EDIT_CONFIRM_BUTTON,
        PROFILE_EDIT_CANCEL_BUTTON,
        PROFILE_EDIT_ALERT_TITLE,
        PROFILE_EDIT_ALERT_MESSAGE,
        PROFILE_EDIT_ALERT_BUTTON,

        CHAT_SEND_BUTTON,
        CHAT_EDITOR_PLACEHOLDER,

        CONNECTION_ERROR_TITLE,
        CONNECTION_ERROR_MESSAGE,
        CONNECTION_ERROR_BUTTON,

    }

    public class LanguageJapanese : BindableBase
    {
        public LanguageJapanese()
        {
            this.Is_Japanese_Selected_ = false;

            this.word_.Add(JAP_WORD.SIGN_IN_FRAME_LABEL, "サインイン");
            this.word_.Add(JAP_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER, "ユーザーネーム");
            this.word_.Add(JAP_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER, "パスワード");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_BUTTON, "ログイン");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_TITLE, "エラー");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_MESSAGE, "ユーザーネームかパスワードが間違いているのでもう一度入力してください。");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_BUTTON, "閉じる");
            this.word_.Add(JAP_WORD.SIGN_IN_CREATE_ACCOUNT_BUTTON, "新規アカウント");

            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL, "名");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER, "名");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL, "氏");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER, "氏");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_USERNAME_LABEL, "ユーザーネーム");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER, "ユーザーネーム");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PASSWORD_LABEL, "パスワード");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER, "パスワード");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_LABEL, "プロファイルの写真");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER, "ウエブサイトのURL");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_CLEAR_BUTTON, "クリア");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON, "完了");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_CANCEL_BUTTON, "キャンセル");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_ERROR_TITLE, "エラー");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_ERROR_MESSAGE, "パスワードが一緒じゃないのでもう一度を入力してみてください。");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_ERROR_BUTTON, "閉じる");


            this.word_.Add(JAP_WORD.HUB_FRAME_LABEL, "株式会社コンサイズ");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_BUTTON, "チャンネル");
            this.word_.Add(JAP_WORD.HUB_DM_BUTTON, "メッセージ");
            this.word_.Add(JAP_WORD.HUB_PROFILE_BUTTON, "プロファイル");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_LABEL, "＃チャンネル");
            this.word_.Add(JAP_WORD.HUB_PROFILE_EDIT_BUTTON, "編集");
            this.word_.Add(JAP_WORD.HUB_PROFILE_LOGOUT_BUTTON, "ログアウト");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_EVENT_ENTER, "入る");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_EVENT_CANCEL, "キャンセル");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_CHAT, "チャットをする");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_PROFILE, "プロファイルを見る");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_DELETE, "削除");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_CANCEL, "キャンセル");

            this.word_.Add(JAP_WORD.SETTING_FRAME_LABEL, "設定");
            this.word_.Add(JAP_WORD.SETTING_LANGUAGE_LABEL, "言語");
            this.word_.Add(JAP_WORD.SETTING_RADIO_ENG_BUTTON, "英語");
            this.word_.Add(JAP_WORD.SETTING_RADIO_JAP_BUTTON, "日本語");
            this.word_.Add(JAP_WORD.SETTING_ACCEPT_BUTTON, "完了");
            this.word_.Add(JAP_WORD.SETTING_CLOSE_BUTTON, "戻る");
            this.word_.Add(JAP_WORD.SETTING_APP_INFORMATION_LABEL, "アプリの環境情報");
            this.word_.Add(JAP_WORD.SETTING_APP_VERSION_, "バージョン：");

            this.word_.Add(JAP_WORD.PROFILE_EDIT_CONFIRM_BUTTON, "完了");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_CANCEL_BUTTON, "キャンセル");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_ALERT_TITLE, "エラー");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_ALERT_MESSAGE, "何も入力してないので完了することができません。");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_ALERT_BUTTON, "閉じる");

            this.word_.Add(JAP_WORD.CHAT_EDITOR_PLACEHOLDER, "入力");
            this.word_.Add(JAP_WORD.CHAT_SEND_BUTTON, "送る");

            this.word_.Add(JAP_WORD.CONNECTION_ERROR_TITLE, "エラー");
            this.word_.Add(JAP_WORD.CONNECTION_ERROR_MESSAGE, "インターネットを繋がらなかったです。");
            this.word_.Add(JAP_WORD.CONNECTION_ERROR_BUTTON, "閉じる");

        }

        private Dictionary<JAP_WORD, string> word_ = new Dictionary<JAP_WORD, string>();
        private bool is_japanese_Selected_;

        public Dictionary<JAP_WORD, string> Word
        {
            get
            {
                return this.word_;
            }
        }

        public bool Is_Japanese_Selected_
        {
            get
            {
                return this.is_japanese_Selected_;
            }

            set
            {
                this.is_japanese_Selected_ = value;
                this.OnPropertyChanged("Is_Japanese_Selected_");
                this.SetProperty(ref this.is_japanese_Selected_, value);
            }
        }
    }
}
