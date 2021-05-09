namespace Project
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.minimize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.maximize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.close_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.new_song_Butt = new System.Windows.Forms.Button();
            this.delete_song_Butt = new System.Windows.Forms.Button();
            this.back_Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).BeginInit();
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
            this.minimize_Butt.Location = new System.Drawing.Point(265, 12);
            this.minimize_Butt.Name = "minimize_Butt";
            this.minimize_Butt.Size = new System.Drawing.Size(29, 29);
            this.minimize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_Butt.TabIndex = 11;
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
            this.maximize_Butt.Location = new System.Drawing.Point(300, 12);
            this.maximize_Butt.Name = "maximize_Butt";
            this.maximize_Butt.Size = new System.Drawing.Size(29, 29);
            this.maximize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize_Butt.TabIndex = 10;
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
            this.close_Butt.Location = new System.Drawing.Point(335, 12);
            this.close_Butt.Name = "close_Butt";
            this.close_Butt.Size = new System.Drawing.Size(29, 29);
            this.close_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Butt.TabIndex = 9;
            this.close_Butt.TabStop = false;
            this.close_Butt.Zoom = 10;
            this.close_Butt.Click += new System.EventHandler(this.close_Butt_Click);
            // 
            // new_song_Butt
            // 
            this.new_song_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_song_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(135)))));
            this.new_song_Butt.Location = new System.Drawing.Point(60, 116);
            this.new_song_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.new_song_Butt.Name = "new_song_Butt";
            this.new_song_Butt.Size = new System.Drawing.Size(117, 41);
            this.new_song_Butt.TabIndex = 13;
            this.new_song_Butt.Text = "New Song";
            this.new_song_Butt.UseVisualStyleBackColor = false;
            this.new_song_Butt.Click += new System.EventHandler(this.new_song_Butt_Click);
            // 
            // delete_song_Butt
            // 
            this.delete_song_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_song_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(135)))));
            this.delete_song_Butt.Location = new System.Drawing.Point(201, 116);
            this.delete_song_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.delete_song_Butt.Name = "delete_song_Butt";
            this.delete_song_Butt.Size = new System.Drawing.Size(117, 41);
            this.delete_song_Butt.TabIndex = 12;
            this.delete_song_Butt.Text = "Delete Song";
            this.delete_song_Butt.UseVisualStyleBackColor = false;
            this.delete_song_Butt.Click += new System.EventHandler(this.delete_song_Butt_Click);
            // 
            // back_Butt
            // 
            this.back_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(135)))));
            this.back_Butt.Location = new System.Drawing.Point(130, 183);
            this.back_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.back_Butt.Name = "back_Butt";
            this.back_Butt.Size = new System.Drawing.Size(117, 41);
            this.back_Butt.TabIndex = 14;
            this.back_Butt.Text = "Back";
            this.back_Butt.UseVisualStyleBackColor = false;
            this.back_Butt.Click += new System.EventHandler(this.back_Butt_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(378, 304);
            this.Controls.Add(this.back_Butt);
            this.Controls.Add(this.new_song_Butt);
            this.Controls.Add(this.delete_song_Butt);
            this.Controls.Add(this.minimize_Butt);
            this.Controls.Add(this.maximize_Butt);
            this.Controls.Add(this.close_Butt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton minimize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton maximize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton close_Butt;
        private System.Windows.Forms.Button new_song_Butt;
        private System.Windows.Forms.Button delete_song_Butt;
        private System.Windows.Forms.Button back_Butt;
    }
}