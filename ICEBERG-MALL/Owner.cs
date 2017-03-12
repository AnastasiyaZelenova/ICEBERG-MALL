using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG_MALL
{
    class Owner
    {
        private string _nameOwner;

        public string NameOwner
        {
            get { return _nameOwner; }
            set { _nameOwner = value; }
        }

        private int _numberOwner;

        public int NumberOwner
        {
            get { return _numberOwner; }
            set { _numberOwner = value; }
        }

        public Owner (string nameOwner, int numberOwner)
        {
            _nameOwner = nameOwner;
            _numberOwner = numberOwner;
        }

    }
}
