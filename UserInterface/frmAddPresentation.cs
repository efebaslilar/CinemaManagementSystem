using BusinessLogicLayer.Manager;
using EntityLayer.Entities;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class frmAddPresentation : Form
    {
        PresentationManager presentationManager = new PresentationManager();
        MovieManager movieManager = new MovieManager();
        SessionManager sessionManager = new SessionManager();
        SaloonManager saloonManager = new SaloonManager();
        public frmAddPresentation()
        {
            InitializeComponent();
        }
        private void frmAddPresentation_Load(object sender, EventArgs e)
        {
            GetAllPresentations();
            GetMovieIdAndNameToComboBox();
            GetSessionIdAndNameToComboBox();
            GetSaloonIdAndNameToComboBox();
            ColumnVisible();
        }
        private void btnAddPresent_Click(object sender, EventArgs e)
        {
            try
            {
                Presentation presentation = new Presentation()
                {
                    IsPresentation = true,
                    MovieId = Convert.ToInt32(cBoxAddPresentationMovieName.SelectedValue),
                    SaloonId = Convert.ToByte(cBoxAddPresentationSaloon.SelectedValue),
                    SessionId = Convert.ToByte(cBoxAddPresentationSession.SelectedValue)
                };
                presentationManager.AddPresentation(presentation);
                MessageBox.Show("Added");
                GetAllPresentations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void endPresentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddPresentation.SelectedRows.Count > 0)
            {
                int _id = Convert.ToInt32(dataGridViewAddPresentation.SelectedRows[0].Cells["Id"].Value.ToString());
                presentationManager.DoEnableFalse(_id);
                GetAllPresentations();
            }
        }
        private void openPresentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddPresentation.SelectedRows.Count > 0)
            {
                int _id = Convert.ToInt32(dataGridViewAddPresentation.SelectedRows[0].Cells["Id"].Value.ToString());
                presentationManager.DoEnableTrue(_id);
                GetAllPresentations();
            }
        }
        void GetMovieIdAndNameToComboBox()
        {
            cBoxAddPresentationMovieName.DisplayMember = "MovieName";
            cBoxAddPresentationMovieName.ValueMember = "Id";
            cBoxAddPresentationMovieName.DataSource = movieManager.GetAllMovies();
        }
        void GetSessionIdAndNameToComboBox()
        {
            cBoxAddPresentationSession.DisplayMember = "MovieSession";
            cBoxAddPresentationSession.ValueMember = "Id";
            cBoxAddPresentationSession.DataSource = sessionManager.GetAllSessions();
        }
        void GetSaloonIdAndNameToComboBox()
        {
            cBoxAddPresentationSaloon.DisplayMember = "SaloonNo";
            cBoxAddPresentationSaloon.ValueMember = "Id";
            cBoxAddPresentationSaloon.DataSource = saloonManager.GetAllSaloon();
        }
        void GetAllPresentations()
        {
            dataGridViewAddPresentation.DataSource = presentationManager.GetAllPresentations();
        }
        void ColumnVisible()
        {
            dataGridViewAddPresentation.Columns[1].Visible = false;
            dataGridViewAddPresentation.Columns[2].Visible = false;
            dataGridViewAddPresentation.Columns[3].Visible = false;
            dataGridViewAddPresentation.Columns[7].Visible = false;
        }
    }
}
