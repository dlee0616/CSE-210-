using System;

namespace game
{
    class developer
    {
        static void Main(string[] args)
        {
            // get first player 
            string player = getFirstPlayer();
            bool gameOver = false;
            //create board
            string[] board = {" "," "," "," "," "," "," "," "," "};
            while(!gameOver){
                //summon board
                DisplayBoard(board);
                int move = getMove(board);
                board = setBoard(board,move,player);
                //determeine winner
                gameOver = checkVictory(board);
                //check victory
                player = togglePlayer(player);
                
            }
        }
        static string getFirstPlayer(){
            while (true){
                Console.Write("Welcome to the Game. Who is going first: ");
                string FirstPlayer = Console.ReadLine();
                switch (FirstPlayer){
                    case "x":
                        Console.WriteLine("x\'s turn");
                        return "x";
                    case "o":
                        Console.WriteLine("o\'s turn");
                        return "o"; 
                    default:
                        Console.WriteLine("It needs to be x or o");
                        break;
                }
            }
        }
        static void DisplayBoard(string[] board){
            Console.WriteLine(String.Format("{0}|{1}|{2}\n-------\n{3}|{4}|{5}\n-------\n{6}|{7}|{8}",board));
        }
        static int getMove(string[] board){
            while(true){
                Console.Write("Make your move(1 - 9): ");
                try{
                    int move = Int32.Parse(Console.ReadLine());
                    if (move >= 1 && move <= 9 && board[move - 1] == " ") {
                        return move - 1;
                    }
                }
                catch{
                }
                Console.WriteLine(" Error: Please choose between 1 and 9");
            }
        }   
        static string[] setBoard(string[] board, int move, string player){
            board[move] = player;
            return board; 
        }
        static string togglePlayer(string player){
            if (player == "x"){
                return "o";
            }
            return "x";
        }
        static bool checkVictory(string[] board){
            string player = "x";
            for (int i = 0; i < 2; i += 1){
                if (board[0] == player && board[1] == player && board[2] == player){

                    return announceVictory(player,board);
                }
                else if  (board[3] == player && board[4] == player && board[5] == player){
                    return announceVictory(player,board);
                }
                else if  (board[6] == player && board[7] == player && board[8] == player){
                    return announceVictory(player,board);
                }
                else if  (board[0] == player && board[3] == player && board[6] == player){
                    return announceVictory(player,board);
                }
                 else if  (board[1] == player && board[4] == player && board[7] == player){
                    return announceVictory(player,board);
                }
                 else if  (board[2] == player && board[5] == player && board[8] == player){
                    return announceVictory(player,board);
                }
                 else if  (board[0] == player && board[4] == player && board[8] == player){
                    return announceVictory(player,board);
                }
                 else if  (board[2] == player && board[4] == player && board[6] == player){
                    return announceVictory(player,board);
                }
                else{
                    player = "o";
                }

            
            }
            return false;
        }
        static bool announceVictory(string player,string[] board){
            DisplayBoard(board);
            Console.WriteLine(String.Format("{0} has won",player));
            return true;

        }

    }
}
