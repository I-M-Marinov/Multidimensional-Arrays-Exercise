

int size = int.Parse(Console.ReadLine());
if (size < 3)
{
    Console.WriteLine($"0");
    return;
}
size += 4;

string[][] board = new string[size][];

int maxHits = 1;
int maxRow = 0;
int maxCol = 0; 
int count = 0;


board[0] = (new String('0', size)).Select(c => c.ToString()).ToArray();
board[1] = (new String('0', size)).Select(c => c.ToString()).ToArray();
board[size - 1] = (new String('0', size)).Select(c => c.ToString()).ToArray();
board[size - 2] = (new String('0', size)).Select(c => c.ToString()).ToArray();

for (int row = 2; row < size - 2; row++)
{
    string line = "00" + Console.ReadLine() + "00";
    board[row] = line.ToCharArray().Select(c => c.ToString()).ToArray();
}
while (maxHits > 0)
{
    maxHits = 0;
    for (int row = 2; row < size - 2; row++)
    {
        for (int col = 2; col < size - 2; col++)
        {
            int hits = 0;
            if (board[row][col] == "K")
            {
                hits = Hits(row, col, board);
                if (hits > maxHits)
                {
                    maxHits = hits;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
    }
    if (maxHits > 0)
    {
        board[maxRow][maxCol] = "0";
        count++;
    }
}
Console.WriteLine($"{count}");
static int Hits(int row, int col, string[][] board)
{
    string k = board[row][col];
    int hits = 0;

    if (board[row - 2][col - 1] == k)
        hits++;
    if (board[row - 2][col + 1] == k)
        hits++;
    if (board[row + 2][col - 1] == k)
        hits++;
    if (board[row + 2][col + 1] == k)
        hits++;
    if (board[row - 1][col - 2] == k)
        hits++;
    if (board[row - 1][col + 2] == k)
        hits++;
    if (board[row + 1][col - 2] == k)
        hits++;
    if (board[row + 1][col + 2] == k)
        hits++;
    return hits;
}