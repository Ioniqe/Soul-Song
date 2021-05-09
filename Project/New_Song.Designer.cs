namespace Project
{
    partial class New_Song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Song));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.minimize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.maximize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.close_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.artist_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emotionResolution = new System.Windows.Forms.ComboBox();
            this.upload_picture_butt = new System.Windows.Forms.Button();
            this.upload_song_butt = new System.Windows.Forms.Button();
            this.save_Butt = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cancel_Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // minimize_Butt
            // 
            this.minimize_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_Butt.BackColor = System.Drawing.Color.Transparent;
            this.minimize_Butt.Image = ((System.Drawing.Image)(resources.GetObject("minimize_Butt.Image")));
            this.minimize_Butt.ImageActive = null;
            this.minimize_Butt.Location = new System.Drawing.Point(579, 12);
            this.minimize_Butt.Name = "minimize_Butt";
            this.minimize_Butt.Size = new System.Drawing.Size(29, 29);
            this.minimize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_Butt.TabIndex = 14;
            this.minimize_Butt.TabStop = false;
            this.minimize_Butt.Zoom = 10;
            this.minimize_Butt.Click += new System.EventHandler(this.minimize_Butt_Click);
            // 
            // maximize_Butt
            // 
            this.maximize_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_Butt.BackColor = System.Drawing.Color.Transparent;
            this.maximize_Butt.Image = ((System.Drawing.Image)(resources.GetObject("maximize_Butt.Image")));
            this.maximize_Butt.ImageActive = null;
            this.maximize_Butt.Location = new System.Drawing.Point(614, 12);
            this.maximize_Butt.Name = "maximize_Butt";
            this.maximize_Butt.Size = new System.Drawing.Size(29, 29);
            this.maximize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize_Butt.TabIndex = 13;
            this.maximize_Butt.TabStop = false;
            this.maximize_Butt.Zoom = 10;
            this.maximize_Butt.Click += new System.EventHandler(this.maximize_Butt_Click);
            // 
            // close_Butt
            // 
            this.close_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Butt.BackColor = System.Drawing.Color.Transparent;
            this.close_Butt.Image = ((System.Drawing.Image)(resources.GetObject("close_Butt.Image")));
            this.close_Butt.ImageActive = null;
            this.close_Butt.Location = new System.Drawing.Point(649, 12);
            this.close_Butt.Name = "close_Butt";
            this.close_Butt.Size = new System.Drawing.Size(29, 29);
            this.close_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Butt.TabIndex = 12;
            this.close_Butt.TabStop = false;
            this.close_Butt.Zoom = 10;
            this.close_Butt.Click += new System.EventHandler(this.close_Butt_Click);
            // 
            // artist_textbox
            // 
            this.artist_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artist_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.artist_textbox.Location = new System.Drawing.Point(153, 135);
            this.artist_textbox.Name = "artist_textbox";
            this.artist_textbox.Size = new System.Drawing.Size(194, 20);
            this.artist_textbox.TabIndex = 18;
            // 
            // name_textbox
            // 
            this.name_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.name_textbox.Location = new System.Drawing.Point(153, 102);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(194, 20);
            this.name_textbox.TabIndex = 17;
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.password_label.Location = new System.Drawing.Point(41, 130);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(59, 25);
            this.password_label.TabIndex = 16;
            this.password_label.Text = "artist:";
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.username_label.Location = new System.Drawing.Point(41, 97);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(67, 25);
            this.username_label.TabIndex = 15;
            this.username_label.Text = "name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(41, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "emotion:";
            // 
            // emotionResolution
            // 
            this.emotionResolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotionResolution.BackColor = System.Drawing.Color.White;
            this.emotionResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.emotionResolution.FormattingEnabled = true;
            this.emotionResolution.Location = new System.Drawing.Point(153, 170);
            this.emotionResolution.Name = "emotionResolution";
            this.emotionResolution.Size = new System.Drawing.Size(194, 21);
            this.emotionResolution.TabIndex = 22;
            // 
            // upload_picture_butt
            // 
            this.upload_picture_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upload_picture_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.upload_picture_butt.Location = new System.Drawing.Point(208, 235);
            this.upload_picture_butt.Name = "upload_picture_butt";
            this.upload_picture_butt.Size = new System.Drawing.Size(151, 46);
            this.upload_picture_butt.TabIndex = 24;
            this.upload_picture_butt.Text = "Upload Picture";
            this.upload_picture_butt.UseVisualStyleBackColor = false;
            this.upload_picture_butt.Click += new System.EventHandler(this.upload_picture_butt_Click);
            // 
            // upload_song_butt
            // 
            this.upload_song_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upload_song_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.upload_song_butt.Location = new System.Drawing.Point(34, 235);
            this.upload_song_butt.Name = "upload_song_butt";
            this.upload_song_butt.Size = new System.Drawing.Size(151, 46);
            this.upload_song_butt.TabIndex = 23;
            this.upload_song_butt.Text = "Upload Song";
            this.upload_song_butt.UseVisualStyleBackColor = false;
            this.upload_song_butt.Click += new System.EventHandler(this.upload_song_butt_Click);
            // 
            // save_Butt
            // 
            this.save_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(182)))), ((int)(((byte)(205)))));
            this.save_Butt.Location = new System.Drawing.Point(208, 303);
            this.save_Butt.Name = "save_Butt";
            this.save_Butt.Size = new System.Drawing.Size(123, 34);
            this.save_Butt.TabIndex = 25;
            this.save_Butt.Text = "Save";
            this.save_Butt.UseVisualStyleBackColor = false;
            this.save_Butt.Click += new System.EventHandler(this.save_Butt_Click);
            // 
            // picture
            // 
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(407, 81);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(256, 256);
            this.picture.TabIndex = 26;
            this.picture.TabStop = false;
            // 
            // cancel_Butt
            // 
            this.cancel_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(182)))), ((int)(((byte)(205)))));
            this.cancel_Butt.Location = new System.Drawing.Point(62, 303);
            this.cancel_Butt.Name = "cancel_Butt";
            this.cancel_Butt.Size = new System.Drawing.Size(123, 34);
            this.cancel_Butt.TabIndex = 27;
            this.cancel_Butt.Text = "Cancel";
            this.cancel_Butt.UseVisualStyleBackColor = false;
            this.cancel_Butt.Click += new System.EventHandler(this.cancel_Butt_Click);
            // 
            // New_Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(692, 411);
            this.Controls.Add(this.cancel_Butt);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.save_Butt);
            this.Controls.Add(this.upload_picture_butt);
            this.Controls.Add(this.upload_song_butt);
            this.Controls.Add(this.emotionResolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artist_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.minimize_Butt);
            this.Controls.Add(this.maximize_Butt);
            this.Controls.Add(this.close_Butt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Song";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New_Song";
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton minimize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton maximize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton close_Butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox artist_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.ComboBox emotionResolution;
        private System.Windows.Forms.Button upload_picture_butt;
        private System.Windows.Forms.Button upload_song_butt;
        private System.Windows.Forms.Button save_Butt;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button cancel_Butt;
    }
}