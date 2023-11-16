using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cadastramento_de_Funcionário
{
    class RoundedTextBox : TextBox
    {
        public int BorderRadius { get; set; } = 10;

        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None; // Remove a borda padrão do TextBox.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Color.Black, 2))
            {
                int radius = BorderRadius;
                int border = 2; // Tamanho da borda

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(Width - radius - border, 0, radius, radius, 270, 90);
                path.AddArc(Width - radius - border, Height - radius - border, radius, radius, 0, 90);
                path.AddArc(0, Height - radius - border, radius, radius, 90, 90);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
