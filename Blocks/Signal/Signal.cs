﻿using Logic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Signal
{
    public class Signal : XBlock
    {
        public Signal()
        {
            base.Properties = new List<KeyValuePair<string, XProperty>>();
            base.Shapes = new List<IShape>();
            base.Pins = new List<XPin>();

            base.Name = "SIGNAL";

            XProperty designationProperty = new XProperty("Designation");
            base.Properties.Add(new KeyValuePair<string, XProperty>("Designation", designationProperty));

            XProperty descriptionProperty = new XProperty("Description");
            base.Properties.Add(new KeyValuePair<string, XProperty>("Description", descriptionProperty));

            XProperty signalProperty = new XProperty("Signal");
            base.Properties.Add(new KeyValuePair<string, XProperty>("Signal", signalProperty));

            XProperty conditionProperty = new XProperty("Condition");
            base.Properties.Add(new KeyValuePair<string, XProperty>("Condition", conditionProperty));

            base.Shapes.Add(
                new XText()
                {
                    X = 5.0,
                    Y = 0.0,
                    Width = 200.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Left,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "{0}",
                    TextProperty = designationProperty
                });
            base.Shapes.Add(
                new XText()
                {
                    X = 5.0,
                    Y = 15.0,
                    Width = 200.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Left,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "{0}",
                    TextProperty = descriptionProperty
                });
            base.Shapes.Add(
                new XText()
                {
                    X = 215.0,
                    Y = 0.0,
                    Width = 80.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Left,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "{0}",
                    TextProperty = signalProperty
                });
            base.Shapes.Add(
                new XText()
                {
                    X = 215.0,
                    Y = 15.0,
                    Width = 80.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Left,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "{0}",
                    TextProperty = conditionProperty
                });
            base.Shapes.Add(new XRectangle() { X = 0.0, Y = 0.0, Width = 300.0, Height = 30.0, IsFilled = false });
            base.Shapes.Add(new XLine() { X1 = 210.0, Y1 = 0.0, X2 = 210.0, Y2 = 30.0 });
            base.Pins.Add(new XPin() { Name = "I", X = 0.0, Y = 15.0, PinType = PinType.Input, Owner = null });
            base.Pins.Add(new XPin() { Name = "O", X = 300.0, Y = 15.0, PinType = PinType.Output, Owner = null });
        }
    }
}
