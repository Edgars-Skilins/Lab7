namespace QualifWorksClient
{
    partial class frmStudent
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
            this.components = new System.ComponentModel.Container();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataModel = new DataModel.DataModelDataSet();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblTopicSupervisor = new System.Windows.Forms.Label();
            this.lblSelectedTopic = new System.Windows.Forms.Label();
            this.cboSelectedTopic = new System.Windows.Forms.ComboBox();
            this.bsQualifWorks = new System.Windows.Forms.BindingSource(this.components);
            this.lblReviewer = new System.Windows.Forms.Label();
            this.cboReviewer = new System.Windows.Forms.ComboBox();
            this.bsReviewers = new System.Windows.Forms.BindingSource(this.components);
            this.chkDues = new System.Windows.Forms.CheckBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTopicSupervisorName = new System.Windows.Forms.Label();
            this.taStudents = new DataModel.DataModelDataSetTableAdapters.StudentsTableAdapter();
            this.taQualifWorks = new DataModel.DataModelDataSetTableAdapters.QualifWorksTableAdapter();
            this.taSupervisorName = new DataModel.DataModelDataSetTableAdapters.SupervisorNameTableAdapter();
            this.cboStudyLevel = new System.Windows.Forms.ComboBox();
            this.lblStudyLevel = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.MaskedTextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualifWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReviewers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(36, 11);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(37, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Vārds:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "Name", true));
            this.txtStudentName.Location = new System.Drawing.Point(79, 8);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(116, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // bsStudents
            // 
            this.bsStudents.DataMember = "Students";
            this.bsStudents.DataSource = this.dsDataModel;
            // 
            // dsDataModel
            // 
            this.dsDataModel.DataSetName = "DataModelDataSet";
            this.dsDataModel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(243, 11);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(49, 13);
            this.lblStudentSurname.TabIndex = 2;
            this.lblStudentSurname.Text = "Uzvārds:";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "Surname", true));
            this.txtStudentSurname.Location = new System.Drawing.Point(298, 8);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(140, 20);
            this.txtStudentSurname.TabIndex = 3;
            // 
            // lblTopicSupervisor
            // 
            this.lblTopicSupervisor.AutoSize = true;
            this.lblTopicSupervisor.Location = new System.Drawing.Point(25, 94);
            this.lblTopicSupervisor.Name = "lblTopicSupervisor";
            this.lblTopicSupervisor.Size = new System.Drawing.Size(48, 13);
            this.lblTopicSupervisor.TabIndex = 10;
            this.lblTopicSupervisor.Text = "Vadītājs:";
            // 
            // lblSelectedTopic
            // 
            this.lblSelectedTopic.AutoSize = true;
            this.lblSelectedTopic.Location = new System.Drawing.Point(36, 64);
            this.lblSelectedTopic.Name = "lblSelectedTopic";
            this.lblSelectedTopic.Size = new System.Drawing.Size(37, 13);
            this.lblSelectedTopic.TabIndex = 8;
            this.lblSelectedTopic.Text = "Tēma:";
            // 
            // cboSelectedTopic
            // 
            this.cboSelectedTopic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsStudents, "TopicID", true));
            this.cboSelectedTopic.DataSource = this.bsQualifWorks;
            this.cboSelectedTopic.DisplayMember = "Topic";
            this.cboSelectedTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedTopic.FormattingEnabled = true;
            this.cboSelectedTopic.Location = new System.Drawing.Point(79, 61);
            this.cboSelectedTopic.Name = "cboSelectedTopic";
            this.cboSelectedTopic.Size = new System.Drawing.Size(519, 21);
            this.cboSelectedTopic.TabIndex = 9;
            this.cboSelectedTopic.ValueMember = "TopicID";
            this.cboSelectedTopic.SelectedValueChanged += new System.EventHandler(this.cboSelectedTopic_SelectedValueChanged);
            // 
            // bsQualifWorks
            // 
            this.bsQualifWorks.AllowNew = false;
            this.bsQualifWorks.DataMember = "QualifWorks";
            this.bsQualifWorks.DataSource = this.dsDataModel;
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Location = new System.Drawing.Point(6, 120);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(67, 13);
            this.lblReviewer.TabIndex = 12;
            this.lblReviewer.Text = "Recenzents:";
            // 
            // cboReviewer
            // 
            this.cboReviewer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsStudents, "ReviewerID", true));
            this.cboReviewer.DataSource = this.bsReviewers;
            this.cboReviewer.DisplayMember = "Supervisor";
            this.cboReviewer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReviewer.FormattingEnabled = true;
            this.cboReviewer.Location = new System.Drawing.Point(79, 117);
            this.cboReviewer.Name = "cboReviewer";
            this.cboReviewer.Size = new System.Drawing.Size(186, 21);
            this.cboReviewer.TabIndex = 13;
            this.cboReviewer.ValueMember = "SupervisorID";
            // 
            // bsReviewers
            // 
            this.bsReviewers.AllowNew = false;
            this.bsReviewers.DataMember = "SupervisorName";
            this.bsReviewers.DataSource = this.dsDataModel;
            // 
            // chkDues
            // 
            this.chkDues.AutoSize = true;
            this.chkDues.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsStudents, "Dues", true));
            this.chkDues.Location = new System.Drawing.Point(77, 151);
            this.chkDues.Name = "chkDues";
            this.chkDues.Size = new System.Drawing.Size(118, 17);
            this.chkDues.TabIndex = 14;
            this.chkDues.Text = "Akadēmiskie parādi";
            this.chkDues.UseVisualStyleBackColor = true;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(300, 94);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 13);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Piezīmes:";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(298, 109);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(300, 73);
            this.txtNotes.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(307, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Atcelt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(226, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Labi";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTopicSupervisorName
            // 
            this.lblTopicSupervisorName.AutoSize = true;
            this.lblTopicSupervisorName.Location = new System.Drawing.Point(79, 94);
            this.lblTopicSupervisorName.Name = "lblTopicSupervisorName";
            this.lblTopicSupervisorName.Size = new System.Drawing.Size(102, 13);
            this.lblTopicSupervisorName.TabIndex = 11;
            this.lblTopicSupervisorName.Text = "<nav izvēlēta tēma>";
            // 
            // taStudents
            // 
            this.taStudents.ClearBeforeFill = true;
            // 
            // taQualifWorks
            // 
            this.taQualifWorks.ClearBeforeFill = true;
            // 
            // taSupervisorName
            // 
            this.taSupervisorName.ClearBeforeFill = true;
            // 
            // cboStudyLevel
            // 
            this.cboStudyLevel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsStudents, "Level", true));
            this.cboStudyLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudyLevel.FormattingEnabled = true;
            this.cboStudyLevel.Location = new System.Drawing.Point(298, 34);
            this.cboStudyLevel.Name = "cboStudyLevel";
            this.cboStudyLevel.Size = new System.Drawing.Size(84, 21);
            this.cboStudyLevel.TabIndex = 7;
            // 
            // lblStudyLevel
            // 
            this.lblStudyLevel.AutoSize = true;
            this.lblStudyLevel.Location = new System.Drawing.Point(215, 37);
            this.lblStudyLevel.Name = "lblStudyLevel";
            this.lblStudyLevel.Size = new System.Drawing.Size(77, 13);
            this.lblStudyLevel.TabIndex = 6;
            this.lblStudyLevel.Text = "Studiju līmenis:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "IDCard", true));
            this.txtStudentId.Location = new System.Drawing.Point(79, 34);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(116, 20);
            this.txtStudentId.TabIndex = 5;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(36, 37);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(40, 13);
            this.lblStudentId.TabIndex = 4;
            this.lblStudentId.Text = "Apl.nr.:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmStudent
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(610, 230);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.cboStudyLevel);
            this.Controls.Add(this.lblStudyLevel);
            this.Controls.Add(this.lblTopicSupervisorName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.chkDues);
            this.Controls.Add(this.cboReviewer);
            this.Controls.Add(this.lblReviewer);
            this.Controls.Add(this.cboSelectedTopic);
            this.Controls.Add(this.lblSelectedTopic);
            this.Controls.Add(this.lblTopicSupervisor);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmStudent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualifWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReviewers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataModel.DataModelDataSetTableAdapters.StudentsTableAdapter taStudents;
        private DataModel.DataModelDataSetTableAdapters.QualifWorksTableAdapter taQualifWorks;
        private DataModel.DataModelDataSet dsDataModel;
        private System.Windows.Forms.BindingSource bsStudents;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label lblTopicSupervisor;
        private System.Windows.Forms.BindingSource bsQualifWorks;
        private System.Windows.Forms.Label lblSelectedTopic;
        private System.Windows.Forms.ComboBox cboSelectedTopic;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.ComboBox cboReviewer;
        private System.Windows.Forms.CheckBox chkDues;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private DataModel.DataModelDataSetTableAdapters.SupervisorNameTableAdapter taSupervisorName;
        private System.Windows.Forms.BindingSource bsReviewers;
        private System.Windows.Forms.Label lblTopicSupervisorName;
        private System.Windows.Forms.ComboBox cboStudyLevel;
        private System.Windows.Forms.Label lblStudyLevel;
        private System.Windows.Forms.MaskedTextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}