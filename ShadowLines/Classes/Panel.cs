using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 50;
    public Color BorderColor { get; set; } = Color.Black;
    public int BorderSize { get; set; } = 2;

    public RoundedPanel()
    {
        this.DoubleBuffered = true; // melhora o desempenho gráfico
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // cria o caminho arredondado
        using (GraphicsPath path = new GraphicsPath())
        {
            int radius = BorderRadius * 2;
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius - 1, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius - 1, this.Height - radius - 1, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius - 1, radius, radius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
