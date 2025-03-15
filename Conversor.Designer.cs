namespace Conversor_de_divises___Ian_Martínez_Picazo
{
    partial class Conversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TaulaBotons = new TableLayoutPanel();
            PesetesAEuros = new Button();
            EurosAPesetes = new Button();
            CaixaEscriptura = new RichTextBox();
            TextTitol = new Label();
            TaulaBotons.SuspendLayout();
            SuspendLayout();
            // 
            // TaulaBotons
            // 
            TaulaBotons.ColumnCount = 4;
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.Controls.Add(PesetesAEuros, 3, 4);
            TaulaBotons.Controls.Add(EurosAPesetes, 3, 3);
            TaulaBotons.Controls.Add(CaixaEscriptura, 0, 1);
            TaulaBotons.Controls.Add(TextTitol, 0, 0);
            TaulaBotons.Dock = DockStyle.Fill;
            TaulaBotons.Location = new Point(0, 0);
            TaulaBotons.Name = "TaulaBotons";
            TaulaBotons.RowCount = 6;
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673565F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6631947F));
            TaulaBotons.Size = new Size(800, 450);
            TaulaBotons.TabIndex = 0;
            // 
            // PesetesAEuros
            // 
            PesetesAEuros.Dock = DockStyle.Fill;
            PesetesAEuros.Location = new Point(603, 303);
            PesetesAEuros.MinimumSize = new Size(40, 40);
            PesetesAEuros.Name = "PesetesAEuros";
            PesetesAEuros.Size = new Size(194, 69);
            PesetesAEuros.TabIndex = 1;
            PesetesAEuros.Text = "Pesetes -> Euros\r\n";
            PesetesAEuros.UseVisualStyleBackColor = true;
            PesetesAEuros.Click += pesetesAEuros;
            // 
            // EurosAPesetes
            // 
            EurosAPesetes.Dock = DockStyle.Fill;
            EurosAPesetes.Location = new Point(603, 228);
            EurosAPesetes.MinimumSize = new Size(40, 40);
            EurosAPesetes.Name = "EurosAPesetes";
            EurosAPesetes.Size = new Size(194, 69);
            EurosAPesetes.TabIndex = 2;
            EurosAPesetes.Text = "Euros -> Pesetes";
            EurosAPesetes.UseVisualStyleBackColor = true;
            EurosAPesetes.Click += eurosAPesetes;
            // 
            // CaixaEscriptura
            // 
            TaulaBotons.SetColumnSpan(CaixaEscriptura, 3);
            CaixaEscriptura.Dock = DockStyle.Fill;
            CaixaEscriptura.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CaixaEscriptura.Location = new Point(3, 78);
            CaixaEscriptura.Multiline = false;
            CaixaEscriptura.Name = "CaixaEscriptura";
            CaixaEscriptura.RightToLeft = RightToLeft.No;
            CaixaEscriptura.Size = new Size(594, 69);
            CaixaEscriptura.TabIndex = 3;
            CaixaEscriptura.Text = "";
            CaixaEscriptura.TextChanged += validacioDeText;
            // 
            // TextTitol
            // 
            TextTitol.AutoSize = true;
            TextTitol.Dock = DockStyle.Fill;
            TextTitol.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TextTitol.Location = new Point(3, 0);
            TextTitol.Name = "TextTitol";
            TextTitol.Size = new Size(194, 75);
            TextTitol.TabIndex = 4;
            TextTitol.Text = "Conversor de divises";
            TextTitol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TaulaBotons);
            Name = "Conversor";
            Text = "Conversor de divises";
            TaulaBotons.ResumeLayout(false);
            TaulaBotons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TaulaBotons;
        private Button PesetesAEuros;
        private Button EurosAPesetes;
        private RichTextBox CaixaEscriptura;
        private Label TextTitol;
    }
}
