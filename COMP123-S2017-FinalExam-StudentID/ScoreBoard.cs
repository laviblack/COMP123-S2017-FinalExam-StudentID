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
 * Version: 0.1 - Created the ScoreBoard class
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
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            scoreTextBox = this.ScoreTextBox;
            timeTextBox = this.TimeTextBox;
            finalScoreTextBox = this.FinalScoreTextBox;
        }

        // public method
        public void UpdateTime()
        {

        }
    }
}
