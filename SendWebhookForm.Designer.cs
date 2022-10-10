namespace WebhookSenderForOBS
{
    partial class SendWebhookForm
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
            this.sendTestWH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для отправки оповещения, скопируйте вебхук и нажмите кнопку ниже\r\nПомните, тест о" +
    "повещения лучше проводить в закрытом канале,\r\nЧтобы не вводить в заблуждение ваш" +
    "их зрителей\r\n\r\n";
            // 
            // sendTestWH
            // 
            this.sendTestWH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendTestWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendTestWH.Location = new System.Drawing.Point(0, 84);
            this.sendTestWH.Name = "sendTestWH";
            this.sendTestWH.Size = new System.Drawing.Size(566, 49);
            this.sendTestWH.TabIndex = 1;
            this.sendTestWH.Text = "Отправить";
            this.sendTestWH.UseVisualStyleBackColor = true;
            this.sendTestWH.Click += new System.EventHandler(this.sendTestWH_Click);
            // 
            // SendWebhookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 133);
            this.Controls.Add(this.sendTestWH);
            this.Controls.Add(this.label1);
            this.Name = "SendWebhookForm";
            this.Text = "Тестовое оповещение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendTestWH;
    }
}