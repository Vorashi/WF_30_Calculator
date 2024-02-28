namespace Task_03
{
    partial class Task_03
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.CbxX = new System.Windows.Forms.ComboBox();
            this.TbxA = new System.Windows.Forms.TextBox();
            this.TbxB = new System.Windows.Forms.TextBox();
            this.BthClear = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblAinput = new System.Windows.Forms.Label();
            this.LblBinput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(36, 386);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(195, 25);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Закрыть ";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalc.Location = new System.Drawing.Point(36, 185);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(195, 27);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Посчитать";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // CbxX
            // 
            this.CbxX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbxX.FormattingEnabled = true;
            this.CbxX.Location = new System.Drawing.Point(36, 33);
            this.CbxX.Name = "CbxX";
            this.CbxX.Size = new System.Drawing.Size(195, 24);
            this.CbxX.TabIndex = 2;
            // 
            // TbxA
            // 
            this.TbxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxA.Location = new System.Drawing.Point(36, 93);
            this.TbxA.Name = "TbxA";
            this.TbxA.Size = new System.Drawing.Size(195, 22);
            this.TbxA.TabIndex = 3;
            // 
            // TbxB
            // 
            this.TbxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxB.Location = new System.Drawing.Point(36, 148);
            this.TbxB.Name = "TbxB";
            this.TbxB.Size = new System.Drawing.Size(195, 22);
            this.TbxB.TabIndex = 4;
            // 
            // BthClear
            // 
            this.BthClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BthClear.Location = new System.Drawing.Point(36, 218);
            this.BthClear.Name = "BthClear";
            this.BthClear.Size = new System.Drawing.Size(195, 25);
            this.BthClear.TabIndex = 5;
            this.BthClear.Text = "Очистить";
            this.BthClear.UseVisualStyleBackColor = true;
            this.BthClear.Click += new System.EventHandler(this.BthClear_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(12, 264);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(90, 16);
            this.LblResult.TabIndex = 9;
            this.LblResult.Text = "Результат = ";
            // 
            // LblAinput
            // 
            this.LblAinput.AutoSize = true;
            this.LblAinput.Location = new System.Drawing.Point(33, 74);
            this.LblAinput.Name = "LblAinput";
            this.LblAinput.Size = new System.Drawing.Size(52, 16);
            this.LblAinput.TabIndex = 10;
            this.LblAinput.Text = "Ввод А";
            // 
            // LblBinput
            // 
            this.LblBinput.AutoSize = true;
            this.LblBinput.Location = new System.Drawing.Point(33, 129);
            this.LblBinput.Name = "LblBinput";
            this.LblBinput.Size = new System.Drawing.Size(52, 16);
            this.LblBinput.TabIndex = 11;
            this.LblBinput.Text = "Ввод В";
            // 
            // Task_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.LblBinput);
            this.Controls.Add(this.LblAinput);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BthClear);
            this.Controls.Add(this.TbxB);
            this.Controls.Add(this.TbxA);
            this.Controls.Add(this.CbxX);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnClose);
            this.Name = "Task_03";
            this.Text = "Математика_WF_30";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.ComboBox CbxX;
        private System.Windows.Forms.TextBox TbxA;
        private System.Windows.Forms.TextBox TbxB;
        private System.Windows.Forms.Button BthClear;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblAinput;
        private System.Windows.Forms.Label LblBinput;
    }
}

