namespace SModel
{
    partial class Form1
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
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.txt_mu = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.lbl_L = new System.Windows.Forms.Label();
            this.lbl_Lq = new System.Windows.Forms.Label();
            this.lbl_W = new System.Windows.Forms.Label();
            this.lbl_Wq = new System.Windows.Forms.Label();
            this.lblUnderline1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_model
            // 
            this.cmb_model.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Items.AddRange(new object[] {
            "M/M/1",
            "M/M/1/K",
            "M/M/C",
            "M/M/C/K"});
            this.cmb_model.Location = new System.Drawing.Point(153, 24);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(100, 25);
            this.cmb_model.TabIndex = 0;
            this.cmb_model.SelectionChangeCommitted += new System.EventHandler(this.cmb_model_SelectionChangeCommitted);
            this.cmb_model.TextChanged += new System.EventHandler(this.cmb_model_TextChanged);
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSim.FlatAppearance.BorderSize = 0;
            this.btnSim.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btnSim.ForeColor = System.Drawing.Color.White;
            this.btnSim.Location = new System.Drawing.Point(89, 295);
            this.btnSim.Margin = new System.Windows.Forms.Padding(0);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(105, 64);
            this.btnSim.TabIndex = 2;
            this.btnSim.Text = "Tính";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // txt_lambda
            // 
            this.txt_lambda.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lambda.Location = new System.Drawing.Point(94, 101);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(100, 25);
            this.txt_lambda.TabIndex = 3;
            // 
            // txt_mu
            // 
            this.txt_mu.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txt_mu.Location = new System.Drawing.Point(94, 153);
            this.txt_mu.Name = "txt_mu";
            this.txt_mu.Size = new System.Drawing.Size(100, 25);
            this.txt_mu.TabIndex = 4;
            // 
            // txt_c
            // 
            this.txt_c.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txt_c.Location = new System.Drawing.Point(94, 203);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 25);
            this.txt_c.TabIndex = 5;
            // 
            // txt_k
            // 
            this.txt_k.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txt_k.Location = new System.Drawing.Point(94, 253);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 25);
            this.txt_k.TabIndex = 6;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(520, 428);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(268, 10);
            this.txt_result.TabIndex = 7;
            // 
            // lbl_L
            // 
            this.lbl_L.AutoSize = true;
            this.lbl_L.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_L.Location = new System.Drawing.Point(296, 144);
            this.lbl_L.Name = "lbl_L";
            this.lbl_L.Size = new System.Drawing.Size(407, 28);
            this.lbl_L.TabIndex = 8;
            this.lbl_L.Text = "Số lượng khách trung bình trong hệ thống: L = ";
            // 
            // lbl_Lq
            // 
            this.lbl_Lq.AutoSize = true;
            this.lbl_Lq.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Lq.Location = new System.Drawing.Point(296, 212);
            this.lbl_Lq.Name = "lbl_Lq";
            this.lbl_Lq.Size = new System.Drawing.Size(421, 28);
            this.lbl_Lq.TabIndex = 9;
            this.lbl_Lq.Text = "Số lượng khách trung bình trong hàng chờ: Lq = ";
            // 
            // lbl_W
            // 
            this.lbl_W.AutoSize = true;
            this.lbl_W.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_W.Location = new System.Drawing.Point(296, 280);
            this.lbl_W.Name = "lbl_W";
            this.lbl_W.Size = new System.Drawing.Size(414, 28);
            this.lbl_W.TabIndex = 10;
            this.lbl_W.Text = "Thời gian khách trung bình trong hệ thống: W =";
            // 
            // lbl_Wq
            // 
            this.lbl_Wq.AutoSize = true;
            this.lbl_Wq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Wq.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Wq.Location = new System.Drawing.Point(296, 348);
            this.lbl_Wq.Name = "lbl_Wq";
            this.lbl_Wq.Size = new System.Drawing.Size(427, 28);
            this.lbl_Wq.TabIndex = 11;
            this.lbl_Wq.Text = "Thời gian khách trung bình trong hàng chờ: Wq =";
            // 
            // lblUnderline1
            // 
            this.lblUnderline1.AutoSize = true;
            this.lblUnderline1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblUnderline1.Location = new System.Drawing.Point(295, 94);
            this.lblUnderline1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnderline1.Name = "lblUnderline1";
            this.lblUnderline1.Size = new System.Drawing.Size(245, 32);
            this.lblUnderline1.TabIndex = 15;
            this.lblUnderline1.Text = "_______________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chọn mô hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dòng vào";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dòng ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "K:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnderline1);
            this.Controls.Add(this.lbl_Wq);
            this.Controls.Add(this.lbl_W);
            this.Controls.Add(this.lbl_Lq);
            this.Controls.Add(this.lbl_L);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_mu);
            this.Controls.Add(this.txt_lambda);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.cmb_model);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.TextBox txt_mu;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label lbl_L;
        private System.Windows.Forms.Label lbl_Lq;
        private System.Windows.Forms.Label lbl_W;
        private System.Windows.Forms.Label lbl_Wq;
        private System.Windows.Forms.Label lblUnderline1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

