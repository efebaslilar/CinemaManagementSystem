namespace UserInterface
{
    partial class frmAddSaloon
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
            this.lblSaloon = new System.Windows.Forms.Label();
            this.txtAddMovieSaloon = new System.Windows.Forms.TextBox();
            this.dataGridViewSaloons = new System.Windows.Forms.DataGridView();
            this.btnAddMovieSaloon = new System.Windows.Forms.Button();
            this.lblSeatNo = new System.Windows.Forms.Label();
            this.txtSeatNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaloons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaloon
            // 
            this.lblSaloon.AutoSize = true;
            this.lblSaloon.Location = new System.Drawing.Point(91, 58);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(40, 13);
            this.lblSaloon.TabIndex = 0;
            this.lblSaloon.Text = "Saloon";
            // 
            // txtAddMovieSaloon
            // 
            this.txtAddMovieSaloon.Location = new System.Drawing.Point(146, 55);
            this.txtAddMovieSaloon.Name = "txtAddMovieSaloon";
            this.txtAddMovieSaloon.Size = new System.Drawing.Size(134, 20);
            this.txtAddMovieSaloon.TabIndex = 1;
            // 
            // dataGridViewSaloons
            // 
            this.dataGridViewSaloons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaloons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaloons.Location = new System.Drawing.Point(12, 153);
            this.dataGridViewSaloons.Name = "dataGridViewSaloons";
            this.dataGridViewSaloons.Size = new System.Drawing.Size(510, 151);
            this.dataGridViewSaloons.TabIndex = 2;
            // 
            // btnAddMovieSaloon
            // 
            this.btnAddMovieSaloon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMovieSaloon.Location = new System.Drawing.Point(318, 62);
            this.btnAddMovieSaloon.Name = "btnAddMovieSaloon";
            this.btnAddMovieSaloon.Size = new System.Drawing.Size(132, 49);
            this.btnAddMovieSaloon.TabIndex = 3;
            this.btnAddMovieSaloon.Text = "Add Saloon";
            this.btnAddMovieSaloon.UseVisualStyleBackColor = false;
            this.btnAddMovieSaloon.Click += new System.EventHandler(this.btnAddMovieSaloon_Click);
            // 
            // lblSeatNo
            // 
            this.lblSeatNo.AutoSize = true;
            this.lblSeatNo.Location = new System.Drawing.Point(91, 108);
            this.lblSeatNo.Name = "lblSeatNo";
            this.lblSeatNo.Size = new System.Drawing.Size(46, 13);
            this.lblSeatNo.TabIndex = 4;
            this.lblSeatNo.Text = "Seat No";
            // 
            // txtSeatNo
            // 
            this.txtSeatNo.Location = new System.Drawing.Point(146, 101);
            this.txtSeatNo.Name = "txtSeatNo";
            this.txtSeatNo.Size = new System.Drawing.Size(134, 20);
            this.txtSeatNo.TabIndex = 5;
            // 
            // frmAddSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 316);
            this.Controls.Add(this.txtSeatNo);
            this.Controls.Add(this.lblSeatNo);
            this.Controls.Add(this.btnAddMovieSaloon);
            this.Controls.Add(this.dataGridViewSaloons);
            this.Controls.Add(this.txtAddMovieSaloon);
            this.Controls.Add(this.lblSaloon);
            this.Name = "frmAddSaloon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSaloon";
            this.Load += new System.EventHandler(this.frmAddSaloon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaloons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.TextBox txtAddMovieSaloon;
        private System.Windows.Forms.DataGridView dataGridViewSaloons;
        private System.Windows.Forms.Button btnAddMovieSaloon;
        private System.Windows.Forms.Label lblSeatNo;
        private System.Windows.Forms.TextBox txtSeatNo;
    }
}