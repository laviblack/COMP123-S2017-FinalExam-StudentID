using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Lyrica Yoshida
 * Date: August 12, 2017
 * StudentID: 300923951
 * Description: This is the driver class
 * Version: 0.2 - Apply the SplashForm
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        // Create object for reference
        public static PickHighestCardForm pickHighestCardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
