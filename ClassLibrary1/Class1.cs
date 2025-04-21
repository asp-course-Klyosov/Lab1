using System;

namespace ClassLibrary1
{
    public class MyLibrary
    {
        /// <summary>
        /// Складывает два целых числа.
        /// </summary>
        /// <param name="num1">Первое целое число.</param>
        /// <param name="num2">Второе целое число.</param>
        /// <returns>Сумма двух целых чисел.</returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Складывает два числа с плавающей точкой.
        /// </summary>
        /// <param name="num1">Первое число с плавающей точкой.</param>
        /// <param name="num2">Второе число с плавающей точкой.</param>
        /// <returns>Сумма двух чисел с плавающей точкой.</returns>
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Складывает два числа, представленных в виде строк.
        /// </summary>
        /// <param name="num1">Первое число в виде строки.</param>
        /// <param name="num2">Второе число в виде строки.</param>
        /// <returns>Сумма двух чисел или 0, если строки не могут быть преобразованы в числа.</returns>
        public static double Add(string num1, string num2)
        {
            double.TryParse(num1, out var number1);
            double.TryParse(num2, out var number2);

            return number1 + number2;
        }

        /// <summary>
        /// Вычитает одно целое число из другого.
        /// </summary>
        /// <param name="num1">Уменьшаемое целое число.</param>
        /// <param name="num2">Вычитаемое целое число.</param>
        /// <returns>Разность двух целых чисел.</returns>
        public static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Вычитает одно число с плавающей точкой из другого.
        /// </summary>
        /// <param name="num1">Уменьшаемое число с плавающей точкой.</param>
        /// <param name="num2">Вычитаемое число с плавающей точкой.</param>
        /// <returns>Разность двух чисел с плавающей точкой.</returns>
        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Вычитает одно число из другого, представленных в виде строк.
        /// </summary>
        /// <param name="num1">Уменьшаемое число в виде строки.</param>
        /// <param name="num2">Вычитаемое число в виде строки.</param>
        /// <returns>Разность двух чисел или 0, если строки не могут быть преобразованы в числа.</returns>
        public static double Substract(string num1, string num2)
        {
            double.TryParse(num1, out var number1);
            double.TryParse(num2, out var number2);

            return number1 - number2;
        }

        /// <summary>
        /// Умножает два целых числа.
        /// </summary>
        /// <param name="num1">Первое целое число.</param>
        /// <param name="num2">Второе целое число.</param>
        /// <returns>Произведение двух целых чисел.</returns>
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Умножает два числа с плавающей точкой.
        /// </summary>
        /// <param name="num1">Первое число с плавающей точкой.</param>
        /// <param name="num2">Второе число с плавающей точкой.</param>
        /// <returns>Произведение двух чисел с плавающей точкой.</returns>
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Умножает два числа, представленных в виде строк.
        /// </summary>
        /// <param name="num1">Первое число в виде строки.</param>
        /// <param name="num2">Второе число в виде строки.</param>
        /// <returns>Произведение двух чисел или 0, если строки не могут быть преобразованы в числа.</returns>
        public static double Multiply(string num1, string num2)
        {
            double.TryParse(num1, out var number1);
            double.TryParse(num2, out var number2);

            return number1 * number2;
        }

        /// <summary>
        /// Делит одно целое число на другое.
        /// </summary>
        /// <param name="num1">Делимое целое число.</param>
        /// <param name="num2">Делитель целое число.</param>
        /// <returns>Частное двух целых чисел.</returns>
        public static double Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Делит одно число с плавающей точкой на другое.
        /// </summary>
        /// <param name="num1">Делимое число с плавающей точкой.</param>
        /// <param name="num2">Делитель число с плавающей точкой.</param>
        /// <returns>Частное двух чисел с плавающей точкой.</returns>
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Делит одно число на другое, представленных в виде строк.
        /// </summary>
        /// <param name="num1">Делимое число в виде строки.</param>
        /// <param name="num2">Делитель число в виде строки.</param>
        /// <returns>Частное двух чисел или 0, если строки не могут быть преобразованы в числа.</returns>
        public static double Divide(string num1, string num2)
        {
            double.TryParse(num1, out var number1);
            double.TryParse(num2, out var number2);

            return number1 / number2;
        }

        /// <summary>
        /// Возводит целое число в степень.
        /// </summary>
        /// <param name="num1">Основание степени.</param>
        /// <param name="num2">Показатель степени.</param>
        /// <returns>Результат возведения числа в степень.</returns>
        public static int Power(int num1, int num2)
        {
            for (int i = 0; i < num2; i++)
            {
                num1 *= i;
            }

            return num1 * num2;
        }

        /// <summary>
        /// Возводит число с плавающей точкой в степень.
        /// </summary>
        /// <param name="num1">Основание степени.</param>
        /// <param name="num2">Показатель степени.</param>
        /// <returns>Результат возведения числа в степень.</returns>
        public static double Power(double num1, double num2)
        {
            for (int i = 0; i < num2; i++)
            {
                num1 *= i;
            }

            return num1 * num2;
        }

        /// <summary>
        /// Вычисляет квадратный корень числа с использованием итерационного метода.
        /// </summary>
        /// <param name="val">Число, из которого извлекается корень.</param>
        /// <param name="nIter">Количество итераций для уточнения результата (по умолчанию 10).</param>
        /// <returns>Квадратный корень числа.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если входное значение меньше 0.</exception>
        public double SquareRoot(double val, int nIter = 10)
        {
            if (val < 0) throw new ArgumentOutOfRangeException("val must be greater than 0");
            if (val == 0) return 0;

            double x0;
            if (val < 1) x0 = 1;
            else x0 = val / 2;

            double xCurrent = x0;
            double xNext;
            for (int i = 1; i < nIter; i++)
            {
                xNext = (xCurrent + (val / xCurrent)) / 2;
                xCurrent = xNext;
            }

            return xCurrent;
        }
    }
}