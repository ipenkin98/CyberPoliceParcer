namespace CyberPoliceParcer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SturtButton = new System.Windows.Forms.Button();
            this.LimitedBox = new System.Windows.Forms.TextBox();
            this.UnlimitedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelsBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EndProcessButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SturtButton
            // 
            this.SturtButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.SturtButton.Location = new System.Drawing.Point(12, 21);
            this.SturtButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SturtButton.Name = "SturtButton";
            this.SturtButton.Size = new System.Drawing.Size(140, 88);
            this.SturtButton.TabIndex = 0;
            this.SturtButton.Text = "Запуск парсера";
            this.toolTip1.SetToolTip(this.SturtButton, "После ввода никнеймов моделей запускает парсер с распределением ссылок в текстовы" +
        "е окна ниже. По онончанию выполнения операции закрывает браузер.");
            this.SturtButton.UseVisualStyleBackColor = true;
            this.SturtButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LimitedBox
            // 
            this.LimitedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LimitedBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LimitedBox.Location = new System.Drawing.Point(10, 45);
            this.LimitedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LimitedBox.Multiline = true;
            this.LimitedBox.Name = "LimitedBox";
            this.LimitedBox.Size = new System.Drawing.Size(539, 412);
            this.LimitedBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.LimitedBox, "Полученные ссылки аккаунтов с ограниченным доступом");
            this.LimitedBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // UnlimitedBox
            // 
            this.UnlimitedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnlimitedBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.UnlimitedBox.Location = new System.Drawing.Point(572, 45);
            this.UnlimitedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnlimitedBox.Multiline = true;
            this.UnlimitedBox.Name = "UnlimitedBox";
            this.UnlimitedBox.Size = new System.Drawing.Size(621, 412);
            this.UnlimitedBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.UnlimitedBox, "Полученные ссылки аккаунтов с открытым доступом");
            this.UnlimitedBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Доступ ограничен";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LimitedBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UnlimitedBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1207, 461);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ссылки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(569, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доступ не ограничен";
            // 
            // ModelsBox
            // 
            this.ModelsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.ModelsBox.Location = new System.Drawing.Point(182, 31);
            this.ModelsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModelsBox.Name = "ModelsBox";
            this.ModelsBox.Size = new System.Drawing.Size(688, 120);
            this.ModelsBox.TabIndex = 7;
            this.ModelsBox.Text = "";
            this.toolTip1.SetToolTip(this.ModelsBox, "Ввести никнеймы для парсинга");
            // 
            // SaveButton1
            // 
            this.SaveButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton1.AutoSize = true;
            this.SaveButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.SaveButton1.Location = new System.Drawing.Point(21, 32);
            this.SaveButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(120, 42);
            this.SaveButton1.TabIndex = 8;
            this.SaveButton1.Text = "Сохранить (1)";
            this.toolTip1.SetToolTip(this.SaveButton1, "Сохранить ссылки с ограниченным доступом ");
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.Button2_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton2.AutoSize = true;
            this.SaveButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.SaveButton2.Location = new System.Drawing.Point(161, 31);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(123, 43);
            this.SaveButton2.TabIndex = 9;
            this.SaveButton2.Text = "Сохранить (2)";
            this.toolTip1.SetToolTip(this.SaveButton2, "Сохранить ссылки без ограниченного доступа");
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SaveButton1);
            this.groupBox2.Controls.Add(this.SaveButton2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(899, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить результат :";
            this.toolTip1.SetToolTip(this.groupBox2, "По умолчанию сохраняется на диск C");
            // 
            // EndProcessButton
            // 
            this.EndProcessButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.EndProcessButton.Location = new System.Drawing.Point(12, 115);
            this.EndProcessButton.Name = "EndProcessButton";
            this.EndProcessButton.Size = new System.Drawing.Size(140, 59);
            this.EndProcessButton.TabIndex = 12;
            this.EndProcessButton.Text = "Завершить";
            this.toolTip1.SetToolTip(this.EndProcessButton, "Завершить парсинг");
            this.EndProcessButton.UseVisualStyleBackColor = true;
            this.EndProcessButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.WarningLabel.Location = new System.Drawing.Point(178, 166);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 21);
            this.WarningLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 653);
            this.Controls.Add(this.EndProcessButton);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ModelsBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SturtButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "CyberPoliceParcer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.RichTextBox ModelsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LimitedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnlimitedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SturtButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Button EndProcessButton;
    }
}

