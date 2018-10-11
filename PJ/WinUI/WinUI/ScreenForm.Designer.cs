namespace WinUI
{
    partial class ScreenForm
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
            this.screenForm_all_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.screenForm_name_panel = new System.Windows.Forms.Panel();
            this.screenForm_flag_button = new System.Windows.Forms.Button();
            this.screenForm_name_textBox = new System.Windows.Forms.TextBox();
            this.screenForm_name_label = new System.Windows.Forms.Label();
            this.screenForm_background_panel = new System.Windows.Forms.Panel();
            this.screenForm_background_button = new System.Windows.Forms.Button();
            this.screenForm_background_label = new System.Windows.Forms.Label();
            this.screenForm_background_textBox = new System.Windows.Forms.TextBox();
            this.screenForm_save_panel = new System.Windows.Forms.Panel();
            this.screenForm_save_button = new System.Windows.Forms.Button();
            this.screenForm_all_tableLayoutPanel.SuspendLayout();
            this.screenForm_name_panel.SuspendLayout();
            this.screenForm_background_panel.SuspendLayout();
            this.screenForm_save_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenForm_all_tableLayoutPanel
            // 
            this.screenForm_all_tableLayoutPanel.ColumnCount = 1;
            this.screenForm_all_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.screenForm_all_tableLayoutPanel.Controls.Add(this.screenForm_name_panel, 0, 0);
            this.screenForm_all_tableLayoutPanel.Controls.Add(this.screenForm_background_panel, 0, 1);
            this.screenForm_all_tableLayoutPanel.Controls.Add(this.screenForm_save_panel, 0, 2);
            this.screenForm_all_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenForm_all_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.screenForm_all_tableLayoutPanel.Name = "screenForm_all_tableLayoutPanel";
            this.screenForm_all_tableLayoutPanel.RowCount = 4;
            this.screenForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.screenForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.screenForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.screenForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.screenForm_all_tableLayoutPanel.Size = new System.Drawing.Size(508, 394);
            this.screenForm_all_tableLayoutPanel.TabIndex = 0;
            // 
            // screenForm_name_panel
            // 
            this.screenForm_name_panel.BackColor = System.Drawing.Color.Transparent;
            this.screenForm_name_panel.Controls.Add(this.screenForm_flag_button);
            this.screenForm_name_panel.Controls.Add(this.screenForm_name_textBox);
            this.screenForm_name_panel.Controls.Add(this.screenForm_name_label);
            this.screenForm_name_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenForm_name_panel.Location = new System.Drawing.Point(3, 3);
            this.screenForm_name_panel.Name = "screenForm_name_panel";
            this.screenForm_name_panel.Size = new System.Drawing.Size(502, 41);
            this.screenForm_name_panel.TabIndex = 0;
            // 
            // screenForm_flag_button
            // 
            this.screenForm_flag_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.screenForm_flag_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screenForm_flag_button.Location = new System.Drawing.Point(389, 1);
            this.screenForm_flag_button.Name = "screenForm_flag_button";
            this.screenForm_flag_button.Size = new System.Drawing.Size(86, 37);
            this.screenForm_flag_button.TabIndex = 2;
            this.screenForm_flag_button.UseVisualStyleBackColor = true;
            this.screenForm_flag_button.Visible = false;
            // 
            // screenForm_name_textBox
            // 
            this.screenForm_name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.screenForm_name_textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screenForm_name_textBox.Location = new System.Drawing.Point(83, 6);
            this.screenForm_name_textBox.Name = "screenForm_name_textBox";
            this.screenForm_name_textBox.Size = new System.Drawing.Size(300, 26);
            this.screenForm_name_textBox.TabIndex = 1;
            // 
            // screenForm_name_label
            // 
            this.screenForm_name_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.screenForm_name_label.AutoSize = true;
            this.screenForm_name_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screenForm_name_label.Location = new System.Drawing.Point(5, 9);
            this.screenForm_name_label.Name = "screenForm_name_label";
            this.screenForm_name_label.Size = new System.Drawing.Size(76, 16);
            this.screenForm_name_label.TabIndex = 0;
            this.screenForm_name_label.Text = "标题配置";
            // 
            // screenForm_background_panel
            // 
            this.screenForm_background_panel.BackColor = System.Drawing.Color.Transparent;
            this.screenForm_background_panel.Controls.Add(this.screenForm_background_button);
            this.screenForm_background_panel.Controls.Add(this.screenForm_background_label);
            this.screenForm_background_panel.Controls.Add(this.screenForm_background_textBox);
            this.screenForm_background_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenForm_background_panel.Location = new System.Drawing.Point(3, 50);
            this.screenForm_background_panel.Name = "screenForm_background_panel";
            this.screenForm_background_panel.Size = new System.Drawing.Size(502, 41);
            this.screenForm_background_panel.TabIndex = 3;
            // 
            // screenForm_background_button
            // 
            this.screenForm_background_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.screenForm_background_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screenForm_background_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screenForm_background_button.Location = new System.Drawing.Point(389, 2);
            this.screenForm_background_button.Name = "screenForm_background_button";
            this.screenForm_background_button.Size = new System.Drawing.Size(86, 37);
            this.screenForm_background_button.TabIndex = 3;
            this.screenForm_background_button.Text = "上传";
            this.screenForm_background_button.UseVisualStyleBackColor = true;
            this.screenForm_background_button.Click += new System.EventHandler(this.system_background_button_click);
            // 
            // screenForm_background_label
            // 
            this.screenForm_background_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.screenForm_background_label.AutoSize = true;
            this.screenForm_background_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screenForm_background_label.Location = new System.Drawing.Point(5, 16);
            this.screenForm_background_label.Name = "screenForm_background_label";
            this.screenForm_background_label.Size = new System.Drawing.Size(76, 16);
            this.screenForm_background_label.TabIndex = 1;
            this.screenForm_background_label.Text = "背景图片";
            // 
            // screenForm_background_textBox
            // 
            this.screenForm_background_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.screenForm_background_textBox.Enabled = false;
            this.screenForm_background_textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screenForm_background_textBox.Location = new System.Drawing.Point(83, 11);
            this.screenForm_background_textBox.Name = "screenForm_background_textBox";
            this.screenForm_background_textBox.Size = new System.Drawing.Size(300, 26);
            this.screenForm_background_textBox.TabIndex = 2;
            // 
            // screenForm_save_panel
            // 
            this.screenForm_save_panel.BackColor = System.Drawing.Color.Transparent;
            this.screenForm_save_panel.Controls.Add(this.screenForm_save_button);
            this.screenForm_save_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenForm_save_panel.Location = new System.Drawing.Point(3, 97);
            this.screenForm_save_panel.Name = "screenForm_save_panel";
            this.screenForm_save_panel.Size = new System.Drawing.Size(502, 41);
            this.screenForm_save_panel.TabIndex = 4;
            // 
            // screenForm_save_button
            // 
            this.screenForm_save_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.screenForm_save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screenForm_save_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screenForm_save_button.Location = new System.Drawing.Point(389, 3);
            this.screenForm_save_button.Name = "screenForm_save_button";
            this.screenForm_save_button.Size = new System.Drawing.Size(86, 40);
            this.screenForm_save_button.TabIndex = 0;
            this.screenForm_save_button.Text = "保存";
            this.screenForm_save_button.UseVisualStyleBackColor = true;
            this.screenForm_save_button.Click += new System.EventHandler(this.system_save_button_click);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 394);
            this.Controls.Add(this.screenForm_all_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenForm";
            this.Text = "综合屏配置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.screenForm_all_tableLayoutPanel.ResumeLayout(false);
            this.screenForm_name_panel.ResumeLayout(false);
            this.screenForm_name_panel.PerformLayout();
            this.screenForm_background_panel.ResumeLayout(false);
            this.screenForm_background_panel.PerformLayout();
            this.screenForm_save_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel screenForm_all_tableLayoutPanel;
        private System.Windows.Forms.Panel screenForm_name_panel;
        private System.Windows.Forms.Label screenForm_name_label;
        private System.Windows.Forms.Button screenForm_flag_button;
        private System.Windows.Forms.TextBox screenForm_name_textBox;
        private System.Windows.Forms.Label screenForm_background_label;
        private System.Windows.Forms.TextBox screenForm_background_textBox;
        private System.Windows.Forms.Panel screenForm_background_panel;
        private System.Windows.Forms.Button screenForm_background_button;
        private System.Windows.Forms.Panel screenForm_save_panel;
        private System.Windows.Forms.Button screenForm_save_button;
    }
}