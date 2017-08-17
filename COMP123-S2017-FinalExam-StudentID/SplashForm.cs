using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Lyrica Yoshida
 * Date: August 12, 2017
 * StudentID: 300923951
 * Description: This is the SplashForm class
 * Version: 0.1 - Created the SplashForm
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    // public property
    public partial class SplashForm : Form
    {
        public PickHighestCardForm pickHighestCardForm
        {
            get
            {
                return Program.pickHighestCardForm;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.pickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
