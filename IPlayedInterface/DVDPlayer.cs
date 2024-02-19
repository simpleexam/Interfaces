using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlayedInterface
{
    internal class DVDPlayer : IPlayed
    {
        public void Pause()
        {
            Console.WriteLine("DVD player is pause");
        }

        public void Play()
        {
            Console.WriteLine("DVD player is play");
        }
        //метод STOP реализован в интерфейсе по умолчанию
       
    }
}
