using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class ValueValidator
    {
        /// <summary>
        /// Метод проверки длинны строки.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="maxLength">Максимально допустимое значение длинны.</param>
        /// <param name="propertyName">Имя проверяемого поля.</param>
        /// <exception cref="ArgumentException">Ошибка выводимая при срабатывании проверки.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength) {
                throw new ArgumentException(
                    $"The {propertyName} should be equal to" +
                    $" {value.Length}, but was {value}.");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        { if (value < min || value > max) 
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}");
            }
        }

    }
}
