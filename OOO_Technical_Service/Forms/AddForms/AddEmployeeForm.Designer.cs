﻿namespace OOO_Technical_Service.Forms
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(94, 96);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(152, 21);
            this.textBoxPassword.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Логин";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(159, 173);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(102, 39);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(28, 173);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 39);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(94, 23);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(152, 21);
            this.textBoxFullName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "ФИО";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(94, 60);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(152, 21);
            this.textBoxLogin.TabIndex = 43;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(94, 129);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(152, 24);
            this.comboBoxRole.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Статус";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(292, 229);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployeeForm";
            this.Text = "Добавить работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label6;
    }
}