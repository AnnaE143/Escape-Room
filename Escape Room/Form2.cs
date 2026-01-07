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
        Boolean doorOpen = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


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
                        outputLabel.Text = "You can see some rusty pipes, a desk and a locked door. On the desk is a safe with a number lock on it.";
                        break;

                    case "search pipe":
                        if (questionFound == false)
                        {
                            outputLabel.Text = "What belongs to you but is used more by others?";
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
                            outputLabel.Text = "Congratulations, you opened the door and therefore won the game.";
                            gameRunning = false;
                            doorOpen = true;
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
    }
}
