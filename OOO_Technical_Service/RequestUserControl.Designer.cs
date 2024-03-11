namespace OOO_Technical_Service
{
    partial class RequestUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.labelBrokenType = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelSatus = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(207, 86);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(176, 25);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата добавления";
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Location = new System.Drawing.Point(185, 81);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(145, 25);
            this.labelEquipment.TabIndex = 3;
            this.labelEquipment.Text = "Оборудование";
            // 
            // labelBrokenType
            // 
            this.labelBrokenType.AutoSize = true;
            this.labelBrokenType.Location = new System.Drawing.Point(231, 122);
            this.labelBrokenType.Name = "labelBrokenType";
            this.labelBrokenType.Size = new System.Drawing.Size(191, 25);
            this.labelBrokenType.TabIndex = 4;
            this.labelBrokenType.Text = "Тип неисправности";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(28, 254);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(453, 115);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание проблемы";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(138, 45);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(81, 25);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Клиент";
            // 
            // labelSatus
            // 
            this.labelSatus.AutoSize = true;
            this.labelSatus.Location = new System.Drawing.Point(62, 45);
            this.labelSatus.Name = "labelSatus";
            this.labelSatus.Size = new System.Drawing.Size(78, 25);
            this.labelSatus.TabIndex = 7;
            this.labelSatus.Text = "Статус";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelSatus);
            this.groupBoxStatus.Location = new System.Drawing.Point(405, 26);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(196, 106);
            this.groupBoxStatus.TabIndex = 8;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Статус заявки";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.label4);
            this.groupBoxData.Controls.Add(this.label3);
            this.groupBoxData.Controls.Add(this.labelPriority);
            this.groupBoxData.Controls.Add(this.label7);
            this.groupBoxData.Controls.Add(this.label2);
            this.groupBoxData.Controls.Add(this.label1);
            this.groupBoxData.Controls.Add(this.labelEquipment);
            this.groupBoxData.Controls.Add(this.labelBrokenType);
            this.groupBoxData.Controls.Add(this.labelClient);
            this.groupBoxData.Controls.Add(this.labelDescription);
            this.groupBoxData.Location = new System.Drawing.Point(620, 26);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(524, 383);
            this.groupBoxData.TabIndex = 9;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Даннные по заявке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Описание проблемы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип неисправности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оборудование:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Клиент:";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(33, 231);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(146, 25);
            this.labelComment.TabIndex = 7;
            this.labelComment.Text = "Комментарии";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(439, 138);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(162, 66);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Редактировать заявку";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(46, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Employee";
            this.Column1.HeaderText = "Работник";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CommentText";
            this.Column2.HeaderText = "Комментарий";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(38, 138);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(162, 66);
            this.buttonAddComment.TabIndex = 13;
            this.buttonAddComment.Text = "Добавить комментарий";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата добавления:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(155, 167);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(116, 25);
            this.labelPriority.TabIndex = 17;
            this.labelPriority.Text = "Приоритет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Приоритет:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(180, 39);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(143, 25);
            this.labelNumber.TabIndex = 19;
            this.labelNumber.Text = "Номер заявки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер заявки:";
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.labelDate);
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(1227, 449);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Label labelBrokenType;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelSatus;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label label8;
    }
}
