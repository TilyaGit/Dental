namespace Dental.Win
{
    partial class ServiceForm
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
            this._objectListViewService = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnDesscribe = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._listOfDoctors = new BrightIdeasSoftware.ObjectListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnUpdateService = new System.Windows.Forms.Button();
            this._btnDeleteService = new System.Windows.Forms.Button();
            this._btnSaveService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtDesscribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtNameService = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewService)).BeginInit();
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
            this.tabPage1.Controls.Add(this._objectListViewService);
            this.tabPage1.Controls.Add(this._listOfDoctors);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Услуги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _objectListViewService
            // 
            this._objectListViewService.AllColumns.Add(this._olvColumnName);
            this._objectListViewService.AllColumns.Add(this._olvColumnDesscribe);
            this._objectListViewService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnName,
            this._olvColumnDesscribe});
            this._objectListViewService.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewService.FullRowSelect = true;
            this._objectListViewService.GridLines = true;
            this._objectListViewService.Location = new System.Drawing.Point(310, 3);
            this._objectListViewService.Name = "_objectListViewService";
            this._objectListViewService.ShowGroups = false;
            this._objectListViewService.Size = new System.Drawing.Size(663, 429);
            this._objectListViewService.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewService.TabIndex = 11;
            this._objectListViewService.UseCompatibleStateImageBehavior = false;
            this._objectListViewService.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnName
            // 
            this._olvColumnName.AspectName = "Name";
            this._olvColumnName.CellPadding = null;
            this._olvColumnName.Text = "Название";
            this._olvColumnName.Width = 243;
            // 
            // _olvColumnDesscribe
            // 
            this._olvColumnDesscribe.AspectName = "Desscribe";
            this._olvColumnDesscribe.CellPadding = null;
            this._olvColumnDesscribe.Text = "Описание";
            this._olvColumnDesscribe.Width = 234;
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
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this._btnUpdateService);
            this.groupBox1.Controls.Add(this._btnDeleteService);
            this.groupBox1.Controls.Add(this._btnSaveService);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtDesscribe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtNameService);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 429);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // _btnUpdateService
            // 
            this._btnUpdateService.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnUpdateService.Location = new System.Drawing.Point(31, 350);
            this._btnUpdateService.Name = "_btnUpdateService";
            this._btnUpdateService.Size = new System.Drawing.Size(234, 21);
            this._btnUpdateService.TabIndex = 11;
            this._btnUpdateService.Text = "Редактировать";
            this._btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // _btnDeleteService
            // 
            this._btnDeleteService.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteService.Location = new System.Drawing.Point(31, 384);
            this._btnDeleteService.Name = "_btnDeleteService";
            this._btnDeleteService.Size = new System.Drawing.Size(234, 21);
            this._btnDeleteService.TabIndex = 4;
            this._btnDeleteService.Text = "Удалить";
            this._btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // _btnSaveService
            // 
            this._btnSaveService.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSaveService.Location = new System.Drawing.Point(31, 316);
            this._btnSaveService.Name = "_btnSaveService";
            this._btnSaveService.Size = new System.Drawing.Size(234, 21);
            this._btnSaveService.TabIndex = 4;
            this._btnSaveService.Text = "Добавить";
            this._btnSaveService.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание";
            // 
            // _txtDesscribe
            // 
            this._txtDesscribe.Location = new System.Drawing.Point(31, 111);
            this._txtDesscribe.Multiline = true;
            this._txtDesscribe.Name = "_txtDesscribe";
            this._txtDesscribe.Size = new System.Drawing.Size(234, 98);
            this._txtDesscribe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // _txtNameService
            // 
            this._txtNameService.Location = new System.Drawing.Point(31, 58);
            this._txtNameService.Name = "_txtNameService";
            this._txtNameService.Size = new System.Drawing.Size(234, 20);
            this._txtNameService.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2019, 2, 24, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Дата начало и конец";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(32, 274);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.Value = new System.DateTime(2019, 2, 24, 0, 0, 0, 0);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServiceForm";
            this.Text = "Категория услуг";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._listOfDoctors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView _objectListViewService;
        private BrightIdeasSoftware.ObjectListView _listOfDoctors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnUpdateService;
        private System.Windows.Forms.Button _btnDeleteService;
        private System.Windows.Forms.Button _btnSaveService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtDesscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtNameService;
        private BrightIdeasSoftware.OLVColumn _olvColumnName;
        private BrightIdeasSoftware.OLVColumn _olvColumnDesscribe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}