string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool isPlayer1Turn = true;
int numTurns = 0;

int[] winningLine = null;
while ((winningLine = GetWinningLine()) == null && numTurns != 9)
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
   
        int gridIndex = Convert.ToInt32(choice) - 1;

        if (isPlayer1Turn)
            grid[gridIndex] = "X";
        else
            grid[gridIndex] = "O";

        numTurns++;

    isPlayer1Turn = !isPlayer1Turn;
}

PrintGrid(winningLine);
if (winningLine != null)
{
    if (!isPlayer1Turn)
        Console.WriteLine("Congratulations Player 1 (X) wins!");
    else
        Console.WriteLine("Congratulations Player 2 (O) wins!");
    Console.WriteLine("Winning line: " + string.Join(", ", winningLine.Select(i => i + 1)));
}
else
    Console.WriteLine("It's a draw");

int[] GetWinningLine()
{
    int[][] winningLines = new int[][]
    {
        new int[] {0, 1, 2},
        new int[] {3, 4, 5},
        new int[] {6, 7, 8},
        new int[] {0, 3, 6},
        new int[] {1, 4, 7},
        new int[] {2, 5, 8},
        new int[] {0, 4, 8},
        new int[] {6, 4, 2}
    };
    foreach (var line in winningLines)
    {
        if (grid[line[0]] == grid[line[1]] && grid[line[1]] == grid[line[2]])
        {
            return line;
        }
    }
    return null;
}

void PrintGrid(int[] highlight = null)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            int idx = i * 3 + j;
            string cell = grid[idx];
            if (highlight != null && highlight.Contains(idx))
                cell = $"[{cell}]";
            else
                cell = $" {cell} ";
            Console.Write(cell);
            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (i < 2) Console.WriteLine("---+---+---");
    }
}
