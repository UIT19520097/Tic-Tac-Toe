
namespace pong
{
    partial class Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank));
            this.lichsu = new System.Windows.Forms.Label();
            this.quaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lichsu
            // 
            this.lichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lichsu.BackColor = System.Drawing.Color.Transparent;
            this.lichsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lichsu.Font = new System.Drawing.Font("Footlight MT Light", 20F);
            this.lichsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lichsu.Location = new System.Drawing.Point(38, 139);
            this.lichsu.Name = "lichsu";
            this.lichsu.Size = new System.Drawing.Size(651, 310);
            this.lichsu.TabIndex = 7;
            this.lichsu.Text = "Top";
            this.lichsu.Click += new System.EventHandler(this.lichsu_Click);
            // 
            // quaylai
            // 
            this.quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quaylai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.quaylai.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.quaylai.FlatAppearance.BorderSize = 0;
            this.quaylai.Font = new System.Drawing.Font("Dutch801 XBd BT", 17F);
            this.quaylai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quaylai.Location = new System.Drawing.Point(593, 12);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(124, 42);
            this.quaylai.TabIndex = 6;
            this.quaylai.Text = "Back";
            this.quaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Dutch801 XBd BT", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(284, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "RANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dutch801 XBd BT", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top       Username     Score     Win    Lost    Draw ";
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lichsu);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.label1);
            this.Name = "Rank";
            this.Text = "Rank";
            this.Load += new System.EventHandler(this.Rank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lichsu;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}