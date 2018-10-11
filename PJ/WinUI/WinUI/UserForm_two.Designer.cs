namespace WinUI
{
    partial class UserForm_two
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
            this.userFormTwo_background_pictureBox = new System.Windows.Forms.PictureBox();
            this.userFormTwo_button_panel = new System.Windows.Forms.Panel();
            this.userFormTwo_button_four = new System.Windows.Forms.Button();
            this.userFormTwo_button_three = new System.Windows.Forms.Button();
            this.userFormTwo_button_two = new System.Windows.Forms.Button();
            this.userFormTwo_button_one = new System.Windows.Forms.Button();
            this.userFormTwo_time_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.userFormTwo_panel_one = new System.Windows.Forms.Panel();
            this.userFormTwo_panel_two = new System.Windows.Forms.Panel();
            this.userFormTwo_panel_three = new System.Windows.Forms.Panel();
            this.userFormTwo_panel_four = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userFormTwo_background_pictureBox)).BeginInit();
            this.userFormTwo_button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userFormTwo_background_pictureBox
            // 
            this.userFormTwo_background_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormTwo_background_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userFormTwo_background_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.userFormTwo_background_pictureBox.Name = "userFormTwo_background_pictureBox";
            this.userFormTwo_background_pictureBox.Size = new System.Drawing.Size(830, 583);
            this.userFormTwo_background_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userFormTwo_background_pictureBox.TabIndex = 0;
            this.userFormTwo_background_pictureBox.TabStop = false;
            // 
            // userFormTwo_button_panel
            // 
            this.userFormTwo_button_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userFormTwo_button_panel.BackColor = System.Drawing.Color.Transparent;
            this.userFormTwo_button_panel.Controls.Add(this.userFormTwo_button_four);
            this.userFormTwo_button_panel.Controls.Add(this.userFormTwo_button_three);
            this.userFormTwo_button_panel.Controls.Add(this.userFormTwo_button_two);
            this.userFormTwo_button_panel.Controls.Add(this.userFormTwo_button_one);
            this.userFormTwo_button_panel.Location = new System.Drawing.Point(0, 62);
            this.userFormTwo_button_panel.Name = "userFormTwo_button_panel";
            this.userFormTwo_button_panel.Size = new System.Drawing.Size(830, 448);
            this.userFormTwo_button_panel.TabIndex = 1;
            this.userFormTwo_button_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserFormTwo_back);
            // 
            // userFormTwo_button_four
            // 
            this.userFormTwo_button_four.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormTwo_button_four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormTwo_button_four.FlatAppearance.BorderSize = 0;
            this.userFormTwo_button_four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormTwo_button_four.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormTwo_button_four.Location = new System.Drawing.Point(442, 242);
            this.userFormTwo_button_four.Name = "userFormTwo_button_four";
            this.userFormTwo_button_four.Size = new System.Drawing.Size(354, 123);
            this.userFormTwo_button_four.TabIndex = 3;
            this.userFormTwo_button_four.UseVisualStyleBackColor = true;
            this.userFormTwo_button_four.Click += new System.EventHandler(this.business_button_four_click);
            // 
            // userFormTwo_button_three
            // 
            this.userFormTwo_button_three.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormTwo_button_three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormTwo_button_three.FlatAppearance.BorderSize = 0;
            this.userFormTwo_button_three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormTwo_button_three.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormTwo_button_three.Location = new System.Drawing.Point(31, 242);
            this.userFormTwo_button_three.Name = "userFormTwo_button_three";
            this.userFormTwo_button_three.Size = new System.Drawing.Size(357, 123);
            this.userFormTwo_button_three.TabIndex = 2;
            this.userFormTwo_button_three.UseVisualStyleBackColor = true;
            this.userFormTwo_button_three.Click += new System.EventHandler(this.business_button_three_click);
            // 
            // userFormTwo_button_two
            // 
            this.userFormTwo_button_two.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormTwo_button_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormTwo_button_two.FlatAppearance.BorderSize = 0;
            this.userFormTwo_button_two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormTwo_button_two.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormTwo_button_two.Location = new System.Drawing.Point(442, 56);
            this.userFormTwo_button_two.Name = "userFormTwo_button_two";
            this.userFormTwo_button_two.Size = new System.Drawing.Size(354, 126);
            this.userFormTwo_button_two.TabIndex = 1;
            this.userFormTwo_button_two.UseVisualStyleBackColor = true;
            this.userFormTwo_button_two.Click += new System.EventHandler(this.business_button_two_click);
            // 
            // userFormTwo_button_one
            // 
            this.userFormTwo_button_one.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormTwo_button_one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormTwo_button_one.FlatAppearance.BorderSize = 0;
            this.userFormTwo_button_one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormTwo_button_one.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormTwo_button_one.Location = new System.Drawing.Point(31, 56);
            this.userFormTwo_button_one.Name = "userFormTwo_button_one";
            this.userFormTwo_button_one.Size = new System.Drawing.Size(357, 126);
            this.userFormTwo_button_one.TabIndex = 0;
            this.userFormTwo_button_one.UseVisualStyleBackColor = true;
            this.userFormTwo_button_one.Click += new System.EventHandler(this.business_button_one_click);
            // 
            // userFormTwo_time_label
            // 
            this.userFormTwo_time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userFormTwo_time_label.AutoSize = true;
            this.userFormTwo_time_label.BackColor = System.Drawing.Color.Transparent;
            this.userFormTwo_time_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormTwo_time_label.Location = new System.Drawing.Point(12, 555);
            this.userFormTwo_time_label.Name = "userFormTwo_time_label";
            this.userFormTwo_time_label.Size = new System.Drawing.Size(85, 19);
            this.userFormTwo_time_label.TabIndex = 2;
            this.userFormTwo_time_label.Text = "当前时间";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.time_tick);
            // 
            // userFormTwo_panel_one
            // 
            this.userFormTwo_panel_one.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userFormTwo_panel_one.BackColor = System.Drawing.Color.Transparent;
            this.userFormTwo_panel_one.Location = new System.Drawing.Point(768, 0);
            this.userFormTwo_panel_one.Name = "userFormTwo_panel_one";
            this.userFormTwo_panel_one.Size = new System.Drawing.Size(62, 56);
            this.userFormTwo_panel_one.TabIndex = 3;
            this.userFormTwo_panel_one.Click += new System.EventHandler(this.system_button_one_click);
            // 
            // userFormTwo_panel_two
            // 
            this.userFormTwo_panel_two.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userFormTwo_panel_two.BackColor = System.Drawing.Color.Transparent;
            this.userFormTwo_panel_two.Location = new System.Drawing.Point(768, 530);
            this.userFormTwo_panel_two.Name = "userFormTwo_panel_two";
            this.userFormTwo_panel_two.Size = new System.Drawing.Size(62, 53);
            this.userFormTwo_panel_two.TabIndex = 4;
            this.userFormTwo_panel_two.Click += new System.EventHandler(this.system_button_two_click);
            // 
            // userFormTwo_panel_three
            // 
            this.userFormTwo_panel_three.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userFormTwo_panel_three.BackColor = System.Drawing.Color.Transparent;
            this.userFormTwo_panel_three.Location = new System.Drawing.Point(0, 530);
            this.userFormTwo_panel_three.Name = "userFormTwo_panel_three";
            this.userFormTwo_panel_three.Size = new System.Drawing.Size(66, 53);
            this.userFormTwo_panel_three.TabIndex = 5;
            this.userFormTwo_panel_three.Click += new System.EventHandler(this.system_button_three_click);
            // 
            // userFormTwo_panel_four
            // 
            this.userFormTwo_panel_four.BackColor = System.Drawing.Color.Transparent;
            this.userFormTwo_panel_four.Location = new System.Drawing.Point(0, 0);
            this.userFormTwo_panel_four.Name = "userFormTwo_panel_four";
            this.userFormTwo_panel_four.Size = new System.Drawing.Size(66, 56);
            this.userFormTwo_panel_four.TabIndex = 6;
            this.userFormTwo_panel_four.Click += new System.EventHandler(this.system_button_four_click);
            // 
            // UserForm_two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 583);
            this.Controls.Add(this.userFormTwo_panel_four);
            this.Controls.Add(this.userFormTwo_panel_three);
            this.Controls.Add(this.userFormTwo_panel_two);
            this.Controls.Add(this.userFormTwo_panel_one);
            this.Controls.Add(this.userFormTwo_time_label);
            this.Controls.Add(this.userFormTwo_button_panel);
            this.Controls.Add(this.userFormTwo_background_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm_two";
            this.Text = "用户界面2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userFormTwo_load);
            ((System.ComponentModel.ISupportInitialize)(this.userFormTwo_background_pictureBox)).EndInit();
            this.userFormTwo_button_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userFormTwo_background_pictureBox;
        private System.Windows.Forms.Panel userFormTwo_button_panel;
        private System.Windows.Forms.Button userFormTwo_button_two;
        private System.Windows.Forms.Button userFormTwo_button_one;
        private System.Windows.Forms.Button userFormTwo_button_three;
        private System.Windows.Forms.Button userFormTwo_button_four;
        private System.Windows.Forms.Label userFormTwo_time_label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel userFormTwo_panel_one;
        private System.Windows.Forms.Panel userFormTwo_panel_two;
        private System.Windows.Forms.Panel userFormTwo_panel_three;
        private System.Windows.Forms.Panel userFormTwo_panel_four;
    }
}