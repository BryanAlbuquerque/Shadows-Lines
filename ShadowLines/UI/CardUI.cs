using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CardUI : Panel
{
    public CardUI()
    {
        this.BackColor = Color.White;
        this.Padding = new Padding(15);
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int radius = 18;

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
        path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
        path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        // ===== SOMBRA MAIS FORTE =====
        using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(90, 0, 0, 0)))
        {
            e.Graphics.FillRectangle(shadowBrush, 5, this.Height - 3, this.Width - 10, 6);
        }

        // ===== BORDA MAIS ESCURA =====
        using (Pen borderPen = new Pen(Color.FromArgb(150, 150, 150), 2))
        {
            e.Graphics.DrawPath(borderPen, path);
        }
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ClassStyle |= 0x00020000; // Drop shadow
            return cp;
        }
    }
}
