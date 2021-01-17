using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel.DataModelDataSetTableAdapters;

namespace WebApp
{
    public partial class TopicSelection : System.Web.UI.Page
    {
        // Pirmā soļa - tēmu saraksta skata sagavatošana rādīšanai
        private void SetupView0()
        {
            // uzstāda pārlūka lapā rādāmo View kontroli
            mvTopicSelection.SetActiveView(vwTopicSelection);
            btnNext.Visible = true;
            // ļaut turpināt tikai tad, kad ir izvēlēta tēma
            btnNext.Enabled = gvTopicSelection.SelectedIndex != -1;
            btnBack.Visible = btnReserve.Visible = false;
        }

        // Otrā soļa - studenta datu skata sagavatošana rādīšanai
        private void SetupView1()
        {
            mvTopicSelection.SetActiveView(vwStudentData);
            lblTopic.Text = "Tēma : " + "\"" + gvTopicSelection.SelectedRow.Cells[1].Text + "\"";
            lblSupervisor.Text = "Vadītājs : " + gvTopicSelection.SelectedRow.Cells[0].Text;
            btnNext.Visible = false;
            btnBack.Visible = btnReserve.Visible = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // atverot lapu, pēc noklusēšanas tiek rādīts pirmais solis:
            SetupView0();
            if (!btnNext.Enabled)
                lblStatus.Text = "Lai turpinātu, izvēlieties sev vēlamo studiju līmeni un noslēguma darba tēmu.";
        }

        protected void gvTopicSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = (gvTopicSelection.SelectedIndex != -1);
            if (btnNext.Enabled)
                lblStatus.Text = "";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            SetupView0();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            SetupView1();
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            // izmantojot noģenerētās klases, piekļūt tabulas Students datiem
            var taStudents = new StudentsTableAdapter();
            var tblStudents
            = new DataModel.DataModelDataSet.StudentsDataTable();
            bool userHasNotReservedBefore = true;

            try
            {
                var testvariable = taStudents.GetData().First(r => r.IDCard == txtStudentID.Text);
                MsgBox("Studentam jau ir rezervēta tēma",this.Page, this);
                userHasNotReservedBefore = false;
            }
            catch { }

            if (String.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                valStudentID.IsValid = false;
            }
            if (!IsValid || !userHasNotReservedBefore) // Ja formas lauki nav veiksmīgi validēti,
                SetupView1(); // tad paliek otrajā solī.
            else try
                {                    
                    // izveido jaunu raksta instanci
                    var newRow = tblStudents.NewStudentsRow();
                    // uzstāda jaunā raksta vērtības
                    newRow.Name = txtStudentName.Text;
                    newRow.Surname = txtStudentSurname.Text;
                    newRow.IDCard = txtStudentID.Text;
                    newRow.Level = Convert.ToInt32(ddlQualifLevel.SelectedValue);
                    newRow.Notes = "Rezervēts no tīmekļa.";
                    newRow.TopicID = (int)gvTopicSelection.SelectedDataKey["TopicID"];
                    // pievieno raksta instanci lokālajai datu kešatmiņai
                    tblStudents.AddStudentsRow(newRow);
                    // aktualizē izmaiņas datu bāzē
                    taStudents.Update(tblStudents);
                    // aktualizē tēmu saraksta tabulas datus tīmekļā lapā
                    gvTopicSelection.DataBind();
                    // uzstāda informāciju lietotājam par veiksmīgu pievienošanu
                    lblStatus.Text = "Paldies, tēmas rezervēšana bija veiksmīga!";
                    // inicializē laukus, sagatavojot jaunas tēmas ievadīšanai
                    txtStudentName.Text = txtStudentSurname.Text = "";
                    gvTopicSelection.SelectedIndex = -1;
                    SetupView0(); // lai pārietu uz pirmo soli
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                    SetupView1(); // lai paliktu otrajā solī
                }

        }

        private void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}
