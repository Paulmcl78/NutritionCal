using System;
using System.Windows.Forms;
using NutritionCal.Common.IOC;
using NutritionCal.GUI.Forms;
using NutritionCal.GUI.IOC;

namespace NutritionCal.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            CastleContainer.Instance.Install(new GUIWindsorInstaller(), new CommonWindsorInstaller());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 mainForm = CastleContainer.Resolve<Form1>();
            Application.Run(mainForm);
            

        }
    }
}
