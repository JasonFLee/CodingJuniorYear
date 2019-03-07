using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    public class SudokuBoard
    {
       
        /// <summary>
        /// Most recent row and most recent column, used for coloring the board
        /// </summary>
        int mrr = -1, mrc = -1;
        int[,] userChangedColors = new int[9, 9];

        /// <summary>
        /// The data structure used to hold board data.
        /// </summary>
        public int[,] Board { get; set; } = new int[9, 9];

        /// <summary>
        /// Defualt constructor for a sudokuboard. Randomly generates solvable boards.
        /// </summary>
        public SudokuBoard()
        {
            Board = new int[9, 9] {
                {0,0,0,2,6,0,7,0,1 },
                {6,8,0,0,7,0,0,9,0},
                {1,9,0,0,0,4,5,0,0 },
                {8,2,0,1,0,0,0,4,0 },
                {0,0,4,6,0,2,9,0,0 },
                {0,5,0,0,0,3,0,2,8 },
                {0,0,9,3,0,0,0,7,4 },
                {0,4,0,0,5,0,0,3,6 },
                {7,0,3,0,1,8,0,0,0 }};
        }

        /// <summary>
        /// Overloaded constructor for a sudokuboard that reads in a file and generates
        /// the board based on that files information
        /// 
        /// There is a file in AppDomain.CurrentDomain.BaseDirectory called HardPuzzles.txt
        /// Each line has 81 characters, either a number or a '.' 
        /// '.' means that the cell should be empty (AKA 0) on the sudokuboard
        /// Use this data to parse a line into the board variable.
        /// </summary>
        /// <param name="fileName">Name of the file you want to load</param>
        public SudokuBoard(string fileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

            }
            Random rnd = new Random();
            string puzzle = file[rnd.Next(1, file.Count)];

            int count = 0;
            for(int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    Board[x, y] = puzzle[count];
                    count = count + 1;
                }
            }
        }

        public SudokuBoard(SudokuBoard board)
        {
            Array.Copy(board.Board, this.Board, this.Board.Length);
        }
        /// <summary>
        /// Checks the entire board to see if it is valid or not.
        /// First, if ANY element in the board is empty (0) then the board is invalid.
        /// Next, check all rows to make sure every row contains explicitly 1-9, no duplicates.
        /// Next, check all columns to make sure every column contains explicity 1-9, no duplicates.
        /// Next, check all squares to make sure every square contains explicity 1-9, no duplicates.
        /// 
        /// If you are going to return false, because you found an error I recommend printing out the board, as well as
        /// the row/column of the error. Makes it easier to debug.
        /// </summary>
        /// <returns>
        /// True: The board is valid, and solved
        /// False: Something is wrong with the board, whether it has empty elements or is organized incorrectly
        /// </returns>
        public bool VerifyBoard()
        {
            //checks rows
            for (int x = 0; x < 9; x++)
            {
                List<int> numbers = new List<int>();

                for (int y = 0; y < 9; y++)
                {
                    numbers.Add(Board[x, y]);
                }
                numbers = numbers.OrderBy(t => t).ToList();
                for (int i = 0; i < 9; i++)
                {
                    if (numbers[i] != i + 1)
                    {
                        return false;
                    }
                }
            }
            //checks columns
            for (int y = 0; y < 9; y++)
            {
                List<int> numbers = new List<int>();

                for (int x = 0; x < 9; x++)
                {
                    numbers.Add(Board[x, y]);
                }
                numbers = numbers.OrderBy(t => t).ToList();
                for (int i = 0; i < 9; i++)
                {
                    if (numbers[i] != i + 1)
                    {
                        return false;
                    }
                }
            }
            //check squares
            for (int x = 0; x < 9; x+=3)
            {
                for (int y = 0; y < 9; y+=3)
                {
                    List<int> numbers = new List<int>();


                    for (int upperRowBox = x - x % 3; upperRowBox < x - x % 3 + 3; upperRowBox++)
                    {
                        for (int LeftColBox = y - y % 3; LeftColBox < y - y % 3 + 3; LeftColBox++)
                        {
                            numbers.Add(Board[upperRowBox, LeftColBox]);
                        }
                    }
                    numbers = numbers.OrderBy(t => t).ToList();

                    for (int i = 0; i < 9; i++)
                    {
                        if (numbers[i] != i + 1)
                        {
                            return false;
                        }
                    }
                }

            }
            return true;
        }

        public List<int> FindLegalDigits(int row, int col)
        {
            List<int> possibledigits = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Remove from the list all elements in the row
            for (int x = 0; x < 9; x++)
            {
                possibledigits.Remove(Board[row, x]);
            }
            //Remove from the list all elements in the column
            for (int x = 0; x < 9; x++)
            {
                possibledigits.Remove(Board[x, col]);
            }
            //remove from the list all elements in the box

            List<int> numbers = new List<int>();


            for (int upperRowBox = row - row % 3; upperRowBox < row - row % 3 + 3; upperRowBox++)
            {
                for (int LeftColBox = col - col % 3; LeftColBox < col - col % 3 + 3; LeftColBox++)
                {
                    possibledigits.Remove(Board[upperRowBox, LeftColBox]);
                    //is this removing the correct thing?
                }
            }

            return possibledigits;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints out the sudoku board in an easily understandable way
        /// </summary>
        public void PrintBoard()
        {
            Console.WriteLine("Y  0  1  2   3  4  5   6  7  8");
            Console.WriteLine("X  ---------------------------");
            for (int row = 0; row < 9; row++)
            {
                if (row % 3 == 0 && row != 0)
                {
                    Console.WriteLine("  ---------+---------+---------");
                }
                Console.Write(row + "|");
                for (int col = 0; col < 9; col++)
                {
                    if (col % 3 == 0 && col != 0)
                    {
                        Console.Write("|");
                    }
                    if (mrr == row && mrc == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (userChangedColors[row, col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(" " + Board[row, col] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Applies a value to a board in the given row and column
        /// </summary>
        /// <param name="val">The value to apply (1-9)</param>
        /// <param name="row">The row (1-9)</param>
        /// <param name="col">The column (1-9)</param>
        /// <returns>If the place was successful or not</returns>
        public bool PlaceValue(int val, int row, int col)
        {
            //if any argument is outside of the range 0-8, return false
            if (val < 1 || val > 9 || row < 0 || row > 8 || col < 0 || col > 8)
                return false;

            mrr = row;
            mrc = col;

            userChangedColors[row, col] = 1;

            //Apply the value
            Board[row, col] = val;
            return true;
        }
    }
}
