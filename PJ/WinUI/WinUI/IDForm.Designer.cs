namespace WinUI
{
    partial class IDForm
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
            this.IDForm_background_pictureBox = new System.Windows.Forms.PictureBox();
            this.IDForm_control_panel = new System.Windows.Forms.Panel();
            this.IDForm_time_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_times_label = new System.Windows.Forms.Label();
            this.IDForm_organization_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_organization_label = new System.Windows.Forms.Label();
            this.IDForm_ok_button = new System.Windows.Forms.Button();
            this.IDForm_birth_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_birth_label = new System.Windows.Forms.Label();
            this.IDForm_next_button = new System.Windows.Forms.Button();
            this.IDForm_pictureBox = new System.Windows.Forms.PictureBox();
            this.IDForm_ID_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_ID_label = new System.Windows.Forms.Label();
            this.IDForm_address_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_address_label = new System.Windows.Forms.Label();
            this.IDForm_nation_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_nation_label = new System.Windows.Forms.Label();
            this.IDForm_sex_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_sex_label = new System.Windows.Forms.Label();
            this.IDForm_name_textBox = new System.Windows.Forms.TextBox();
            this.IDForm_name_label = new System.Windows.Forms.Label();
            this.IDForm_time_label = new System.Windows.Forms.Label();
            this.IDForm_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDForm_background_pictureBox)).BeginInit();
            this.IDForm_control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDForm_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IDForm_background_pictureBox
            // 
            this.IDForm_background_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IDForm_background_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDForm_background_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.IDForm_background_pictureBox.Name = "IDForm_background_pictureBox";
            this.IDForm_background_pictureBox.Size = new System.Drawing.Size(1012, 570);
            this.IDForm_background_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IDForm_background_pictureBox.TabIndex = 0;
            this.IDForm_background_pictureBox.TabStop = false;
            // 
            // IDForm_control_panel
            // 
            this.IDForm_control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDForm_control_panel.BackColor = System.Drawing.Color.Transparent;
            this.IDForm_control_panel.Controls.Add(this.IDForm_time_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_times_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_organization_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_organization_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_ok_button);
            this.IDForm_control_panel.Controls.Add(this.IDForm_birth_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_birth_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_next_button);
            this.IDForm_control_panel.Controls.Add(this.IDForm_pictureBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_ID_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_ID_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_address_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_address_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_nation_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_nation_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_sex_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_sex_label);
            this.IDForm_control_panel.Controls.Add(this.IDForm_name_textBox);
            this.IDForm_control_panel.Controls.Add(this.IDForm_name_label);
            this.IDForm_control_panel.Location = new System.Drawing.Point(60, 24);
            this.IDForm_control_panel.Name = "IDForm_control_panel";
            this.IDForm_control_panel.Size = new System.Drawing.Size(880, 484);
            this.IDForm_control_panel.TabIndex = 1;
            this.IDForm_control_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IDForm_MouseDown_Double_click);
            // 
            // IDForm_time_textBox
            // 
            this.IDForm_time_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_time_textBox.Enabled = false;
            this.IDForm_time_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_time_textBox.Location = new System.Drawing.Point(145, 412);
            this.IDForm_time_textBox.Multiline = true;
            this.IDForm_time_textBox.Name = "IDForm_time_textBox";
            this.IDForm_time_textBox.Size = new System.Drawing.Size(261, 60);
            this.IDForm_time_textBox.TabIndex = 18;
            // 
            // IDForm_times_label
            // 
            this.IDForm_times_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_times_label.AutoSize = true;
            this.IDForm_times_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.IDForm_times_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_times_label.Location = new System.Drawing.Point(38, 422);
            this.IDForm_times_label.Name = "IDForm_times_label";
            this.IDForm_times_label.Size = new System.Drawing.Size(69, 19);
            this.IDForm_times_label.TabIndex = 17;
            this.IDForm_times_label.Text = "有效期";
            // 
            // IDForm_organization_textBox
            // 
            this.IDForm_organization_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_organization_textBox.Enabled = false;
            this.IDForm_organization_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_organization_textBox.Location = new System.Drawing.Point(557, 32);
            this.IDForm_organization_textBox.Name = "IDForm_organization_textBox";
            this.IDForm_organization_textBox.Size = new System.Drawing.Size(292, 29);
            this.IDForm_organization_textBox.TabIndex = 16;
            // 
            // IDForm_organization_label
            // 
            this.IDForm_organization_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_organization_label.AutoSize = true;
            this.IDForm_organization_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.IDForm_organization_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_organization_label.Location = new System.Drawing.Point(444, 35);
            this.IDForm_organization_label.Name = "IDForm_organization_label";
            this.IDForm_organization_label.Size = new System.Drawing.Size(89, 19);
            this.IDForm_organization_label.TabIndex = 15;
            this.IDForm_organization_label.Text = "签发机关";
            // 
            // IDForm_ok_button
            // 
            this.IDForm_ok_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IDForm_ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IDForm_ok_button.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_ok_button.Location = new System.Drawing.Point(468, 412);
            this.IDForm_ok_button.Name = "IDForm_ok_button";
            this.IDForm_ok_button.Size = new System.Drawing.Size(136, 60);
            this.IDForm_ok_button.TabIndex = 14;
            this.IDForm_ok_button.Text = "确认";
            this.IDForm_ok_button.UseVisualStyleBackColor = true;
            this.IDForm_ok_button.Click += new System.EventHandler(this.IDForm_ok_button_click);
            // 
            // IDForm_birth_textBox
            // 
            this.IDForm_birth_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_birth_textBox.Enabled = false;
            this.IDForm_birth_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_birth_textBox.Location = new System.Drawing.Point(145, 167);
            this.IDForm_birth_textBox.Name = "IDForm_birth_textBox";
            this.IDForm_birth_textBox.Size = new System.Drawing.Size(261, 29);
            this.IDForm_birth_textBox.TabIndex = 13;
            // 
            // IDForm_birth_label
            // 
            this.IDForm_birth_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_birth_label.AutoSize = true;
            this.IDForm_birth_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_birth_label.Location = new System.Drawing.Point(53, 170);
            this.IDForm_birth_label.Name = "IDForm_birth_label";
            this.IDForm_birth_label.Size = new System.Drawing.Size(49, 19);
            this.IDForm_birth_label.TabIndex = 12;
            this.IDForm_birth_label.Text = "出生";
            // 
            // IDForm_next_button
            // 
            this.IDForm_next_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IDForm_next_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IDForm_next_button.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_next_button.Location = new System.Drawing.Point(665, 412);
            this.IDForm_next_button.Name = "IDForm_next_button";
            this.IDForm_next_button.Size = new System.Drawing.Size(136, 60);
            this.IDForm_next_button.TabIndex = 11;
            this.IDForm_next_button.Text = "下一步";
            this.IDForm_next_button.UseVisualStyleBackColor = true;
            this.IDForm_next_button.Click += new System.EventHandler(this.IDForm_next_button_click);
            // 
            // IDForm_pictureBox
            // 
            this.IDForm_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IDForm_pictureBox.Location = new System.Drawing.Point(557, 80);
            this.IDForm_pictureBox.Name = "IDForm_pictureBox";
            this.IDForm_pictureBox.Size = new System.Drawing.Size(200, 246);
            this.IDForm_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IDForm_pictureBox.TabIndex = 10;
            this.IDForm_pictureBox.TabStop = false;
            // 
            // IDForm_ID_textBox
            // 
            this.IDForm_ID_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_ID_textBox.Enabled = false;
            this.IDForm_ID_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_ID_textBox.Location = new System.Drawing.Point(145, 353);
            this.IDForm_ID_textBox.Name = "IDForm_ID_textBox";
            this.IDForm_ID_textBox.Size = new System.Drawing.Size(261, 29);
            this.IDForm_ID_textBox.TabIndex = 9;
            // 
            // IDForm_ID_label
            // 
            this.IDForm_ID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_ID_label.AutoSize = true;
            this.IDForm_ID_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_ID_label.Location = new System.Drawing.Point(38, 353);
            this.IDForm_ID_label.Name = "IDForm_ID_label";
            this.IDForm_ID_label.Size = new System.Drawing.Size(89, 19);
            this.IDForm_ID_label.TabIndex = 8;
            this.IDForm_ID_label.Text = "身份证号";
            // 
            // IDForm_address_textBox
            // 
            this.IDForm_address_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_address_textBox.Enabled = false;
            this.IDForm_address_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_address_textBox.Location = new System.Drawing.Point(145, 231);
            this.IDForm_address_textBox.Multiline = true;
            this.IDForm_address_textBox.Name = "IDForm_address_textBox";
            this.IDForm_address_textBox.Size = new System.Drawing.Size(261, 95);
            this.IDForm_address_textBox.TabIndex = 7;
            // 
            // IDForm_address_label
            // 
            this.IDForm_address_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_address_label.AutoSize = true;
            this.IDForm_address_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_address_label.Location = new System.Drawing.Point(53, 234);
            this.IDForm_address_label.Name = "IDForm_address_label";
            this.IDForm_address_label.Size = new System.Drawing.Size(49, 19);
            this.IDForm_address_label.TabIndex = 6;
            this.IDForm_address_label.Text = "住址";
            // 
            // IDForm_nation_textBox
            // 
            this.IDForm_nation_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_nation_textBox.Enabled = false;
            this.IDForm_nation_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_nation_textBox.Location = new System.Drawing.Point(321, 99);
            this.IDForm_nation_textBox.Name = "IDForm_nation_textBox";
            this.IDForm_nation_textBox.Size = new System.Drawing.Size(85, 29);
            this.IDForm_nation_textBox.TabIndex = 5;
            // 
            // IDForm_nation_label
            // 
            this.IDForm_nation_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_nation_label.AutoSize = true;
            this.IDForm_nation_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_nation_label.Location = new System.Drawing.Point(252, 102);
            this.IDForm_nation_label.Name = "IDForm_nation_label";
            this.IDForm_nation_label.Size = new System.Drawing.Size(49, 19);
            this.IDForm_nation_label.TabIndex = 4;
            this.IDForm_nation_label.Text = "名族";
            // 
            // IDForm_sex_textBox
            // 
            this.IDForm_sex_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_sex_textBox.Enabled = false;
            this.IDForm_sex_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_sex_textBox.Location = new System.Drawing.Point(145, 99);
            this.IDForm_sex_textBox.Name = "IDForm_sex_textBox";
            this.IDForm_sex_textBox.Size = new System.Drawing.Size(79, 29);
            this.IDForm_sex_textBox.TabIndex = 3;
            // 
            // IDForm_sex_label
            // 
            this.IDForm_sex_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_sex_label.AutoSize = true;
            this.IDForm_sex_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_sex_label.Location = new System.Drawing.Point(53, 109);
            this.IDForm_sex_label.Name = "IDForm_sex_label";
            this.IDForm_sex_label.Size = new System.Drawing.Size(49, 19);
            this.IDForm_sex_label.TabIndex = 2;
            this.IDForm_sex_label.Text = "性别";
            // 
            // IDForm_name_textBox
            // 
            this.IDForm_name_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_name_textBox.Enabled = false;
            this.IDForm_name_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_name_textBox.Location = new System.Drawing.Point(145, 35);
            this.IDForm_name_textBox.Name = "IDForm_name_textBox";
            this.IDForm_name_textBox.Size = new System.Drawing.Size(261, 29);
            this.IDForm_name_textBox.TabIndex = 1;
            // 
            // IDForm_name_label
            // 
            this.IDForm_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDForm_name_label.AutoSize = true;
            this.IDForm_name_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_name_label.Location = new System.Drawing.Point(53, 38);
            this.IDForm_name_label.Name = "IDForm_name_label";
            this.IDForm_name_label.Size = new System.Drawing.Size(49, 19);
            this.IDForm_name_label.TabIndex = 0;
            this.IDForm_name_label.Text = "姓名";
            // 
            // IDForm_time_label
            // 
            this.IDForm_time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IDForm_time_label.AutoSize = true;
            this.IDForm_time_label.BackColor = System.Drawing.Color.Transparent;
            this.IDForm_time_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDForm_time_label.Location = new System.Drawing.Point(12, 542);
            this.IDForm_time_label.Name = "IDForm_time_label";
            this.IDForm_time_label.Size = new System.Drawing.Size(47, 19);
            this.IDForm_time_label.TabIndex = 2;
            this.IDForm_time_label.Text = "时间";
            // 
            // IDForm_timer
            // 
            this.IDForm_timer.Enabled = true;
            this.IDForm_timer.Interval = 1000;
            this.IDForm_timer.Tick += new System.EventHandler(this.IDForm_time_tick);
            // 
            // IDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 570);
            this.Controls.Add(this.IDForm_time_label);
            this.Controls.Add(this.IDForm_control_panel);
            this.Controls.Add(this.IDForm_background_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDForm";
            this.Text = "IDForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IDForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.IDForm_background_pictureBox)).EndInit();
            this.IDForm_control_panel.ResumeLayout(false);
            this.IDForm_control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDForm_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IDForm_background_pictureBox;
        private System.Windows.Forms.Panel IDForm_control_panel;
        private System.Windows.Forms.Label IDForm_time_label;
        private System.Windows.Forms.Timer IDForm_timer;
        private System.Windows.Forms.Label IDForm_name_label;
        private System.Windows.Forms.TextBox IDForm_name_textBox;
        private System.Windows.Forms.Label IDForm_sex_label;
        private System.Windows.Forms.TextBox IDForm_sex_textBox;
        private System.Windows.Forms.TextBox IDForm_nation_textBox;
        private System.Windows.Forms.Label IDForm_nation_label;
        private System.Windows.Forms.Label IDForm_address_label;
        private System.Windows.Forms.TextBox IDForm_address_textBox;
        private System.Windows.Forms.Label IDForm_ID_label;
        private System.Windows.Forms.TextBox IDForm_ID_textBox;
        private System.Windows.Forms.PictureBox IDForm_pictureBox;
        private System.Windows.Forms.Button IDForm_next_button;
        private System.Windows.Forms.Label IDForm_birth_label;
        private System.Windows.Forms.TextBox IDForm_birth_textBox;
        private System.Windows.Forms.Button IDForm_ok_button;
        private System.Windows.Forms.Label IDForm_organization_label;
        private System.Windows.Forms.TextBox IDForm_organization_textBox;
        private System.Windows.Forms.Label IDForm_times_label;
        private System.Windows.Forms.TextBox IDForm_time_textBox;
    }
}