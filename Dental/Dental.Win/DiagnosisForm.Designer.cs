namespace Dental.Win
{
    partial class DiagnosisForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._objectListViewDoctore = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnSecondName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnThirdName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnBirthDay = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnPhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._listOfDoctors = new BrightIdeasSoftware.ObjectListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnUpdateDoctore = new System.Windows.Forms.Button();
            this._btnDeleteDoctore = new System.Windows.Forms.Button();
            this._btnSaveDoctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSecondName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewDoctore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._listOfDoctors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 461);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._objectListViewDoctore);
            this.tabPage1.Controls.Add(this._listOfDoctors);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Диагнос";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _objectListViewDoctore
            // 
            this._objectListViewDoctore.AllColumns.Add(this._olvColumnFirstName);
            this._objectListViewDoctore.AllColumns.Add(this._olvColumnSecondName);
            this._objectListViewDoctore.AllColumns.Add(this._olvColumnThirdName);
            this._objectListViewDoctore.AllColumns.Add(this._olvColumnBirthDay);
            this._objectListViewDoctore.AllColumns.Add(this._olvColumnPhoneNumber);
            this._objectListViewDoctore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnFirstName,
            this._olvColumnSecondName,
            this._olvColumnThirdName,
            this._olvColumnBirthDay,
            this._olvColumnPhoneNumber});
            this._objectListViewDoctore.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewDoctore.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewDoctore.FullRowSelect = true;
            this._objectListViewDoctore.GridLines = true;
            this._objectListViewDoctore.Location = new System.Drawing.Point(310, 3);
            this._objectListViewDoctore.Name = "_objectListViewDoctore";
            this._objectListViewDoctore.ShowGroups = false;
            this._objectListViewDoctore.Size = new System.Drawing.Size(663, 429);
            this._objectListViewDoctore.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewDoctore.TabIndex = 11;
            this._objectListViewDoctore.UseCompatibleStateImageBehavior = false;
            this._objectListViewDoctore.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnFirstName
            // 
            this._olvColumnFirstName.AspectName = "FirstName";
            this._olvColumnFirstName.CellPadding = null;
            this._olvColumnFirstName.Text = "Имя";
            // 
            // _olvColumnSecondName
            // 
            this._olvColumnSecondName.AspectName = "SecondName";
            this._olvColumnSecondName.CellPadding = null;
            this._olvColumnSecondName.Text = "Фамилия";
            // 
            // _olvColumnThirdName
            // 
            this._olvColumnThirdName.AspectName = "ThirdName";
            this._olvColumnThirdName.CellPadding = null;
            this._olvColumnThirdName.Text = "Отчество";
            // 
            // _olvColumnBirthDay
            // 
            this._olvColumnBirthDay.AspectName = "BirthDay";
            this._olvColumnBirthDay.CellPadding = null;
            this._olvColumnBirthDay.Text = "Дата рождения";
            // 
            // _olvColumnPhoneNumber
            // 
            this._olvColumnPhoneNumber.CellPadding = null;
            this._olvColumnPhoneNumber.Text = "Телефон";
            // 
            // _listOfDoctors
            // 
            this._listOfDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this._listOfDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listOfDoctors.FullRowSelect = true;
            this._listOfDoctors.GridLines = true;
            this._listOfDoctors.Location = new System.Drawing.Point(310, 3);
            this._listOfDoctors.Name = "_listOfDoctors";
            this._listOfDoctors.ShowGroups = false;
            this._listOfDoctors.Size = new System.Drawing.Size(663, 429);
            this._listOfDoctors.SortGroupItemsByPrimaryColumn = false;
            this._listOfDoctors.TabIndex = 8;
            this._listOfDoctors.UseCompatibleStateImageBehavior = false;
            this._listOfDoctors.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnUpdateDoctore);
            this.groupBox1.Controls.Add(this._btnDeleteDoctore);
            this.groupBox1.Controls.Add(this._btnSaveDoctor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtSecondName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 429);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // _btnUpdateDoctore
            // 
            this._btnUpdateDoctore.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnUpdateDoctore.Location = new System.Drawing.Point(31, 199);
            this._btnUpdateDoctore.Name = "_btnUpdateDoctore";
            this._btnUpdateDoctore.Size = new System.Drawing.Size(234, 21);
            this._btnUpdateDoctore.TabIndex = 11;
            this._btnUpdateDoctore.Text = "Редактировать";
            this._btnUpdateDoctore.UseVisualStyleBackColor = true;
            // 
            // _btnDeleteDoctore
            // 
            this._btnDeleteDoctore.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteDoctore.Location = new System.Drawing.Point(31, 233);
            this._btnDeleteDoctore.Name = "_btnDeleteDoctore";
            this._btnDeleteDoctore.Size = new System.Drawing.Size(234, 21);
            this._btnDeleteDoctore.TabIndex = 4;
            this._btnDeleteDoctore.Text = "Удалить";
            this._btnDeleteDoctore.UseVisualStyleBackColor = true;
            // 
            // _btnSaveDoctor
            // 
            this._btnSaveDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSaveDoctor.Location = new System.Drawing.Point(31, 165);
            this._btnSaveDoctor.Name = "_btnSaveDoctor";
            this._btnSaveDoctor.Size = new System.Drawing.Size(234, 21);
            this._btnSaveDoctor.TabIndex = 4;
            this._btnSaveDoctor.Text = "Добавить";
            this._btnSaveDoctor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название диагноса";
            // 
            // _txtSecondName
            // 
            this._txtSecondName.Location = new System.Drawing.Point(31, 105);
            this._txtSecondName.Name = "_txtSecondName";
            this._txtSecondName.Size = new System.Drawing.Size(234, 20);
            this._txtSecondName.TabIndex = 0;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "DiagnosisForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewDoctore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._listOfDoctors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView _objectListViewDoctore;
        private BrightIdeasSoftware.OLVColumn _olvColumnFirstName;
        private BrightIdeasSoftware.OLVColumn _olvColumnSecondName;
        private BrightIdeasSoftware.OLVColumn _olvColumnThirdName;
        private BrightIdeasSoftware.OLVColumn _olvColumnBirthDay;
        private BrightIdeasSoftware.OLVColumn _olvColumnPhoneNumber;
        private BrightIdeasSoftware.ObjectListView _listOfDoctors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnUpdateDoctore;
        private System.Windows.Forms.Button _btnDeleteDoctore;
        private System.Windows.Forms.Button _btnSaveDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSecondName;
    }
}