namespace Lab04
{
    partial class Form1
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
            label1 = new Label();
            txtN = new TextBox();
            txtTong = new TextBox();
            label2 = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập n:";
            // 
            // txtN
            // 
            txtN.Location = new Point(68, 0);
            txtN.Name = "txtN";
            txtN.Size = new Size(391, 27);
            txtN.TabIndex = 1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(67, 42);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(392, 27);
            txtTong.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 45);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Tổng:";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(94, 109);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(303, 109);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 172);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(label2);
            Controls.Add(txtTong);
            Controls.Add(txtN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BaiTap01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtN;
        private TextBox txtTong;
        private Label label2;
        private Button btnTinh;
        private Button btnThoat;
    }
}
