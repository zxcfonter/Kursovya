
namespace Регистратура_поликлиники
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBd = new System.Windows.Forms.Button();
            this.sortBD = new System.Windows.Forms.Button();
            this.CloseBD = new System.Windows.Forms.Button();
            this.RedactBD = new System.Windows.Forms.Button();
            this.deleteBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // addBd
            // 
            this.addBd.Location = new System.Drawing.Point(32, 376);
            this.addBd.Name = "addBd";
            this.addBd.Size = new System.Drawing.Size(86, 23);
            this.addBd.TabIndex = 1;
            this.addBd.Text = "Добавить";
            this.addBd.UseVisualStyleBackColor = true;
            this.addBd.Click += new System.EventHandler(this.addBd_Click);
            // 
            // sortBD
            // 
            this.sortBD.Location = new System.Drawing.Point(227, 418);
            this.sortBD.Name = "sortBD";
            this.sortBD.Size = new System.Drawing.Size(86, 23);
            this.sortBD.TabIndex = 5;
            this.sortBD.Text = "Сортировка";
            this.sortBD.UseVisualStyleBackColor = true;
            this.sortBD.Click += new System.EventHandler(this.sortBD_Click);
            // 
            // CloseBD
            // 
            this.CloseBD.Location = new System.Drawing.Point(431, 376);
            this.CloseBD.Name = "CloseBD";
            this.CloseBD.Size = new System.Drawing.Size(86, 23);
            this.CloseBD.TabIndex = 6;
            this.CloseBD.Text = "Закрыть";
            this.CloseBD.UseVisualStyleBackColor = true;
            this.CloseBD.Click += new System.EventHandler(this.CloseBD_Click);
            // 
            // RedactBD
            // 
            this.RedactBD.Location = new System.Drawing.Point(303, 376);
            this.RedactBD.Name = "RedactBD";
            this.RedactBD.Size = new System.Drawing.Size(98, 23);
            this.RedactBD.TabIndex = 7;
            this.RedactBD.Text = "Редактировать";
            this.RedactBD.UseVisualStyleBackColor = true;
            this.RedactBD.Click += new System.EventHandler(this.RedactBD_Click);
            // 
            // deleteBD
            // 
            this.deleteBD.Location = new System.Drawing.Point(163, 376);
            this.deleteBD.Name = "deleteBD";
            this.deleteBD.Size = new System.Drawing.Size(98, 23);
            this.deleteBD.TabIndex = 8;
            this.deleteBD.Text = "Удалить";
            this.deleteBD.UseVisualStyleBackColor = true;
            this.deleteBD.Click += new System.EventHandler(this.deleteBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 453);
            this.Controls.Add(this.deleteBD);
            this.Controls.Add(this.RedactBD);
            this.Controls.Add(this.CloseBD);
            this.Controls.Add(this.sortBD);
            this.Controls.Add(this.addBd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Регистратура поликлиники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBd;
        private System.Windows.Forms.Button sortBD;
        private System.Windows.Forms.Button CloseBD;
        private System.Windows.Forms.Button RedactBD;
        private System.Windows.Forms.Button deleteBD;
    }
}

