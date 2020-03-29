﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Point
{
    
    public int x;
    public int y;

    //Constructor
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Operator overloading
    public static Point operator + (Point a, Point b)
    {
        return new Point(a.x + b.x, a.y + b.y);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.x - p2.x, p1.y - p2.y);
    }
    public static bool operator == (Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }

    // Override Equal: code will run faster because default implementation runs through reflections
    public override bool Equals(object obj)
    {
        if(obj is Point)
        {
            Point p = (Point)obj;
            return x == p.x && y == p.y;
        }
        //return base.Equals(obj);
        return false;
    }

    public bool Equals (Point p)
    {
        return x == p.x && y == p.y;
    }

    public override int GetHashCode()
    {
        return x ^ y;
    }

    // Ability to just log the point
    public override string ToString()
    {
        return string.Format("({0},{1})", x, y);
    }
}
