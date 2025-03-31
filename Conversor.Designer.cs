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
            BotoBuidar = new Button();
            CaixaEscriptura = new RichTextBox();
            ConversorTitol = new Label();
            ContenidorDivisaActual = new SplitContainer();
            DivisaActualText = new Label();
            DivisaActualCaixa = new ComboBox();
            TaulaHistorial = new TableLayoutPanel();
            BotoEsborrar = new Button();
            HistorialTitol = new Label();
            TaulaDades = new DataGridView();
            ContenidorTipusTransaccio = new Panel();
            VendaTransaccio = new RadioButton();
            CompraTransaccio = new RadioButton();
            ContenidorClients = new SplitContainer();
            ClientsText = new Label();
            ClientsCaixa = new ComboBox();
            DescomptesContenidor = new SplitContainer();
            Descompte1CaixaMarca = new CheckBox();
            Descompte2CaixaMarca = new CheckBox();
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
            ContenidorTipusTransaccio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorClients).BeginInit();
            ContenidorClients.Panel1.SuspendLayout();
            ContenidorClients.Panel2.SuspendLayout();
            ContenidorClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DescomptesContenidor).BeginInit();
            DescomptesContenidor.Panel1.SuspendLayout();
            DescomptesContenidor.Panel2.SuspendLayout();
            DescomptesContenidor.SuspendLayout();
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
            TaulaConversor.Controls.Add(BotoBuidar, 3, 1);
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
            ConvertirDivisaBoto.Text = "Convertir\r\n(Ctrl+N)";
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
            // BotoBuidar
            // 
            BotoBuidar.BackColor = Color.Red;
            BotoBuidar.Dock = DockStyle.Fill;
            BotoBuidar.Location = new Point(303, 78);
            BotoBuidar.MinimumSize = new Size(40, 40);
            BotoBuidar.Name = "BotoBuidar";
            BotoBuidar.Size = new Size(94, 69);
            BotoBuidar.TabIndex = 5;
            BotoBuidar.Text = "Buidar\r\n(Ctrl+Q)";
            BotoBuidar.UseVisualStyleBackColor = false;
            BotoBuidar.Click += buidarCaixa;
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
            CaixaEscriptura.TextChanged += validacioQuantitat;
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
            TaulaHistorial.Controls.Add(BotoEsborrar, 0, 3);
            TaulaHistorial.Controls.Add(HistorialTitol, 0, 0);
            TaulaHistorial.Controls.Add(TaulaDades, 0, 1);
            TaulaHistorial.Controls.Add(ContenidorTipusTransaccio, 3, 5);
            TaulaHistorial.Controls.Add(ContenidorClients, 0, 4);
            TaulaHistorial.Controls.Add(DescomptesContenidor, 0, 5);
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
            TaulaHistorial.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TaulaHistorial.Size = new Size(396, 450);
            TaulaHistorial.TabIndex = 2;
            // 
            // BotoEsborrar
            // 
            BotoEsborrar.BackColor = Color.Red;
            TaulaHistorial.SetColumnSpan(BotoEsborrar, 4);
            BotoEsborrar.Dock = DockStyle.Fill;
            BotoEsborrar.Location = new Point(3, 228);
            BotoEsborrar.MinimumSize = new Size(40, 40);
            BotoEsborrar.Name = "BotoEsborrar";
            BotoEsborrar.Size = new Size(390, 69);
            BotoEsborrar.TabIndex = 14;
            BotoEsborrar.Text = "Esborrar registre\r\n(Ctrl+D)\r\n";
            BotoEsborrar.UseVisualStyleBackColor = false;
            BotoEsborrar.Click += esborrarRegistre;
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
            TaulaDades.AllowUserToAddRows = false;
            TaulaDades.AllowUserToDeleteRows = false;
            TaulaDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TaulaDades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaulaHistorial.SetColumnSpan(TaulaDades, 4);
            TaulaDades.Dock = DockStyle.Fill;
            TaulaDades.Location = new Point(3, 78);
            TaulaDades.Name = "TaulaDades";
            TaulaDades.RowHeadersWidth = 51;
            TaulaHistorial.SetRowSpan(TaulaDades, 2);
            TaulaDades.Size = new Size(390, 144);
            TaulaDades.TabIndex = 5;
            TaulaDades.CellValueChanged += comprovarDadesCoherents;
            // 
            // ContenidorTipusTransaccio
            // 
            ContenidorTipusTransaccio.Controls.Add(VendaTransaccio);
            ContenidorTipusTransaccio.Controls.Add(CompraTransaccio);
            ContenidorTipusTransaccio.Dock = DockStyle.Fill;
            ContenidorTipusTransaccio.Location = new Point(300, 378);
            ContenidorTipusTransaccio.Name = "ContenidorTipusTransaccio";
            ContenidorTipusTransaccio.Size = new Size(93, 69);
            ContenidorTipusTransaccio.TabIndex = 12;
            // 
            // VendaTransaccio
            // 
            VendaTransaccio.AutoSize = true;
            VendaTransaccio.Dock = DockStyle.Bottom;
            VendaTransaccio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VendaTransaccio.Location = new Point(0, 45);
            VendaTransaccio.Name = "VendaTransaccio";
            VendaTransaccio.Size = new Size(93, 24);
            VendaTransaccio.TabIndex = 3;
            VendaTransaccio.Text = "Venda";
            VendaTransaccio.UseVisualStyleBackColor = true;
            VendaTransaccio.KeyDown += keyShortcuts;
            // 
            // CompraTransaccio
            // 
            CompraTransaccio.AutoSize = true;
            CompraTransaccio.Checked = true;
            CompraTransaccio.Dock = DockStyle.Top;
            CompraTransaccio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompraTransaccio.Location = new Point(0, 0);
            CompraTransaccio.Name = "CompraTransaccio";
            CompraTransaccio.Size = new Size(93, 24);
            CompraTransaccio.TabIndex = 2;
            CompraTransaccio.TabStop = true;
            CompraTransaccio.Text = "Compra";
            CompraTransaccio.UseVisualStyleBackColor = true;
            // 
            // ContenidorClients
            // 
            TaulaHistorial.SetColumnSpan(ContenidorClients, 4);
            ContenidorClients.Dock = DockStyle.Fill;
            ContenidorClients.Location = new Point(3, 303);
            ContenidorClients.Name = "ContenidorClients";
            // 
            // ContenidorClients.Panel1
            // 
            ContenidorClients.Panel1.Controls.Add(ClientsText);
            // 
            // ContenidorClients.Panel2
            // 
            ContenidorClients.Panel2.Controls.Add(ClientsCaixa);
            ContenidorClients.Size = new Size(390, 69);
            ContenidorClients.SplitterDistance = 195;
            ContenidorClients.TabIndex = 13;
            // 
            // ClientsText
            // 
            ClientsText.Dock = DockStyle.Top;
            ClientsText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientsText.Location = new Point(0, 0);
            ClientsText.Name = "ClientsText";
            ClientsText.Size = new Size(195, 20);
            ClientsText.TabIndex = 7;
            ClientsText.Text = "Client";
            ClientsText.TextAlign = ContentAlignment.TopCenter;
            // 
            // ClientsCaixa
            // 
            ClientsCaixa.Dock = DockStyle.Fill;
            ClientsCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientsCaixa.FormattingEnabled = true;
            ClientsCaixa.Location = new Point(0, 0);
            ClientsCaixa.Name = "ClientsCaixa";
            ClientsCaixa.Size = new Size(191, 28);
            ClientsCaixa.TabIndex = 6;
            // 
            // DescomptesContenidor
            // 
            TaulaHistorial.SetColumnSpan(DescomptesContenidor, 3);
            DescomptesContenidor.Dock = DockStyle.Fill;
            DescomptesContenidor.Location = new Point(3, 378);
            DescomptesContenidor.Name = "DescomptesContenidor";
            // 
            // DescomptesContenidor.Panel1
            // 
            DescomptesContenidor.Panel1.Controls.Add(Descompte1CaixaMarca);
            // 
            // DescomptesContenidor.Panel2
            // 
            DescomptesContenidor.Panel2.Controls.Add(Descompte2CaixaMarca);
            DescomptesContenidor.Size = new Size(291, 69);
            DescomptesContenidor.SplitterDistance = 146;
            DescomptesContenidor.TabIndex = 15;
            // 
            // Descompte1CaixaMarca
            // 
            Descompte1CaixaMarca.AutoSize = true;
            Descompte1CaixaMarca.CausesValidation = false;
            Descompte1CaixaMarca.Dock = DockStyle.Fill;
            Descompte1CaixaMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Descompte1CaixaMarca.Location = new Point(0, 0);
            Descompte1CaixaMarca.Name = "Descompte1CaixaMarca";
            Descompte1CaixaMarca.Size = new Size(146, 69);
            Descompte1CaixaMarca.TabIndex = 10;
            Descompte1CaixaMarca.Text = "Descompte 1";
            Descompte1CaixaMarca.UseVisualStyleBackColor = true;
            // 
            // Descompte2CaixaMarca
            // 
            Descompte2CaixaMarca.AutoSize = true;
            Descompte2CaixaMarca.CausesValidation = false;
            Descompte2CaixaMarca.Dock = DockStyle.Fill;
            Descompte2CaixaMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Descompte2CaixaMarca.Location = new Point(0, 0);
            Descompte2CaixaMarca.Name = "Descompte2CaixaMarca";
            Descompte2CaixaMarca.Size = new Size(141, 69);
            Descompte2CaixaMarca.TabIndex = 11;
            Descompte2CaixaMarca.Text = "Descompte 2";
            Descompte2CaixaMarca.UseVisualStyleBackColor = true;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ContenidorDivisioVistes);
            KeyPreview = true;
            Name = "Conversor";
            Text = "Conversor de divises";
            KeyDown += keyShortcuts;
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
            ContenidorTipusTransaccio.ResumeLayout(false);
            ContenidorTipusTransaccio.PerformLayout();
            ContenidorClients.Panel1.ResumeLayout(false);
            ContenidorClients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorClients).EndInit();
            ContenidorClients.ResumeLayout(false);
            DescomptesContenidor.Panel1.ResumeLayout(false);
            DescomptesContenidor.Panel1.PerformLayout();
            DescomptesContenidor.Panel2.ResumeLayout(false);
            DescomptesContenidor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DescomptesContenidor).EndInit();
            DescomptesContenidor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer ContenidorDivisioVistes;
        private TableLayoutPanel TaulaConversor;
        private Button ConvertirDivisaBoto;
        private SplitContainer ContenidorDivisaConvertir;
        private Label DivisaConvertirText;
        private ComboBox DivisaConvertirCaixa;
        private Button BotoBuidar;
        private RichTextBox CaixaEscriptura;
        private Label ConversorTitol;
        private SplitContainer ContenidorDivisaActual;
        private Label DivisaActualText;
        private ComboBox DivisaActualCaixa;
        private TableLayoutPanel TaulaHistorial;
        private Label HistorialTitol;
        private DataGridView TaulaDades;
        private ComboBox ClientsCaixa;
        private Label ClientsText;
        private CheckBox Descompte2CaixaMarca;
        private CheckBox Descompte1CaixaMarca;
        private Panel ContenidorTipusTransaccio;
        private RadioButton VendaTransaccio;
        private RadioButton CompraTransaccio;
        private SplitContainer ContenidorClients;
        private Button BotoEsborrar;
        private SplitContainer DescomptesContenidor;
    }
}
