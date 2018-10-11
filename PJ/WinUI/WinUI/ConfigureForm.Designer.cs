namespace WinUI
{
    partial class ConfigureForm
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
            this.configureForm_splitContainer = new System.Windows.Forms.SplitContainer();
            this.configureForm_lable_panel = new System.Windows.Forms.Panel();
            this.configureForm_name_label = new System.Windows.Forms.Label();
            this.configureForm_form_panel = new System.Windows.Forms.Panel();
            this.configureForm_button_panel = new System.Windows.Forms.Panel();
            this.configureForm_exit_button = new System.Windows.Forms.Button();
            this.configureForm_password_button = new System.Windows.Forms.Button();
            this.configureForm_language_button = new System.Windows.Forms.Button();
            this.configureForm_print_button = new System.Windows.Forms.Button();
            this.configureForm_vip_button = new System.Windows.Forms.Button();
            this.confugureForm_screen_button = new System.Windows.Forms.Button();
            this.configureForm_ui_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.configureForm_splitContainer)).BeginInit();
            this.configureForm_splitContainer.Panel1.SuspendLayout();
            this.configureForm_splitContainer.Panel2.SuspendLayout();
            this.configureForm_splitContainer.SuspendLayout();
            this.configureForm_lable_panel.SuspendLayout();
            this.configureForm_button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // configureForm_splitContainer
            // 
            this.configureForm_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configureForm_splitContainer.IsSplitterFixed = true;
            this.configureForm_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.configureForm_splitContainer.Name = "configureForm_splitContainer";
            this.configureForm_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // configureForm_splitContainer.Panel1
            // 
            this.configureForm_splitContainer.Panel1.Controls.Add(this.configureForm_lable_panel);
            this.configureForm_splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // configureForm_splitContainer.Panel2
            // 
            this.configureForm_splitContainer.Panel2.Controls.Add(this.configureForm_form_panel);
            this.configureForm_splitContainer.Panel2.Controls.Add(this.configureForm_button_panel);
            this.configureForm_splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.configureForm_splitContainer.Size = new System.Drawing.Size(644, 454);
            this.configureForm_splitContainer.SplitterDistance = 71;
            this.configureForm_splitContainer.SplitterWidth = 1;
            this.configureForm_splitContainer.TabIndex = 0;
            // 
            // configureForm_lable_panel
            // 
            this.configureForm_lable_panel.BackColor = System.Drawing.Color.Transparent;
            this.configureForm_lable_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.configureForm_lable_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configureForm_lable_panel.Controls.Add(this.configureForm_name_label);
            this.configureForm_lable_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configureForm_lable_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.configureForm_lable_panel.Location = new System.Drawing.Point(0, 0);
            this.configureForm_lable_panel.Name = "configureForm_lable_panel";
            this.configureForm_lable_panel.Size = new System.Drawing.Size(644, 71);
            this.configureForm_lable_panel.TabIndex = 0;
            // 
            // configureForm_name_label
            // 
            this.configureForm_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.configureForm_name_label.AutoSize = true;
            this.configureForm_name_label.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_name_label.Location = new System.Drawing.Point(156, 14);
            this.configureForm_name_label.Name = "configureForm_name_label";
            this.configureForm_name_label.Size = new System.Drawing.Size(231, 35);
            this.configureForm_name_label.TabIndex = 0;
            this.configureForm_name_label.Text = "系统配置界面";
            // 
            // configureForm_form_panel
            // 
            this.configureForm_form_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configureForm_form_panel.BackColor = System.Drawing.Color.Transparent;
            this.configureForm_form_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_form_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configureForm_form_panel.Location = new System.Drawing.Point(155, 4);
            this.configureForm_form_panel.Name = "configureForm_form_panel";
            this.configureForm_form_panel.Size = new System.Drawing.Size(486, 378);
            this.configureForm_form_panel.TabIndex = 1;
            // 
            // configureForm_button_panel
            // 
            this.configureForm_button_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.configureForm_button_panel.BackColor = System.Drawing.Color.Transparent;
            this.configureForm_button_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configureForm_button_panel.Controls.Add(this.configureForm_exit_button);
            this.configureForm_button_panel.Controls.Add(this.configureForm_password_button);
            this.configureForm_button_panel.Controls.Add(this.configureForm_language_button);
            this.configureForm_button_panel.Controls.Add(this.configureForm_print_button);
            this.configureForm_button_panel.Controls.Add(this.configureForm_vip_button);
            this.configureForm_button_panel.Controls.Add(this.confugureForm_screen_button);
            this.configureForm_button_panel.Controls.Add(this.configureForm_ui_button);
            this.configureForm_button_panel.Location = new System.Drawing.Point(4, 4);
            this.configureForm_button_panel.Name = "configureForm_button_panel";
            this.configureForm_button_panel.Size = new System.Drawing.Size(145, 402);
            this.configureForm_button_panel.TabIndex = 0;
            // 
            // configureForm_exit_button
            // 
            this.configureForm_exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configureForm_exit_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_exit_button.Location = new System.Drawing.Point(0, 320);
            this.configureForm_exit_button.Name = "configureForm_exit_button";
            this.configureForm_exit_button.Size = new System.Drawing.Size(145, 56);
            this.configureForm_exit_button.TabIndex = 6;
            this.configureForm_exit_button.Text = "退出";
            this.configureForm_exit_button.UseVisualStyleBackColor = true;
            this.configureForm_exit_button.Click += new System.EventHandler(this.system_help_button_click);
            // 
            // configureForm_password_button
            // 
            this.configureForm_password_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_password_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configureForm_password_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_password_button.Location = new System.Drawing.Point(0, 264);
            this.configureForm_password_button.Name = "configureForm_password_button";
            this.configureForm_password_button.Size = new System.Drawing.Size(145, 56);
            this.configureForm_password_button.TabIndex = 5;
            this.configureForm_password_button.Text = "密码设置";
            this.configureForm_password_button.UseVisualStyleBackColor = true;
            this.configureForm_password_button.Click += new System.EventHandler(this.system_password_button_click);
            // 
            // configureForm_language_button
            // 
            this.configureForm_language_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_language_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configureForm_language_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_language_button.Location = new System.Drawing.Point(0, 211);
            this.configureForm_language_button.Name = "configureForm_language_button";
            this.configureForm_language_button.Size = new System.Drawing.Size(145, 56);
            this.configureForm_language_button.TabIndex = 4;
            this.configureForm_language_button.Text = "语音配置";
            this.configureForm_language_button.UseVisualStyleBackColor = true;
            this.configureForm_language_button.Click += new System.EventHandler(this.system_language_button_click);
            // 
            // configureForm_print_button
            // 
            this.configureForm_print_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_print_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configureForm_print_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_print_button.Location = new System.Drawing.Point(0, 158);
            this.configureForm_print_button.Name = "configureForm_print_button";
            this.configureForm_print_button.Size = new System.Drawing.Size(144, 54);
            this.configureForm_print_button.TabIndex = 3;
            this.configureForm_print_button.Text = "打印机配置";
            this.configureForm_print_button.UseVisualStyleBackColor = true;
            this.configureForm_print_button.Click += new System.EventHandler(this.system_print_button_click);
            // 
            // configureForm_vip_button
            // 
            this.configureForm_vip_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_vip_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configureForm_vip_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_vip_button.Location = new System.Drawing.Point(0, 104);
            this.configureForm_vip_button.Name = "configureForm_vip_button";
            this.configureForm_vip_button.Size = new System.Drawing.Size(145, 56);
            this.configureForm_vip_button.TabIndex = 2;
            this.configureForm_vip_button.Text = "vip客户配置";
            this.configureForm_vip_button.UseVisualStyleBackColor = true;
            this.configureForm_vip_button.Click += new System.EventHandler(this.system_vip_button_click);
            // 
            // confugureForm_screen_button
            // 
            this.confugureForm_screen_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confugureForm_screen_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confugureForm_screen_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confugureForm_screen_button.Location = new System.Drawing.Point(0, 53);
            this.confugureForm_screen_button.Name = "confugureForm_screen_button";
            this.confugureForm_screen_button.Size = new System.Drawing.Size(145, 52);
            this.confugureForm_screen_button.TabIndex = 1;
            this.confugureForm_screen_button.Text = "综合屏配置";
            this.confugureForm_screen_button.UseVisualStyleBackColor = true;
            this.confugureForm_screen_button.Click += new System.EventHandler(this.system_screen_button_click);
            // 
            // configureForm_ui_button
            // 
            this.configureForm_ui_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configureForm_ui_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configureForm_ui_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configureForm_ui_button.Location = new System.Drawing.Point(0, 0);
            this.configureForm_ui_button.Name = "configureForm_ui_button";
            this.configureForm_ui_button.Size = new System.Drawing.Size(145, 53);
            this.configureForm_ui_button.TabIndex = 0;
            this.configureForm_ui_button.Text = "界面配置";
            this.configureForm_ui_button.UseVisualStyleBackColor = true;
            this.configureForm_ui_button.Click += new System.EventHandler(this.system_ui_button_click);
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 454);
            this.Controls.Add(this.configureForm_splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigureForm";
            this.Text = "系统配置界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.configureForm_load);
            this.configureForm_splitContainer.Panel1.ResumeLayout(false);
            this.configureForm_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configureForm_splitContainer)).EndInit();
            this.configureForm_splitContainer.ResumeLayout(false);
            this.configureForm_lable_panel.ResumeLayout(false);
            this.configureForm_lable_panel.PerformLayout();
            this.configureForm_button_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer configureForm_splitContainer;
        private System.Windows.Forms.Label configureForm_name_label;
        private System.Windows.Forms.Panel configureForm_lable_panel;
        private System.Windows.Forms.Panel configureForm_button_panel;
        private System.Windows.Forms.Button configureForm_ui_button;
        private System.Windows.Forms.Panel configureForm_form_panel;
        private System.Windows.Forms.Button configureForm_vip_button;
        private System.Windows.Forms.Button confugureForm_screen_button;
        private System.Windows.Forms.Button configureForm_exit_button;
        private System.Windows.Forms.Button configureForm_password_button;
        private System.Windows.Forms.Button configureForm_language_button;
        private System.Windows.Forms.Button configureForm_print_button;
    }
}