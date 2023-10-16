﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public interface ILogicalExpression<T> where T : IComparable
    {
        bool Compare(Field<T> left, Field<T> right);
    }
}
