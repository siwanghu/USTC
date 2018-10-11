namespace WinUI
{
    partial class UserForm_one
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();            
            this.userFromOne_time_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.userFromOne_button_panel = new System.Windows.Forms.Panel();
            this.userFormOne_button_one = new System.Windows.Forms.Button();
            this.userFormOne_button_three = new System.Windows.Forms.Button();
            this.userFormOne_button_two = new System.Windows.Forms.Button();
            this.userFormOne_panel_one = new System.Windows.Forms.Panel();
            this.userFormOne_panel_two = new System.Windows.Forms.Panel();
            this.userFormOne_panel_four = new System.Windows.Forms.Panel();
            this.userFormOne_panel_three = new System.Windows.Forms.Panel();
            userFormOne_background_pictureBox = new System.Windows.Forms.PictureBox();
            this.userFromOne_button_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(userFormOne_background_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userFromOne_time_label
            // 
            this.userFromOne_time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userFromOne_time_label.AutoSize = true;
            this.userFromOne_time_label.BackColor = System.Drawing.Color.Transparent;
            this.userFromOne_time_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFromOne_time_label.Location = new System.Drawing.Point(12, 541);
            this.userFromOne_time_label.Name = "userFromOne_time_label";
            this.userFromOne_time_label.Size = new System.Drawing.Size(85, 19);
            this.userFromOne_time_label.TabIndex = 1;
            this.userFromOne_time_label.Text = "当前时间";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_tick);
            // 
            // userFromOne_button_panel
            // 
            this.userFromOne_button_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userFromOne_button_panel.BackColor = System.Drawing.Color.Transparent;
            this.userFromOne_button_panel.Controls.Add(this.userFormOne_button_one);
            this.userFromOne_button_panel.Controls.Add(this.userFormOne_button_three);
            this.userFromOne_button_panel.Controls.Add(this.userFormOne_button_two);
            this.userFromOne_button_panel.Location = new System.Drawing.Point(85, 26);
            this.userFromOne_button_panel.Name = "userFromOne_button_panel";
            this.userFromOne_button_panel.Size = new System.Drawing.Size(635, 504);
            this.userFromOne_button_panel.TabIndex = 5;
            this.userFromOne_button_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserFormOne_back);
            // 
            // userFormOne_button_one
            // 
            this.userFormOne_button_one.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormOne_button_one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormOne_button_one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormOne_button_one.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormOne_button_one.Location = new System.Drawing.Point(89, 26);
            this.userFormOne_button_one.Name = "userFormOne_button_one";
            this.userFormOne_button_one.Size = new System.Drawing.Size(464, 123);
            this.userFormOne_button_one.TabIndex = 2;
            this.userFormOne_button_one.UseVisualStyleBackColor = true;
            this.userFormOne_button_one.Click += new System.EventHandler(this.business_button_one_click);
            // 
            // userFormOne_button_three
            // 
            this.userFormOne_button_three.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormOne_button_three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormOne_button_three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormOne_button_three.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormOne_button_three.Location = new System.Drawing.Point(89, 367);
            this.userFormOne_button_three.Name = "userFormOne_button_three";
            this.userFormOne_button_three.Size = new System.Drawing.Size(464, 119);
            this.userFormOne_button_three.TabIndex = 4;
            this.userFormOne_button_three.UseVisualStyleBackColor = true;
            this.userFormOne_button_three.Click += new System.EventHandler(this.business_button_three_click);
            // 
            // userFormOne_button_two
            // 
            this.userFormOne_button_two.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userFormOne_button_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFormOne_button_two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFormOne_button_two.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userFormOne_button_two.Location = new System.Drawing.Point(89, 197);
            this.userFormOne_button_two.Name = "userFormOne_button_two";
            this.userFormOne_button_two.Size = new System.Drawing.Size(464, 118);
            this.userFormOne_button_two.TabIndex = 3;
            this.userFormOne_button_two.UseVisualStyleBackColor = true;
            this.userFormOne_button_two.Click += new System.EventHandler(this.business_button_two_click);
            // 
            // userFormOne_panel_one
            // 
            this.userFormOne_panel_one.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userFormOne_panel_one.BackColor = System.Drawing.Color.Transparent;
            this.userFormOne_panel_one.Location = new System.Drawing.Point(755, 0);
            this.userFormOne_panel_one.Name = "userFormOne_panel_one";
            this.userFormOne_panel_one.Size = new System.Drawing.Size(57, 54);
            this.userFormOne_panel_one.TabIndex = 6;
            this.userFormOne_panel_one.Click += new System.EventHandler(this.system_button_one_click);
            // 
            // userFormOne_panel_two
            // 
            this.userFormOne_panel_two.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userFormOne_panel_two.BackColor = System.Drawing.Color.Transparent;
            this.userFormOne_panel_two.Location = new System.Drawing.Point(742, 520);
            this.userFormOne_panel_two.Name = "userFormOne_panel_two";
            this.userFormOne_panel_two.Size = new System.Drawing.Size(70, 56);
            this.userFormOne_panel_two.TabIndex = 7;
            this.userFormOne_panel_two.Click += new System.EventHandler(this.system_button_two_click);
            // 
            // userFormOne_panel_four
            // 
            this.userFormOne_panel_four.BackColor = System.Drawing.Color.Transparent;
            this.userFormOne_panel_four.Location = new System.Drawing.Point(0, 0);
            this.userFormOne_panel_four.Name = "userFormOne_panel_four";
            this.userFormOne_panel_four.Size = new System.Drawing.Size(65, 54);
            this.userFormOne_panel_four.TabIndex = 8;
            this.userFormOne_panel_four.Click += new System.EventHandler(this.system_button_four_click);
            // 
            // userFormOne_panel_three
            // 
            this.userFormOne_panel_three.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userFormOne_panel_three.BackColor = System.Drawing.Color.Transparent;
            this.userFormOne_panel_three.Location = new System.Drawing.Point(0, 520);
            this.userFormOne_panel_three.Name = "userFormOne_panel_three";
            this.userFormOne_panel_three.Size = new System.Drawing.Size(65, 56);
            this.userFormOne_panel_three.TabIndex = 9;
            this.userFormOne_panel_three.Click += new System.EventHandler(this.system_button_three_click);
            // 
            // userFormOne_background_pictureBox
            // 
            userFormOne_background_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            userFormOne_background_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            userFormOne_background_pictureBox.Location = new System.Drawing.Point(0, 0);
            userFormOne_background_pictureBox.Name = "userFormOne_background_pictureBox";
            userFormOne_background_pictureBox.Size = new System.Drawing.Size(812, 576);
            userFormOne_background_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            userFormOne_background_pictureBox.TabIndex = 0;
            userFormOne_background_pictureBox.TabStop = false;
            // 
            // UserForm_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 576);
            this.Controls.Add(this.userFormOne_panel_three);
            this.Controls.Add(this.userFormOne_panel_four);
            this.Controls.Add(this.userFormOne_panel_two);
            this.Controls.Add(this.userFormOne_panel_one);
            this.Controls.Add(this.userFromOne_button_panel);
            this.Controls.Add(this.userFromOne_time_label);
            this.Controls.Add(userFormOne_background_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm_one";
            this.Text = "用户界面1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userForm_load);
            this.userFromOne_button_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(userFormOne_background_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userFormOne_background_pictureBox;
        private System.Windows.Forms.Label userFromOne_time_label;
        private System.Windows.Forms.Button userFormOne_button_one;
        private System.Windows.Forms.Button userFormOne_button_two;
        private System.Windows.Forms.Button userFormOne_button_three;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel userFromOne_button_panel;
        private System.Windows.Forms.Panel userFormOne_panel_one;
        private System.Windows.Forms.Panel userFormOne_panel_two;
        private System.Windows.Forms.Panel userFormOne_panel_four;
        private System.Windows.Forms.Panel userFormOne_panel_three;
    }
}

