using System.Windows.Forms;

// Permet fer que el dispisitiu de l'usuari pugui utilitzar qualsevol tipus de decimal.
using System.Globalization;
using System.Diagnostics;

namespace Conversor_de_divises___Ian_Martínez_Picazo
{
    public partial class Conversor : Form
    {
        // Divises seleccionables.
        private static readonly string[] divises =
        {
            "Euro | €",
            "Dòlar Estats Units | $",
            "Lliura Esterlina | £",
            "Ien Japonès | ¥",
            "Franc Suís | CHF"
        };

        // Totes les conversions possibles.
        private static readonly Dictionary<string, double> conversions = new Dictionary<string, double>
        {
            // Conversions d'Euro (€).
            { "€_A_$", 1.10 },
            { "€_A_£", 0.85 },
            { "€_A_¥", 130.00 },
            { "€_A_CHF", 1.05 },

            // Conversions de Dòlar ($).
            { "$_A_€", 1 / 1.10 },
            { "$_A_£", 0.77 },
            { "$_A_¥", 118.18 },
            { "$_A_CHF", 0.95 },

            // Conversions de Lliura Esterlina (£).
            { "£_A_€", 1 / 0.85 },
            { "£_A_$", 1.30 },
            { "£_A_¥", 153.00 },
            { "£_A_CHF", 1.36 },

            // Conversions de Ien Japonès (¥).
            { "¥_A_€", 1 / 130.00 },
            { "¥_A_$", 1 / 118.18 },
            { "¥_A_£", 1 / 153.00 },
            { "¥_A_CHF", 0.0079 },

            // Conversions de Franc Suís (CHF).
            { "CHF_A_€", 1 / 1.05 },
            { "CHF_A_$", 1 / 0.95 },
            { "CHF_A_£", 1 / 1.36 },
            { "CHF_A_¥", 1 / 0.0079 }
        };

        public Conversor()
        {
            InitializeComponent();

            // Creació de botons númerics.
            for (int i = 1; i <= 9; i++)
            {
                CrearBotons("Num" + i, i.ToString(), (i - 1) % 3, (i - 1) / 3 + 2);
            }
            CrearBotons("Num0", "0", 0, 5, 2);
            CrearBotons("Decimal", ".", 2, 5);

            // Afegeix les divises als desplegables.
            this.DivisaActualCaixa.Items.AddRange(divises);
            this.DivisaConvertirCaixa.Items.AddRange(divises);

            this.ContenidorDivisaActual.SplitterDistance = this.ContenidorDivisaActual.Width / 2;
            this.ContenidorDivisaConvertir.SplitterDistance = this.ContenidorDivisaConvertir.Width / 2;
        }

        // Assigna els botons númerics per codi a la vista i també assigna un event compartit per a cadascú.
        private void CrearBotons(string nom, string text, int columna, int fila, int fusionar_columnes = 1)
        {
            Button btn = new Button
            {
                Name = nom,
                Text = text,
                MinimumSize = new Size(40, 40),
                Dock = DockStyle.Fill
            };

            this.TaulaBotons.Controls.Add(btn, columna, fila);

            this.TaulaBotons.SetColumnSpan(btn, fusionar_columnes);

            btn.Click += botoPremut;
        }

        // Troba el botó premut dinamicament i ho escriu a la caixa de text.
        public void botoPremut(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            this.CaixaEscriptura.Text += btn.Text;
        }


        // Variable per evitar bucles.
        private bool canviant_text = false;

        // Assegura que el contingut de la caixa de text sigui valid.
        public void validacioDeText(object sender, EventArgs e)
        {
            // Evita que l'esdeveniment s'activi mentre es modifica el text programàticament.
            if (canviant_text) return;

            // Desa la posició del cursor.
            int cursor = this.CaixaEscriptura.SelectionStart;

            // Substitueix les comes per punts.
            string text = this.CaixaEscriptura.Text.Replace(',', '.');

            // Preven l'entrada de caràcters no numèrics ni punts decimals excessius.
            string text_valid = string.Empty;
            bool decimal_trobat = false;

            // Itera a través de cada caràcter del text.
            foreach (char caracter in text)
            {
                // Permet només números i un sol punt decimal.
                if (char.IsDigit(caracter))
                {
                    text_valid += caracter; // Afegeix el número.
                }
                else if (caracter == '.' && !decimal_trobat)
                {
                    text_valid += caracter; // Afegeix el punt decimal.
                    decimal_trobat = true; // Marca que s'ha trobat un punt decimal.
                }
            }
            // Desactiva el canvi de text per evitar el llançament de l'esdeveniment.
            canviant_text = true;

            // Assigna el text validat de nou.
            this.CaixaEscriptura.Text = text_valid + aillarSimbolDivisa(this.DivisaActualCaixa.Text.Trim());

            // Restaura la posició del cursor després de la validació.
            this.CaixaEscriptura.SelectionStart = cursor;

            // Rehabilita l'esdeveniment de canvi de text després de la modificació.
            canviant_text = false;
        }

        // Determina la divisa actual.
        private void divisaActualSeleccionada(object sender, EventArgs e)
        {
            this.CaixaEscriptura.Text = this.CaixaEscriptura.Text + " ";
        }

        // Calculs de conversió de divisa amb control d'errada.
        private void convertirDivisa(object sender, EventArgs e)
        {
            // Obté les divises seleccionades
            String divisa_actual = aillarSimbolDivisa(this.DivisaActualCaixa.Text);
            String divisa_convertir = aillarSimbolDivisa(this.DivisaConvertirCaixa.Text);

            // Obté la part númmerica de la caixa de text
            if (double.TryParse(this.CaixaEscriptura.Text.Substring(0, CaixaEscriptura.Text.Length - divisa_actual.Length), NumberStyles.Any, CultureInfo.InvariantCulture, out double quantitat))
            {
                // Consulta al dictionari per a fer el calcul de conversió.
                string conversio = $"{divisa_actual}_A_{divisa_convertir}";
                if (conversions.TryGetValue(conversio, out double taxa))
                {
                    double resultat = quantitat * taxa;
                    this.DivisaActualCaixa.SelectedItem = this.DivisaConvertirCaixa.SelectedItem;
                    this.CaixaEscriptura.Text = resultat.ToString("F4");
                }
                else
                {
                    MessageBox.Show("Skib");
                }
            }
            else
            {
                MessageBox.Show("No m'agradan les lletres a l'hora de calcular.");
            }
        }

        // Retorna el simbol de la divisa proporcionada. (Format: [Nom] | [Simbol)
        public String aillarSimbolDivisa(String divisa_text)
        {
            for (int i = 0;i < divisa_text.Length;i++)
            {
                char buscador = divisa_text[i];
                if (buscador == '|')
                {
                    return divisa_text.Substring(i + 1).Trim();
                }
            }
            return "Skib";
        }

        // Buida la caixa.
        private void buidarCaixa(object sender, EventArgs e)
        {
            this.CaixaEscriptura.Text = null;
        }
    }
}