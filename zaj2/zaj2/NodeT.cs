﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj2
{
    public class NodeT
    {
        public NodeT lewe;
        public NodeT prawe;
        public NodeT rodzic;
        public int data;

        public NodeT(int data)
        {

            this.data = data;
        }
    }
}
