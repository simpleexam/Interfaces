namespace IPlayedInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPlayed> playeds = new List<IPlayed>();
            playeds.Add(new DVDPlayer()) ;
            playeds.Add(new CDplayer());
            playeds.Add(new DVDPlayer());
            playeds.Add(new CDplayer());

            Console.WriteLine("\nзапуск всех плееров");
            foreach (IPlayed item in playeds)
            {
                item.Play();
            }
            Console.WriteLine("\nпауза всех плееров");
            foreach (IPlayed item in playeds)
            {
                item.Pause();
            }
            Console.WriteLine("\nостановка всех плееров");
            foreach (IPlayed item in playeds)
            {
                item.Stop();
            }
        }
    }
}