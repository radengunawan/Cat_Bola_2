using System;
using System.Collections.Generic;
using System.Text;

namespace Cat_Bola_2
{
    class MainBolaCat
    {

        //public const int MAGAZINE_SIZE = 16;  // We’ll keep this constant public because
        //it’s going to be used by the Main method
        private int balls = 100;
        //private int ballsLoaded = 0;

        public static int MagazineSize { get; private set; } = 16;


        public int BallsLoaded { get; private set; }

        // public int GetBallsLoaded()               //--------------------------------   
        // { return this.ballsLoaded; }             //When the game requires 
        // to show the amount of 
        public bool IsEmpty()                   // remaining balls and the number       
        { return this.BallsLoaded == 0; }       // of balls loaded in the UI, it

        //public int GetBalls()                   // is able to summon the GetBalls and
        //{ return this.balls; }                  // GetBallsLoaded methods.
        //                                        //---------------------------------

        //public void SetBalls(int numberOfBalls)
        //{
        //    if (numberOfBalls > 0)
        //        this.balls = numberOfBalls; // The game wants to be capable to arrange the amount of balls.
        //    Reload();                       // The SetBalls method secure the balls field by only
        //}                                   // permitting the game to arrange a positive number of balls.
        //                                    // Then it summons Reload to automatically reload the gun.

        public int Bollaz
        {
            get { return this.balls; }

            set
            {
                if (value > 0)
                    this.balls = value;
                Reload();
            }
            //get; set;
        }

        //public int BallsLoaded
        //{
        //    get { return this.ballsLoaded; }
        //    set { this.ballsLoaded = value; }
        //}


        public void Reload()                       // The only way to refill the gun is to summon the
        {                                           // Reload method, which fills the gun with a
            if (this.balls > MagazineSize)         // full magazine, or the  number of balls
                this.BallsLoaded = MagazineSize;   // left if there isn’t a full magazine’s worth.
            else                                    // This protects the balls and ballsLoaded fields
                this.BallsLoaded = this.balls;      // from being async.
        }


        public bool Shoot()
        {

            if (BallsLoaded == 0) return false;
            this.BallsLoaded--;                     // The Shoot method returns true
            this.balls--;                           // and decrements the balls field if
            return true;                            // the gun is loaded, or false if it isn’t.
        }

    }
}