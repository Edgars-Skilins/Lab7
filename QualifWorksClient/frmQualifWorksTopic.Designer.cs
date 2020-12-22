namespace QualifWorksClient
{
    partial class frmQualifWorksTopic
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
            this.dsDataModel = new DataModel.DataModelDataSet();
            this.taQualifWorks = new DataModel.DataModelDataSetTableAdapters.QualifWorksTableAdapter();
            this.taSupervisorName = new DataModel.DataModelDataSetTableAdapters.SupervisorNameTableAdapter();
            this.bsQualifWorks = new System.Windows.Forms.BindingSource(this.components);
            this.bsSupervisorName = new System.Windows.Forms.BindingSource(this.components);
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.cboSupervisor = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDataModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualifWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupervisorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDataModel
            // 
            this.dsDataModel.DataSetName = "DataModelDataSet";
            this.dsDataModel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taQualifWorks
            // 
            this.taQualifWorks.ClearBeforeFill = true;
            // 
            // taSupervisorName
            // 
            this.taSupervisorName.ClearBeforeFill = true;
            // 
            // bsQualifWorks
            // 
            this.bsQualifWorks.DataMember = "QualifWorks";
            this.bsQualifWorks.DataSource = this.dsDataModel;
            // 
            // bsSupervisorName
            // 
            this.bsSupervisorName.AllowNew = false;
            this.bsSupervisorName.DataMember = "SupervisorName";
            this.bsSupervisorName.DataSource = this.dsDataModel;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(12, 15);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(48, 13);
            this.lblSupervisor.TabIndex = 0;
            this.lblSupervisor.Text = "Vadītājs:";
            // 
            // cboSupervisor
            // 
            this.cboSupervisor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsQualifWorks, "SupervisorID", true));
            this.cboSupervisor.DataSource = this.bsSupervisorName;
            this.cboSupervisor.DisplayMember = "Supervisor";
            this.cboSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupervisor.FormattingEnabled = true;
            this.cboSupervisor.Location = new System.Drawing.Point(66, 12);
            this.cboSupervisor.Name = "cboSupervisor";
            this.cboSupervisor.Size = new System.Drawing.Size(191, 21);
            this.cboSupervisor.TabIndex = 1;
            this.cboSupervisor.ValueMember = "SupervisorID";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(275, 15);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(77, 13);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Studiju līmenis:";
            // 
            // cboLevel
            // 
            this.cboLevel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsQualifWorks, "Level", true));
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(358, 12);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(84, 21);
            this.cboLevel.TabIndex = 3;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(23, 42);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(37, 13);
            this.lblTopic.TabIndex = 4;
            this.lblTopic.Text = "Tēma:";
            // 
            // txtTopic
            // 
            this.txtTopic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQualifWorks, "Topic", true));
            this.txtTopic.Location = new System.Drawing.Point(66, 39);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(376, 20);
            this.txtTopic.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(160, 65);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Labi";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Atcelt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmQualifWorksTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 90);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cboSupervisor);
            this.Controls.Add(this.lblSupervisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQualifWorksTopic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Noslēguma darba tēma";
            ((System.ComponentModel.ISupportInitialize)(this.dsDataModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualifWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupervisorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataModel.DataModelDataSet dsDataModel;
        private DataModel.DataModelDataSetTableAdapters.QualifWorksTableAdapter taQualifWorks;
        private DataModel.DataModelDataSetTableAdapters.SupervisorNameTableAdapter taSupervisorName;
        private System.Windows.Forms.BindingSource bsQualifWorks;
        private System.Windows.Forms.BindingSource bsSupervisorName;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.ComboBox cboSupervisor;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}