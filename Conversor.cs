using System.Windows.Forms;

namespace Conversor_de_divises___Ian_Martínez_Picazo
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();

            for (int i = 1; i <= 9; i++)
            {
                CrearBotons("Num" + i, i.ToString(), (i - 1) % 3, (i - 1) / 3 + 2);
            }

            CrearBotons("Num0", "0", 0, 5, true);
        }

        // Assigna els botons númerics per codi a la vista i també assigna un event compartit per a cadascú.
        private void CrearBotons(string nom, string text, int columna, int fila, bool fusionarColumnes = false)
        {
            Button btn = new Button
            {
                Name = nom,
                Text = text,
                MinimumSize = new Size(40, 40),
                Dock = DockStyle.Fill
            };

            this.TaulaBotons.Controls.Add(btn, columna, fila);

            if (fusionarColumnes)
            {
                this.TaulaBotons.SetColumnSpan(btn, 3);
            }

            btn.Click += botoPremut;
        }

        // Troba el botó premut dinamicament i ho escriu a la caixa de text.
        public void botoPremut(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string text = btn.Text;

            this.CaixaEscriptura.Text += text;
        }


        // Variable per evitar bucles.
        private bool canviant_text = false, canvi_manual = true;

        // Assegura que el contingut de la caixa de text sigui valid.
        public void validacioDeText(object sender, EventArgs e)
        {
            // Evita que l'esdeveniment s'activi mentre es modifica el text programàticament.
            if (canviant_text || !canvi_manual) return;

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
            this.CaixaEscriptura.Text = text_valid + divisa;

            // Restaura la posició del cursor després de la validació.
            this.CaixaEscriptura.SelectionStart = cursor;

            // Rehabilita l'esdeveniment de canvi de text després de la modificació.
            canviant_text = false;
        }


        // Valor constant de conversió.
        private const double conversio = 166.386;

        // Determina la divisa actual. (Euro per defecte.)
        private string divisa = "€";

        // Calculs de conversió de divisa amb control d'errada.
        public void eurosAPesetes(Object sender, EventArgs e)
        {
            if (!divisa.Equals("€") && !string.IsNullOrEmpty(this.CaixaEscriptura.Text.Trim()))
            {
                if (double.TryParse(this.CaixaEscriptura.Text.Substring(0, this.CaixaEscriptura.Text.Length - 3), out double euros))
                {
                    divisa = "€";
                    canviant_text = true;
                    canvi_manual = false;
                    this.CaixaEscriptura.Text = (euros * conversio).ToString("G"); // Compacta els nombres.
                    this.CaixaEscriptura.Text += divisa;
                    canviant_text = false;
                    canvi_manual = true;
                }
                else
                {
                    MessageBox.Show("Tan sols números.");
                }
            }
        }
        public void pesetesAEuros(Object sender, EventArgs e)
        {
            if (!divisa.Equals("Pts") && !string.IsNullOrEmpty(this.CaixaEscriptura.Text.Trim()))
            {
                if (double.TryParse(this.CaixaEscriptura.Text.Substring(0, this.CaixaEscriptura.Text.Length - 1), out double pesetas))
                {
                    divisa = "Pts";
                    canviant_text = true;
                    canvi_manual = false;
                    this.CaixaEscriptura.Text = (pesetas / conversio).ToString("G"); // Compacta els nombres.
                    this.CaixaEscriptura.Text += divisa;
                    canviant_text = false;
                    canvi_manual = true;
                }
                else
                {
                    MessageBox.Show("Tan sols números.");
                }
            }
        }
    }
}