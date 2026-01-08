using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room
{
    public partial class Form2 : Form
    {
        Boolean gameRunning = true;
        Boolean questionFound = false;
        Boolean keyFound = false;
        double elapsedTime;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            elapsedTime = 00.00;
            stopTimer.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = commandTextBox.Text;
                string inputAnswer = answerTextBox.Text;

                switch (input)
                {
                    case "look":
                        outputLabel.Text = "You can see some rusty pipes, a desk and a locked door. On the desk is a safe with a lock on it.";
                        break;

                    case "search pipe":
                        if (questionFound == false)
                        {
                            outputLabel.Text = "What belongs to you but is used more by others? \nTo open the safe, please put in the answer to the question in the lower Textbox and the command open safe in the upper one.";
                            answerTextBox.Visible = true;
                        }
                        else
                        {
                            outputLabel.Text = "You have already found this hint.";
                        }
                        break;

                    case "open door":
                        if (keyFound == false)
                        {
                            outputLabel.Text = "To exit the room please get the key out of the safe";
                        }
                        else
                        {
                            outputLabel.Text = "Congratulations, you opened the door and therefore won the game. To save your time, please enter safe highscore into the Textbox";
                            answerTextBox.Visible = false;
                            gameRunning = false;
                        }
                        break;

                    case "open safe":
                        if (inputAnswer == "name")
                        {
                            outputLabel.Text = "That is correct! You open the safe and take out the key.";
                            keyFound = true;
                        }
                        else if (questionFound == false)
                        {
                            outputLabel.Text = "How are you going to open the safe if you don't have the riddle yet? Search for it first.";
                        }
                        else
                        {
                            outputLabel.Text = "That is wrong, try again.";
                        }
                        break;

                    case "save highscore":
                        HighScoreForm highScoreForm = new HighScoreForm();
                        highScoreForm.Show();
                        break;

                    case "exit":
                        gameRunning = false;
                        this.Close();
                        break;

                    default:
                        outputLabel.Text = "Please pick one of the commands listed above.";
                        break;

                }
            }
            catch
            {

            }
        }

        private void stopTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime + 0.1;
            timeLabel.Text = elapsedTime.ToString("F1");

            if (gameRunning == false)
            {
                stopTimer.Stop();
            }
        }
    }
}
