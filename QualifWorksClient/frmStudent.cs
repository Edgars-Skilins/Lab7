using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DataModel;

namespace QualifWorksClient
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

            taSupervisorName.Fill(dsDataModel.SupervisorName);
            taQualifWorks.Fill(dsDataModel.QualifWorks);

            cboStudyLevel.DataSource = QualifLevel.Levels;
            cboStudyLevel.DisplayMember = QualifLevel.DisplayMember;
            cboStudyLevel.ValueMember = QualifLevel.ValueMember;
        }

        public void AddNew()
        {
            bsStudents.AddNew();
        }

        public void Edit(int studentId)
        {
            taStudents.FillByStudentID(dsDataModel.Students, studentId);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                errorProvider.SetError(txtStudentName, "Studenta vārds nedrīkst būt tukšs!");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtStudentSurname.Text))
            {
                errorProvider.SetError(txtStudentSurname, "Studenta uzvārds nedrīkst būt tukšs!");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider.SetError(txtStudentId, "Studenta apliecības numurs nedrīkst būt tukšs!");
                return;
            }
            if (txtStudentId.Text.Length != 9)
            {
                errorProvider.SetError(txtStudentId, "Studenta apliecības numuram jāsastāv no 9 cipariem!");
                return;
            }
            if (!int.TryParse(txtStudentId.Text.Substring(0,3), out int tempInt) 
                || !txtStudentId.Text.Substring(3, 3).All(Char.IsLetter) 
                || !int.TryParse(txtStudentId.Text.Substring(6, 3), out tempInt))
            {
                errorProvider.SetError(txtStudentId, "Studenta apliecības numuram jāsastāv no pirmajiem 3 cipariem, 3 burtiem un jābeidzas ar 3 cipariem!");
                return;
            }
            if (String.IsNullOrEmpty(cboStudyLevel.Text))
            {
                errorProvider.SetError(cboStudyLevel, "Studiju līmenis nedrīkst būt tukšs!");
                return;
            }

            try
            {
                bsStudents.EndEdit();
                taStudents.Update(dsDataModel.Students);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsStudents.CancelEdit();
            DialogResult = DialogResult.Cancel;
        }

        private void cboSelectedTopic_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSelectedTopic.SelectedIndex != -1)
            {
                object str = taSupervisorName.GetSupervisorNameBy((int)cboSelectedTopic.SelectedValue);
                lblTopicSupervisorName.Text = (string)str ?? "<Vadītājs tēmai netika atrasts!>";
            }
            else
                lblTopicSupervisorName.Text = "<nav izvēlēta tēma>";
        }
    }
}
