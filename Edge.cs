﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_2
{
    public class Edge //Ребро
    {
        public int Weight { get; set; } //вес связи
        public Node Node { get; set; } // узел, на который связь ссылается
    }

}
