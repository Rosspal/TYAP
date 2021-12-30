namespace KoganL3_test2
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
            this.btnADD = new System.Windows.Forms.Button();
            this.tbxADD = new System.Windows.Forms.TextBox();
            this.tbxTABLE = new System.Windows.Forms.TextBox();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.tbxSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LoadFactor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Colissions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_IdCount = new System.Windows.Forms.Label();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.rb_6 = new System.Windows.Forms.RadioButton();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.label_FileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.Location = new System.Drawing.Point(12, 87);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(321, 33);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Добавить идентификатор";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // tbxADD
            // 
            this.tbxADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxADD.Location = new System.Drawing.Point(12, 61);
            this.tbxADD.Name = "tbxADD";
            this.tbxADD.Size = new System.Drawing.Size(321, 22);
            this.tbxADD.TabIndex = 1;
            // 
            // tbxTABLE
            // 
            this.tbxTABLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTABLE.Location = new System.Drawing.Point(339, 61);
            this.tbxTABLE.Multiline = true;
            this.tbxTABLE.Name = "tbxTABLE";
            this.tbxTABLE.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxTABLE.Size = new System.Drawing.Size(391, 409);
            this.tbxTABLE.TabIndex = 2;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSEARCH.Location = new System.Drawing.Point(12, 154);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(321, 33);
            this.btnSEARCH.TabIndex = 3;
            this.btnSEARCH.Text = "Найти идентификатор";
            this.btnSEARCH.UseVisualStyleBackColor = true;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // tbxSEARCH
            // 
            this.tbxSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSEARCH.Location = new System.Drawing.Point(12, 126);
            this.tbxSEARCH.Name = "tbxSEARCH";
            this.tbxSEARCH.Size = new System.Drawing.Size(321, 22);
            this.tbxSEARCH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(416, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таблица идентификаторов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Коэффициент заполнения: ";
            // 
            // label_LoadFactor
            // 
            this.label_LoadFactor.AutoSize = true;
            this.label_LoadFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LoadFactor.Location = new System.Drawing.Point(192, 257);
            this.label_LoadFactor.Name = "label_LoadFactor";
            this.label_LoadFactor.Size = new System.Drawing.Size(20, 16);
            this.label_LoadFactor.TabIndex = 7;
            this.label_LoadFactor.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число коллизий: ";
            // 
            // label_Colissions
            // 
            this.label_Colissions.AutoSize = true;
            this.label_Colissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Colissions.Location = new System.Drawing.Point(123, 231);
            this.label_Colissions.Name = "label_Colissions";
            this.label_Colissions.Size = new System.Drawing.Size(20, 16);
            this.label_Colissions.TabIndex = 9;
            this.label_Colissions.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Число элементов в таблице: ";
            // 
            // label_IdCount
            // 
            this.label_IdCount.AutoSize = true;
            this.label_IdCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IdCount.Location = new System.Drawing.Point(201, 205);
            this.label_IdCount.Name = "label_IdCount";
            this.label_IdCount.Size = new System.Drawing.Size(20, 16);
            this.label_IdCount.TabIndex = 11;
            this.label_IdCount.Text = "---";
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Checked = true;
            this.rb_1.Location = new System.Drawing.Point(15, 323);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(150, 17);
            this.rb_1.TabIndex = 12;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Простое рехеширование";
            this.rb_1.UseVisualStyleBackColor = true;
            this.rb_1.CheckedChanged += new System.EventHandler(this.rb_1_CheckedChanged);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(15, 346);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(149, 17);
            this.rb_2.TabIndex = 13;
            this.rb_2.Text = "Псевдослучайные числа";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.rb_2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Метод организации таблицы";
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(15, 369);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(132, 17);
            this.rb_3.TabIndex = 15;
            this.rb_3.Text = "Метод произведения";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.rb_3_CheckedChanged);
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(15, 392);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(101, 17);
            this.rb_4.TabIndex = 16;
            this.rb_4.Text = "Метод цепочек";
            this.rb_4.UseVisualStyleBackColor = true;
            this.rb_4.CheckedChanged += new System.EventHandler(this.rb_4_CheckedChanged);
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(15, 415);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(107, 17);
            this.rb_5.TabIndex = 17;
            this.rb_5.Text = "Простой список";
            this.rb_5.UseVisualStyleBackColor = true;
            this.rb_5.CheckedChanged += new System.EventHandler(this.rb_5_CheckedChanged);
            // 
            // rb_6
            // 
            this.rb_6.AutoSize = true;
            this.rb_6.Location = new System.Drawing.Point(15, 438);
            this.rb_6.Name = "rb_6";
            this.rb_6.Size = new System.Drawing.Size(145, 17);
            this.rb_6.TabIndex = 18;
            this.rb_6.Text = "Упорядоченный список";
            this.rb_6.UseVisualStyleBackColor = true;
            this.rb_6.CheckedChanged += new System.EventHandler(this.rb_6_CheckedChanged);
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Location = new System.Drawing.Point(213, 32);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(120, 23);
            this.btn_LoadFile.TabIndex = 19;
            this.btn_LoadFile.Text = "Загрузить файл";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FileName.Location = new System.Drawing.Point(12, 35);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(120, 16);
            this.label_FileName.TabIndex = 20;
            this.label_FileName.Text = "Число коллизий: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 499);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.rb_6);
            this.Controls.Add(this.rb_5);
            this.Controls.Add(this.rb_4);
            this.Controls.Add(this.rb_3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.label_IdCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Colissions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_LoadFactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSEARCH);
            this.Controls.Add(this.btnSEARCH);
            this.Controls.Add(this.tbxTABLE);
            this.Controls.Add(this.tbxADD);
            this.Controls.Add(this.btnADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox tbxADD;
        private System.Windows.Forms.TextBox tbxTABLE;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.TextBox tbxSEARCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_LoadFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Colissions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_IdCount;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.RadioButton rb_6;
        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Label label_FileName;
    }
}

