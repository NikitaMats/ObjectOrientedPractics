using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        /// <summary>
        /// Переменная хранящее уникальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Счетчик всех существующих объектов покупателя.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Переменная хранящая полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Переменная хранящая адрес доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает имя покупателя. Длина не более 200 символов.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Переменная хранящая адрес доставки для покупателя. Длинна до 500 символов.
        /// </summary>
        public string Address 
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _fullname = value;
            }
        }



        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Customer()
        {
            _id = _allItemsCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть не длиннее 200 символов.</param>
        /// <param name="info">Информация. Должно быть не длиннее 1000 символов.</param>
        /// <param name="cost">Цена. Должно быть от 0 до 100000.</param>
        public Customer(string fullname, string adddress)
        {
            _id = _allItemsCount++;
            _fullname = fullname;
            _address = adddress;
        }


    }
}
