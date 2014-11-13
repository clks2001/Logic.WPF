﻿using Logic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Graph
{
    public class PageGraphContext
    {
        public IDictionary<XPin, ICollection<Tuple<XPin, bool>>> Connections { get; set; }
        public IDictionary<XPin, ICollection<Tuple<XPin, bool>>> Dependencies { get; set; }
        public IDictionary<XPin, PinType> PinTypes { get; set; }
        public IList<XBlock> OrderedBlocks { get; set; }
    }
}
