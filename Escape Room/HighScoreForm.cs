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
            try
            {
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
            catch { }
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
            instructionLabel2.Visible = false;
            
            players = players.OrderBy(p => p.Time).ToList();

            using (StreamWriter writer = new StreamWriter(filePath))
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
