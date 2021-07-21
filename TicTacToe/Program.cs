using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fields = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string spieler = "Spieler 1";
            string gewinner = "";
            int zug = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Tic Tac Toe");
                showField(fields);
                Console.Write("\n{0} bitte ziehen: ", spieler);
                int field;
                try
                {
                    field = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
                catch
                {
                    continue;
                }
                //Falscheingabe ausschließen
                if (field < 1 || field > 9 || fields[field - 1] != field.ToString()) continue;

                zug++;
                fields[field - 1] = spieler == "Spieler 1" ? "X" : "O";

                #region Alternative
                /*
                if (spieler == "Spieler 1")
                {
                    fields[field-1] = "X";
                }
                else
                {
                    fields[field-1] = "O";
                }
                 */
                #endregion

                //Prüfe gewonnen
                int sum = 0;

                for (int j = 0; j < fields.Length; j = j + 3)
                {
                    sum = fields[j][0] + fields[j + 1][0] + fields[j + 2][0];
                    if (sum == 3 * 88 || sum == 3 * 79)
                    {
                        gewinner = spieler;
                        continue;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    sum = fields[j][0] + fields[j + 3][0] + fields[j + 6][0];
                    if (sum == 3 * 88 || sum == 3 * 79)
                    {
                        gewinner = spieler;
                        continue;
                    }
                }

                sum = fields[0][0] + fields[4][0] + fields[8][0];
                if (sum == 3 * 88 || sum == 3 * 79)
                {
                    gewinner = spieler;
                    continue;
                }

                sum = fields[2][0] + fields[4][0] + fields[6][0];
                if (sum == 3 * 88 || sum == 3 * 79)
                {
                    gewinner = spieler;
                    continue;
                }
                if (zug == 10) break;
                //Spielerwechsel
                spieler = spieler == "Spieler 1" ? "Spieler 2" : "Spieler 1";
            } while (gewinner == "" );
            
            
            //Letzte Ausgabe mit Gewinner;
            Console.Clear();
            Console.WriteLine("Tic Tac Toe");
            showField(fields);

            if (gewinner != "")
            {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Gewinner ist: " + gewinner);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("Unentschieden!!!");
            }
            Console.ReadLine();

        }

        static void showField(string[] fields)
        {
            Console.Write("+---+---+---+\n| ");
            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i] == "X") Console.ForegroundColor = ConsoleColor.Red;
                if (fields[i] == "O") Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(fields[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" | ");
                if (i == 8) break;
                if (i % 3 == 2) Console.Write("\n+---+---+---+\n| ");
            }
            Console.WriteLine("\n+---+---+---+");
        }
    }
}
