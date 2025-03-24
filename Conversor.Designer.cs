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
            ContenidorDivisioVistes = new SplitContainer();
            TaulaConversor = new TableLayoutPanel();
            ConvertirDivisaBoto = new Button();
            ContenidorDivisaConvertir = new SplitContainer();
            DivisaConvertirText = new Label();
            DivisaConvertirCaixa = new ComboBox();
            Buidar = new Button();
            CaixaEscriptura = new RichTextBox();
            ConversorTitol = new Label();
            ContenidorDivisaActual = new SplitContainer();
            DivisaActualText = new Label();
            DivisaActualCaixa = new ComboBox();
            TaulaHistorial = new TableLayoutPanel();
            HistorialTitol = new Label();
            TaulaDades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisioVistes).BeginInit();
            ContenidorDivisioVistes.Panel1.SuspendLayout();
            ContenidorDivisioVistes.Panel2.SuspendLayout();
            ContenidorDivisioVistes.SuspendLayout();
            TaulaConversor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaConvertir).BeginInit();
            ContenidorDivisaConvertir.Panel1.SuspendLayout();
            ContenidorDivisaConvertir.Panel2.SuspendLayout();
            ContenidorDivisaConvertir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaActual).BeginInit();
            ContenidorDivisaActual.Panel1.SuspendLayout();
            ContenidorDivisaActual.Panel2.SuspendLayout();
            ContenidorDivisaActual.SuspendLayout();
            TaulaHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaulaDades).BeginInit();
            SuspendLayout();
            // 
            // ContenidorDivisioVistes
            // 
            ContenidorDivisioVistes.Dock = DockStyle.Fill;
            ContenidorDivisioVistes.Location = new Point(0, 0);
            ContenidorDivisioVistes.Name = "ContenidorDivisioVistes";
            // 
            // ContenidorDivisioVistes.Panel1
            // 
            ContenidorDivisioVistes.Panel1.Controls.Add(TaulaConversor);
            // 
            // ContenidorDivisioVistes.Panel2
            // 
            ContenidorDivisioVistes.Panel2.Controls.Add(TaulaHistorial);
            ContenidorDivisioVistes.Size = new Size(800, 450);
            ContenidorDivisioVistes.SplitterDistance = 400;
            ContenidorDivisioVistes.TabIndex = 0;
            // 
            // TaulaConversor
            // 
            TaulaConversor.ColumnCount = 4;
            TaulaConversor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaConversor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaConversor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaConversor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaConversor.Controls.Add(ConvertirDivisaBoto, 3, 5);
            TaulaConversor.Controls.Add(ContenidorDivisaConvertir, 3, 4);
            TaulaConversor.Controls.Add(Buidar, 3, 1);
            TaulaConversor.Controls.Add(CaixaEscriptura, 0, 1);
            TaulaConversor.Controls.Add(ConversorTitol, 0, 0);
            TaulaConversor.Controls.Add(ContenidorDivisaActual, 3, 3);
            TaulaConversor.Dock = DockStyle.Fill;
            TaulaConversor.Location = new Point(0, 0);
            TaulaConversor.Name = "TaulaConversor";
            TaulaConversor.RowCount = 6;
            TaulaConversor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673565F));
            TaulaConversor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaConversor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaConversor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaConversor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaConversor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6631947F));
            TaulaConversor.Size = new Size(400, 450);
            TaulaConversor.TabIndex = 1;
            // 
            // ConvertirDivisaBoto
            // 
            ConvertirDivisaBoto.BackColor = Color.FromArgb(0, 192, 192);
            ConvertirDivisaBoto.Dock = DockStyle.Fill;
            ConvertirDivisaBoto.Location = new Point(303, 378);
            ConvertirDivisaBoto.MinimumSize = new Size(40, 40);
            ConvertirDivisaBoto.Name = "ConvertirDivisaBoto";
            ConvertirDivisaBoto.Size = new Size(94, 69);
            ConvertirDivisaBoto.TabIndex = 10;
            ConvertirDivisaBoto.Text = "Convertir";
            ConvertirDivisaBoto.UseVisualStyleBackColor = false;
            ConvertirDivisaBoto.Click += convertirDivisa;
            // 
            // ContenidorDivisaConvertir
            // 
            ContenidorDivisaConvertir.Dock = DockStyle.Fill;
            ContenidorDivisaConvertir.IsSplitterFixed = true;
            ContenidorDivisaConvertir.Location = new Point(303, 303);
            ContenidorDivisaConvertir.Name = "ContenidorDivisaConvertir";
            // 
            // ContenidorDivisaConvertir.Panel1
            // 
            ContenidorDivisaConvertir.Panel1.Controls.Add(DivisaConvertirText);
            // 
            // ContenidorDivisaConvertir.Panel2
            // 
            ContenidorDivisaConvertir.Panel2.Controls.Add(DivisaConvertirCaixa);
            ContenidorDivisaConvertir.Size = new Size(94, 69);
            ContenidorDivisaConvertir.SplitterDistance = 47;
            ContenidorDivisaConvertir.TabIndex = 9;
            // 
            // DivisaConvertirText
            // 
            DivisaConvertirText.Dock = DockStyle.Fill;
            DivisaConvertirText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DivisaConvertirText.Location = new Point(0, 0);
            DivisaConvertirText.Name = "DivisaConvertirText";
            DivisaConvertirText.Size = new Size(47, 69);
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
            DivisaConvertirCaixa.Size = new Size(43, 28);
            DivisaConvertirCaixa.TabIndex = 6;
            // 
            // Buidar
            // 
            Buidar.BackColor = Color.Red;
            Buidar.Dock = DockStyle.Fill;
            Buidar.Location = new Point(303, 78);
            Buidar.MinimumSize = new Size(40, 40);
            Buidar.Name = "Buidar";
            Buidar.Size = new Size(94, 69);
            Buidar.TabIndex = 5;
            Buidar.Text = "Buidar";
            Buidar.UseVisualStyleBackColor = false;
            Buidar.Click += buidarCaixa;
            // 
            // CaixaEscriptura
            // 
            TaulaConversor.SetColumnSpan(CaixaEscriptura, 3);
            CaixaEscriptura.Dock = DockStyle.Fill;
            CaixaEscriptura.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CaixaEscriptura.Location = new Point(3, 78);
            CaixaEscriptura.Multiline = false;
            CaixaEscriptura.Name = "CaixaEscriptura";
            CaixaEscriptura.RightToLeft = RightToLeft.No;
            CaixaEscriptura.Size = new Size(294, 69);
            CaixaEscriptura.TabIndex = 3;
            CaixaEscriptura.Text = "";
            CaixaEscriptura.TextChanged += validacioDeText;
            // 
            // ConversorTitol
            // 
            ConversorTitol.AutoSize = true;
            TaulaConversor.SetColumnSpan(ConversorTitol, 4);
            ConversorTitol.Dock = DockStyle.Fill;
            ConversorTitol.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ConversorTitol.Location = new Point(3, 0);
            ConversorTitol.Name = "ConversorTitol";
            ConversorTitol.Size = new Size(394, 75);
            ConversorTitol.TabIndex = 4;
            ConversorTitol.Text = "Conversor de divises";
            ConversorTitol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContenidorDivisaActual
            // 
            ContenidorDivisaActual.Dock = DockStyle.Fill;
            ContenidorDivisaActual.IsSplitterFixed = true;
            ContenidorDivisaActual.Location = new Point(303, 228);
            ContenidorDivisaActual.Name = "ContenidorDivisaActual";
            // 
            // ContenidorDivisaActual.Panel1
            // 
            ContenidorDivisaActual.Panel1.Controls.Add(DivisaActualText);
            // 
            // ContenidorDivisaActual.Panel2
            // 
            ContenidorDivisaActual.Panel2.Controls.Add(DivisaActualCaixa);
            ContenidorDivisaActual.Size = new Size(94, 69);
            ContenidorDivisaActual.SplitterDistance = 47;
            ContenidorDivisaActual.TabIndex = 7;
            // 
            // DivisaActualText
            // 
            DivisaActualText.Dock = DockStyle.Fill;
            DivisaActualText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DivisaActualText.Location = new Point(0, 0);
            DivisaActualText.Name = "DivisaActualText";
            DivisaActualText.Size = new Size(47, 69);
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
            DivisaActualCaixa.Size = new Size(43, 28);
            DivisaActualCaixa.TabIndex = 6;
            DivisaActualCaixa.SelectedIndexChanged += divisaActualSeleccionada;
            // 
            // TaulaHistorial
            // 
            TaulaHistorial.ColumnCount = 4;
            TaulaHistorial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaHistorial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaHistorial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaHistorial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaHistorial.Controls.Add(HistorialTitol, 0, 0);
            TaulaHistorial.Controls.Add(TaulaDades, 0, 1);
            TaulaHistorial.Dock = DockStyle.Fill;
            TaulaHistorial.Location = new Point(0, 0);
            TaulaHistorial.Name = "TaulaHistorial";
            TaulaHistorial.RowCount = 6;
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673565F));
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66736F));
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6631947F));
            TaulaHistorial.Size = new Size(396, 450);
            TaulaHistorial.TabIndex = 2;
            // 
            // HistorialTitol
            // 
            HistorialTitol.AutoSize = true;
            TaulaHistorial.SetColumnSpan(HistorialTitol, 4);
            HistorialTitol.Dock = DockStyle.Fill;
            HistorialTitol.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            HistorialTitol.Location = new Point(3, 0);
            HistorialTitol.Name = "HistorialTitol";
            HistorialTitol.Size = new Size(390, 75);
            HistorialTitol.TabIndex = 4;
            HistorialTitol.Text = "Historial de conversions";
            HistorialTitol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaulaDades
            // 
            TaulaDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TaulaDades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaulaHistorial.SetColumnSpan(TaulaDades, 4);
            TaulaDades.Dock = DockStyle.Fill;
            TaulaDades.Location = new Point(3, 78);
            TaulaDades.Name = "TaulaDades";
            TaulaDades.ReadOnly = true;
            TaulaDades.RowHeadersWidth = 51;
            TaulaHistorial.SetRowSpan(TaulaDades, 2);
            TaulaDades.Size = new Size(390, 144);
            TaulaDades.TabIndex = 5;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ContenidorDivisioVistes);
            Name = "Conversor";
            Text = "Conversor de divises";
            ContenidorDivisioVistes.Panel1.ResumeLayout(false);
            ContenidorDivisioVistes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisioVistes).EndInit();
            ContenidorDivisioVistes.ResumeLayout(false);
            TaulaConversor.ResumeLayout(false);
            TaulaConversor.PerformLayout();
            ContenidorDivisaConvertir.Panel1.ResumeLayout(false);
            ContenidorDivisaConvertir.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaConvertir).EndInit();
            ContenidorDivisaConvertir.ResumeLayout(false);
            ContenidorDivisaActual.Panel1.ResumeLayout(false);
            ContenidorDivisaActual.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaActual).EndInit();
            ContenidorDivisaActual.ResumeLayout(false);
            TaulaHistorial.ResumeLayout(false);
            TaulaHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaulaDades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer ContenidorDivisioVistes;
        private TableLayoutPanel TaulaConversor;
        private Button ConvertirDivisaBoto;
        private SplitContainer ContenidorDivisaConvertir;
        private Label DivisaConvertirText;
        private ComboBox DivisaConvertirCaixa;
        private Button Buidar;
        private RichTextBox CaixaEscriptura;
        private Label ConversorTitol;
        private SplitContainer ContenidorDivisaActual;
        private Label DivisaActualText;
        private ComboBox DivisaActualCaixa;
        private TableLayoutPanel TaulaHistorial;
        private Label HistorialTitol;
        private DataGridView TaulaDades;
    }
}
