using System.Windows.Forms;

namespace Conversor_de_divises___Ian_Martínez_Picazo
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();

            // Assigna els botons númerics per codi.
            for (int i = 1; i <= 9; i++)
            {
                Button btn = new Button();
                btn.Name = "Num" + i.ToString();
                btn.Text = $"{i}";
                btn.MinimumSize = new Size(40, 40);
                btn.Dock = DockStyle.Fill;
                this.TaulaBotons.Controls.Add(btn, (i - 1) % 3, (i - 1) / 3);
            }
        }
    }
}
