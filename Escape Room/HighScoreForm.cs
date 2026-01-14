using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room
{
    public partial class HighScoreForm : Form
    {
        string filePath = @"C:\DocumentsCP\rankingEscapeRoom.txt"; //creates an external file to save scores

        List<Challenger> players = new List<Challenger> //list to save scores in
        {
        };

        public HighScoreForm()
        {
            InitializeComponent();
        }

        class Challenger
        {
            public string Name { get; set; } //player name
            public double Time { get; set; } //player time
        }

        private void enterButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //add the new player and time to the list
                string name = nameTextBox.Text;
                double time = double.Parse(timeTextBox.Text);

                players.Add(new Challenger { Name = name, Time = time });
                for (int i = 0; i < players.Count; i++)
                {
                    rankingLabel.Text += players[i].Name + " " + players[i].Time + "      ";
                }
                nameTextBox.Clear();
                timeTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            rankingLabel.Visible = true;
            nameTextBox.Visible = false;
            timeTextBox.Visible = false;
            enterButton2.Visible = false;
            saveScoreButton.Visible = false;
            players.Clear();
            rankingLabel.Text = "";

            //read in the data from the external file

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i = i + 2)
            {
                string name = lines[i];
                double time = double.Parse(lines[i + 1]);
                players.Add(new Challenger { Name = name, Time = time });
                rankingLabel.Text += $"{name}\n";
                rankingLabel.Text += $"{time}\n";
            }
        }

        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            //save the data to the external file
            instructionLabel2.Visible = false;
            
            players = players.OrderBy(p => p.Time).ToList();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var player in players)
                {
                    writer.WriteLine(player.Name);
                    writer.WriteLine(player.Time);
                }
            }
        }
    }
}
