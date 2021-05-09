namespace Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.confirm_Butt = new System.Windows.Forms.Button();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.close_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.maximize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimize_Butt = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.error_label = new System.Windows.Forms.Label();
            this.new_user_Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.username_label.Location = new System.Drawing.Point(36, 111);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(105, 25);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "username:";
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.password_label.Location = new System.Drawing.Point(37, 143);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(102, 25);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "password:";
            // 
            // confirm_Butt
            // 
            this.confirm_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(135)))));
            this.confirm_Butt.Location = new System.Drawing.Point(202, 215);
            this.confirm_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.confirm_Butt.Name = "confirm_Butt";
            this.confirm_Butt.Size = new System.Drawing.Size(117, 41);
            this.confirm_Butt.TabIndex = 2;
            this.confirm_Butt.Text = "confirm";
            this.confirm_Butt.UseVisualStyleBackColor = false;
            this.confirm_Butt.Click += new System.EventHandler(this.confirm_Butt_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_textbox.Location = new System.Drawing.Point(148, 115);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(194, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_textbox.Location = new System.Drawing.Point(148, 148);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(194, 20);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // close_Butt
            // 
            this.close_Butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Butt.BackColor = System.Drawing.Color.Transparent;
            this.close_Butt.Image = ((System.Drawing.Image)(resources.GetObject("close_Butt.Image")));
            this.close_Butt.ImageActive = null;
            this.close_Butt.Location = new System.Drawing.Point(337, 12);
            this.close_Butt.Name = "close_Butt";
            this.close_Butt.Size = new System.Drawing.Size(25, 23);
            this.close_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Butt.TabIndex = 5;
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
            this.maximize_Butt.Location = new System.Drawing.Point(306, 12);
            this.maximize_Butt.Name = "maximize_Butt";
            this.maximize_Butt.Size = new System.Drawing.Size(25, 23);
            this.maximize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize_Butt.TabIndex = 6;
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
            this.minimize_Butt.Location = new System.Drawing.Point(275, 12);
            this.minimize_Butt.Name = "minimize_Butt";
            this.minimize_Butt.Size = new System.Drawing.Size(25, 23);
            this.minimize_Butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_Butt.TabIndex = 7;
            this.minimize_Butt.TabStop = false;
            this.minimize_Butt.Zoom = 10;
            this.minimize_Butt.Click += new System.EventHandler(this.minimize_Butt_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.error_label.Location = new System.Drawing.Point(143, 64);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 25);
            this.error_label.TabIndex = 8;
            // 
            // new_user_Butt
            // 
            this.new_user_Butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_user_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(135)))));
            this.new_user_Butt.Location = new System.Drawing.Point(61, 215);
            this.new_user_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.new_user_Butt.Name = "new_user_Butt";
            this.new_user_Butt.Size = new System.Drawing.Size(117, 41);
            this.new_user_Butt.TabIndex = 9;
            this.new_user_Butt.Text = "new user";
            this.new_user_Butt.UseVisualStyleBackColor = false;
            this.new_user_Butt.Click += new System.EventHandler(this.new_user_Butt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(378, 304);
            this.Controls.Add(this.new_user_Butt);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.minimize_Butt);
            this.Controls.Add(this.maximize_Butt);
            this.Controls.Add(this.close_Butt);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.confirm_Butt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.close_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Butt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button confirm_Butt;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton minimize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton maximize_Butt;
        private Bunifu.Framework.UI.BunifuImageButton close_Butt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button new_user_Butt;
    }
}