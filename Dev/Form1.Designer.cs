namespace Dev
{
    partial class Frm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSp = new System.Windows.Forms.ListBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.dateDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adrs = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.grpFind = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brnDel = new System.Windows.Forms.Button();
            this.obman = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind2 = new System.Windows.Forms.Button();
            this.btnFind1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstFind = new System.Windows.Forms.ListBox();
            this.txtNumR = new System.Windows.Forms.TextBox();
            this.txtDateR = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
            this.grpFind.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSp
            // 
            this.lstSp.FormattingEnabled = true;
            this.lstSp.Location = new System.Drawing.Point(6, 40);
            this.lstSp.Name = "lstSp";
            this.lstSp.ScrollAlwaysVisible = true;
            this.lstSp.Size = new System.Drawing.Size(649, 82);
            this.lstSp.TabIndex = 1;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.dateDay);
            this.grpAdd.Controls.Add(this.label2);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.dateTime);
            this.grpAdd.Controls.Add(this.lblDate);
            this.grpAdd.Controls.Add(this.FIO);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Controls.Add(this.Adrs);
            this.grpAdd.Controls.Add(this.lblN);
            this.grpAdd.Location = new System.Drawing.Point(21, 190);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(360, 157);
            this.grpAdd.TabIndex = 3;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Добавить заявку";
            // 
            // dateDay
            // 
            this.dateDay.Location = new System.Drawing.Point(267, 89);
            this.dateDay.Name = "dateDay";
            this.dateDay.Size = new System.Drawing.Size(84, 20);
            this.dateDay.TabIndex = 8;
            this.dateDay.Enter += new System.EventHandler(this.dateDay_Enter);
            this.dateDay.Leave += new System.EventHandler(this.dateDay_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(342, 21);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(115, 89);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(92, 20);
            this.dateTime.TabIndex = 5;
            this.dateTime.Enter += new System.EventHandler(this.dateTime_Enter);
            this.dateTime.Leave += new System.EventHandler(this.dateTime_Leave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 92);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Желаемое время :";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(67, 59);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(284, 20);
            this.FIO.TabIndex = 3;
            this.FIO.Enter += new System.EventHandler(this.FIO_Enter);
            this.FIO.Leave += new System.EventHandler(this.FIO_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ф. И. О. :";
            // 
            // Adrs
            // 
            this.Adrs.Location = new System.Drawing.Point(117, 29);
            this.Adrs.Name = "Adrs";
            this.Adrs.Size = new System.Drawing.Size(234, 20);
            this.Adrs.TabIndex = 1;
            this.Adrs.Enter += new System.EventHandler(this.Adrs_Enter);
            this.Adrs.Leave += new System.EventHandler(this.Adrs_Leave);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(6, 32);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(105, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Пункт назначения :";
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.label6);
            this.grpFind.Controls.Add(this.label5);
            this.grpFind.Controls.Add(this.label4);
            this.grpFind.Controls.Add(this.label3);
            this.grpFind.Controls.Add(this.brnDel);
            this.grpFind.Controls.Add(this.lstSp);
            this.grpFind.Location = new System.Drawing.Point(387, 190);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(662, 157);
            this.grpFind.TabIndex = 4;
            this.grpFind.TabStop = false;
            this.grpFind.Text = "Заявки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "№ Рейса : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ф. И. О. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пункт назначения :";
            // 
            // brnDel
            // 
            this.brnDel.Location = new System.Drawing.Point(6, 128);
            this.brnDel.Name = "brnDel";
            this.brnDel.Size = new System.Drawing.Size(649, 23);
            this.brnDel.TabIndex = 2;
            this.brnDel.Text = "Удалить заявку";
            this.brnDel.UseVisualStyleBackColor = true;
            this.brnDel.Click += new System.EventHandler(this.brnDel_Click);
            // 
            // obman
            // 
            this.obman.Location = new System.Drawing.Point(514, 551);
            this.obman.Name = "obman";
            this.obman.Size = new System.Drawing.Size(14, 20);
            this.obman.TabIndex = 5;
            this.obman.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnFind2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnFind1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lstFind);
            this.groupBox1.Controls.Add(this.txtNumR);
            this.groupBox1.Controls.Add(this.txtDateR);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найти заявку";
            // 
            // btnFind2
            // 
            this.btnFind2.Location = new System.Drawing.Point(911, 75);
            this.btnFind2.Name = "btnFind2";
            this.btnFind2.Size = new System.Drawing.Size(97, 20);
            this.btnFind2.TabIndex = 6;
            this.btnFind2.Text = "Найти";
            this.btnFind2.UseVisualStyleBackColor = true;
            this.btnFind2.Click += new System.EventHandler(this.btnFind2_Click);
            // 
            // btnFind1
            // 
            this.btnFind1.Location = new System.Drawing.Point(910, 30);
            this.btnFind1.Name = "btnFind1";
            this.btnFind1.Size = new System.Drawing.Size(97, 20);
            this.btnFind1.TabIndex = 5;
            this.btnFind1.Text = "Найти";
            this.btnFind1.UseVisualStyleBackColor = true;
            this.btnFind1.Click += new System.EventHandler(this.btnFind1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(685, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Дата вылета :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Номер рейса :";
            // 
            // lstFind
            // 
            this.lstFind.FormattingEnabled = true;
            this.lstFind.Location = new System.Drawing.Point(6, 32);
            this.lstFind.Name = "lstFind";
            this.lstFind.ScrollAlwaysVisible = true;
            this.lstFind.Size = new System.Drawing.Size(672, 108);
            this.lstFind.TabIndex = 2;
            // 
            // txtNumR
            // 
            this.txtNumR.Location = new System.Drawing.Point(764, 31);
            this.txtNumR.Name = "txtNumR";
            this.txtNumR.Size = new System.Drawing.Size(140, 20);
            this.txtNumR.TabIndex = 1;
            this.txtNumR.Enter += new System.EventHandler(this.txtNumR_Enter);
            this.txtNumR.Leave += new System.EventHandler(this.txtNumR_Leave);
            // 
            // txtDateR
            // 
            this.txtDateR.Location = new System.Drawing.Point(765, 75);
            this.txtDateR.Name = "txtDateR";
            this.txtDateR.Size = new System.Drawing.Size(140, 20);
            this.txtDateR.TabIndex = 0;
            this.txtDateR.Enter += new System.EventHandler(this.txtDateR_Enter);
            this.txtDateR.Leave += new System.EventHandler(this.txtDateR_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(334, 20);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "№ Рейса : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Дата :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ф. И. О. :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Пункт назначения :";
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.obman);
            this.Controls.Add(this.grpFind);
            this.Controls.Add(this.grpAdd);
            this.Name = "Frm";
            this.Text = "Заявки ";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSp;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adrs;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.GroupBox grpFind;
        private System.Windows.Forms.Button brnDel;
        private System.Windows.Forms.TextBox obman;
        private System.Windows.Forms.TextBox dateDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind2;
        private System.Windows.Forms.Button btnFind1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstFind;
        private System.Windows.Forms.TextBox txtNumR;
        private System.Windows.Forms.TextBox txtDateR;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

