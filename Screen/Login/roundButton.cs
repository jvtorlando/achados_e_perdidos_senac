using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace achados_e_perdidos_senac.Screen.Login
{
    public class roundButton : Button
    {
        // Propriedade para o raio das bordas (adicionada)
        private int _cornerRadius = 10;
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate(); // Força o redesenho quando mudar
            }
        }

        // Cores personalizadas
        public Color DefaultColor { get; set; } = Color.FromArgb(0, 69, 135);
        public Color HoverColor { get; set; } = Color.FromArgb(0, 58, 115);
        public Color ClickColor { get; set; } = Color.FromArgb(0, 47, 95);

        public roundButton()
        {
            // Configurações padrão
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = DefaultColor;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Configura eventos de mouse
            MouseEnter += (sender, e) => BackColor = HoverColor;
            MouseLeave += (sender, e) => BackColor = DefaultColor;
            MouseDown += (sender, e) => BackColor = ClickColor;
            MouseUp += (sender, e) => BackColor = HoverColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = GetRoundedRect(rect, CornerRadius))
            {
                // Preenche com a cor de fundo atual
                e.Graphics.FillPath(new SolidBrush(BackColor), path);

                // Desenha texto centralizado
                TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
                                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle baseRect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(baseRect);
                return path;
            }

            path.AddArc(baseRect.X, baseRect.Y, radius, radius, 180, 90);
            path.AddArc(baseRect.Right - radius, baseRect.Y, radius, radius, 270, 90);
            path.AddArc(baseRect.Right - radius, baseRect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(baseRect.X, baseRect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
