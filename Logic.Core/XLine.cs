﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Core
{
    public class XLine : IShape
    {
        public IStyle Style { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public void Render(object dc, IRenderer renderer, IStyle style)
        {
            renderer.DrawLine(dc, style, this);
        }
    }
}
