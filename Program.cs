using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baq_Sozdik
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            String lang = Properties.Settings.Default.Language;
            if(lang == "kk-CN")
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                }
                catch (CultureNotFoundException)
                {
                    BuildCulture();
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

                }
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sozdik());
        }

        private static void BuildCulture()
        {
            CultureAndRegionInfoBuilder car1 = new CultureAndRegionInfoBuilder("kk-CN",
                                             CultureAndRegionModifiers.Neutral);
            car1.LoadDataFromCultureInfo(CultureInfo.CreateSpecificCulture("kk"));
            car1.LoadDataFromRegionInfo(new RegionInfo("CN"));

            // Register the culture. 
            try
            {
                car1.Register();
            }
            catch (InvalidOperationException)
            {
                // Swallow the exception: the culture already is registered.
            }
        }
    }
}
