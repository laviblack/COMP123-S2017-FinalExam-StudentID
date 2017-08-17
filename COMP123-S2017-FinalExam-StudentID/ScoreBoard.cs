using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Lyrica Yoshida
 * Date: August 12, 2017
 * StudentID: 300923951
 * Description: This is the ScoreBoard class
 * Version: 0.3 - added comments
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public class ScoreBoard
    {
        // private instance variables
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // public properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            { 
                this._timeTextBox = value;
            }
        }

        // constructor
        /// <summary>
        /// This is the constructo for the ScoreBoard class
        /// It takes three arguments
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
            this.Score = int.Parse(this.ScoreTextBox.Text);
            this.FinalScoreTextBox.Text = this.Score.ToString();
            this.Time = int.Parse(this.TimeTextBox.Text);
        }

        // public method
        /// <summary>
        /// This is the UpadateTime method to show the time reducing
        /// </summary>
        public void UpdateTime()
        {
            this.Time = int.Parse(this.TimeTextBox.Text);
            this.Time--;
            this.TimeTextBox.Text = this.Time.ToString();
        }
    }
}
