using BusinessLogicLayer.Manager;
using EntityLayer.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class frmSellTickets : Form
    {
        PresentationManager presentationManager = new PresentationManager();
        SellTicketManager sellTicketManager = new SellTicketManager();
        public frmSellTickets()
        {
            InitializeComponent();
        }

        private void frmSellTickets_Load(object sender, EventArgs e)
        {
            GetAllSellTickets();
            GetMovieInfoToComboBox();
            ColumnVisibleProcess();
        }
        void GetMovieInfoToComboBox()
        {
            cBoxSellTicketMovies.DisplayMember = "Movie Saloon Session";
            cBoxSellTicketMovies.ValueMember = "Id";
            cBoxSellTicketMovies.DataSource = presentationManager.GetEnablePresentation();
        }
        void GetAllSellTickets()
        {
            dataGridViewSellTickets.DataSource = null;
            dataGridViewSellTickets.DataSource = sellTicketManager.GetAllSellTickets();
        }
        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            try
            {
                SellTicket sellTicket = new SellTicket()
                {
                    CustomerNameSurname = txtNameSurname.Text,
                    PresentationId = Convert.ToInt32(cBoxSellTicketMovies.SelectedValue)
                };
                sellTicketManager.AddNewSellTicket(sellTicket);
                MessageBox.Show("Okey");
                GetAllSellTickets();
                ColumnVisibleProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void ColumnVisibleProcess()
        {
            dataGridViewSellTickets.Columns[0].Visible = false;
            dataGridViewSellTickets.Columns[3].Visible = false;
        }
    }
}
