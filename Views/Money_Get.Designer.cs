namespace WindowsFormsApp4
{
    partial class Money_Get
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
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Continue = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(20, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 35);
			this.label5.TabIndex = 15;
			this.label5.Text = "label5";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(390, 281);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(328, 28);
			this.textBox2.TabIndex = 12;
			// 
			// Continue
			// 
			this.Continue.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Continue.Location = new System.Drawing.Point(390, 405);
			this.Continue.Name = "Continue";
			this.Continue.Size = new System.Drawing.Size(328, 60);
			this.Continue.TabIndex = 11;
			this.Continue.Text = "Продолжить";
			this.Continue.UseVisualStyleBackColor = true;
			this.Continue.Click += new System.EventHandler(this.Continue_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(20, 281);
			this.label3.MaximumSize = new System.Drawing.Size(300, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 70);
			this.label3.TabIndex = 10;
			this.label3.Text = "Введите количество рублей";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(20, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 37);
			this.label2.TabIndex = 9;
			this.label2.Text = "Ваш Баланс";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(390, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(364, 53);
			this.label1.TabIndex = 8;
			this.label1.Text = "Пополнение счета";
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.PaleGreen;
			this.Button2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button2.Location = new System.Drawing.Point(20, 20);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(159, 48);
			this.Button2.TabIndex = 16;
			this.Button2.Text = "<- Назад";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Money_Get
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 653);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Continue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Money_Get";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Withdrawal";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Money_Get_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button2;
    }
}