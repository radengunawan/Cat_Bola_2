using System;

namespace Cat_Bola_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainBolaCat senpi = new MainBolaCat();
            // TO Fix the error:
            // 1. Add the ReadInt method

            while (true)
            {
                Console.WriteLine($"{senpi.Bollaz} balls, {senpi.BallsLoaded} loaded.");

                if (senpi.IsEmpty()) Console.WriteLine("DANGER!. You're out of ammo");
                Console.WriteLine("Shoot=Space, Reload = r, Quit = q");

                char khoonci = Console.ReadKey(true).KeyChar;

                if (khoonci == ' ') Console.WriteLine($"Shooting returned {senpi.Shoot()}");

                else if (khoonci == 'r') senpi.Reload();

                else if (khoonci == '+')
                {
                    //senpi.SetBalls(senpi.GetBalls() + PaintballGun.MAGAZINE_SIZE);
                    // senpi.Bollaz += PaintballGun.MAGAZINE_SIZE;
                    senpi.Bollaz += senpi.MagazineSize;
                }

                else if (khoonci == 'q') return;



            }
        }
    }
}
