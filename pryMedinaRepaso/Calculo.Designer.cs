namespace pryMedinaRepaso
{
    partial class Calculo
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
            lblMonto = new Label();
            lblIVA = new Label();
            txtMonto = new TextBox();
            btnCalculo = new Button();
            cbxIVA = new ComboBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(35, 30);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(35, 75);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(24, 15);
            lblIVA.TabIndex = 1;
            lblIVA.Text = "IVA";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(105, 30);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 23);
            txtMonto.TabIndex = 2;
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(234, 133);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(75, 23);
            btnCalculo.TabIndex = 4;
            btnCalculo.Text = "Calculo";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // cbxIVA
            // 
            cbxIVA.AutoCompleteCustomSource.AddRange(new string[] { "10%", "20%" });
            cbxIVA.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIVA.FormattingEnabled = true;
            cbxIVA.Items.AddRange(new object[] { "10", "21" });
            cbxIVA.Location = new Point(105, 72);
            cbxIVA.Name = "cbxIVA";
            cbxIVA.Size = new Size(121, 23);
            cbxIVA.TabIndex = 5;
            cbxIVA.SelectedIndexChanged += cbxIVA_SelectedIndexChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(142, 178);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // Calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 245);
            Controls.Add(lblResultado);
            Controls.Add(cbxIVA);
            Controls.Add(btnCalculo);
            Controls.Add(txtMonto);
            Controls.Add(lblIVA);
            Controls.Add(lblMonto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblIVA;
        private TextBox txtMonto;
        private Button btnCalculo;
        private ComboBox cbxIVA;
        private Label lblResultado;
    }
}