﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal struct Point
    {
        public double x;
        public double y;
    
    public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        public static double calculatemethod(Point p1, Point p2) {
            double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            return distance;
        }
    }
}