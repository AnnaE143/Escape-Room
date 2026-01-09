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
        string filePath = @"C:\DocumentsCP\rankingEscapeRoom.txt";

        List<Challenger> players = new List<Challenger>
        {
            new Challenger{Name = "A", Time = 20.3}
        };

        public HighScoreForm()
        {
            InitializeComponent();
        }

        class Challenger
        {
            public string Name { get; set; }
            public double Time { get; set; }
        }

        private void enterButton2_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            double time = double.Parse(timeTextBox.Text);

            players.Add(new Challenger { Name = name, Time = time });
            for (int i = 0; i < players.Count; i++)
            {
                rankingLabel.Text += players[i].Name + " " + players[i].Time + "      ";
            }
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            players.Clear();

            string[] lines = File.ReadAllLines(filePath);

            string name;
            int time;
            for (int i = 0; i < lines.Length; i = i + 2)
            {
                name = lines[i];
                //time = Convert.ToInt16(lines[i + 1]);
                players.Add(new Challenger { Name = name, Time = time });
                rankingLabel.Text = $"{name[i]}\n";
                rankingLabel.Text += $"{time}\n";
            }
        }

        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            instructionLabel2.Visible = false;
            rankingLabel.Visible = true;
            File.WriteAllText(filePath, "");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < players.Count; i++)
                {
                    writer.WriteLine(players[i].Name);
                    writer.WriteLine(players[i].Time);
                }
            }
        }
    }
}
