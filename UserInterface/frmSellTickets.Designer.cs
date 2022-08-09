namespace UserInterface
{
    partial class frmSellTickets
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
            this.dataGridViewSellTickets = new System.Windows.Forms.DataGridView();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.lblSellTicketMovie = new System.Windows.Forms.Label();
            this.cBoxSellTicketMovies = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSellTickets
            // 
            this.dataGridViewSellTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSellTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSellTickets.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSellTickets.Name = "dataGridViewSellTickets";
            this.dataGridViewSellTickets.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewSellTickets.TabIndex = 0;
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(398, 233);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(80, 13);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "Name Surname";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(484, 230);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(100, 20);
            this.txtNameSurname.TabIndex = 3;
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellTicket.Location = new System.Drawing.Point(401, 290);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(183, 51);
            this.btnSellTicket.TabIndex = 4;
            this.btnSellTicket.Text = "Sell Ticket";
            this.btnSellTicket.UseVisualStyleBackColor = false;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // lblSellTicketMovie
            // 
            this.lblSellTicketMovie.AutoSize = true;
            this.lblSellTicketMovie.Location = new System.Drawing.Point(17, 233);
            this.lblSellTicketMovie.Name = "lblSellTicketMovie";
            this.lblSellTicketMovie.Size = new System.Drawing.Size(36, 13);
            this.lblSellTicketMovie.TabIndex = 5;
            this.lblSellTicketMovie.Text = "Movie";
            // 
            // cBoxSellTicketMovies
            // 
            this.cBoxSellTicketMovies.FormattingEnabled = true;
            this.cBoxSellTicketMovies.Location = new System.Drawing.Point(85, 230);
            this.cBoxSellTicketMovies.Name = "cBoxSellTicketMovies";
            this.cBoxSellTicketMovies.Size = new System.Drawing.Size(243, 21);
            this.cBoxSellTicketMovies.TabIndex = 6;
            // 
            // frmSellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.cBoxSellTicketMovies);
            this.Controls.Add(this.lblSellTicketMovie);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.dataGridViewSellTickets);
            this.Name = "frmSellTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellTickets";
            this.Load += new System.EventHandler(this.frmSellTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSellTickets;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Label lblSellTicketMovie;
        private System.Windows.Forms.ComboBox cBoxSellTicketMovies;
    }
}