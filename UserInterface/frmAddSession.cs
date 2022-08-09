using BusinessLogicLayer.Manager;
using EntityLayer.Entities;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class frmAddSession : Form
    {
        SessionManager sessionManager = new SessionManager();
        public frmAddSession()
        {
            InitializeComponent();
        }
        private void frmAddSession_Load(object sender, EventArgs e)
        {
            GetAllSessions();
            ColumnVisibleProcess();
        }
        private void btnAddMovieSession_Click(object sender, EventArgs e)
        {
            try
            {
                Session session = new Session()
                {
                    MovieSession = txtAddMovieSession.Text
                };
                sessionManager.AddSession(session);
                MessageBox.Show("Added");
                ClearSessionText();
                GetAllSessions();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void GetAllSessions()
        {
            dataGridViewSession.DataSource = sessionManager.GetAllSessions();
        }
        void ClearSessionText()
        {
            txtAddMovieSession.Clear();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewSession.Columns[1].Visible = false;
        }
    }
}
