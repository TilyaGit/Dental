namespace Dental.Win
{
    partial class PatientForm
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
            this._listOfPations = new BrightIdeasSoftware.ObjectListView();
            this._colFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._colSecondName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._colThirdName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._colPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._colBirthDay = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this._txtThirdName = new System.Windows.Forms.TextBox();
            this._dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtPhone = new System.Windows.Forms.TextBox();
            this._txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSecondName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._listOfMedications = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnDiagnosis = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnPlan = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._comboServce = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._btnUpdateMedication = new System.Windows.Forms.Button();
            this._btnLoadSnapshot = new System.Windows.Forms.Button();
            this._pictureboxImage = new System.Windows.Forms.PictureBox();
            this._comboDiagnostics = new System.Windows.Forms.ComboBox();
            this._btnDeleteMedication = new System.Windows.Forms.Button();
            this._btnSaveMedication = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._txtPlan = new System.Windows.Forms.TextBox();
            this._openFileDialogMedication = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._listOfPations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._listOfMedications)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 553);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._listOfPations);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пациент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _listOfPations
            // 
            this._listOfPations.AllColumns.Add(this._colFirstName);
            this._listOfPations.AllColumns.Add(this._colSecondName);
            this._listOfPations.AllColumns.Add(this._colThirdName);
            this._listOfPations.AllColumns.Add(this._colPhone);
            this._listOfPations.AllColumns.Add(this._colBirthDay);
            this._listOfPations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._colFirstName,
            this._colSecondName,
            this._colThirdName,
            this._colPhone,
            this._colBirthDay});
            this._listOfPations.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listOfPations.FullRowSelect = true;
            this._listOfPations.GridLines = true;
            this._listOfPations.Location = new System.Drawing.Point(317, 3);
            this._listOfPations.Name = "_listOfPations";
            this._listOfPations.ShowGroups = false;
            this._listOfPations.Size = new System.Drawing.Size(710, 521);
            this._listOfPations.TabIndex = 5;
            this._listOfPations.UseCompatibleStateImageBehavior = false;
            this._listOfPations.View = System.Windows.Forms.View.Details;
            // 
            // _colFirstName
            // 
            this._colFirstName.AspectName = "FirstName";
            this._colFirstName.CellPadding = null;
            this._colFirstName.Text = "Имя";
            this._colFirstName.Width = 106;
            // 
            // _colSecondName
            // 
            this._colSecondName.AspectName = "SecondName";
            this._colSecondName.CellPadding = null;
            this._colSecondName.Text = "Фамилия";
            this._colSecondName.Width = 99;
            // 
            // _colThirdName
            // 
            this._colThirdName.AspectName = "ThirdName";
            this._colThirdName.CellPadding = null;
            this._colThirdName.Text = "Отчество";
            this._colThirdName.Width = 102;
            // 
            // _colPhone
            // 
            this._colPhone.AspectName = "PhoneNumber";
            this._colPhone.CellPadding = null;
            this._colPhone.Text = "Телефон";
            this._colPhone.Width = 101;
            // 
            // _colBirthDay
            // 
            this._colBirthDay.AspectName = "BirthDay";
            this._colBirthDay.CellPadding = null;
            this._colBirthDay.Text = "Дата рождения";
            this._colBirthDay.Width = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._txtThirdName);
            this.groupBox1.Controls.Add(this._dtpBirthDay);
            this.groupBox1.Controls.Add(this._btnUpdate);
            this.groupBox1.Controls.Add(this._btnDelete);
            this.groupBox1.Controls.Add(this._btnSave);
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
            this.groupBox1.Size = new System.Drawing.Size(314, 521);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Отчество";
            // 
            // _txtThirdName
            // 
            this._txtThirdName.Location = new System.Drawing.Point(31, 152);
            this._txtThirdName.Name = "_txtThirdName";
            this._txtThirdName.Size = new System.Drawing.Size(234, 20);
            this._txtThirdName.TabIndex = 12;
            // 
            // _dtpBirthDay
            // 
            this._dtpBirthDay.Location = new System.Drawing.Point(31, 247);
            this._dtpBirthDay.Name = "_dtpBirthDay";
            this._dtpBirthDay.Size = new System.Drawing.Size(234, 20);
            this._dtpBirthDay.TabIndex = 3;
            this._dtpBirthDay.Value = new System.DateTime(2019, 2, 17, 15, 10, 0, 0);
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnUpdate.Location = new System.Drawing.Point(31, 317);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(234, 21);
            this._btnUpdate.TabIndex = 4;
            this._btnUpdate.Text = "Редактировать";
            this._btnUpdate.UseVisualStyleBackColor = true;
            // 
            // _btnDelete
            // 
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.Location = new System.Drawing.Point(31, 351);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(234, 21);
            this._btnDelete.TabIndex = 4;
            this._btnDelete.Text = "Удалить";
            this._btnDelete.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSave.Location = new System.Drawing.Point(31, 283);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(234, 21);
            this._btnSave.TabIndex = 4;
            this._btnSave.Text = "Добавить";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 181);
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
            // _txtPhone
            // 
            this._txtPhone.Location = new System.Drawing.Point(31, 197);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._listOfMedications);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История болезней";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _listOfMedications
            // 
            this._listOfMedications.AllColumns.Add(this._olvColumnDiagnosis);
            this._listOfMedications.AllColumns.Add(this._olvColumnPlan);
            this._listOfMedications.AllColumns.Add(this._olvColumnImage);
            this._listOfMedications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnDiagnosis,
            this._olvColumnPlan,
            this._olvColumnImage});
            this._listOfMedications.Cursor = System.Windows.Forms.Cursors.Hand;
            this._listOfMedications.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listOfMedications.FullRowSelect = true;
            this._listOfMedications.GridLines = true;
            this._listOfMedications.Location = new System.Drawing.Point(311, 3);
            this._listOfMedications.Name = "_listOfMedications";
            this._listOfMedications.ShowGroups = false;
            this._listOfMedications.Size = new System.Drawing.Size(716, 521);
            this._listOfMedications.SortGroupItemsByPrimaryColumn = false;
            this._listOfMedications.TabIndex = 7;
            this._listOfMedications.UseCompatibleStateImageBehavior = false;
            this._listOfMedications.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnDiagnosis
            // 
            this._olvColumnDiagnosis.AspectName = "Diagnosis";
            this._olvColumnDiagnosis.CellPadding = null;
            this._olvColumnDiagnosis.Text = "Диагноз";
            this._olvColumnDiagnosis.Width = 251;
            // 
            // _olvColumnPlan
            // 
            this._olvColumnPlan.AspectName = "Plan";
            this._olvColumnPlan.CellPadding = null;
            this._olvColumnPlan.Text = "План";
            this._olvColumnPlan.Width = 277;
            // 
            // _olvColumnImage
            // 
            this._olvColumnImage.AspectName = "Snapshot";
            this._olvColumnImage.CellPadding = null;
            this._olvColumnImage.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this._olvColumnImage.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._olvColumnImage.IsTileViewColumn = true;
            this._olvColumnImage.Text = "Снимок";
            this._olvColumnImage.Width = 184;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._comboServce);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this._comboBoxDoctor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this._btnUpdateMedication);
            this.groupBox2.Controls.Add(this._btnLoadSnapshot);
            this.groupBox2.Controls.Add(this._pictureboxImage);
            this.groupBox2.Controls.Add(this._comboDiagnostics);
            this.groupBox2.Controls.Add(this._btnDeleteMedication);
            this.groupBox2.Controls.Add(this._btnSaveMedication);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._txtPlan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 521);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // _comboServce
            // 
            this._comboServce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboServce.FormattingEnabled = true;
            this._comboServce.Location = new System.Drawing.Point(31, 213);
            this._comboServce.Name = "_comboServce";
            this._comboServce.Size = new System.Drawing.Size(234, 21);
            this._comboServce.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label10.Location = new System.Drawing.Point(116, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Услуги:";
            // 
            // _comboBoxDoctor
            // 
            this._comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxDoctor.FormattingEnabled = true;
            this._comboBoxDoctor.Location = new System.Drawing.Point(31, 31);
            this._comboBoxDoctor.Name = "_comboBoxDoctor";
            this._comboBoxDoctor.Size = new System.Drawing.Size(234, 21);
            this._comboBoxDoctor.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label9.Location = new System.Drawing.Point(105, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Выбор доктора";
            // 
            // _btnUpdateMedication
            // 
            this._btnUpdateMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnUpdateMedication.Location = new System.Drawing.Point(32, 460);
            this._btnUpdateMedication.Name = "_btnUpdateMedication";
            this._btnUpdateMedication.Size = new System.Drawing.Size(234, 21);
            this._btnUpdateMedication.TabIndex = 8;
            this._btnUpdateMedication.Text = "Редактировать";
            this._btnUpdateMedication.UseVisualStyleBackColor = true;
            // 
            // _btnLoadSnapshot
            // 
            this._btnLoadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnLoadSnapshot.Location = new System.Drawing.Point(32, 405);
            this._btnLoadSnapshot.Name = "_btnLoadSnapshot";
            this._btnLoadSnapshot.Size = new System.Drawing.Size(234, 21);
            this._btnLoadSnapshot.TabIndex = 7;
            this._btnLoadSnapshot.Text = "Загрузить снимок";
            this._btnLoadSnapshot.UseVisualStyleBackColor = true;
            // 
            // _pictureboxImage
            // 
            this._pictureboxImage.Location = new System.Drawing.Point(32, 253);
            this._pictureboxImage.Name = "_pictureboxImage";
            this._pictureboxImage.Size = new System.Drawing.Size(234, 146);
            this._pictureboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureboxImage.TabIndex = 6;
            this._pictureboxImage.TabStop = false;
            // 
            // _comboDiagnostics
            // 
            this._comboDiagnostics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboDiagnostics.FormattingEnabled = true;
            this._comboDiagnostics.Location = new System.Drawing.Point(32, 172);
            this._comboDiagnostics.Name = "_comboDiagnostics";
            this._comboDiagnostics.Size = new System.Drawing.Size(234, 21);
            this._comboDiagnostics.TabIndex = 5;
            // 
            // _btnDeleteMedication
            // 
            this._btnDeleteMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteMedication.Location = new System.Drawing.Point(32, 485);
            this._btnDeleteMedication.Name = "_btnDeleteMedication";
            this._btnDeleteMedication.Size = new System.Drawing.Size(234, 21);
            this._btnDeleteMedication.TabIndex = 4;
            this._btnDeleteMedication.Text = "Удалить";
            this._btnDeleteMedication.UseVisualStyleBackColor = true;
            // 
            // _btnSaveMedication
            // 
            this._btnSaveMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSaveMedication.Location = new System.Drawing.Point(32, 434);
            this._btnSaveMedication.Name = "_btnSaveMedication";
            this._btnSaveMedication.Size = new System.Drawing.Size(234, 21);
            this._btnSaveMedication.TabIndex = 4;
            this._btnSaveMedication.Text = "Сохранить";
            this._btnSaveMedication.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Снимок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "План";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label7.Location = new System.Drawing.Point(116, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Диагноз";
            // 
            // _txtPlan
            // 
            this._txtPlan.Location = new System.Drawing.Point(31, 76);
            this._txtPlan.Multiline = true;
            this._txtPlan.Name = "_txtPlan";
            this._txtPlan.Size = new System.Drawing.Size(234, 76);
            this._txtPlan.TabIndex = 2;
            // 
            // _openFileDialogMedication
            // 
            this._openFileDialogMedication.FileName = "_openFileDialogMedication";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "PatientForm";
            this.Text = "Пациент";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._listOfPations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._listOfMedications)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker _dtpBirthDay;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtPhone;
        private System.Windows.Forms.TextBox _txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSecondName;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.ObjectListView _listOfMedications;
        private BrightIdeasSoftware.OLVColumn _olvColumnDiagnosis;
        private BrightIdeasSoftware.OLVColumn _olvColumnPlan;
        private System.Windows.Forms.OpenFileDialog _openFileDialogMedication;
        private BrightIdeasSoftware.OLVColumn _olvColumnImage;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtThirdName;
        private BrightIdeasSoftware.ObjectListView _listOfPations;
        private BrightIdeasSoftware.OLVColumn _colFirstName;
        private BrightIdeasSoftware.OLVColumn _colSecondName;
        private BrightIdeasSoftware.OLVColumn _colThirdName;
        private BrightIdeasSoftware.OLVColumn _colPhone;
        private BrightIdeasSoftware.OLVColumn _colBirthDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox _comboBoxDoctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button _btnUpdateMedication;
        private System.Windows.Forms.Button _btnLoadSnapshot;
        private System.Windows.Forms.PictureBox _pictureboxImage;
        private System.Windows.Forms.ComboBox _comboDiagnostics;
        private System.Windows.Forms.Button _btnDeleteMedication;
        private System.Windows.Forms.Button _btnSaveMedication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtPlan;
        private System.Windows.Forms.ComboBox _comboServce;
        private System.Windows.Forms.Label label10;
    }
}