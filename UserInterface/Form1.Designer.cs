namespace UserInterface
{
    partial class Form1
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
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnSellTickets = new System.Windows.Forms.Button();
            this.btnAddSaloon = new System.Windows.Forms.Button();
            this.btnPresentation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilm.Location = new System.Drawing.Point(126, 100);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(140, 64);
            this.btnAddFilm.TabIndex = 0;
            this.btnAddFilm.Text = "Add Film";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSession.Location = new System.Drawing.Point(300, 100);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(140, 64);
            this.btnAddSession.TabIndex = 1;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnSellTickets
            // 
            this.btnSellTickets.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTickets.Location = new System.Drawing.Point(394, 226);
            this.btnSellTickets.Name = "btnSellTickets";
            this.btnSellTickets.Size = new System.Drawing.Size(216, 64);
            this.btnSellTickets.TabIndex = 4;
            this.btnSellTickets.Text = "Sell Tickets";
            this.btnSellTickets.UseVisualStyleBackColor = false;
            this.btnSellTickets.Click += new System.EventHandler(this.btnSellTickets_Click);
            // 
            // btnAddSaloon
            // 
            this.btnAddSaloon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSaloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSaloon.Location = new System.Drawing.Point(470, 100);
            this.btnAddSaloon.Name = "btnAddSaloon";
            this.btnAddSaloon.Size = new System.Drawing.Size(140, 64);
            this.btnAddSaloon.TabIndex = 2;
            this.btnAddSaloon.Text = "Add Saloon";
            this.btnAddSaloon.UseVisualStyleBackColor = false;
            this.btnAddSaloon.Click += new System.EventHandler(this.btnAddSaloon_Click);
            // 
            // btnPresentation
            // 
            this.btnPresentation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresentation.Location = new System.Drawing.Point(126, 226);
            this.btnPresentation.Name = "btnPresentation";
            this.btnPresentation.Size = new System.Drawing.Size(216, 64);
            this.btnPresentation.TabIndex = 3;
            this.btnPresentation.Text = "Presentation";
            this.btnPresentation.UseVisualStyleBackColor = false;
            this.btnPresentation.Click += new System.EventHandler(this.btnPresentation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(751, 395);
            this.Controls.Add(this.btnPresentation);
            this.Controls.Add(this.btnAddSaloon);
            this.Controls.Add(this.btnSellTickets);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.btnAddFilm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnSellTickets;
        private System.Windows.Forms.Button btnAddSaloon;
        private System.Windows.Forms.Button btnPresentation;
    }
}

