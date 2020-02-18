namespace Dental.Win
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnAddPatient = new System.Windows.Forms.Button();
            this._txtPatientSearch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._listOfPations = new BrightIdeasSoftware.ObjectListView();
            this._colFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._colSecondName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._сolThirdName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._colPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.леченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._listOfPations)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnAddPatient);
            this.groupBox1.Controls.Add(this._txtPatientSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // _btnAddPatient
            // 
            this._btnAddPatient.Location = new System.Drawing.Point(629, 17);
            this._btnAddPatient.Name = "_btnAddPatient";
            this._btnAddPatient.Size = new System.Drawing.Size(227, 22);
            this._btnAddPatient.TabIndex = 3;
            this._btnAddPatient.Text = "Добавить пациента";
            this._btnAddPatient.UseVisualStyleBackColor = true;
            // 
            // _txtPatientSearch
            // 
            this._txtPatientSearch.Location = new System.Drawing.Point(52, 18);
            this._txtPatientSearch.Name = "_txtPatientSearch";
            this._txtPatientSearch.Size = new System.Drawing.Size(531, 20);
            this._txtPatientSearch.TabIndex = 0;
            // 
            // _listOfPations
            // 
            this._listOfPations.AllColumns.Add(this._colFirstName);
            this._listOfPations.AllColumns.Add(this._colSecondName);
            this._listOfPations.AllColumns.Add(this._сolThirdName);
            this._listOfPations.AllColumns.Add(this._colPhone);
            this._listOfPations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._colFirstName,
            this._colSecondName,
            this._сolThirdName,
            this._colPhone});
            this._listOfPations.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listOfPations.FullRowSelect = true;
            this._listOfPations.GridLines = true;
            this._listOfPations.Location = new System.Drawing.Point(0, 75);
            this._listOfPations.Name = "_listOfPations";
            this._listOfPations.ShowGroups = false;
            this._listOfPations.Size = new System.Drawing.Size(984, 386);
            this._listOfPations.TabIndex = 1;
            this._listOfPations.UseCompatibleStateImageBehavior = false;
            this._listOfPations.View = System.Windows.Forms.View.Details;
            // 
            // _colFirstName
            // 
            this._colFirstName.AspectName = "FirstName";
            this._colFirstName.CellPadding = null;
            this._colFirstName.Text = "Имя";
            this._colFirstName.Width = 264;
            // 
            // _colSecondName
            // 
            this._colSecondName.AspectName = "SecondName";
            this._colSecondName.CellPadding = null;
            this._colSecondName.Text = "Фамилия";
            this._colSecondName.Width = 238;
            // 
            // _сolThirdName
            // 
            this._сolThirdName.AspectName = "ThirdName";
            this._сolThirdName.CellPadding = null;
            this._сolThirdName.Text = "Отчество";
            this._сolThirdName.Width = 157;
            // 
            // _colPhone
            // 
            this._colPhone.AspectName = "PhoneNumber";
            this._colPhone.CellPadding = null;
            this._colPhone.Text = "Телефон";
            this._colPhone.Width = 256;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.врачToolStripMenuItem,
            this.леченияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.клиентToolStripMenuItem.Text = "Пациенты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // врачToolStripMenuItem
            // 
            this.врачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.врачToolStripMenuItem.Name = "врачToolStripMenuItem";
            this.врачToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.врачToolStripMenuItem.Text = "Врач";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // леченияToolStripMenuItem
            // 
            this.леченияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.леченияToolStripMenuItem.Name = "леченияToolStripMenuItem";
            this.леченияToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.леченияToolStripMenuItem.Text = "Услуги";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this._listOfPations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Dental";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._listOfPations)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtPatientSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BrightIdeasSoftware.ObjectListView _listOfPations;
        private BrightIdeasSoftware.OLVColumn _colFirstName;
        private BrightIdeasSoftware.OLVColumn _colSecondName;
        private BrightIdeasSoftware.OLVColumn _colPhone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.Button _btnAddPatient;
        private System.Windows.Forms.ToolStripMenuItem врачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem леченияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private BrightIdeasSoftware.OLVColumn _сolThirdName;
    }
}

