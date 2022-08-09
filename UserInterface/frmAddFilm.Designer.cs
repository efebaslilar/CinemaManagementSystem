namespace UserInterface
{
    partial class frmAddFilm
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
            this.tabPageMovieType = new System.Windows.Forms.TabPage();
            this.dataGridViewMovieTypes = new System.Windows.Forms.DataGridView();
            this.btnAddMovieType = new System.Windows.Forms.Button();
            this.txtAddMovieType = new System.Windows.Forms.TextBox();
            this.lblAddMovieType = new System.Windows.Forms.Label();
            this.tabPageAddMovies = new System.Windows.Forms.TabPage();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.cBoxMovieType = new System.Windows.Forms.ComboBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblTypeOfMovie = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblAddMovies = new System.Windows.Forms.Label();
            this.tabControlMovieType = new System.Windows.Forms.TabControl();
            this.tabPageMovieType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieTypes)).BeginInit();
            this.tabPageAddMovies.SuspendLayout();
            this.tabControlMovieType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMovieType
            // 
            this.tabPageMovieType.Controls.Add(this.dataGridViewMovieTypes);
            this.tabPageMovieType.Controls.Add(this.btnAddMovieType);
            this.tabPageMovieType.Controls.Add(this.txtAddMovieType);
            this.tabPageMovieType.Controls.Add(this.lblAddMovieType);
            this.tabPageMovieType.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovieType.Name = "tabPageMovieType";
            this.tabPageMovieType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovieType.Size = new System.Drawing.Size(491, 368);
            this.tabPageMovieType.TabIndex = 1;
            this.tabPageMovieType.Text = "Add  Movie Type";
            this.tabPageMovieType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMovieTypes
            // 
            this.dataGridViewMovieTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovieTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieTypes.Location = new System.Drawing.Point(8, 209);
            this.dataGridViewMovieTypes.Name = "dataGridViewMovieTypes";
            this.dataGridViewMovieTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovieTypes.Size = new System.Drawing.Size(475, 151);
            this.dataGridViewMovieTypes.TabIndex = 3;
            // 
            // btnAddMovieType
            // 
            this.btnAddMovieType.BackColor = System.Drawing.Color.White;
            this.btnAddMovieType.Location = new System.Drawing.Point(307, 96);
            this.btnAddMovieType.Name = "btnAddMovieType";
            this.btnAddMovieType.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovieType.TabIndex = 2;
            this.btnAddMovieType.Text = "Add";
            this.btnAddMovieType.UseVisualStyleBackColor = false;
            this.btnAddMovieType.Click += new System.EventHandler(this.btnAddMovieType_Click);
            // 
            // txtAddMovieType
            // 
            this.txtAddMovieType.Location = new System.Drawing.Point(168, 98);
            this.txtAddMovieType.Name = "txtAddMovieType";
            this.txtAddMovieType.Size = new System.Drawing.Size(100, 20);
            this.txtAddMovieType.TabIndex = 1;
            // 
            // lblAddMovieType
            // 
            this.lblAddMovieType.AutoSize = true;
            this.lblAddMovieType.Location = new System.Drawing.Point(86, 101);
            this.lblAddMovieType.Name = "lblAddMovieType";
            this.lblAddMovieType.Size = new System.Drawing.Size(63, 13);
            this.lblAddMovieType.TabIndex = 0;
            this.lblAddMovieType.Text = "Movie Type";
            // 
            // tabPageAddMovies
            // 
            this.tabPageAddMovies.Controls.Add(this.txtDuration);
            this.tabPageAddMovies.Controls.Add(this.txtDirector);
            this.tabPageAddMovies.Controls.Add(this.cBoxMovieType);
            this.tabPageAddMovies.Controls.Add(this.txtMovieName);
            this.tabPageAddMovies.Controls.Add(this.btnAddMovie);
            this.tabPageAddMovies.Controls.Add(this.lblDuration);
            this.tabPageAddMovies.Controls.Add(this.lblDirector);
            this.tabPageAddMovies.Controls.Add(this.lblTypeOfMovie);
            this.tabPageAddMovies.Controls.Add(this.lblMovieName);
            this.tabPageAddMovies.Controls.Add(this.lblAddMovies);
            this.tabPageAddMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddMovies.Name = "tabPageAddMovies";
            this.tabPageAddMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddMovies.Size = new System.Drawing.Size(491, 368);
            this.tabPageAddMovies.TabIndex = 0;
            this.tabPageAddMovies.Text = "Add Movie";
            this.tabPageAddMovies.UseVisualStyleBackColor = true;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(224, 223);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(117, 20);
            this.txtDuration.TabIndex = 17;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(224, 183);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(117, 20);
            this.txtDirector.TabIndex = 16;
            // 
            // cBoxMovieType
            // 
            this.cBoxMovieType.FormattingEnabled = true;
            this.cBoxMovieType.Location = new System.Drawing.Point(224, 144);
            this.cBoxMovieType.Name = "cBoxMovieType";
            this.cBoxMovieType.Size = new System.Drawing.Size(117, 21);
            this.cBoxMovieType.TabIndex = 15;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(224, 106);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(117, 20);
            this.txtMovieName.TabIndex = 14;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(121, 283);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(220, 63);
            this.btnAddMovie.TabIndex = 13;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(118, 223);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(118, 184);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "Director";
            // 
            // lblTypeOfMovie
            // 
            this.lblTypeOfMovie.AutoSize = true;
            this.lblTypeOfMovie.Location = new System.Drawing.Point(118, 145);
            this.lblTypeOfMovie.Name = "lblTypeOfMovie";
            this.lblTypeOfMovie.Size = new System.Drawing.Size(63, 13);
            this.lblTypeOfMovie.TabIndex = 10;
            this.lblTypeOfMovie.Text = "Movie Type";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(118, 106);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(67, 13);
            this.lblMovieName.TabIndex = 11;
            this.lblMovieName.Text = "Movie Name";
            // 
            // lblAddMovies
            // 
            this.lblAddMovies.AutoSize = true;
            this.lblAddMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovies.Location = new System.Drawing.Point(165, 47);
            this.lblAddMovies.Name = "lblAddMovies";
            this.lblAddMovies.Size = new System.Drawing.Size(135, 25);
            this.lblAddMovies.TabIndex = 12;
            this.lblAddMovies.Text = "Add Movies";
            // 
            // tabControlMovieType
            // 
            this.tabControlMovieType.Controls.Add(this.tabPageAddMovies);
            this.tabControlMovieType.Controls.Add(this.tabPageMovieType);
            this.tabControlMovieType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMovieType.Location = new System.Drawing.Point(0, 0);
            this.tabControlMovieType.Name = "tabControlMovieType";
            this.tabControlMovieType.SelectedIndex = 0;
            this.tabControlMovieType.Size = new System.Drawing.Size(499, 394);
            this.tabControlMovieType.TabIndex = 8;
            // 
            // frmAddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(499, 394);
            this.Controls.Add(this.tabControlMovieType);
            this.Name = "frmAddFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFilm";
            this.Load += new System.EventHandler(this.frmAddFilm_Load);
            this.tabPageMovieType.ResumeLayout(false);
            this.tabPageMovieType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieTypes)).EndInit();
            this.tabPageAddMovies.ResumeLayout(false);
            this.tabPageAddMovies.PerformLayout();
            this.tabControlMovieType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageMovieType;
        private System.Windows.Forms.DataGridView dataGridViewMovieTypes;
        private System.Windows.Forms.Button btnAddMovieType;
        private System.Windows.Forms.TextBox txtAddMovieType;
        private System.Windows.Forms.Label lblAddMovieType;
        private System.Windows.Forms.TabPage tabPageAddMovies;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.ComboBox cBoxMovieType;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblTypeOfMovie;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblAddMovies;
        private System.Windows.Forms.TabControl tabControlMovieType;
    }
}