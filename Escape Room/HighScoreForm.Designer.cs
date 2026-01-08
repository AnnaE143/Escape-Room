namespace Escape_Room
{
    partial class HighScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoreForm));
            this.rankingLabel = new System.Windows.Forms.Label();
            this.enterButton2 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rankingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rankingLabel
            // 
            this.rankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankingLabel.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rankingLabel.Location = new System.Drawing.Point(12, 9);
            this.rankingLabel.Name = "rankingLabel";
            this.rankingLabel.Size = new System.Drawing.Size(453, 409);
            this.rankingLabel.TabIndex = 0;
            this.rankingLabel.Visible = false;
            // 
            // enterButton2
            // 
            this.enterButton2.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton2.Location = new System.Drawing.Point(227, 198);
            this.enterButton2.Name = "enterButton2";
            this.enterButton2.Size = new System.Drawing.Size(175, 30);
            this.enterButton2.TabIndex = 10;
            this.enterButton2.Text = "Enter";
            this.enterButton2.UseVisualStyleBackColor = true;
            this.enterButton2.Click += new System.EventHandler(this.enterButton2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(74, 199);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 30);
            this.nameTextBox.TabIndex = 9;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(74, 235);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(144, 30);
            this.timeTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 85);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please put in you name in the upper Textbox and your time in the lower and then p" +
    "ress enter.";
            // 
            // rankingButton
            // 
            this.rankingButton.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingButton.Location = new System.Drawing.Point(227, 235);
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(175, 30);
            this.rankingButton.TabIndex = 13;
            this.rankingButton.Text = "See Ranking";
            this.rankingButton.UseVisualStyleBackColor = true;
            this.rankingButton.Click += new System.EventHandler(this.rankingButton_Click);
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(477, 427);
            this.Controls.Add(this.rankingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.enterButton2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.rankingLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScoreForm";
            this.Text = "Escape Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rankingLabel;
        private System.Windows.Forms.Button enterButton2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rankingButton;
    }
}