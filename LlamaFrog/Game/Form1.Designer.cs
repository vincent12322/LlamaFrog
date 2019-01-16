namespace Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llamaButton = new System.Windows.Forms.Button();
            this.frogButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.highscoreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(52, 29);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 20);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: ";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(250, 26);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(70, 26);
            this.scoreBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // llamaButton
            // 
            this.llamaButton.Location = new System.Drawing.Point(77, 322);
            this.llamaButton.Name = "llamaButton";
            this.llamaButton.Size = new System.Drawing.Size(116, 60);
            this.llamaButton.TabIndex = 5;
            this.llamaButton.Text = "Llama";
            this.llamaButton.UseVisualStyleBackColor = true;
            this.llamaButton.Click += new System.EventHandler(this.llamaButton_Click);
            // 
            // frogButton
            // 
            this.frogButton.Location = new System.Drawing.Point(189, 322);
            this.frogButton.Name = "frogButton";
            this.frogButton.Size = new System.Drawing.Size(111, 60);
            this.frogButton.TabIndex = 6;
            this.frogButton.Text = "Frog";
            this.frogButton.UseVisualStyleBackColor = true;
            this.frogButton.Click += new System.EventHandler(this.frogButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // highscoreBox
            // 
            this.highscoreBox.Location = new System.Drawing.Point(250, 63);
            this.highscoreBox.Name = "highscoreBox";
            this.highscoreBox.ReadOnly = true;
            this.highscoreBox.Size = new System.Drawing.Size(70, 26);
            this.highscoreBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "High Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 469);
            this.Controls.Add(this.highscoreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.frogButton);
            this.Controls.Add(this.llamaButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Llama Frog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button llamaButton;
        private System.Windows.Forms.Button frogButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox highscoreBox;
        private System.Windows.Forms.Label label2;
    }
}

