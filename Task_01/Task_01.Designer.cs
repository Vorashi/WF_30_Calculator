namespace Task_01
{
    partial class Task_01
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
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TbxInput
            // 
            this.TbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxInput.Location = new System.Drawing.Point(12, 13);
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(448, 22);
            this.TbxInput.TabIndex = 0;
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(12, 52);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(448, 189);
            this.Panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 254);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TbxInput);
            this.Name = "Form1";
            this.Text = "Калькулятор_WF30";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.Panel Panel;
    }
}

