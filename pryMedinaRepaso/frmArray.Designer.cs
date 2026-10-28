namespace pryMedinaRepaso
{
    partial class frmArray
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
            lblGrupo = new Label();
            lstLista = new ListBox();
            cbxGrupo = new ComboBox();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(47, 45);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo";
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(69, 109);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(204, 94);
            lstLista.TabIndex = 1;
            // 
            // cbxGrupo
            // 
            cbxGrupo.FormattingEnabled = true;
            cbxGrupo.Location = new Point(112, 45);
            cbxGrupo.Name = "cbxGrupo";
            cbxGrupo.Size = new Size(121, 23);
            cbxGrupo.TabIndex = 2;
            cbxGrupo.SelectedIndexChanged += cbxGrupo_SelectedIndexChanged;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 263);
            Controls.Add(cbxGrupo);
            Controls.Add(lstLista);
            Controls.Add(lblGrupo);
            Name = "frmArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmArray";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ListBox lstLista;
        private ComboBox cbxGrupo;
    }
}