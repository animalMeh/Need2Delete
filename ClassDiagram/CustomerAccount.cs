using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class CustomerAccount : Account
    {
        public TestedAccount TestedAccount
        {
            get => default(TestedAccount);
            set
            {
            }
        }
    }
}