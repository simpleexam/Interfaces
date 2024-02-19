using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlayedInterface
{
    internal class CDplayer : IPlayed
    {
        public void Pause()
        {
            Console.WriteLine("CD player is pause");
        }

        public void Play()
        {
            Console.WriteLine("CD player is play");
        }
        //метод STOP реализован в интерфейсе по умолчанию
    }
}
