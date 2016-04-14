using CefSharp;
using Squirrel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniteEDTeacher.Views;

namespace UniteEDTeacher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Cef.Initialize(new CefSettings());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (UniteEDTeacher.Properties.Settings.Default.activated)
            {
                checkForUpdates();
                Application.Run(new DashboardForm());
            }
            else
            {
                Application.Run(new ActivateForm());
            }

        }
        private async static void checkForUpdates()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/myuser/myapp"))
            {
                await mgr.Result.UpdateApp();
            }
                
        }
        /*private async static void CheckAndApplyUpdates()
        {
            string UpdatePath = "";
            try
            {
                bool shouldRestart = false;
                using (var mgr = new UpdateManager(UpdatePath))
                {
                    var updateInfo = mgr.CheckForUpdate().Result;
                    if (updateInfo.CurrentlyInstalledVersion.Version < updateInfo.FutureReleaseEntry.Version)
                    {
                        shouldRestart = true;
                        mgr.DownloadReleases(updateInfo.ReleasesToApply).Wait();
                        mgr.ApplyReleases(updateInfo).Wait();
                        await mgr.UpdateApp();
                    }
                }

                if (shouldRestart)
                {
                    UpdateManager.RestartApp();
                }
            }
            catch (Exception e)
            {
                // Uh Oh!
            }
        }*/

        //private static bool CanUpdate()
        //{
        //    return !string.IsNullOrWhiteSpace(UpdatePath);
        //}
    }
}
