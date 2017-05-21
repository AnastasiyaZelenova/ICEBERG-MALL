using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ICEBERG_MALL
{
    public class Methods
    {
        private const string _fileName = "../../Serialization.xml";

        private List<Category> _categories = new List<Category>();
       
        public List<Category> Categories
        {
            get { return _categories; }
            set { value = _categories; }
        }

        public Methods()
        {
            DeserializeData();
        }

        public Methods(List<Category> categories)
        {
            _categories = categories;
        }

        public void AddCategory(Category category)
        {
            _categories.Add(category);
            SerializeData();
        }

        public void DeleteCategory(Category category)
        {
            _categories.Remove(category);
            SerializeData();
        }

        public void EditCategory(Category category, string input)
        {
            category.NameCategory = input;
            SerializeData();
        }

        public void AddTradePoint(TradePoint tradepoint, Category category)
        {
            category.TradePoints.Add(tradepoint);
            SerializeData();
        }

        public void DeleteTradePoint(TradePoint tradepoint, Category category)
        {
            category.TradePoints.Remove(tradepoint);
            SerializeData();
        }

        public void EditTradePoint(TradePoint tradepoint, string name, string description)
        {
            tradepoint.Name = name;
            tradepoint.Description = description;
            SerializeData();
        }

        private void SerializeData()
        {
            File.Delete(_fileName);
            using (var fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Category>));
                xml.Serialize(fs, Categories);
            }
        }

        private void DeserializeData()
        {
            if (File.Exists(_fileName))
            {
                using (var fs = new FileStream(_fileName, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Category>));
                    _categories = (List<Category>)xml.Deserialize(fs);
                }
            }
        }

    }
}
