using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    /// <summary>
    /// Пространство имен, содержащее приложение для демонстрации работы со списком объектов галактик.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в приложение, которая выводит приветствие, запускает перебор списка галактик и ожидает нажатия клавиши.
        /// </summary>
        /// <param name="args">Массив строк, содержащий аргументы командной строки</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();
        }
        /// <summary>
        /// Метод, создающий список объектов галактик и выводящий их названия, расстояние и тип в консоль.
        /// </summary>
        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
            new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
            new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
            new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
            new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
        };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }

            // Expected Output:
            //  Tadpole  400,  Spiral
            //  Pinwheel  25,  Spiral
            //  Cartwheel, 500,  Lenticular
            //  Small Magellanic Cloud .2,  Irregular
            //  Andromeda  3,  Spiral
            //  Maffei 1,  11,  Elliptical
        }
    }
    /// <summary>
    /// Класс, представляющий данные об отдельной галактике, включая её название, расстояние и морфологический тип.
    /// </summary>
    public class Galaxy
    {
        public string Name { get; set; }

        public double MegaLightYears { get; set; }
        public GType GalaxyType { get; set; }

    }
    /// <summary>
    /// Класс-обертка, преобразующий символьный код типа галактики в человекочитаемое перечисление.
    /// </summary>
    public class GType
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса GType, преобразуя символьный код
        /// </summary>
        /// <param name="type">Символьный код типа галактики</param>
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'I':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Свойство, хранящее значение перечисления, соответствующее типу галактики
        /// </summary>
        public object MyGType { get; set; }
        /// <summary>
        /// Закрытое перечисление, определяющее возможные морфологические типы галактик.
        /// </summary>
        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}
