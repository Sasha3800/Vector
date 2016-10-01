using System;

namespace vec
{
    class Vector
    {
        private double x;
        private double y;
        private double z;
        /// <summary>
        /// Инициализация координат вектора
        /// </summary>
        /// <param name="_x">Координата x</param>
        /// <param name="_y">Координата y</param>
        /// <param name="_z">Координата z</param>
        public Vector(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public double _x
        {
            get
            {
                return x;
            }
        }

        public double _y
        {
            get
            {
                return y;
            }
        }

        public double _z
        {
            get
            {
                return z;
            }
        }
        /// <summary>
        /// Находит модуль вектора
        /// </summary>
        /// <returns></returns>
        public float Mod()
        {
            float a;
            a = (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2 + Math.Pow(z, 2)));
            return a;
        }
        /// <summary>
        /// Метод сложения векторов
        /// </summary>
        /// <param name="a"></param>
        public void Plus(Vector a)
        {

        }

    }
}
