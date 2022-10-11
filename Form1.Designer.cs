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
            this.openStartSettings = new System.Windows.Forms.Button();
            this.testStartWebhook = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openStopSettings = new System.Windows.Forms.Button();
            this.testStopWebhook = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createLuaFile
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.createLuaFile, 2);
            this.createLuaFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createLuaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createLuaFile.Location = new System.Drawing.Point(3, 3);
            this.createLuaFile.Name = "createLuaFile";
            this.createLuaFile.Size = new System.Drawing.Size(676, 165);
            this.createLuaFile.TabIndex = 0;
            this.createLuaFile.Text = "Создать lua скрипт";
            this.createLuaFile.UseVisualStyleBackColor = true;
            this.createLuaFile.Click += new System.EventHandler(this.createLuaFile_Click);
            // 
            // openStartSettings
            // 
            this.openStartSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openStartSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openStartSettings.Location = new System.Drawing.Point(3, 174);
            this.openStartSettings.Name = "openStartSettings";
            this.openStartSettings.Size = new System.Drawing.Size(335, 165);
            this.openStartSettings.TabIndex = 1;
            this.openStartSettings.Text = "Настройка оповещения\r\nО начале стрима\r\n";
            this.openStartSettings.UseVisualStyleBackColor = true;
            this.openStartSettings.Click += new System.EventHandler(this.openStartSettings_Click);
            // 
            // testStartWebhook
            // 
            this.testStartWebhook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testStartWebhook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testStartWebhook.Location = new System.Drawing.Point(3, 345);
            this.testStartWebhook.Name = "testStartWebhook";
            this.testStartWebhook.Size = new System.Drawing.Size(335, 80);
            this.testStartWebhook.TabIndex = 2;
            this.testStartWebhook.Text = "Отправить тестовое оповещение";
            this.testStartWebhook.UseVisualStyleBackColor = true;
            this.testStartWebhook.Click += new System.EventHandler(this.testWebhook_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.createLuaFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.testStartWebhook, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.openStartSettings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.openStopSettings, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.testStopWebhook, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 428);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // openStopSettings
            // 
            this.openStopSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openStopSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openStopSettings.Location = new System.Drawing.Point(344, 174);
            this.openStopSettings.Name = "openStopSettings";
            this.openStopSettings.Size = new System.Drawing.Size(335, 165);
            this.openStopSettings.TabIndex = 3;
            this.openStopSettings.Text = "Настройка оповещения\r\nО конце стрима";
            this.openStopSettings.UseVisualStyleBackColor = true;
            this.openStopSettings.Click += new System.EventHandler(this.openStopSettings_Click);
            // 
            // testStopWebhook
            // 
            this.testStopWebhook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testStopWebhook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testStopWebhook.Location = new System.Drawing.Point(344, 345);
            this.testStopWebhook.Name = "testStopWebhook";
            this.testStopWebhook.Size = new System.Drawing.Size(335, 80);
            this.testStopWebhook.TabIndex = 4;
            this.testStopWebhook.Text = "Отправить тестовое оповещение\r\nО конце стрима";
            this.testStopWebhook.UseVisualStyleBackColor = true;
            this.testStopWebhook.Click += new System.EventHandler(this.testStopWebhook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(260, 250);
            this.Name = "Form1";
            this.Text = "Оповещение для дискорда";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createLuaFile;
        private System.Windows.Forms.Button openStartSettings;
        private System.Windows.Forms.Button testStartWebhook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button openStopSettings;
        private System.Windows.Forms.Button testStopWebhook;
    }
}

