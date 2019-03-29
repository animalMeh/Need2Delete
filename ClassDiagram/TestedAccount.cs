using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class TestedAccount : Account, ITestable
    {
        public int Teacher
        {
            get => default(int);
            set
            {
            }
        }
    }
}