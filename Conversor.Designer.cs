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
            Button_EurosAPesetes = new Button();
            Button_PesetesAEuros = new Button();
            TaulaBotons.SuspendLayout();
            SuspendLayout();
            // 
            // TaulaBotons
            // 
            TaulaBotons.Anchor = AnchorStyles.Top;
            TaulaBotons.ColumnCount = 4;
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TaulaBotons.Controls.Add(Button_PesetesAEuros, 3, 2);
            TaulaBotons.Controls.Add(Button_EurosAPesetes, 3, 1);
            TaulaBotons.Location = new Point(289, 91);
            TaulaBotons.Name = "TaulaBotons";
            TaulaBotons.RowCount = 4;
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TaulaBotons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TaulaBotons.Size = new Size(422, 272);
            TaulaBotons.TabIndex = 0;
            // 
            // Button_EurosAPesetes
            // 
            Button_EurosAPesetes.Dock = DockStyle.Fill;
            Button_EurosAPesetes.Location = new Point(318, 71);
            Button_EurosAPesetes.MinimumSize = new Size(40, 40);
            Button_EurosAPesetes.Name = "Button_EurosAPesetes";
            Button_EurosAPesetes.Size = new Size(101, 62);
            Button_EurosAPesetes.TabIndex = 0;
            Button_EurosAPesetes.Text = "Euros -> Pesetes";
            Button_EurosAPesetes.UseVisualStyleBackColor = true;
            // 
            // Button_PesetesAEuros
            // 
            Button_PesetesAEuros.Anchor = AnchorStyles.None;
            Button_PesetesAEuros.Location = new Point(318, 139);
            Button_PesetesAEuros.MinimumSize = new Size(40, 40);
            Button_PesetesAEuros.Name = "Button_PesetesAEuros";
            Button_PesetesAEuros.Size = new Size(101, 62);
            Button_PesetesAEuros.TabIndex = 1;
            Button_PesetesAEuros.Text = "Pesetes -> Euros\r\n";
            Button_PesetesAEuros.UseVisualStyleBackColor = true;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TaulaBotons);
            Name = "Conversor";
            Text = "Conversor";
            TaulaBotons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TaulaBotons;
        private Button Button_EurosAPesetes;
        private Button Button_PesetesAEuros;
    }
}
