namespace _1310
{
    partial class frmNhapLieu
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
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(466, 110);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnKhoiTao.TabIndex = 0;
            this.btnKhoiTao.Text = "button1";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // txtSoDong
            // 
            this.txtSoDong.Location = new System.Drawing.Point(246, 94);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(100, 20);
            this.txtSoDong.TabIndex = 1;
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(260, 139);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(100, 20);
            this.txtSoCot.TabIndex = 2;
            // 
            // frmNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.btnKhoiTao);
            this.Name = "frmNhapLieu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox txtSoCot;
    }
}

