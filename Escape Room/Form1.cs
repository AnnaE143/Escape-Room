/*
 * Final Project: Escape Room
 * 13/01/2026
 */
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open the game form
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            //open the instructions
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }
    }
}
