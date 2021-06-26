
namespace pong
{
    partial class LichSuNguoiChoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuNguoiChoi));
            this.label1 = new System.Windows.Forms.Label();
            this.quaylai = new System.Windows.Forms.Button();
            this.xoalichsu = new System.Windows.Forms.Button();
            this.lichsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Cooper BlkIt BT", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(227, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quaylai
            // 
            this.quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quaylai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.quaylai.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.quaylai.FlatAppearance.BorderSize = 0;
            this.quaylai.Font = new System.Drawing.Font("Cooper BlkIt BT", 15F);
            this.quaylai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quaylai.Location = new System.Drawing.Point(546, 12);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(124, 42);
            this.quaylai.TabIndex = 1;
            this.quaylai.Text = "Back";
            this.quaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.button1_Click);
            // 
            // xoalichsu
            // 
            this.xoalichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xoalichsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.xoalichsu.Font = new System.Drawing.Font("Cooper BlkIt BT", 15F);
            this.xoalichsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoalichsu.Location = new System.Drawing.Point(546, 361);
            this.xoalichsu.Name = "xoalichsu";
            this.xoalichsu.Size = new System.Drawing.Size(124, 42);
            this.xoalichsu.TabIndex = 3;
            this.xoalichsu.Text = "Delete";
            this.xoalichsu.UseVisualStyleBackColor = false;
            this.xoalichsu.Click += new System.EventHandler(this.xoalichsu_Click);
            // 
            // lichsu
            // 
            this.lichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lichsu.BackColor = System.Drawing.Color.Transparent;
            this.lichsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lichsu.Font = new System.Drawing.Font("Cooper BlkIt BT", 20F);
            this.lichsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lichsu.Location = new System.Drawing.Point(56, 93);
            this.lichsu.Name = "lichsu";
            this.lichsu.Size = new System.Drawing.Size(553, 277);
            this.lichsu.TabIndex = 4;
            this.lichsu.Text = "Time Point";
            this.lichsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lichsu.Click += new System.EventHandler(this.lichsu_Click_1);
            // 
            // LichSuNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 415);
            this.Controls.Add(this.xoalichsu);
            this.Controls.Add(this.lichsu);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "LichSuNguoiChoi";
            this.Text = "LichSuNguoiChoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Button xoalichsu;
        private System.Windows.Forms.Label lichsu;
    }
}