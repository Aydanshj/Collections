﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    internal class Student
    {
        public string Name;
        public string GroupNo;

        public override string ToString()
        {
            return $"Name: {Name} - GroupNo: {GroupNo}";
        }

    }
}
