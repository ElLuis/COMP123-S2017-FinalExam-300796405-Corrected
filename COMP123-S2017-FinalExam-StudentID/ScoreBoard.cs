using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        public TextBox FinalScoreTextBox
        {
            get
            {
                return _finalScoreTextBox;
            }
            set
            {
                _finalScoreTextBox = value;
            }
        }
        public int Score //set ScoreTextBox.text & FinalScoreTextBox.text --> _score value
        {
            get
            {
                return _score;
            }
            set
            {
                FinalScoreTextBox.Text = value.ToString();
                ScoreTextBox.Text = value.ToString();
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return _scoreTextBox;
            }
            set
            {
                _scoreTextBox = value;
            }
        }
    }
}
