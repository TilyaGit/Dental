namespace Dental.Win
{
    partial class DoctorForm
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
            this._txtPhone = new System.Windows.Forms.TextBox();
            this._txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSecondName = new System.Windows.Forms.TextBox();
            this._dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this._btnDeleteDoctore = new System.Windows.Forms.Button();
            this._btnSaveDoctor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnUpdateDoctore = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._txtThirdName = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._objectListViewDoctore = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnSecondName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnThirdName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnBirthDay = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnPhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._listOfDoctors = new BrightIdeasSoftware.ObjectListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewDoctore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._listOfDoctors)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtPhone
            // 
            this._txtPhone.Location = new System.Drawing.Point(31, 201);
            this._txtPhone.Name = "_txtPhone";
            this._txtPhone.Size = new System.Drawing.Size(234, 20);
            this._txtPhone.TabIndex = 2;
            // 
            // _txtFirstName
            // 
            this._txtFirstName.Location = new System.Drawing.Point(31, 106);
            this._txtFirstName.Name = "_txtFirstName";
            this._txtFirstName.Size = new System.Drawing.Size(234, 20);
            this._txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // _txtSecondName
            // 
            this._txtSecondName.Location = new System.Drawing.Point(31, 57);
            this._txtSecondName.Name = "_txtSecondName";
            this._txtSecondName.Size = new System.Drawing.Size(234, 20);
            this._txtSecondName.TabIndex = 0;
            // 
            // _dtpBirthDay
            // 
            this._dtpBirthDay.Location = new System.Drawing.Point(31, 258);
            this._dtpBirthDay.Name = "_dtpBirthDay";
            this._dtpBirthDay.Size = new System.Drawing.Size(234, 20);
            this._dtpBirthDay.TabIndex = 3;
            // 
            // _btnDeleteDoctore
            // 
            this._btnDeleteDoctore.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteDoctore.Location = new System.Drawing.Point(31, 363);
            this._btnDeleteDoctore.Name = "_btnDeleteDoctore";
            this._btnDeleteDoctore.Size = new System.Drawing.Size(234, 21);
            this._btnDeleteDoctore.TabIndex = 4;
            this._btnDeleteDoctore.Text = "Удалить";
            this._btnDeleteDoctore.UseVisualStyleBackColor = true;
            // 
            // _btnSaveDoctor
            // 
            this._btnSaveDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSaveDoctor.Location = new System.Drawing.Point(31, 295);
            this._btnSaveDoctor.Name = "_btnSaveDoctor";
            this._btnSaveDoctor.Size = new System.Drawing.Size(234, 21);
            this._btnSaveDoctor.TabIndex = 4;
            this._btnSaveDoctor.Text = "Добавить";
            this._btnSaveDoctor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnUpdateDoctore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._dtpBirthDay);
            this.groupBox1.Controls.Add(this._txtThirdName);
            this.groupBox1.Controls.Add(this._btnDeleteDoctore);
            this.groupBox1.Controls.Add(this._btnSaveDoctor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtPhone);
            this.groupBox1.Controls.Add(this._txtFirstName);
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
            this._btnUpdateDoctore.Location = new System.Drawing.Point(31, 329);
            this._btnUpdateDoctore.Name = "_btnUpdateDoctore";
            this._btnUpdateDoctore.Size = new System.Drawing.Size(234, 21);
            this._btnUpdateDoctore.TabIndex = 11;
            this._btnUpdateDoctore.Text = "Редактировать";
            this._btnUpdateDoctore.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отчество";
            // 
            // _txtThirdName
            // 
            this._txtThirdName.Location = new System.Drawing.Point(31, 154);
            this._txtThirdName.Name = "_txtThirdName";
            this._txtThirdName.Size = new System.Drawing.Size(234, 20);
            this._txtThirdName.TabIndex = 10;
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
            this.tabPage1.Text = "Доктор";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 461);
            this.tabControl1.TabIndex = 4;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewDoctore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._listOfDoctors)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox _txtPhone;
        private System.Windows.Forms.TextBox _txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSecondName;
        private System.Windows.Forms.DateTimePicker _dtpBirthDay;
        private System.Windows.Forms.Button _btnDeleteDoctore;
        private System.Windows.Forms.Button _btnSaveDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private BrightIdeasSoftware.ObjectListView _listOfDoctors;
        private System.Windows.Forms.Button _btnUpdateDoctore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtThirdName;
        private BrightIdeasSoftware.ObjectListView _objectListViewDoctore;
        private BrightIdeasSoftware.OLVColumn _olvColumnFirstName;
        private BrightIdeasSoftware.OLVColumn _olvColumnSecondName;
        private BrightIdeasSoftware.OLVColumn _olvColumnThirdName;
        private BrightIdeasSoftware.OLVColumn _olvColumnBirthDay;
        private BrightIdeasSoftware.OLVColumn _olvColumnPhoneNumber;
    }
}