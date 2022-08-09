using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            frmAddFilm addFilm = new frmAddFilm();
            addFilm.Show();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            frmAddSession addSession = new frmAddSession();
            addSession.Show();
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            frmAddSaloon addSaloon = new frmAddSaloon();
            addSaloon.Show();
        }

        private void btnSellTickets_Click(object sender, EventArgs e)
        {
            frmSellTickets sellTickets = new frmSellTickets();
            sellTickets.Show();
        }

        private void btnPresentation_Click(object sender, EventArgs e)
        {
            frmAddPresentation frmAddPresentation = new frmAddPresentation();
            frmAddPresentation.Show();
        }
    }
}
