namespace CompressPrj
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
            this.CodeDataBtn = new System.Windows.Forms.Button();
            this.InputTextField = new System.Windows.Forms.RichTextBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BinInputTextField = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DictionaryField = new System.Windows.Forms.RichTextBox();
            this.CodeByDictionaryField = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DecodeDataBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DecodeTextField = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CompressCoeffLabel = new System.Windows.Forms.Label();
            this.FreqBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeDataBtn
            // 
            this.CodeDataBtn.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeDataBtn.Location = new System.Drawing.Point(822, 6);
            this.CodeDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CodeDataBtn.Name = "CodeDataBtn";
            this.CodeDataBtn.Size = new System.Drawing.Size(263, 34);
            this.CodeDataBtn.TabIndex = 0;
            this.CodeDataBtn.Text = "Закодувати дані";
            this.CodeDataBtn.UseVisualStyleBackColor = true;
            this.CodeDataBtn.Click += new System.EventHandler(this.CodeDataBtn_Click);
            // 
            // InputTextField
            // 
            this.InputTextField.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextField.Location = new System.Drawing.Point(180, 46);
            this.InputTextField.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextField.Name = "InputTextField";
            this.InputTextField.Size = new System.Drawing.Size(520, 190);
            this.InputTextField.TabIndex = 1;
            this.InputTextField.Text = "";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadDataButton.Location = new System.Drawing.Point(419, 7);
            this.LoadDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(395, 34);
            this.LoadDataButton.TabIndex = 2;
            this.LoadDataButton.Text = "Завантажити файл з даними";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label1.Location = new System.Drawing.Point(181, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вхідний текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label2.Location = new System.Drawing.Point(710, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Двійкове представлення тексту:";
            // 
            // BinInputTextField
            // 
            this.BinInputTextField.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.BinInputTextField.Location = new System.Drawing.Point(715, 78);
            this.BinInputTextField.Margin = new System.Windows.Forms.Padding(4);
            this.BinInputTextField.Name = "BinInputTextField";
            this.BinInputTextField.Size = new System.Drawing.Size(440, 158);
            this.BinInputTextField.TabIndex = 4;
            this.BinInputTextField.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label3.Location = new System.Drawing.Point(182, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Словник з кодами:";
            // 
            // DictionaryField
            // 
            this.DictionaryField.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.DictionaryField.Location = new System.Drawing.Point(180, 278);
            this.DictionaryField.Margin = new System.Windows.Forms.Padding(4);
            this.DictionaryField.Name = "DictionaryField";
            this.DictionaryField.Size = new System.Drawing.Size(398, 136);
            this.DictionaryField.TabIndex = 7;
            this.DictionaryField.Text = "";
            // 
            // CodeByDictionaryField
            // 
            this.CodeByDictionaryField.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.CodeByDictionaryField.Location = new System.Drawing.Point(586, 278);
            this.CodeByDictionaryField.Margin = new System.Windows.Forms.Padding(4);
            this.CodeByDictionaryField.Name = "CodeByDictionaryField";
            this.CodeByDictionaryField.Size = new System.Drawing.Size(569, 136);
            this.CodeByDictionaryField.TabIndex = 9;
            this.CodeByDictionaryField.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label4.Location = new System.Drawing.Point(581, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Закодований текст (за словником з кодами):";
            // 
            // DecodeDataBtn
            // 
            this.DecodeDataBtn.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeDataBtn.Location = new System.Drawing.Point(508, 424);
            this.DecodeDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DecodeDataBtn.Name = "DecodeDataBtn";
            this.DecodeDataBtn.Size = new System.Drawing.Size(296, 36);
            this.DecodeDataBtn.TabIndex = 10;
            this.DecodeDataBtn.Text = "Розкодувати дані";
            this.DecodeDataBtn.UseVisualStyleBackColor = true;
            this.DecodeDataBtn.Click += new System.EventHandler(this.DecodeDataBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label5.Location = new System.Drawing.Point(187, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Декодований текст:";
            // 
            // DecodeTextField
            // 
            this.DecodeTextField.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.DecodeTextField.Location = new System.Drawing.Point(180, 468);
            this.DecodeTextField.Margin = new System.Windows.Forms.Padding(4);
            this.DecodeTextField.Name = "DecodeTextField";
            this.DecodeTextField.Size = new System.Drawing.Size(1085, 118);
            this.DecodeTextField.TabIndex = 11;
            this.DecodeTextField.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(843, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Стиснення:";
            // 
            // CompressCoeffLabel
            // 
            this.CompressCoeffLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CompressCoeffLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.CompressCoeffLabel.Location = new System.Drawing.Point(994, 434);
            this.CompressCoeffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompressCoeffLabel.Name = "CompressCoeffLabel";
            this.CompressCoeffLabel.Size = new System.Drawing.Size(113, 28);
            this.CompressCoeffLabel.TabIndex = 14;
            this.CompressCoeffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FreqBox
            // 
            this.FreqBox.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreqBox.Location = new System.Drawing.Point(13, 78);
            this.FreqBox.Margin = new System.Windows.Forms.Padding(4);
            this.FreqBox.Name = "FreqBox";
            this.FreqBox.Size = new System.Drawing.Size(159, 510);
            this.FreqBox.TabIndex = 15;
            this.FreqBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label7.Location = new System.Drawing.Point(-4, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label8.Location = new System.Drawing.Point(13, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Словник з";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "частотою";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label10.Location = new System.Drawing.Point(13, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "входження:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label11.Location = new System.Drawing.Point(979, 251);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 23);
            this.label11.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label12.Location = new System.Drawing.Point(1002, 52);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 23);
            this.label12.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label13.Location = new System.Drawing.Point(379, 434);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 23);
            this.label13.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label14.Location = new System.Drawing.Point(584, 293);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.label15.Location = new System.Drawing.Point(329, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 23);
            this.label15.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 608);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FreqBox);
            this.Controls.Add(this.CompressCoeffLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DecodeTextField);
            this.Controls.Add(this.DecodeDataBtn);
            this.Controls.Add(this.CodeByDictionaryField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DictionaryField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BinInputTextField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.InputTextField);
            this.Controls.Add(this.CodeDataBtn);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програмний засіб для стиснення текстових даних. © Петров Л.А. Група КП-12. 2021 р" +
    "ік.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CodeDataBtn;
        private System.Windows.Forms.RichTextBox InputTextField;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox BinInputTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DictionaryField;
        private System.Windows.Forms.RichTextBox CodeByDictionaryField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DecodeDataBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox DecodeTextField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CompressCoeffLabel;
        private System.Windows.Forms.RichTextBox FreqBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

