namespace Project
{
    partial class Song_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Song_Form));
            this.songPicture = new System.Windows.Forms.PictureBox();
            this.songLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.songPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // songPicture
            // 
            this.songPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.songPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.songPicture.Location = new System.Drawing.Point(5, 5);
            this.songPicture.Name = "songPicture";
            this.songPicture.Size = new System.Drawing.Size(140, 140);
            this.songPicture.TabIndex = 0;
            this.songPicture.TabStop = false;
            // 
            // songLabel
            // 
            this.songLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songLabel.AutoSize = true;
            this.songLabel.Font = new System.Drawing.Font("Lemon/Milk light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.songLabel.Location = new System.Drawing.Point(154, 16);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(175, 67);
            this.songLabel.TabIndex = 14;
            this.songLabel.Text = "song";
            // 
            // artistLabel
            // 
            this.artistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Lemon/Milk light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.artistLabel.Location = new System.Drawing.Point(159, 83);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(117, 42);
            this.artistLabel.TabIndex = 15;
            this.artistLabel.Text = "artist";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1226, 35);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Song_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.songPicture);
            this.Name = "Song_Form";
            this.Size = new System.Drawing.Size(1340, 150);
            ((System.ComponentModel.ISupportInitialize)(this.songPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox songPicture;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Label artistLabel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
