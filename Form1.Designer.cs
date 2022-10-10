namespace WebhookSenderForOBS
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
            this.createLuaFile = new System.Windows.Forms.Button();
            this.openSettings = new System.Windows.Forms.Button();
            this.testWebhook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createLuaFile
            // 
            this.createLuaFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.createLuaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createLuaFile.Location = new System.Drawing.Point(0, 0);
            this.createLuaFile.Name = "createLuaFile";
            this.createLuaFile.Size = new System.Drawing.Size(784, 41);
            this.createLuaFile.TabIndex = 0;
            this.createLuaFile.Text = "Создать lua скрипт";
            this.createLuaFile.UseVisualStyleBackColor = true;
            // 
            // openSettings
            // 
            this.openSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.openSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openSettings.Location = new System.Drawing.Point(0, 41);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(784, 40);
            this.openSettings.TabIndex = 1;
            this.openSettings.Text = "Настройка оповещения";
            this.openSettings.UseVisualStyleBackColor = true;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // testWebhook
            // 
            this.testWebhook.Dock = System.Windows.Forms.DockStyle.Top;
            this.testWebhook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testWebhook.Location = new System.Drawing.Point(0, 81);
            this.testWebhook.Name = "testWebhook";
            this.testWebhook.Size = new System.Drawing.Size(784, 41);
            this.testWebhook.TabIndex = 2;
            this.testWebhook.Text = "Отправить тестовое оповещение";
            this.testWebhook.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 121);
            this.Controls.Add(this.testWebhook);
            this.Controls.Add(this.openSettings);
            this.Controls.Add(this.createLuaFile);
            this.MaximumSize = new System.Drawing.Size(800, 160);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createLuaFile;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Button testWebhook;
    }
}

