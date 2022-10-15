using System;
// The program must include a README file.
// The program must include class and method comments.
// The program must have at least two classes.
// The program must remain true to game play described in the overview.

namespace Hilo
{
    class player
    {
       static void Main(string[] args)
        {
            Director director = new Director();
            director.startGame();
        }
    }
}

