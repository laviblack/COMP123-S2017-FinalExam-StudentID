namespace COMP123_S2017_FinalExam_StudentID
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(22, 173);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(553, 61);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome to the game!";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeMessage);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.Label WelcomeMessage;
    }
}