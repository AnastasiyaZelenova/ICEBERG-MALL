using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG_MALL
{
    class TradePoint
    {
        private string _typeTradePoint;

        public string TypeTradePoint
        {
            get { return _typeTradePoint; }
            set { _typeTradePoint = value; }
        }

        private string _nameTradePoint;

        public string NameTradePoint
        {
            get { return _nameTradePoint; }
            set { _nameTradePoint = value; }
        }

        private int _numberTradePoint;

        public int NumberTradePoint
        {
            get { return _numberTradePoint; }
            set { _numberTradePoint = value; }
        }

        private DateTime _openingHours;

        public DateTime OpeningHours
        {
            get { return _openingHours; }
            set { _openingHours = value; }
        }

        private int _floor;

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public TradePoint (string typeTradePoint, string nameTradePoint, int numberTradePoint, DateTime openingHours, int floor)
        {
            _typeTradePoint = TypeTradePoint;
            _nameTradePoint = NameTradePoint;
            _numberTradePoint = NumberTradePoint;
            _openingHours = OpeningHours;
            _floor = Floor;
        }


    }
}
