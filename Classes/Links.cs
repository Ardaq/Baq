using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baq_Sozdik.Classes
{
    class Links
    {
        public static string HtmlUrlString
        {
            get
            {
                string htmlurlstring = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\html\\index.html";
                return Path.GetFullPath(htmlurlstring);
            }
        }

        public static string HtmlUrlHomeKZ
        {
            get
            {
                string htmlurlstring = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\html\\home.html";
                return Path.GetFullPath(htmlurlstring);
            }
        }

        public static string HtmlUrlHomeCN
        {
            get
            {
                string htmlurlstring = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\html\\home-rtl.html";
                return Path.GetFullPath(htmlurlstring);
            }
        }

        public static string HtmlUrlStringss
        {
            get
            {
                string htmlurlstring = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\HTML\\";
                return Path.GetFullPath(htmlurlstring);
            }
        }

        public static string Wikipediaurl
        {
            get
            {
                string wikipedia = "https://kk.wikipedia.org/w/index.php?action=render&title=";
                return wikipedia;
            }
        }

        public static string ConnectionStringSQLite
        {
            get
            {
                string database =
                    //AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Databases\\sozdikDB";
                    AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Sozdik";
                string connectionString = @"Data Source=" + Path.GetFullPath(database) + ";Password=";
                return connectionString;
            }
        }
    }
}
