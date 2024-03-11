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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(266, 83);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(228, 28);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата добавления";
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Location = new System.Drawing.Point(202, 80);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(165, 23);
            this.labelEquipment.TabIndex = 3;
            this.labelEquipment.Text = "Оборудование";
            // 
            // labelBrokenType
            // 
            this.labelBrokenType.AutoSize = true;
            this.labelBrokenType.Location = new System.Drawing.Point(244, 117);
            this.labelBrokenType.Name = "labelBrokenType";
            this.labelBrokenType.Size = new System.Drawing.Size(208, 23);
            this.labelBrokenType.TabIndex = 4;
            this.labelBrokenType.Text = "Тип неисправности";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(28, 224);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(453, 130);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание проблемы";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(138, 43);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(81, 23);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Клиент";
            // 
            // labelSatus
            // 
            this.labelSatus.AutoSize = true;
            this.labelSatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.labelSatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSatus.Location = new System.Drawing.Point(62, 43);
            this.labelSatus.Name = "labelSatus";
            this.labelSatus.Size = new System.Drawing.Size(86, 23);
            this.labelSatus.TabIndex = 7;
            this.labelSatus.Text = "Статус";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.groupBoxStatus.Controls.Add(this.labelSatus);
            this.groupBoxStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxStatus.Location = new System.Drawing.Point(503, 25);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(196, 101);
            this.groupBoxStatus.TabIndex = 8;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Статус заявки";
            // 
            // groupBoxData
            // 
            this.groupBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
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
            this.groupBoxData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxData.Location = new System.Drawing.Point(717, 25);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(524, 368);
            this.groupBoxData.TabIndex = 9;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Даннные по заявке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Описание проблемы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип неисправности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оборудование:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Клиент:";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComment.Location = new System.Drawing.Point(25, 217);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(182, 28);
            this.labelComment.TabIndex = 7;
            this.labelComment.Text = "Комментарии";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEdit.Location = new System.Drawing.Point(503, 132);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 63);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Редактировать заявку";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(30, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(669, 144);
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
            this.buttonAddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.buttonAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddComment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddComment.Location = new System.Drawing.Point(29, 132);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(162, 63);
            this.buttonAddComment.TabIndex = 13;
            this.buttonAddComment.Text = "Добавить комментарий";
            this.buttonAddComment.UseVisualStyleBackColor = false;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата добавления:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(155, 156);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(122, 23);
            this.labelPriority.TabIndex = 17;
            this.labelPriority.Text = "Приоритет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Приоритет:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(218, 38);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(180, 28);
            this.labelNumber.TabIndex = 19;
            this.labelNumber.Text = "Номер заявки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер заявки:";
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
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
            this.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(1283, 431);
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
