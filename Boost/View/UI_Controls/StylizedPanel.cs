using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Boost.View.UI_Controls
{
    public class StylizedPanel : Panel
    {
        public Color GradientColorA { get; set; }

        public Color GradientColorB { get; set; }

        public float GradientAngle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, GradientColorA, GradientColorB, GradientAngle);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
