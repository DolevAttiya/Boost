﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View.UI_Controls
{
    public class StylizedForm : Form
    {
        public Color GradientColorA { get; set; }

        public Color GradientColorB { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, GradientColorA, GradientColorB, Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
