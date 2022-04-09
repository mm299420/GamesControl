using System.ComponentModel;

namespace Kartenspiel
{
    partial class jokerS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.picBJoker = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBJoker)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.picBJoker.Location = new System.Drawing.Point(29, 73);
            this.picBJoker.Name = "picBJoker";
            this.picBJoker.Size = new System.Drawing.Size(478, 314);
            this.picBJoker.TabIndex = 0;
            this.picBJoker.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Joker Gewinnt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jokerS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBJoker);
            this.Name = "jokerS";
            this.Text = "jokerS";
            this.Load += new System.EventHandler(this.jokerS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBJoker)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picBJoker;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}