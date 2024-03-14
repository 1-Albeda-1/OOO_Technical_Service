namespace OOO_Technical_Service.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelFIO = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelRole = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.запчастиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базыДанныхToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.авторизацияToolStripMenuItem,
            this.добавитьРаботникаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базыДанныхToolStripMenuItem
            // 
            this.базыДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявкиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.запчастиToolStripMenuItem});
            this.базыДанныхToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.базыДанныхToolStripMenuItem.Name = "базыДанныхToolStripMenuItem";
            this.базыДанныхToolStripMenuItem.Size = new System.Drawing.Size(174, 33);
            this.базыДанныхToolStripMenuItem.Text = "Базы данных";
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.заявкиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.клиентыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(134, 33);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(177, 33);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(271, 33);
            this.добавитьРаботникаToolStripMenuItem.Text = "Добавить работника";
            this.добавитьРаботникаToolStripMenuItem.Visible = false;
            this.добавитьРаботникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьРаботникаToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelFIO,
            this.toolStripLabelRole});
            this.toolStrip1.Location = new System.Drawing.Point(0, 462);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1104, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Пользователь:";
            // 
            // toolStripLabelFIO
            // 
            this.toolStripLabelFIO.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabelFIO.Name = "toolStripLabelFIO";
            this.toolStripLabelFIO.Size = new System.Drawing.Size(173, 27);
            this.toolStripLabelFIO.Text = "Пользователь:";
            // 
            // toolStripLabelRole
            // 
            this.toolStripLabelRole.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabelRole.Name = "toolStripLabelRole";
            this.toolStripLabelRole.Size = new System.Drawing.Size(99, 27);
            this.toolStripLabelRole.Text = "Статус:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 212);
            this.label1.TabIndex = 2;
            this.label1.Text = "ООО “Техноcервис” – ваш надежный партнер в обслуживании и ремонте разнообразной т" +
    "ехники. Наша команда опытных специалистов готова помочь вам в решении любых проб" +
    "лем, связанных с вашим оборудованием.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.оборудованиеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOO_Technical_Service.Properties.Resources.icons8_tools_50;
            this.pictureBox1.Location = new System.Drawing.Point(524, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // запчастиToolStripMenuItem
            // 
            this.запчастиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.запчастиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.запчастиToolStripMenuItem.Name = "запчастиToolStripMenuItem";
            this.запчастиToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.запчастиToolStripMenuItem.Text = "Запчасти";
            this.запчастиToolStripMenuItem.Click += new System.EventHandler(this.запчастиToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1104, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1128, 559);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1128, 559);
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem базыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFIO;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRole;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запчастиToolStripMenuItem;
    }
}