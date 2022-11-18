namespace Youtube_Downloader
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmMenu1 = new Youtube_Downloader.Controllers.FrmMenu();
            this.LblLink = new System.Windows.Forms.Label();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAuthorTxt = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.LblDurationOut = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.LblVideoTitle = new System.Windows.Forms.Label();
            this.CbxFormats = new System.Windows.Forms.ComboBox();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmMenu1
            // 
            this.frmMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.frmMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmMenu1.Location = new System.Drawing.Point(0, 0);
            this.frmMenu1.Name = "frmMenu1";
            this.frmMenu1.Size = new System.Drawing.Size(417, 40);
            this.frmMenu1.TabIndex = 0;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLink.Location = new System.Drawing.Point(77, 66);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(33, 17);
            this.LblLink.TabIndex = 1;
            this.LblLink.Text = "Link:";
            // 
            // TxtLink
            // 
            this.TxtLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLink.Location = new System.Drawing.Point(115, 63);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(225, 25);
            this.TxtLink.TabIndex = 2;
            this.TxtLink.TextChanged += new System.EventHandler(this.TxtLink_TextChanged);
            this.TxtLink.Leave += new System.EventHandler(this.TxtLink_Leave);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(3, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Titulo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDownload);
            this.panel1.Controls.Add(this.CbxFormats);
            this.panel1.Controls.Add(this.LblAuthorTxt);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.LblDurationOut);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.LblVideoTitle);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 194);
            this.panel1.TabIndex = 4;
            // 
            // LblAuthorTxt
            // 
            this.LblAuthorTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAuthorTxt.Location = new System.Drawing.Point(65, 43);
            this.LblAuthorTxt.Name = "LblAuthorTxt";
            this.LblAuthorTxt.Size = new System.Drawing.Size(325, 17);
            this.LblAuthorTxt.TabIndex = 8;
            this.LblAuthorTxt.Text = "||||";
            this.LblAuthorTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(4, 44);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 20);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Author:";
            // 
            // LblDurationOut
            // 
            this.LblDurationOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDurationOut.Location = new System.Drawing.Point(65, 72);
            this.LblDurationOut.Name = "LblDurationOut";
            this.LblDurationOut.Size = new System.Drawing.Size(325, 17);
            this.LblDurationOut.TabIndex = 6;
            this.LblDurationOut.Text = "||||";
            this.LblDurationOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(3, 72);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(68, 20);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Duração:";
            // 
            // LblVideoTitle
            // 
            this.LblVideoTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVideoTitle.Location = new System.Drawing.Point(65, 17);
            this.LblVideoTitle.Name = "LblVideoTitle";
            this.LblVideoTitle.Size = new System.Drawing.Size(325, 17);
            this.LblVideoTitle.TabIndex = 4;
            this.LblVideoTitle.Text = "||||";
            this.LblVideoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxFormats
            // 
            this.CbxFormats.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxFormats.FormattingEnabled = true;
            this.CbxFormats.Items.AddRange(new object[] {
            "MP4",
            "MP3"});
            this.CbxFormats.Location = new System.Drawing.Point(4, 111);
            this.CbxFormats.Name = "CbxFormats";
            this.CbxFormats.Size = new System.Drawing.Size(121, 28);
            this.CbxFormats.TabIndex = 9;
            this.CbxFormats.Text = "Select Format";
            // 
            // BtnDownload
            // 
            this.BtnDownload.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDownload.Location = new System.Drawing.Point(131, 111);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(259, 28);
            this.BtnDownload.TabIndex = 10;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtLink);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.frmMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controllers.FrmMenu frmMenu1;
        private Label LblLink;
        private TextBox TxtLink;
        private Label lbl1;
        private Panel panel1;
        private Label LblVideoTitle;
        private Label LblDurationOut;
        private Label lbl3;
        private Label LblAuthorTxt;
        private Label lbl2;
        private ComboBox CbxFormats;
        private Button BtnDownload;
    }
}