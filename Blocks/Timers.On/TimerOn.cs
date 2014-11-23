﻿using Logic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timers.On
{
    public class TimerOn : XBlock
    {
        public TimerOn()
        {
            base.Properties = new List<KeyValuePair<string, XProperty>>();
            base.Shapes = new List<IShape>();
            base.Pins = new List<XPin>();

            base.Name = "TIMER-ON";

            XProperty delayProperty = new XProperty("1");
            base.Properties.Add(new KeyValuePair<string, XProperty>("Delay", delayProperty));

            base.Shapes.Add(
                new XText()
                {
                    X = -15.0,
                    Y = -15.0,
                    Width = 60.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Center,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "T={0}s",
                    TextProperty = delayProperty
                });
            base.Shapes.Add(
                new XText()
                {
                    X = 0.0,
                    Y = 3.0,
                    Width = 15.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Center,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "T"
                });
            base.Shapes.Add(
                new XText()
                {
                    X = 15.0,
                    Y = 3.0,
                    Width = 15.0,
                    Height = 15.0,
                    HAlignment = HAlignment.Center,
                    VAlignment = VAlignment.Center,
                    FontName = "Consolas",
                    FontSize = 11.0,
                    Text = "0"
                });
            base.Shapes.Add(new XRectangle() { X = 0.0, Y = 0.0, Width = 30.0, Height = 30.0, IsFilled = false });
            base.Shapes.Add(new XLine() { X1 = 7.0, Y1 = 18.0, X2 = 7.0, Y2 = 22.0 });
            base.Shapes.Add(new XLine() { X1 = 23.0, Y1 = 18.0, X2 = 23.0, Y2 = 22.0 });
            base.Shapes.Add(new XLine() { X1 = 23.0, Y1 = 20.0, X2 = 7.0, Y2 = 20.0 });
            base.Pins.Add(new XPin() { Name = "L", X = 0.0, Y = 15.0, PinType = PinType.None, Owner = null });
            base.Pins.Add(new XPin() { Name = "R", X = 30.0, Y = 15.0, PinType = PinType.None, Owner = null });
            base.Pins.Add(new XPin() { Name = "T", X = 15.0, Y = 0.0, PinType = PinType.None, Owner = null });
            base.Pins.Add(new XPin() { Name = "B", X = 15.0, Y = 30.0, PinType = PinType.None, Owner = null });
        }
    }
}
