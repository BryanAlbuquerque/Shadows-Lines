using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class CustomBackgroundPanel : Panel
{
    public CustomBackgroundPanel()
    {
        this.DoubleBuffered = true;
        this.Dock = DockStyle.Fill;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Fundo gradiente
        using (var gradient = new LinearGradientBrush(
            this.ClientRectangle,
            Color.FromArgb(0, 0, 0, 0),
            Color.White,
            45f))
        {
            g.FillRectangle(gradient, this.ClientRectangle);
        }

        // Forma superior
        using (var path = new GraphicsPath())
        {
            path.AddBezier(0, 0, 150, 0, 300, 100, 0, 200);
            path.AddLine(0, 200, 0, 0);

            using (var brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, 200),
                Color.Black,
                Color.Black,
                90f))
            {
                g.FillPath(brush, path);
            }
        }

        // Forma inferior
        using (var path = new GraphicsPath())
        {
            int h = this.Height;
            path.AddBezier(0, h - 100, 200, h, 400, h - 100, this.Width, h);
            path.AddLine(this.Width, h, 0, h);

            using (var brush = new LinearGradientBrush(
                new Rectangle(0, h - 200, this.Width, 200),
                Color.Black,
                Color.Black,
                270f))
            {
                g.FillPath(brush, path);
            }
        }
    }
}
