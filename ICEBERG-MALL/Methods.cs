using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows;

namespace ICEBERG_MALL
{
    public class Methods
    {
        private const string _fileName = "../../Serialization.xml";
        Logger _logger = new Logger();
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
            int c = 0;
            List<Category> _tempList = _categories;
            foreach (Category item in _categories)
            {
                if (category.NameCategory == item.NameCategory)
                {
                    c++;
                }
            }
            if (c == 0)
            {
                _tempList.Add(category);
            }
            else
            {
                MessageBox.Show("Такая категория уже есть!");
            }
            _categories = _tempList;
            _logger.Log($"Добавлена категория {category.NameCategory}");
            SerializeData();
        }

        public void DeleteCategory(Category category)
        {
            _categories.Remove(category);
            _logger.Log($"Удалена категория {category.NameCategory}");
            SerializeData();
        }

        public void EditCategory(Category category, string input)
        {
            category.NameCategory = input;
            _logger.Log($"Изменена категория {category.NameCategory}");
            SerializeData();
        }

        public List<Category> SearchCategory(string input)
        {
            List<Category> tmp = new List<Category>();
            foreach (var item in _categories)
            {
                if (item.NameCategory.ToUpper().Contains(input.ToUpper()))
                    tmp.Add(item);
            }
            return tmp;
        }

        public List<TradePoint> SearchTradePoint (Category category, string input)
        {
            List<TradePoint> tmp = new List<TradePoint>();
            foreach (var item in category.TradePoints)
            {
                if (item.Name.ToUpper().Contains(input.ToUpper()))
                    tmp.Add(item);
            }
            return tmp;
        }

        public void AddTradePoint(TradePoint tradepoint, Category category)
        {
            category.TradePoints.Add(tradepoint);
            _logger.Log($"Добавлена торговая точка {tradepoint.Name}");
            SerializeData();
        }

        public void DeleteTradePoint(TradePoint tradepoint, Category category)
        {
            category.TradePoints.Remove(tradepoint);
            _logger.Log($"Удалена торговая точка {tradepoint.Name}");
            SerializeData();
        }

        public void EditTradePoint(TradePoint tradepoint, string name, string description)
        {
            tradepoint.Name = name;
            tradepoint.Description = description;
            _logger.Log($"Изменена торговая точка {tradepoint.Name}");
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
            else
            {
                MessageBox.Show("Файл не существует, либо он пуст", "Ошибка");
            }
        }

    }
}
