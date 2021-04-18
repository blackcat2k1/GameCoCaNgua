
namespace GameCoCaNgua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Pnl__Board = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicBoard = new System.Windows.Forms.PictureBox();
            this.Pnl__Board.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl__Board
            // 
            this.Pnl__Board.Controls.Add(this.PicBoard);
            this.Pnl__Board.Location = new System.Drawing.Point(34, 31);
            this.Pnl__Board.Name = "Pnl__Board";
            this.Pnl__Board.Size = new System.Drawing.Size(700, 615);
            this.Pnl__Board.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnRoll);
            this.panel2.Location = new System.Drawing.Point(763, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 495);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.Location = new System.Drawing.Point(178, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 67);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gold;
            this.btnStart.Location = new System.Drawing.Point(30, 377);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 67);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRoll.Location = new System.Drawing.Point(30, 200);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(243, 102);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PicBoard
            // 
            this.PicBoard.Image = global::GameCoCaNgua.Properties.Resources.BANCO1;
            this.PicBoard.Location = new System.Drawing.Point(3, 29);
            this.PicBoard.Name = "PicBoard";
            this.PicBoard.Size = new System.Drawing.Size(657, 586);
            this.PicBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoard.TabIndex = 0;
            this.PicBoard.TabStop = false;
            this.PicBoard.Click += new System.EventHandler(this.PicBoard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl__Board);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Host";
            this.Pnl__Board.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl__Board;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PicBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRoll;
    }
}