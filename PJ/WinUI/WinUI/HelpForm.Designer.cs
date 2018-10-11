namespace WinUI
{
    partial class HelpForm
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
            this.helpForm_all_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.helpForm_panel_one = new System.Windows.Forms.Panel();
            this.helpForm_help_label = new System.Windows.Forms.Label();
            this.helpForm_panel_two = new System.Windows.Forms.Panel();
            this.helpForm_exit_button = new System.Windows.Forms.Button();
            this.helpForm_all_tableLayoutPanel.SuspendLayout();
            this.helpForm_panel_one.SuspendLayout();
            this.helpForm_panel_two.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpForm_all_tableLayoutPanel
            // 
            this.helpForm_all_tableLayoutPanel.ColumnCount = 3;
            this.helpForm_all_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.helpForm_all_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.helpForm_all_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.helpForm_all_tableLayoutPanel.Controls.Add(this.helpForm_panel_one, 0, 1);
            this.helpForm_all_tableLayoutPanel.Controls.Add(this.helpForm_panel_two, 1, 2);
            this.helpForm_all_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpForm_all_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.helpForm_all_tableLayoutPanel.Name = "helpForm_all_tableLayoutPanel";
            this.helpForm_all_tableLayoutPanel.RowCount = 4;
            this.helpForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.helpForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.helpForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.helpForm_all_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.helpForm_all_tableLayoutPanel.Size = new System.Drawing.Size(462, 355);
            this.helpForm_all_tableLayoutPanel.TabIndex = 0;
            // 
            // helpForm_panel_one
            // 
            this.helpForm_panel_one.BackColor = System.Drawing.Color.Transparent;
            this.helpForm_panel_one.Controls.Add(this.helpForm_help_label);
            this.helpForm_panel_one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpForm_panel_one.Location = new System.Drawing.Point(3, 38);
            this.helpForm_panel_one.Name = "helpForm_panel_one";
            this.helpForm_panel_one.Size = new System.Drawing.Size(271, 171);
            this.helpForm_panel_one.TabIndex = 0;
            // 
            // helpForm_help_label
            // 
            this.helpForm_help_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.helpForm_help_label.AutoSize = true;
            this.helpForm_help_label.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpForm_help_label.Location = new System.Drawing.Point(9, 62);
            this.helpForm_help_label.Name = "helpForm_help_label";
            this.helpForm_help_label.Size = new System.Drawing.Size(231, 35);
            this.helpForm_help_label.TabIndex = 0;
            this.helpForm_help_label.Text = "软件使用说明";
            // 
            // helpForm_panel_two
            // 
            this.helpForm_panel_two.BackColor = System.Drawing.Color.Transparent;
            this.helpForm_panel_two.Controls.Add(this.helpForm_exit_button);
            this.helpForm_panel_two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpForm_panel_two.Location = new System.Drawing.Point(280, 215);
            this.helpForm_panel_two.Name = "helpForm_panel_two";
            this.helpForm_panel_two.Size = new System.Drawing.Size(86, 29);
            this.helpForm_panel_two.TabIndex = 1;
            // 
            // helpForm_exit_button
            // 
            this.helpForm_exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpForm_exit_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpForm_exit_button.Location = new System.Drawing.Point(-1, 6);
            this.helpForm_exit_button.Name = "helpForm_exit_button";
            this.helpForm_exit_button.Size = new System.Drawing.Size(78, 36);
            this.helpForm_exit_button.TabIndex = 0;
            this.helpForm_exit_button.Text = "退出";
            this.helpForm_exit_button.UseVisualStyleBackColor = true;
            this.helpForm_exit_button.Click += new System.EventHandler(this.system_exit_button_click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 355);
            this.Controls.Add(this.helpForm_all_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.Text = "帮助界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.helpForm_all_tableLayoutPanel.ResumeLayout(false);
            this.helpForm_panel_one.ResumeLayout(false);
            this.helpForm_panel_one.PerformLayout();
            this.helpForm_panel_two.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel helpForm_all_tableLayoutPanel;
        private System.Windows.Forms.Panel helpForm_panel_one;
        private System.Windows.Forms.Panel helpForm_panel_two;
        private System.Windows.Forms.Button helpForm_exit_button;
        private System.Windows.Forms.Label helpForm_help_label;
    }
}