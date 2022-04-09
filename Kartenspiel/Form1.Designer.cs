namespace Kartenspiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.xlblPlayer = new System.Windows.Forms.Label();
            this.xlblPC = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.txtPunktePC = new System.Windows.Forms.TextBox();
            this.txtPunktePlayer = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.picBPC = new System.Windows.Forms.PictureBox();
            this.picBPlayer = new System.Windows.Forms.PictureBox();
            this.picBHerz = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRunde = new System.Windows.Forms.Label();
            this.lblRundeV = new System.Windows.Forms.Label();
            this.btnGameMenu = new System.Windows.Forms.Button();
            this.lblNPC = new System.Windows.Forms.Label();
            this.lblNPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBHerz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(499, 189);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(181, 31);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // xlblPlayer
            // 
            this.xlblPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xlblPlayer.Location = new System.Drawing.Point(499, 100);
            this.xlblPlayer.Name = "xlblPlayer";
            this.xlblPlayer.Size = new System.Drawing.Size(181, 32);
            this.xlblPlayer.TabIndex = 2;
            this.xlblPlayer.Text = "Player";
            this.xlblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xlblPC
            // 
            this.xlblPC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xlblPC.Location = new System.Drawing.Point(499, 12);
            this.xlblPC.Name = "xlblPC";
            this.xlblPC.Size = new System.Drawing.Size(181, 32);
            this.xlblPC.TabIndex = 3;
            this.xlblPC.Text = "Computer";
            this.xlblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayer.Location = new System.Drawing.Point(314, 281);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(164, 32);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPC
            // 
            this.lblPC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPC.Location = new System.Drawing.Point(78, 281);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(164, 32);
            this.lblPC.TabIndex = 5;
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPunktePC
            // 
            this.txtPunktePC.Location = new System.Drawing.Point(499, 47);
            this.txtPunktePC.Multiline = true;
            this.txtPunktePC.Name = "txtPunktePC";
            this.txtPunktePC.ReadOnly = true;
            this.txtPunktePC.Size = new System.Drawing.Size(181, 29);
            this.txtPunktePC.TabIndex = 6;
            // 
            // txtPunktePlayer
            // 
            this.txtPunktePlayer.Location = new System.Drawing.Point(499, 135);
            this.txtPunktePlayer.Multiline = true;
            this.txtPunktePlayer.Name = "txtPunktePlayer";
            this.txtPunktePlayer.ReadOnly = true;
            this.txtPunktePlayer.Size = new System.Drawing.Size(181, 29);
            this.txtPunktePlayer.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtStatus.Location = new System.Drawing.Point(699, 12);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(230, 64);
            this.txtStatus.TabIndex = 8;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBPC
            // 
            this.picBPC.Enabled = false;
            this.picBPC.Location = new System.Drawing.Point(12, 12);
            this.picBPC.Name = "picBPC";
            this.picBPC.Size = new System.Drawing.Size(230, 266);
            this.picBPC.TabIndex = 15;
            this.picBPC.TabStop = false;
            // 
            // picBPlayer
            // 
            this.picBPlayer.Enabled = false;
            this.picBPlayer.Location = new System.Drawing.Point(248, 12);
            this.picBPlayer.Name = "picBPlayer";
            this.picBPlayer.Size = new System.Drawing.Size(230, 266);
            this.picBPlayer.TabIndex = 16;
            this.picBPlayer.TabStop = false;
            // 
            // picBHerz
            // 
            this.picBHerz.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBHerz.InitialImage")));
            this.picBHerz.Location = new System.Drawing.Point(699, 79);
            this.picBHerz.Name = "picBHerz";
            this.picBHerz.Size = new System.Drawing.Size(230, 266);
            this.picBHerz.TabIndex = 11;
            this.picBHerz.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "New Round";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRunde
            // 
            this.lblRunde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRunde.Location = new System.Drawing.Point(12, 316);
            this.lblRunde.Name = "lblRunde";
            this.lblRunde.Size = new System.Drawing.Size(45, 32);
            this.lblRunde.TabIndex = 17;
            this.lblRunde.Text = "Runde: ";
            this.lblRunde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRundeV
            // 
            this.lblRundeV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRundeV.Location = new System.Drawing.Point(52, 316);
            this.lblRundeV.Name = "lblRundeV";
            this.lblRundeV.Size = new System.Drawing.Size(45, 32);
            this.lblRundeV.TabIndex = 18;
            this.lblRundeV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGameMenu
            // 
            this.btnGameMenu.Location = new System.Drawing.Point(499, 226);
            this.btnGameMenu.Name = "btnGameMenu";
            this.btnGameMenu.Size = new System.Drawing.Size(87, 31);
            this.btnGameMenu.TabIndex = 19;
            this.btnGameMenu.Text = "Menu";
            this.btnGameMenu.UseVisualStyleBackColor = true;
            this.btnGameMenu.Click += new System.EventHandler(this.btnGameMenu_Click);
            // 
            // lblNPC
            // 
            this.lblNPC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNPC.Location = new System.Drawing.Point(12, 281);
            this.lblNPC.Name = "lblNPC";
            this.lblNPC.Size = new System.Drawing.Size(60, 32);
            this.lblNPC.TabIndex = 20;
            this.lblNPC.Text = "PC";
            this.lblNPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNPlayer
            // 
            this.lblNPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNPlayer.Location = new System.Drawing.Point(248, 281);
            this.lblNPlayer.Name = "lblNPlayer";
            this.lblNPlayer.Size = new System.Drawing.Size(60, 32);
            this.lblNPlayer.TabIndex = 21;
            this.lblNPlayer.Text = "Player";
            this.lblNPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 357);
            this.Controls.Add(this.lblNPlayer);
            this.Controls.Add(this.lblNPC);
            this.Controls.Add(this.picBPlayer);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.picBPC);
            this.Controls.Add(this.btnGameMenu);
            this.Controls.Add(this.lblRundeV);
            this.Controls.Add(this.lblRunde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBHerz);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPunktePlayer);
            this.Controls.Add(this.txtPunktePC);
            this.Controls.Add(this.xlblPC);
            this.Controls.Add(this.xlblPlayer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBHerz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNPC;
        private System.Windows.Forms.Label lblNPlayer;

        public System.Windows.Forms.Button btnGameMenu;

        private System.Windows.Forms.Label lblRunde;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox txtPunktePlayer;

        private System.Windows.Forms.Label xlblPC;
        private System.Windows.Forms.Label xlblPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPunktePC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picBHerz;
        private System.Windows.Forms.PictureBox picBPC;
        private System.Windows.Forms.PictureBox picBPlayer;

        private System.Windows.Forms.Button btnNewGame;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRundeV;

        #endregion
    }
}