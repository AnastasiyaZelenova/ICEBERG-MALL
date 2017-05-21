using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG_MALL
{
   public class TradePoint
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private Category _category;

        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public TradePoint() { }

        public TradePoint(string name, string description)
        {
            _name = name;
            _description = description;
        }
       
    }
}
