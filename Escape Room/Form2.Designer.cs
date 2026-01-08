namespace Escape_Room
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.introductionLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.stopTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introductionLabel
            // 
            this.introductionLabel.BackColor = System.Drawing.Color.Transparent;
            this.introductionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.introductionLabel.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.introductionLabel.Location = new System.Drawing.Point(12, 9);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(393, 91);
            this.introductionLabel.TabIndex = 0;
            this.introductionLabel.Text = "Welcome to the Escape Room.\r\nYou are currently inside a locked room.";
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instructionLabel.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.instructionLabel.Location = new System.Drawing.Point(395, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(393, 91);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Your commands are: look, \r\nsearch pipe, open safe,\r\nopen door, exit";
            // 
            // commandTextBox
            // 
            this.commandTextBox.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandTextBox.Location = new System.Drawing.Point(242, 203);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(144, 30);
            this.commandTextBox.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(395, 226);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(175, 30);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLabel.Location = new System.Drawing.Point(12, 316);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 125);
            this.outputLabel.TabIndex = 4;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(242, 254);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(144, 30);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.Visible = false;
            // 
            // stopTimer
            // 
            this.stopTimer.Interval = 10;
            this.stopTimer.Tick += new System.EventHandler(this.stopTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLabel.Location = new System.Drawing.Point(688, 113);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 35);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "0.0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.introductionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Escape Room";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Timer stopTimer;
        private System.Windows.Forms.Label timeLabel;
    }
}