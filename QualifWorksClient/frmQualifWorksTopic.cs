using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace QualifWorksClient
{
    public partial class frmQualifWorksTopic : Form
    {
        public frmQualifWorksTopic()
        {
            InitializeComponent();
            cboLevel.DataSource = QualifLevel.Levels;
            cboLevel.DisplayMember = QualifLevel.DisplayMember;
            cboLevel.ValueMember = QualifLevel.ValueMember;
            taSupervisorName.Fill(dsDataModel.SupervisorName);
        }

        public void AddNew()
        {
            // aktivizē jauna raksta pievienošanu
            bsQualifWorks.AddNew();
        }

        public void Edit(int topicId)
        {
            // aktivizē esoša raksta labošanu
            taQualifWorks.FillByTopicID(dsDataModel.QualifWorks, topicId);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            errorProvider.Clear();
            if (String.IsNullOrEmpty(cboSupervisor.Text))
            {
                errorProvider.SetError(cboSupervisor, "Vadītājs nedrīkst būt tukšs!");
                return;
            }
            if (String.IsNullOrEmpty(cboLevel.Text))
            {
                errorProvider.SetError(cboLevel, "Minimālais studiju līmenis nedrīkst būt tukšs!");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtTopic.Text))
            {
                errorProvider.SetError(txtTopic, "Tēma nedrīkst būt tukša!");
                return;
            }

            try
            {
                bsQualifWorks.EndEdit();
                taQualifWorks.Update(dsDataModel.QualifWorks);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK
                , MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsQualifWorks.CancelEdit();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
