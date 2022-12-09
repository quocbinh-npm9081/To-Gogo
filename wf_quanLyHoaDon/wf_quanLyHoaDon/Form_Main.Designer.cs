
namespace wf_quanLyHoaDon
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyHangHoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiDuLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyHangHoaToolStripMenuItem,
            this.quanLyHoaDonToolStripMenuItem,
            this.ghiDuLieuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyHangHoaToolStripMenuItem
            // 
            this.quanLyHangHoaToolStripMenuItem.Name = "quanLyHangHoaToolStripMenuItem";
            this.quanLyHangHoaToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.quanLyHangHoaToolStripMenuItem.Text = "Quan ly hang hoa";
            // 
            // quanLyHoaDonToolStripMenuItem
            // 
            this.quanLyHoaDonToolStripMenuItem.Name = "quanLyHoaDonToolStripMenuItem";
            this.quanLyHoaDonToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.quanLyHoaDonToolStripMenuItem.Text = "Quan ly hoa don";
            // 
            // ghiDuLieuToolStripMenuItem
            // 
            this.ghiDuLieuToolStripMenuItem.Name = "ghiDuLieuToolStripMenuItem";
            this.ghiDuLieuToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.ghiDuLieuToolStripMenuItem.Text = "Ghi du lieu";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 555);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyHangHoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiDuLieuToolStripMenuItem;
    }
}