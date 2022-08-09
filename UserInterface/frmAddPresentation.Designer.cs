namespace UserInterface
{
    partial class frmAddPresentation
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
            this.components = new System.ComponentModel.Container();
            this.cBoxAddPresentationMovieName = new System.Windows.Forms.ComboBox();
            this.cBoxAddPresentationSaloon = new System.Windows.Forms.ComboBox();
            this.cBoxAddPresentationSession = new System.Windows.Forms.ComboBox();
            this.btnAddPresent = new System.Windows.Forms.Button();
            this.lblSaloon = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridViewAddPresentation = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endPresentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPresentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddPresentation)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxAddPresentationMovieName
            // 
            this.cBoxAddPresentationMovieName.FormattingEnabled = true;
            this.cBoxAddPresentationMovieName.Location = new System.Drawing.Point(245, 246);
            this.cBoxAddPresentationMovieName.Name = "cBoxAddPresentationMovieName";
            this.cBoxAddPresentationMovieName.Size = new System.Drawing.Size(100, 21);
            this.cBoxAddPresentationMovieName.TabIndex = 16;
            // 
            // cBoxAddPresentationSaloon
            // 
            this.cBoxAddPresentationSaloon.FormattingEnabled = true;
            this.cBoxAddPresentationSaloon.Location = new System.Drawing.Point(245, 330);
            this.cBoxAddPresentationSaloon.Name = "cBoxAddPresentationSaloon";
            this.cBoxAddPresentationSaloon.Size = new System.Drawing.Size(100, 21);
            this.cBoxAddPresentationSaloon.TabIndex = 14;
            // 
            // cBoxAddPresentationSession
            // 
            this.cBoxAddPresentationSession.FormattingEnabled = true;
            this.cBoxAddPresentationSession.Location = new System.Drawing.Point(245, 291);
            this.cBoxAddPresentationSession.Name = "cBoxAddPresentationSession";
            this.cBoxAddPresentationSession.Size = new System.Drawing.Size(100, 21);
            this.cBoxAddPresentationSession.TabIndex = 15;
            // 
            // btnAddPresent
            // 
            this.btnAddPresent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPresent.Location = new System.Drawing.Point(415, 275);
            this.btnAddPresent.Name = "btnAddPresent";
            this.btnAddPresent.Size = new System.Drawing.Size(183, 51);
            this.btnAddPresent.TabIndex = 13;
            this.btnAddPresent.Text = "Add Presentation";
            this.btnAddPresent.UseVisualStyleBackColor = false;
            this.btnAddPresent.Click += new System.EventHandler(this.btnAddPresent_Click);
            // 
            // lblSaloon
            // 
            this.lblSaloon.AutoSize = true;
            this.lblSaloon.Location = new System.Drawing.Point(163, 337);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(40, 13);
            this.lblSaloon.TabIndex = 8;
            this.lblSaloon.Text = "Saloon";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(163, 294);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(44, 13);
            this.lblSession.TabIndex = 10;
            this.lblSession.Text = "Session";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(163, 252);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Movie";
            // 
            // dataGridViewAddPresentation
            // 
            this.dataGridViewAddPresentation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddPresentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddPresentation.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewAddPresentation.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewAddPresentation.Name = "dataGridViewAddPresentation";
            this.dataGridViewAddPresentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddPresentation.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewAddPresentation.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endPresentationToolStripMenuItem,
            this.openPresentationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // endPresentationToolStripMenuItem
            // 
            this.endPresentationToolStripMenuItem.Name = "endPresentationToolStripMenuItem";
            this.endPresentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endPresentationToolStripMenuItem.Text = "End Presentation";
            this.endPresentationToolStripMenuItem.Click += new System.EventHandler(this.endPresentationToolStripMenuItem_Click);
            // 
            // openPresentationToolStripMenuItem
            // 
            this.openPresentationToolStripMenuItem.Name = "openPresentationToolStripMenuItem";
            this.openPresentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openPresentationToolStripMenuItem.Text = "Open Presentation";
            this.openPresentationToolStripMenuItem.Click += new System.EventHandler(this.openPresentationToolStripMenuItem_Click);
            // 
            // frmAddPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxAddPresentationMovieName);
            this.Controls.Add(this.cBoxAddPresentationSaloon);
            this.Controls.Add(this.cBoxAddPresentationSession);
            this.Controls.Add(this.btnAddPresent);
            this.Controls.Add(this.lblSaloon);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridViewAddPresentation);
            this.Name = "frmAddPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPresentation";
            this.Load += new System.EventHandler(this.frmAddPresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddPresentation)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxAddPresentationMovieName;
        private System.Windows.Forms.ComboBox cBoxAddPresentationSaloon;
        private System.Windows.Forms.ComboBox cBoxAddPresentationSession;
        private System.Windows.Forms.Button btnAddPresent;
        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridViewAddPresentation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endPresentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPresentationToolStripMenuItem;
    }
}