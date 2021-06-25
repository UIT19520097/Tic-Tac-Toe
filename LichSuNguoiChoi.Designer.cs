
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
            this.label1.Font = new System.Drawing.Font("UVN Saigon", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(283, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quaylai
            // 
            this.quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quaylai.BackColor = System.Drawing.Color.Teal;
            this.quaylai.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.quaylai.FlatAppearance.BorderSize = 0;
            this.quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.quaylai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quaylai.Image = global::pong.Properties.Resources.arrow_96_32;
            this.quaylai.Location = new System.Drawing.Point(615, 61);
            this.quaylai.Margin = new System.Windows.Forms.Padding(4);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(143, 35);
            this.quaylai.TabIndex = 1;
            this.quaylai.Text = "Quay Lại";
            this.quaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.button1_Click);
            // 
            // xoalichsu
            // 
            this.xoalichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xoalichsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.xoalichsu.Location = new System.Drawing.Point(615, 13);
            this.xoalichsu.Margin = new System.Windows.Forms.Padding(4);
            this.xoalichsu.Name = "xoalichsu";
            this.xoalichsu.Size = new System.Drawing.Size(143, 40);
            this.xoalichsu.TabIndex = 3;
            this.xoalichsu.Text = "Xóa lịch sử";
            this.xoalichsu.UseVisualStyleBackColor = true;
            this.xoalichsu.Click += new System.EventHandler(this.xoalichsu_Click);
            // 
            // lichsu
            // 
            this.lichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lichsu.BackColor = System.Drawing.Color.Transparent;
            this.lichsu.Font = new System.Drawing.Font("UVN Gio May", 13F, System.Drawing.FontStyle.Bold);
            this.lichsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lichsu.Location = new System.Drawing.Point(80, 100);
            this.lichsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lichsu.Name = "lichsu";
            this.lichsu.Size = new System.Drawing.Size(629, 260);
            this.lichsu.TabIndex = 4;
            this.lichsu.Text = "Time Point";
            this.lichsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lichsu.Click += new System.EventHandler(this.lichsu_Click_1);
            // 
            // LichSuNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 430);
            this.Controls.Add(this.lichsu);
            this.Controls.Add(this.xoalichsu);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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