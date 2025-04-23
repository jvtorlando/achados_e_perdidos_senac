using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace achados_e_perdidos_senac.Controls
{
    public class RoundTextBox : TextBox
    {
        private int _cornerRadius = 15;
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        private Color _borderColor = Color.Gray;
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private float _borderWidth = 1f;
        public float BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = value; Invalidate(); }
        }

        public RoundTextBox()
        {
            // Configurações padrão
            SetStyle(ControlStyles.UserPaint, true);
            this.BorderStyle = BorderStyle.None;
            this.BackColor = SystemColors.Control; // Cor Control
            this.Font = new Font("Segoe UI", 10);
            this.Size = new Size(276, 45); // Altura maior (38 -> 45)
            this.Padding = new Padding(10, 10, 10, 10); // Padding interno
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Cria o retângulo arredondado
            using (var path = GetRoundRect(ClientRectangle, CornerRadius))
            {
                // Preenche o fundo
                e.Graphics.FillPath(new SolidBrush(BackColor), path);

                // Desenha a borda fina
                using (var pen = new Pen(BorderColor, BorderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Desenha o texto
                TextRenderer.DrawText(e.Graphics, Text, Font,
                    new Rectangle(Padding.Left, Padding.Top,
                                Width - Padding.Left - Padding.Right,
                                Height - Padding.Top - Padding.Bottom),
                    ForeColor, BackColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }

            // Desenha o texto de placeholder
            if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(PlaceholderText) && !Focused)
            {
                using (var brush = new SolidBrush(PlaceholderColor))
                {
                    var flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                    TextRenderer.DrawText(e.Graphics, PlaceholderText, Font,
                        new Rectangle(Padding.Left, 0, Width - Padding.Left - Padding.Right, Height), PlaceholderColor, flags);
                }

            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Invalidate(); // Redesenha ao receber foco
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Invalidate(); // Redesenha ao perder foco
        }

        private GraphicsPath GetRoundRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        public string PlaceholderText { get; set; }
        public Color PlaceholderColor { get; set; } = Color.Gray;

    }
}

