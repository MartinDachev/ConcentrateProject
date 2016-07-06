using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public static class Constants
    {
        public static string CREDENTIALS_REQUIRED_REGISTER { get { return "Полетата отбелязани със звезда (*) са задължителни"; } }

        public static string CREDENTIALS_USERNAME_TAKEN { get { return "Потребителското име вече съществува*";} }

        public static string CREDENTIALS_EMAIL_TAKEN { get { return "Имейла вече е зает*"; } }

        public static string CREDENTIALS_REQUIRED_LOGIN { get { return "Изисква се Потребителско име/парола*"; } }

        public static string CREDENTIALS_WRONG { get { return "Грешно Потребителско име/парола*"; } }

        public static string PASSWORD_NOT_MATCH { get { return "Паролите не съвпадат*"; } }
    }
}
