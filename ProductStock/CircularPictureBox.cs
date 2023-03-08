﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProductStock
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}
