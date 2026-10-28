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
            btnSobreescribir = new Button();
            lblGrupo1 = new Label();
            lblDato = new Label();
            comboBox1 = new ComboBox();
            txtdato = new TextBox();
            btnGrabar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 45);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo";
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(12, 93);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(204, 94);
            lstLista.TabIndex = 1;
            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged;
            // 
            // cbxGrupo
            // 
            cbxGrupo.FormattingEnabled = true;
            cbxGrupo.Location = new Point(95, 45);
            cbxGrupo.Name = "cbxGrupo";
            cbxGrupo.Size = new Size(121, 23);
            cbxGrupo.TabIndex = 2;
            cbxGrupo.SelectedIndexChanged += cbxGrupo_SelectedIndexChanged;
            // 
            // btnSobreescribir
            // 
            btnSobreescribir.Location = new Point(52, 213);
            btnSobreescribir.Name = "btnSobreescribir";
            btnSobreescribir.Size = new Size(121, 23);
            btnSobreescribir.TabIndex = 3;
            btnSobreescribir.Text = "Sobreescribir array";
            btnSobreescribir.UseVisualStyleBackColor = true;
            // 
            // lblGrupo1
            // 
            lblGrupo1.AutoSize = true;
            lblGrupo1.Location = new Point(25, 260);
            lblGrupo1.Name = "lblGrupo1";
            lblGrupo1.Size = new Size(40, 15);
            lblGrupo1.TabIndex = 4;
            lblGrupo1.Text = "Grupo";
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(25, 292);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 5;
            lblDato.Text = "Dato";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 260);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // txtdato
            // 
            txtdato.Location = new Point(84, 292);
            txtdato.Name = "txtdato";
            txtdato.Size = new Size(121, 23);
            txtdato.TabIndex = 7;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(147, 328);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(89, 357);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 9;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 381);
            Controls.Add(lblMensaje);
            Controls.Add(btnGrabar);
            Controls.Add(txtdato);
            Controls.Add(comboBox1);
            Controls.Add(lblDato);
            Controls.Add(lblGrupo1);
            Controls.Add(btnSobreescribir);
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
        private Button btnSobreescribir;
        private Label lblGrupo1;
        private Label lblDato;
        private ComboBox comboBox1;
        private TextBox txtdato;
        private Button btnGrabar;
        private Label lblMensaje;
    }
}