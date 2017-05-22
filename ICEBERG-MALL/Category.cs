using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG_MALL
{
   public  class Category
    {
        private string _nameCategory;
    
        public string NameCategory
        {
            get { return _nameCategory; }
            set { _nameCategory = value; }
        }

        private List<TradePoint> _tradePoints = new List<TradePoint>();

        public List<TradePoint> TradePoints
        {
            get { return _tradePoints; }
            set { _tradePoints = value; }
        }
        public Category() { }
        
        public Category (string nameCategory)
        {
            _nameCategory = nameCategory;
        }

    }
}
