using BusinessLogicLayer.Manager;
using EntityLayer.Entities;
using System;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class frmAddSaloon : Form
    {
        SaloonManager saloonManager = new SaloonManager();
        public frmAddSaloon()
        {
            InitializeComponent();
        }
        private void frmAddSaloon_Load(object sender, EventArgs e)
        {
            GetAllSaloons();
            ColumnVisibleProcess();
        }
        private void btnAddMovieSaloon_Click(object sender, EventArgs e)
        {
            try
            {
                Saloon saloon = new Saloon()
                {
                    SaloonNo = txtAddMovieSaloon.Text,
                    SeatNo = Convert.ToInt32(txtSeatNo.Text)
                };
                saloonManager.AddSaloon(saloon);
                MessageBox.Show("Added");
            }
            catch (Exception)
            {

                throw;
            }
        }
        void GetAllSaloons()
        {
            dataGridViewSaloons.DataSource = saloonManager.GetAllSaloon();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewSaloons.Columns[2].Visible = false;
        }
    }
}
