﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj3
{
    public class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int data){
            this.data = data;
        }
    }
}
