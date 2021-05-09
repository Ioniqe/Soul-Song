namespace Project
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minimize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.maximize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.close_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.results = new System.Windows.Forms.Label();
            this.back_Butt = new System.Windows.Forms.Button();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.volume = new Bunifu.Framework.UI.BunifuSlider();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.skip_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.skip_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.play = new Bunifu.Framework.UI.BunifuImageButton();
            this.songLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skip_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // minimize_Butt
            // 
            this.minimize_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_Butt.BackColor = System.Drawing.Color.Transparent;
            this.minimize_Butt.Image = ((System.Drawing.Image)(resources.GetObject("minimize_Butt.Image")));
            this.minimize_Butt.ImageActive = null;
            this.minimize_Butt.Location = new System.Drawing.Point(1244, 17);
            this.minimize_Butt.Name = "minimize_Butt";
            this.minimize_Butt.Size = new System.Drawing.Size(33, 32);
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
            this.maximize_Butt.Location = new System.Drawing.Point(1279, 17);
            this.maximize_Butt.Name = "maximize_Butt";
            this.maximize_Butt.Size = new System.Drawing.Size(33, 32);
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
            this.close_Butt.Location = new System.Drawing.Point(1314, 17);
            this.close_Butt.Name = "close_Butt";
            this.close_Butt.Size = new System.Drawing.Size(33, 32);
            this.close_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Butt.TabIndex = 9;
            this.close_Butt.TabStop = false;
            this.close_Butt.Zoom = 10;
            this.close_Butt.Click += new System.EventHandler(this.close_Butt_Click);
            // 
            // results
            // 
            this.results.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Lemon/Milk light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.ForeColor = System.Drawing.Color.Gainsboro;
            this.results.Location = new System.Drawing.Point(590, 12);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(163, 50);
            this.results.TabIndex = 12;
            this.results.Text = "Results";
            // 
            // back_Butt
            // 
            this.back_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(135)))));
            this.back_Butt.Location = new System.Drawing.Point(9, 12);
            this.back_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.back_Butt.Name = "back_Butt";
            this.back_Butt.Size = new System.Drawing.Size(117, 41);
            this.back_Butt.TabIndex = 13;
            this.back_Butt.Text = "Take Picture";
            this.back_Butt.UseVisualStyleBackColor = false;
            this.back_Butt.Click += new System.EventHandler(this.back_Butt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.volume);
            this.panel1.Controls.Add(this.maximize_Butt);
            this.panel1.Controls.Add(this.close_Butt);
            this.panel1.Controls.Add(this.minimize_Butt);
            this.panel1.Controls.Add(this.back_Butt);
            this.panel1.Controls.Add(this.results);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 72);
            this.panel1.TabIndex = 17;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BackgroudColor = System.Drawing.Color.Gainsboro;
            this.volume.BorderRadius = 5;
            this.volume.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.volume.Location = new System.Drawing.Point(1061, 21);
            this.volume.MaximumValue = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(123, 30);
            this.volume.TabIndex = 14;
            this.volume.Value = 50;
            this.volume.ValueChanged += new System.EventHandler(this.changeValue);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1366, 903);
            this.flowLayoutPanel1.TabIndex = 18;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 515);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(425, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.skip_back);
            this.panel3.Controls.Add(this.skip_next);
            this.panel3.Controls.Add(this.play);
            this.panel3.Controls.Add(this.songLabel);
            this.panel3.Controls.Add(this.artistLabel);
            this.panel3.Location = new System.Drawing.Point(3, 524);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1340, 276);
            this.panel3.TabIndex = 1;
            // 
            // skip_back
            // 
            this.skip_back.BackColor = System.Drawing.Color.Transparent;
            this.skip_back.Image = ((System.Drawing.Image)(resources.GetObject("skip_back.Image")));
            this.skip_back.ImageActive = null;
            this.skip_back.Location = new System.Drawing.Point(513, 173);
            this.skip_back.Name = "skip_back";
            this.skip_back.Size = new System.Drawing.Size(50, 50);
            this.skip_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skip_back.TabIndex = 22;
            this.skip_back.TabStop = false;
            this.skip_back.Zoom = 10;
            this.skip_back.Click += new System.EventHandler(this.skip_back_Click);
            // 
            // skip_next
            // 
            this.skip_next.BackColor = System.Drawing.Color.Transparent;
            this.skip_next.Image = ((System.Drawing.Image)(resources.GetObject("skip_next.Image")));
            this.skip_next.ImageActive = null;
            this.skip_next.Location = new System.Drawing.Point(766, 173);
            this.skip_next.Name = "skip_next";
            this.skip_next.Size = new System.Drawing.Size(50, 50);
            this.skip_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skip_next.TabIndex = 21;
            this.skip_next.TabStop = false;
            this.skip_next.Zoom = 10;
            this.skip_next.Click += new System.EventHandler(this.skip_next_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.ImageActive = null;
            this.play.Location = new System.Drawing.Point(629, 162);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(70, 70);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 20;
            this.play.TabStop = false;
            this.play.Zoom = 10;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // songLabel
            // 
            this.songLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songLabel.Font = new System.Drawing.Font("Lemon/Milk light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.songLabel.Location = new System.Drawing.Point(9, 22);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(1318, 72);
            this.songLabel.TabIndex = 18;
            this.songLabel.Text = "song";
            this.songLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistLabel
            // 
            this.artistLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artistLabel.Font = new System.Drawing.Font("Lemon/Milk light", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.artistLabel.Location = new System.Drawing.Point(9, 97);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(1318, 42);
            this.artistLabel.TabIndex = 17;
            this.artistLabel.Text = "artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1366, 975);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skip_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton minimize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton maximize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton close_Butt;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button back_Butt;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Label artistLabel;
        private Bunifu.Framework.UI.BunifuImageButton skip_back;
        private Bunifu.Framework.UI.BunifuImageButton skip_next;
        private Bunifu.Framework.UI.BunifuImageButton play;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuSlider volume;
    }
}