namespace WindowsFormsApp4
{
    partial class Money_trasfer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1_id = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(390, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Перевод средств";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(20, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ваш Баланс";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(20, 371);
			this.label3.MaximumSize = new System.Drawing.Size(300, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 70);
			this.label3.TabIndex = 2;
			this.label3.Text = "Введите количество рублей";
			// 
			// Button1
			// 
			this.Button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button1.Location = new System.Drawing.Point(390, 483);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(328, 60);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Продолжить";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(390, 354);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(328, 28);
			this.textBox2.TabIndex = 4;
			// 
			// textBox1_id
			// 
			this.textBox1_id.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1_id.Location = new System.Drawing.Point(390, 241);
			this.textBox1_id.Name = "textBox1_id";
			this.textBox1_id.Size = new System.Drawing.Size(328, 28);
			this.textBox1_id.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(20, 241);
			this.label4.MaximumSize = new System.Drawing.Size(300, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(284, 105);
			this.label4.TabIndex = 5;
			this.label4.Text = "Введите id пользователя или ваш id ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(20, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 35);
			this.label5.TabIndex = 7;
			this.label5.Text = "label5";
			// 
			// Button2
			// 
			this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Button2.BackColor = System.Drawing.Color.PaleGreen;
			this.Button2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button2.Location = new System.Drawing.Point(20, 20);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(159, 48);
			this.Button2.TabIndex = 17;
			this.Button2.Text = "<- Назад";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Money_trasfer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 653);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1_id);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Money_trasfer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Money_trasfer";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Money_trasfer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button2;
    }
}