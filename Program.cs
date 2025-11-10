string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool isPlayer1Turn = true;
int numTurns = 0;

while (!CheckedVictory() && numTurns != 9)
{
    PrintGrid();

    if (isPlayer1Turn)
        Console.WriteLine("Player 1 (X), your turn!");
    else
        Console.WriteLine("Player 2 (O), your turn!");

    string choice;

    while (true)
    {
        choice = Console.ReadLine();

        if (int.TryParse(choice, out int num) && num >= 1 && num <= 9 && grid[num - 1] != "X" && grid[num - 1] != "O")
        {
            break;
        }
        Console.WriteLine("Invalid input. Please enter a number between 1 and 9 that is not already taken.");
    }
   

    if (grid.Contains(choice) && choice != "X" && choice != "O")
    {
        int gridIndex = Convert.ToInt32(choice) - 1;

        if (isPlayer1Turn)
            grid[gridIndex] = "X";
        else
            grid[gridIndex] = "O";

        numTurns++;
    }

    isPlayer1Turn = !isPlayer1Turn;
}

if (CheckedVictory())
{
    if (!isPlayer1Turn)
        Console.WriteLine("Congratulations Player 1 (X) wins!");
    else
        Console.WriteLine("Congratulations Player 2 (O) wins!");
}
else
    Console.WriteLine("It's a draw");

bool CheckedVictory()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diaDown = grid[0] == grid[4] && grid[4] == grid[8];
    bool diaUp = grid[6] == grid[4] && grid[4] == grid[2];

    return row1 || row2 || row3 || col1 || col2 || col3 || diaDown || diaUp;
}

void PrintGrid()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            int idx = i * 3 + j;
            Console.Write($" {grid[idx]} ");
            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (i < 2) Console.WriteLine("---+---+---");
    }
}
