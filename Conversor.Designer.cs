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
            ConvertirDivisaBoto = new Button();
            ContenidorDivisaConvertir = new SplitContainer();
            DivisaConvertirText = new Label();
            DivisaConvertirCaixa = new ComboBox();
            Buidar = new Button();
            CaixaEscriptura = new RichTextBox();
            TextTitol = new Label();
            ContenidorDivisaActual = new SplitContainer();
            DivisaActualText = new Label();
            DivisaActualCaixa = new ComboBox();
            TaulaBotons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaConvertir).BeginInit();
            ContenidorDivisaConvertir.Panel1.SuspendLayout();
            ContenidorDivisaConvertir.Panel2.SuspendLayout();
            ContenidorDivisaConvertir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaActual).BeginInit();
            ContenidorDivisaActual.Panel1.SuspendLayout();
            ContenidorDivisaActual.Panel2.SuspendLayout();
            ContenidorDivisaActual.SuspendLayout();
            SuspendLayout();
            // 
            // TaulaBotons
            // 
            TaulaBotons.ColumnCount = 4;
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.Controls.Add(ConvertirDivisaBoto, 3, 5);
            TaulaBotons.Controls.Add(ContenidorDivisaConvertir, 3, 4);
            TaulaBotons.Controls.Add(Buidar, 3, 1);
            TaulaBotons.Controls.Add(CaixaEscriptura, 0, 1);
            TaulaBotons.Controls.Add(TextTitol, 0, 0);
            TaulaBotons.Controls.Add(ContenidorDivisaActual, 3, 3);
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
            // ConvertirDivisaBoto
            // 
            ConvertirDivisaBoto.BackColor = Color.FromArgb(0, 192, 192);
            ConvertirDivisaBoto.Dock = DockStyle.Fill;
            ConvertirDivisaBoto.Location = new Point(603, 378);
            ConvertirDivisaBoto.MinimumSize = new Size(40, 40);
            ConvertirDivisaBoto.Name = "ConvertirDivisaBoto";
            ConvertirDivisaBoto.Size = new Size(194, 69);
            ConvertirDivisaBoto.TabIndex = 10;
            ConvertirDivisaBoto.Text = "Convertir";
            ConvertirDivisaBoto.UseVisualStyleBackColor = false;
            ConvertirDivisaBoto.Click += convertirDivisa;
            // 
            // ContenidorDivisaConvertir
            // 
            ContenidorDivisaConvertir.Dock = DockStyle.Fill;
            ContenidorDivisaConvertir.IsSplitterFixed = true;
            ContenidorDivisaConvertir.Location = new Point(603, 303);
            ContenidorDivisaConvertir.Name = "ContenidorDivisaConvertir";
            // 
            // ContenidorDivisaConvertir.Panel1
            // 
            ContenidorDivisaConvertir.Panel1.Controls.Add(DivisaConvertirText);
            // 
            // ContenidorDivisaConvertir.Panel2
            // 
            ContenidorDivisaConvertir.Panel2.Controls.Add(DivisaConvertirCaixa);
            ContenidorDivisaConvertir.Size = new Size(194, 69);
            ContenidorDivisaConvertir.SplitterDistance = 97;
            ContenidorDivisaConvertir.TabIndex = 9;
            // 
            // DivisaConvertirText
            // 
            DivisaConvertirText.Dock = DockStyle.Fill;
            DivisaConvertirText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DivisaConvertirText.Location = new Point(0, 0);
            DivisaConvertirText.Name = "DivisaConvertirText";
            DivisaConvertirText.Size = new Size(97, 69);
            DivisaConvertirText.TabIndex = 0;
            DivisaConvertirText.Text = "Divisa a convertir";
            DivisaConvertirText.TextAlign = ContentAlignment.TopCenter;
            // 
            // DivisaConvertirCaixa
            // 
            DivisaConvertirCaixa.Dock = DockStyle.Fill;
            DivisaConvertirCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisaConvertirCaixa.FormattingEnabled = true;
            DivisaConvertirCaixa.Location = new Point(0, 0);
            DivisaConvertirCaixa.Name = "DivisaConvertirCaixa";
            DivisaConvertirCaixa.Size = new Size(93, 28);
            DivisaConvertirCaixa.TabIndex = 6;
            // 
            // Buidar
            // 
            Buidar.BackColor = Color.Red;
            Buidar.Dock = DockStyle.Fill;
            Buidar.Location = new Point(603, 78);
            Buidar.MinimumSize = new Size(40, 40);
            Buidar.Name = "Buidar";
            Buidar.Size = new Size(194, 69);
            Buidar.TabIndex = 5;
            Buidar.Text = "Buidar";
            Buidar.UseVisualStyleBackColor = false;
            Buidar.Click += buidarCaixa;
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
            // ContenidorDivisaActual
            // 
            ContenidorDivisaActual.Dock = DockStyle.Fill;
            ContenidorDivisaActual.IsSplitterFixed = true;
            ContenidorDivisaActual.Location = new Point(603, 228);
            ContenidorDivisaActual.Name = "ContenidorDivisaActual";
            // 
            // ContenidorDivisaActual.Panel1
            // 
            ContenidorDivisaActual.Panel1.Controls.Add(DivisaActualText);
            // 
            // ContenidorDivisaActual.Panel2
            // 
            ContenidorDivisaActual.Panel2.Controls.Add(DivisaActualCaixa);
            ContenidorDivisaActual.Size = new Size(194, 69);
            ContenidorDivisaActual.SplitterDistance = 97;
            ContenidorDivisaActual.TabIndex = 7;
            // 
            // DivisaActualText
            // 
            DivisaActualText.Dock = DockStyle.Fill;
            DivisaActualText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DivisaActualText.Location = new Point(0, 0);
            DivisaActualText.Name = "DivisaActualText";
            DivisaActualText.Size = new Size(97, 69);
            DivisaActualText.TabIndex = 0;
            DivisaActualText.Text = "Divisa actual";
            DivisaActualText.TextAlign = ContentAlignment.TopCenter;
            // 
            // DivisaActualCaixa
            // 
            DivisaActualCaixa.Dock = DockStyle.Fill;
            DivisaActualCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisaActualCaixa.FormattingEnabled = true;
            DivisaActualCaixa.Location = new Point(0, 0);
            DivisaActualCaixa.Name = "DivisaActualCaixa";
            DivisaActualCaixa.Size = new Size(93, 28);
            DivisaActualCaixa.TabIndex = 6;
            DivisaActualCaixa.SelectedIndexChanged += divisaActualSeleccionada;
            DivisaActualCaixa.Click += divisaActualSeleccionada;
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
            ContenidorDivisaConvertir.Panel1.ResumeLayout(false);
            ContenidorDivisaConvertir.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaConvertir).EndInit();
            ContenidorDivisaConvertir.ResumeLayout(false);
            ContenidorDivisaActual.Panel1.ResumeLayout(false);
            ContenidorDivisaActual.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaActual).EndInit();
            ContenidorDivisaActual.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TaulaBotons;
        private RichTextBox CaixaEscriptura;
        private Label TextTitol;
        private Button Buidar;
        private ComboBox DivisaActualCaixa;
        private SplitContainer ContenidorDivisaActual;
        private Label DivisaActualText;
        private Button ConvertirDivisaBoto;
        private SplitContainer ContenidorDivisaConvertir;
        private Label DivisaConvertirText;
        private ComboBox DivisaConvertirCaixa;
    }
}
