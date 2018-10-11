namespace WinUI
{
    partial class MainForm
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
            this.MainForm_background_pictureBox = new System.Windows.Forms.PictureBox();
            this.MainForm_button_panel = new System.Windows.Forms.Panel();
            this.MainForm_Ticket_button = new System.Windows.Forms.Button();
            this.MainForm_Queue_button = new System.Windows.Forms.Button();
            this.MainForm_time_label = new System.Windows.Forms.Label();
            this.MainForm_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainForm_background_pictureBox)).BeginInit();
            this.MainForm_button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm_background_pictureBox
            // 
            this.MainForm_background_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainForm_background_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_background_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainForm_background_pictureBox.Name = "MainForm_background_pictureBox";
            this.MainForm_background_pictureBox.Size = new System.Drawing.Size(837, 522);
            this.MainForm_background_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainForm_background_pictureBox.TabIndex = 0;
            this.MainForm_background_pictureBox.TabStop = false;
            // 
            // MainForm_button_panel
            // 
            this.MainForm_button_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainForm_button_panel.BackColor = System.Drawing.Color.Transparent;
            this.MainForm_button_panel.Controls.Add(this.MainForm_Ticket_button);
            this.MainForm_button_panel.Controls.Add(this.MainForm_Queue_button);
            this.MainForm_button_panel.Location = new System.Drawing.Point(60, 48);
            this.MainForm_button_panel.Name = "MainForm_button_panel";
            this.MainForm_button_panel.Size = new System.Drawing.Size(699, 429);
            this.MainForm_button_panel.TabIndex = 1;
            // 
            // MainForm_Ticket_button
            // 
            this.MainForm_Ticket_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainForm_Ticket_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainForm_Ticket_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainForm_Ticket_button.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainForm_Ticket_button.Location = new System.Drawing.Point(99, 244);
            this.MainForm_Ticket_button.Name = "MainForm_Ticket_button";
            this.MainForm_Ticket_button.Size = new System.Drawing.Size(495, 153);
            this.MainForm_Ticket_button.TabIndex = 1;
            this.MainForm_Ticket_button.Text = "自助填单";
            this.MainForm_Ticket_button.UseVisualStyleBackColor = true;
            this.MainForm_Ticket_button.Click += new System.EventHandler(this.MainForm_Ticket_button_click);
            // 
            // MainForm_Queue_button
            // 
            this.MainForm_Queue_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainForm_Queue_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainForm_Queue_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainForm_Queue_button.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainForm_Queue_button.Location = new System.Drawing.Point(99, 31);
            this.MainForm_Queue_button.Name = "MainForm_Queue_button";
            this.MainForm_Queue_button.Size = new System.Drawing.Size(495, 156);
            this.MainForm_Queue_button.TabIndex = 0;
            this.MainForm_Queue_button.Text = "预约排队";
            this.MainForm_Queue_button.UseVisualStyleBackColor = true;
            this.MainForm_Queue_button.Click += new System.EventHandler(this.MainForm_Queue_button_click);
            // 
            // MainForm_time_label
            // 
            this.MainForm_time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainForm_time_label.AutoSize = true;
            this.MainForm_time_label.BackColor = System.Drawing.Color.Transparent;
            this.MainForm_time_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainForm_time_label.Location = new System.Drawing.Point(12, 488);
            this.MainForm_time_label.Name = "MainForm_time_label";
            this.MainForm_time_label.Size = new System.Drawing.Size(47, 19);
            this.MainForm_time_label.TabIndex = 2;
            this.MainForm_time_label.Text = "时间";
            // 
            // MainForm_timer
            // 
            this.MainForm_timer.Enabled = true;
            this.MainForm_timer.Interval = 1000;
            this.MainForm_timer.Tick += new System.EventHandler(this.MainForm_time_tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 522);
            this.Controls.Add(this.MainForm_time_label);
            this.Controls.Add(this.MainForm_button_panel);
            this.Controls.Add(this.MainForm_background_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.MainForm_background_pictureBox)).EndInit();
            this.MainForm_button_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainForm_background_pictureBox;
        private System.Windows.Forms.Panel MainForm_button_panel;
        private System.Windows.Forms.Button MainForm_Ticket_button;
        private System.Windows.Forms.Button MainForm_Queue_button;
        private System.Windows.Forms.Label MainForm_time_label;
        private System.Windows.Forms.Timer MainForm_timer;
    }
}