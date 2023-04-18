namespace Email
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
            this.SendEmail = new System.Windows.Forms.Button();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelTextOfLetter = new System.Windows.Forms.Label();
            this.checkBoxHtml = new System.Windows.Forms.CheckBox();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxTextOfLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendEmail
            // 
            this.SendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendEmail.Location = new System.Drawing.Point(587, 750);
            this.SendEmail.Margin = new System.Windows.Forms.Padding(6);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(281, 79);
            this.SendEmail.TabIndex = 0;
            this.SendEmail.Text = "Отправить";
            this.SendEmail.UseVisualStyleBackColor = true;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // labelSender
            // 
            this.labelSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSender.Location = new System.Drawing.Point(13, 13);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(197, 67);
            this.labelSender.TabIndex = 1;
            this.labelSender.Text = "От кого";
            // 
            // labelRecipient
            // 
            this.labelRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecipient.Location = new System.Drawing.Point(13, 94);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(197, 67);
            this.labelRecipient.TabIndex = 2;
            this.labelRecipient.Text = "Кому";
            // 
            // labelSubject
            // 
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(13, 161);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(197, 67);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Тема";
            // 
            // labelTextOfLetter
            // 
            this.labelTextOfLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextOfLetter.Location = new System.Drawing.Point(13, 228);
            this.labelTextOfLetter.Name = "labelTextOfLetter";
            this.labelTextOfLetter.Size = new System.Drawing.Size(855, 67);
            this.labelTextOfLetter.TabIndex = 4;
            this.labelTextOfLetter.Text = "Текст пмсма";
            this.labelTextOfLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxHtml
            // 
            this.checkBoxHtml.AutoSize = true;
            this.checkBoxHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHtml.Location = new System.Drawing.Point(22, 763);
            this.checkBoxHtml.Name = "checkBoxHtml";
            this.checkBoxHtml.Size = new System.Drawing.Size(507, 55);
            this.checkBoxHtml.TabIndex = 5;
            this.checkBoxHtml.Text = "представляет html код";
            this.checkBoxHtml.UseVisualStyleBackColor = true;
            // 
            // textBoxSender
            // 
            this.textBoxSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSender.Location = new System.Drawing.Point(225, 13);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(643, 56);
            this.textBoxSender.TabIndex = 6;
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRecipient.Location = new System.Drawing.Point(225, 91);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(643, 56);
            this.textBoxRecipient.TabIndex = 7;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSubject.Location = new System.Drawing.Point(225, 172);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(643, 56);
            this.textBoxSubject.TabIndex = 8;
            // 
            // textBoxTextOfLetter
            // 
            this.textBoxTextOfLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTextOfLetter.Location = new System.Drawing.Point(22, 298);
            this.textBoxTextOfLetter.Multiline = true;
            this.textBoxTextOfLetter.Name = "textBoxTextOfLetter";
            this.textBoxTextOfLetter.Size = new System.Drawing.Size(846, 431);
            this.textBoxTextOfLetter.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 858);
            this.Controls.Add(this.textBoxTextOfLetter);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxRecipient);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.checkBoxHtml);
            this.Controls.Add(this.labelTextOfLetter);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelRecipient);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.SendEmail);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Отправка писем";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendEmail;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelTextOfLetter;
        private System.Windows.Forms.CheckBox checkBoxHtml;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxTextOfLetter;
    }
}

