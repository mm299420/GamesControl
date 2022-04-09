namespace GamesControl
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
            this.btnPlayerVSPC = new System.Windows.Forms.Button();
            this.btnBlackJ = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayerVSPC
            // 
            this.btnPlayerVSPC.Location = new System.Drawing.Point(9, 13);
            this.btnPlayerVSPC.Name = "btnPlayerVSPC";
            this.btnPlayerVSPC.Size = new System.Drawing.Size(198, 95);
            this.btnPlayerVSPC.TabIndex = 0;
            this.btnPlayerVSPC.Text = "Player VS PC";
            this.btnPlayerVSPC.UseVisualStyleBackColor = true;
            this.btnPlayerVSPC.Click += new System.EventHandler(this.btnPlayerVSPC_Click);
            // 
            // btnBlackJ
            // 
            this.btnBlackJ.Location = new System.Drawing.Point(213, 13);
            this.btnBlackJ.Name = "btnBlackJ";
            this.btnBlackJ.Size = new System.Drawing.Size(198, 95);
            this.btnBlackJ.TabIndex = 1;
            this.btnBlackJ.Text = "Blackjack";
            this.btnBlackJ.UseVisualStyleBackColor = true;
            this.btnBlackJ.Click += new System.EventHandler(this.btnBlackJ_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(417, 65);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(62, 42);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 114);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnBlackJ);
            this.Controls.Add(this.btnPlayerVSPC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEXIT;

        private System.Windows.Forms.Button btnPlayerVSPC;
        private System.Windows.Forms.Button btnBlackJ;

        #endregion
    }
}