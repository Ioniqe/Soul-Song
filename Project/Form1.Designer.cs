namespace Project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.capture_butt = new System.Windows.Forms.Button();
            this.cameraResolution = new System.Windows.Forms.ComboBox();
            this.detect_butt = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.close_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.maximize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(44, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // capture_butt
            // 
            this.capture_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.capture_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(182)))), ((int)(((byte)(205)))));
            this.capture_butt.Location = new System.Drawing.Point(496, 883);
            this.capture_butt.Name = "capture_butt";
            this.capture_butt.Size = new System.Drawing.Size(183, 60);
            this.capture_butt.TabIndex = 1;
            this.capture_butt.Text = "Capture";
            this.capture_butt.UseVisualStyleBackColor = false;
            this.capture_butt.Click += new System.EventHandler(this.captureButt_Click);
            // 
            // cameraResolution
            // 
            this.cameraResolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cameraResolution.BackColor = System.Drawing.Color.White;
            this.cameraResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.cameraResolution.FormattingEnabled = true;
            this.cameraResolution.Location = new System.Drawing.Point(475, 841);
            this.cameraResolution.Name = "cameraResolution";
            this.cameraResolution.Size = new System.Drawing.Size(435, 21);
            this.cameraResolution.TabIndex = 3;
            this.cameraResolution.SelectedIndexChanged += new System.EventHandler(this.cameraResolution_SelectedIndexChanged);
            // 
            // detect_butt
            // 
            this.detect_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detect_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.detect_butt.Location = new System.Drawing.Point(712, 883);
            this.detect_butt.Name = "detect_butt";
            this.detect_butt.Size = new System.Drawing.Size(183, 60);
            this.detect_butt.TabIndex = 4;
            this.detect_butt.Text = "Detect Emotion";
            this.detect_butt.UseVisualStyleBackColor = false;
            this.detect_butt.Click += new System.EventHandler(this.detect_butt_Click);
            // 
            // results
            // 
            this.results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.results.Location = new System.Drawing.Point(679, 30);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 20);
            this.results.TabIndex = 5;
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
            // close_Butt
            // 
            this.close_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Butt.BackColor = System.Drawing.Color.Transparent;
            this.close_Butt.Image = ((System.Drawing.Image)(resources.GetObject("close_Butt.Image")));
            this.close_Butt.ImageActive = null;
            this.close_Butt.Location = new System.Drawing.Point(1321, 12);
            this.close_Butt.Name = "close_Butt";
            this.close_Butt.Size = new System.Drawing.Size(29, 29);
            this.close_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Butt.TabIndex = 6;
            this.close_Butt.TabStop = false;
            this.close_Butt.Zoom = 10;
            this.close_Butt.Click += new System.EventHandler(this.close_Butt_Click);
            // 
            // maximize_Butt
            // 
            this.maximize_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_Butt.BackColor = System.Drawing.Color.Transparent;
            this.maximize_Butt.Image = ((System.Drawing.Image)(resources.GetObject("maximize_Butt.Image")));
            this.maximize_Butt.ImageActive = null;
            this.maximize_Butt.Location = new System.Drawing.Point(1286, 12);
            this.maximize_Butt.Name = "maximize_Butt";
            this.maximize_Butt.Size = new System.Drawing.Size(29, 29);
            this.maximize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize_Butt.TabIndex = 7;
            this.maximize_Butt.TabStop = false;
            this.maximize_Butt.Zoom = 10;
            this.maximize_Butt.Click += new System.EventHandler(this.maximize_Butt_Click);
            // 
            // minimize_Butt
            // 
            this.minimize_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_Butt.BackColor = System.Drawing.Color.Transparent;
            this.minimize_Butt.Image = ((System.Drawing.Image)(resources.GetObject("minimize_Butt.Image")));
            this.minimize_Butt.ImageActive = null;
            this.minimize_Butt.Location = new System.Drawing.Point(1251, 12);
            this.minimize_Butt.Name = "minimize_Butt";
            this.minimize_Butt.Size = new System.Drawing.Size(29, 29);
            this.minimize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_Butt.TabIndex = 8;
            this.minimize_Butt.TabStop = false;
            this.minimize_Butt.Zoom = 10;
            this.minimize_Butt.Click += new System.EventHandler(this.minimize_Butt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1068, 810);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 144);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1366, 975);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.minimize_Butt);
            this.Controls.Add(this.maximize_Butt);
            this.Controls.Add(this.close_Butt);
            this.Controls.Add(this.results);
            this.Controls.Add(this.detect_butt);
            this.Controls.Add(this.cameraResolution);
            this.Controls.Add(this.capture_butt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button capture_butt;
        private System.Windows.Forms.ComboBox cameraResolution;
        private System.Windows.Forms.Button detect_butt;
        private System.Windows.Forms.Label results;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton minimize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton maximize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton close_Butt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

