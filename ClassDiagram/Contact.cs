using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Contact : IDeterminable
    {
        public CustomerAccount CustomerAccount
        {
            get => default(CustomerAccount);
            set
            {
            }
        }

        public ManagerAccount ManagerAccount
        {
            get => default(ManagerAccount);
            set
            {
            }
        }

        public DirectorAccount DirectorAccount
        {
            get => default(DirectorAccount);
            set
            {
            }
        }
    }
}