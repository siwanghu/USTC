namespace WinUI
{
    partial class TicketForm
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
            this.TicketForm_webBrowser = new WebKit.WebKitBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketForm_webBrowser
            // 
            this.TicketForm_webBrowser.BackColor = System.Drawing.Color.White;
            this.TicketForm_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketForm_webBrowser.Location = new System.Drawing.Point(3, 3);
            this.TicketForm_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TicketForm_webBrowser.Name = "TicketForm_webBrowser";
            this.TicketForm_webBrowser.Size = new System.Drawing.Size(778, 508);
            this.TicketForm_webBrowser.TabIndex = 0;
            this.TicketForm_webBrowser.Url = null;
            this.TicketForm_webBrowser.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_test);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TicketForm_webBrowser, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 514);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicketForm_load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WebKit.WebKitBrowser TicketForm_webBrowser;
        //private System.Windows.Forms.WebBrowser TicketForm_webBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}