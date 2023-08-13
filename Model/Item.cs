using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        /// <summary>
        /// Переменная хранящее уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Счетчик всех существующих объектов товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Переменная хранящая название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Переменная хранящая информацию о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Переменная хранящая стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает имя товара. Длина не более 200 символов.
        /// </summary>
        public string Name 
        { 
            get    
            { 
                return _name;    
            } 
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара. Длина не более 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. Значение от 0 до 100000.
        /// </summary>
        public double Cost {
            get 
            {
                return _cost; 
            }
            set 
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = _allItemsCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть не длиннее 200 символов.</param>
        /// <param name="info">Информация. Должно быть не длиннее 1000 символов.</param>
        /// <param name="cost">Цена. Должно быть от 0 до 100000.</param>
        public Item(string name, string info, double cost)
        {
            _id = _allItemsCount++;
            _name = name;
            _info = info;
            _cost = cost;
        }


    }
}
