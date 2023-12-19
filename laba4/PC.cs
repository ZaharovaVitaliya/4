using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class PC
    {
        string model;
        int mgh;
        string firma;
        int hdd;
        int memory;
        int price;

        //3) Объявить конструктор класса Person, который будет принимать значение поля name: 
        public PC(string model, int mgh, string firma, int hdd, int memory, int price)
        {
            this.model = model;
            this.mgh = mgh;
            this.firma = firma;
            this.hdd = hdd;
            this.memory = memory;
            this.price = price;
        }

        public string GetInformation()
        {
            string information;
            information = "Модель: " + this.model + "; Тактовая частота: " + this.mgh.ToString() + ";  Марка видеокарты: " + this.firma + "; Объем жесткого диска: " + this.hdd + "; Объем оперативной памяти: " + this.memory.ToString() + "; Стоимость: " + this.price + " руб.";
            return information;
        }
    }
}
