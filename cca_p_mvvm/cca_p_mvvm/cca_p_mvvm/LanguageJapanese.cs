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
        CREATE_ACCOUNT_PASSWORD_ERROR_TITLE,
        CREATE_ACCOUNT_PASSWORD_ERROR_MESSAGE,
        CREATE_ACCOUNT_PASSWORD_ERROR_BUTTON,
        CREATE_ACCOUNT_FIELDS_ERROR_TITLE,
        CREATE_ACCOUNT_FIELDS_ERROR_MESSAGE,
        CREATE_ACCOUNT_FIELDS_ERROR_BUTTON,

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
        SETTING_APP_VERSION_,
        SETTING_COLOR_DESIGN_LABEL,
        SETTING_RADIO_LIGHT_BUTTON,
        SETTING_RADIO_DARK_BUTTON,
        SETTING_RADIO_HALLOWEEN_BUTTON,
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
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_TITLE, "エラー");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_MESSAGE, "ユーザーネームかパスワードが間違いているのでもう一度入力してください。");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_BUTTON, "閉じる");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_TITLE, "エラー");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_MESSAGE, "サーバーに繋がらなかったです。");
            this.word_.Add(JAP_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_BUTTON, "閉じる");
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
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PROFILE_BIO_LABEL, "ステータス");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PROFILE_BIO_PLACEHOLDER, "興味があることとか好きなこととか皆に伝いたいようにこちらに入力してください。");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_BACK_BUTTON, "戻る");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_NEXT_BUTTON, "次へ");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON, "完了");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_CANCEL_BUTTON, "キャンセル");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PROGRESS_BAR_TEXT, "プログレス： ");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_CLEAR_BUTTON, "クリア");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_TITLE, "エラー");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_MESSAGE, "パスワードが一緒じゃないのでもう一度を入力してみてください。");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_BUTTON, "閉じる");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_FIELDS_ERROR_TITLE, "エラー");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_FIELDS_ERROR_MESSAGE, "名前とユーザーネームとパスワードの入力が必要です。");
            this.word_.Add(JAP_WORD.CREATE_ACCOUNT_FIELDS_ERROR_BUTTON, "閉じる");

            this.word_.Add(JAP_WORD.HUB_FRAME_LABEL, "株式会社コンサイズ");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_BUTTON, "チャンネル");
            this.word_.Add(JAP_WORD.HUB_PROFILE_BUTTON, "プロファイル");
            this.word_.Add(JAP_WORD.HUB_PROFILE_EDIT_BUTTON, "編集");
            this.word_.Add(JAP_WORD.HUB_PROFILE_LOGOUT_BUTTON, "ログアウト");
            this.word_.Add(JAP_WORD.HUB_PROFILE_FULLNAME_LABEL, "名前");
            this.word_.Add(JAP_WORD.HUB_PROFILE_BIO_LABEL, "ステータス");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_EVENT_ENTER, "入る");
            this.word_.Add(JAP_WORD.HUB_CHANNEL_EVENT_CANCEL, "キャンセル");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_CHAT, "チャットをする");
            this.word_.Add(JAP_WORD.HUB_DM_BUTTON, "メッセージ");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_PROFILE, "プロファイルを見る");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_DELETE, "削除");
            this.word_.Add(JAP_WORD.HUB_DM_EVENT_CANCEL, "キャンセル");

            this.word_.Add(JAP_WORD.VIEW_USER_PROFILE_FULLNAME_LABEL, "名前");
            this.word_.Add(JAP_WORD.VIEW_USER_PROFILE_BIO_LABEL, "ステータス");

            this.word_.Add(JAP_WORD.SETTING_FRAME_LABEL, "設定");
            this.word_.Add(JAP_WORD.SETTING_LANGUAGE_LABEL, "言語");
            this.word_.Add(JAP_WORD.SETTING_RADIO_ENG_BUTTON, "英語");
            this.word_.Add(JAP_WORD.SETTING_RADIO_JAP_BUTTON, "日本語");
            this.word_.Add(JAP_WORD.SETTING_ACCEPT_BUTTON, "完了");
            this.word_.Add(JAP_WORD.SETTING_CLOSE_BUTTON, "戻る");
            this.word_.Add(JAP_WORD.SETTING_APP_INFORMATION_LABEL, "アプリの環境情報");
            this.word_.Add(JAP_WORD.SETTING_APP_VERSION_, "バージョン：");
            this.word_.Add(JAP_WORD.SETTING_COLOR_DESIGN_LABEL, "設計の色");
            this.word_.Add(JAP_WORD.SETTING_RADIO_LIGHT_BUTTON, "ライト");
            this.word_.Add(JAP_WORD.SETTING_RADIO_DARK_BUTTON, "ダーク");
            this.word_.Add(JAP_WORD.SETTING_RADIO_HALLOWEEN_BUTTON, "ハロウィーン");
            this.word_.Add(JAP_WORD.SETTING_CONNECTION_INFO_LABEL, "コネクション情報");
            this.word_.Add(JAP_WORD.SETTING_IP_LABEL, "IP：");
            this.word_.Add(JAP_WORD.SETTING_PORT_LABEL, "ポート：");
            this.word_.Add(JAP_WORD.SETTING_CHANGE_BUTTON, "編集");
            this.word_.Add(JAP_WORD.SETTING_CONFIRM_BUTTON, "完了");
            this.word_.Add(JAP_WORD.SETTING_CANCEL_BUTTON, "キャンセル");
            this.word_.Add(JAP_WORD.SETTING_INVALID_FORMAT_ERROR_TITLE, "エラー");
            this.word_.Add(JAP_WORD.SETTING_INVALID_FORMAT_ERROR_MESSAGE, "無効な形式です。");
            this.word_.Add(JAP_WORD.SETTING_INVALID_FORMAT_ERROR_BUTTON, "閉じる");

            this.word_.Add(JAP_WORD.PROFILE_EDIT_CONFIRM_BUTTON, "完了");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_CANCEL_BUTTON, "キャンセル");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_ALERT_TITLE, "エラー");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_ALERT_MESSAGE, "何も入力してないので完了することができません。");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_ALERT_BUTTON, "閉じる");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_BIO_LABEL, "ステータス");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_BIO_PLACEHOLDER, "興味があることとか好きなこととか皆に伝いたいようにこちらに入力してください。");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_PICTURE_LABEL, "プロファイルの写真");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_FIRST_NAME, "名");
            this.word_.Add(JAP_WORD.PROFILE_EDIT_LAST_NAME, "氏");

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
                this.SetProperty(ref this.is_japanese_Selected_, value);
                this.RaisePropertyChanged("Is_Japanese_Selected_");
            }
        }
    }
}
