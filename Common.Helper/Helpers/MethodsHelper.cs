using Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Helpers
{
    class MethodsHelper
    {
        public string EncrypteSha256(string data)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(data));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        public string GetTime(DateTime data)
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;

            var ts = new TimeSpan(DateTime.Now.Ticks - data.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * minute)
            {
                if (ts.Seconds <= 0)
                {
                    return "Az Önce";
                }
                else
                {
                    return ts.Seconds == 1 ? "bir saniye önce" : ts.Seconds + " saniye önce";
                }
            }
            if (delta < 2 * minute)
            {
                return "bir dakika önce";
            }
            if (delta < 45 * minute)
            {
                return ts.Minutes + " dakika önce";
            }
            if (delta < 90 * minute)
            {
                return "bir saat önce";
            }
            if (delta < 24 * hour)
            {
                return ts.Hours + " saat önce";
            }
            if (delta < 48 * hour)
            {
                return "dün";
            }
            if (delta < 30 * day)
            {
                return ts.Days + " gün önce";
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "geçen ay" : months + " ay önce";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "geçen sene" : years + " sene önce";
            }
        }

        public string EditErrorMessage(List<ErrorMessageObject> messages)
        {
            if (messages.Count > 0)
            {
                string mesaj = String.Empty;

                for (int i = 0; i < messages.Count; i++)
                {
                    if (i == messages.Count - 1)
                    {
                        mesaj += messages[i].Message;
                    }
                    else
                    {
                        mesaj += messages[i].Message + " <br> ";
                    }
                }

                return mesaj;
            }
            else
            {
                return "";
            }

        }
    }
}
