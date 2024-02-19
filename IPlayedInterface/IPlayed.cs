using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlayedInterface
{
    public interface IPlayed
    {
        void Play();
        void Pause();

        //реализация метода по умолчанию в интерфейсе ( с .NET 5.0)
        void Stop()
        {
            Console.WriteLine($"{this.GetType().Name} is stopped");
        }
    }
}
