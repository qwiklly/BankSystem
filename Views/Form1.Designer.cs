namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.fgdgdfg = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1_id = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Button2
			// 
			this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Button2.AutoSize = true;
			this.Button2.BackColor = System.Drawing.Color.White;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Button2.Location = new System.Drawing.Point(615, 833);
			this.Button2.Margin = new System.Windows.Forms.Padding(0);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(574, 99);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "войти  в банк";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(816, 671);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 23);
			this.label2.TabIndex = 9;
			// 
			// fgdgdfg
			// 
			this.fgdgdfg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fgdgdfg.AutoSize = true;
			this.fgdgdfg.BackColor = System.Drawing.Color.LightGray;
			this.fgdgdfg.Font = new System.Drawing.Font("Calibri", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fgdgdfg.ForeColor = System.Drawing.Color.White;
			this.fgdgdfg.Location = new System.Drawing.Point(447, 34);
			this.fgdgdfg.Name = "fgdgdfg";
			this.fgdgdfg.Size = new System.Drawing.Size(1037, 183);
			this.fgdgdfg.TabIndex = 11;
			this.fgdgdfg.Text = "Банк \"Выгода\"";
			this.fgdgdfg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(615, 576);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(569, 58);
			this.label1.TabIndex = 15;
			this.label1.Text = "Введите ваш id - от 0 до 9 :\r\n";
			// 
			// textBox1_id
			// 
			this.textBox1_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1_id.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1_id.Location = new System.Drawing.Point(615, 671);
			this.textBox1_id.Name = "textBox1_id";
			this.textBox1_id.Size = new System.Drawing.Size(574, 53);
			this.textBox1_id.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(615, 433);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(745, 97);
			this.label3.TabIndex = 13;
			this.label3.Text = "Номер вашего счета";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
			this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1920, 1082);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1902, 1033);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1_id);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fgdgdfg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label fgdgdfg;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1_id;
		private System.Windows.Forms.Label label3;
	}
}

