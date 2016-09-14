namespace coinFlip
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
            this.pbHeads = new System.Windows.Forms.PictureBox();
            this.pbTails = new System.Windows.Forms.PictureBox();
            this.btnFlip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTails)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHeads
            // 
            this.pbHeads.BackColor = System.Drawing.SystemColors.Control;
            this.pbHeads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHeads.Image = ((System.Drawing.Image)(resources.GetObject("pbHeads.Image")));
            this.pbHeads.Location = new System.Drawing.Point(40, 67);
            this.pbHeads.Name = "pbHeads";
            this.pbHeads.Size = new System.Drawing.Size(168, 149);
            this.pbHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeads.TabIndex = 0;
            this.pbHeads.TabStop = false;
            // 
            // pbTails
            // 
            this.pbTails.Image = ((System.Drawing.Image)(resources.GetObject("pbTails.Image")));
            this.pbTails.Location = new System.Drawing.Point(40, 67);
            this.pbTails.Name = "pbTails";
            this.pbTails.Size = new System.Drawing.Size(168, 149);
            this.pbTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTails.TabIndex = 1;
            this.pbTails.TabStop = false;
            this.pbTails.Visible = false;
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(51, 12);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(147, 48);
            this.btnFlip.TabIndex = 2;
            this.btnFlip.Text = "Flip Coin";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 228);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.pbTails);
            this.Controls.Add(this.pbHeads);
            this.Name = "Form1";
            this.Text = "Flipper";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeads;
        private System.Windows.Forms.PictureBox pbTails;
        private System.Windows.Forms.Button btnFlip;
    }
}

