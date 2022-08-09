using BusinessLogicLayer.Manager;
using EntityLayer.Entities;
using System;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class frmAddFilm : Form
    {
        MovieManager movieManager = new MovieManager();
        MovieTypeManager movieTypeManager = new MovieTypeManager();
        public frmAddFilm()
        {
            InitializeComponent();
        }
        private void frmAddFilm_Load(object sender, EventArgs e)
        {
            GetAllMovieTypesToGrid();
            GetMovieTypeIdAndMovieNameToCombo();
            ColumnVisibleProcess();
        }
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                Movie a = new Movie()
                {
                    MovieName = txtMovieName.Text,
                    Director = txtDirector.Text,
                    Duration = Convert.ToInt32(txtDuration.Text),
                    MovieTypeId = Convert.ToByte(cBoxMovieType.SelectedValue)
                };
                movieManager.AddNewMovie(a);
                MessageBox.Show("Added");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnAddMovieType_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddMovieType.Text == "")
                {
                    MessageBox.Show("Movie Type must not be empty!");
                }
                else
                {
                    MovieType a = new MovieType()
                    {
                        MovieTypeName = txtAddMovieType.Text
                    };
                    movieTypeManager.AddNewMovieType(a);
                    MessageBox.Show("Added");
                    ClearMovieTypeText();
                    GetAllMovieTypesToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GetAllMovieTypesToGrid()
        {
            try
            {
                dataGridViewMovieTypes.DataSource = movieTypeManager.GetAllMovieTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GetMovieTypeIdAndMovieNameToCombo()
        {
            cBoxMovieType.DisplayMember = "MovieTypeName";
            cBoxMovieType.ValueMember = "Id";
            cBoxMovieType.DataSource = movieTypeManager.GetAllMovieTypes();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewMovieTypes.Columns[1].Visible = false;
        }
        void ClearMovieTypeText()
        {
            txtAddMovieType.Clear();
        }
    }
}
