Possition p1 = new Possition(8, 'A', ' ');
StartGame();


void StartGame()
{


    bool b = true;
    do
    {
        Console.WriteLine("Insert Game mode ` Game1 or Game2");
        string GameMode = Console.ReadLine();
        if (GameMode == "Game1")
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");
            CreateСhessBoard();
            start();
            b = false;
        }
        else if (GameMode == "Game2")
        {
            KnightCheck();
            b = false;
        }
        else
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");
            Console.SetCursorPosition(0, 0);
        }

    } while (b == true);

}
void KnightCheck()
{

    bool b = true;
    while (b == true)
    {
        int x = 0;
        int y = 0;
        int x1 = 0;
        int y1 = 0;
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("                                                                      ");
        Console.WriteLine("                                                                      ");
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("Insert Possition(A8,B4,C3....)");
        Console.WriteLine("Insert NEXT Possition(A8,B4,C3....)");
        Console.SetCursorPosition(40, 2);
        String a1 = Console.ReadLine();
        Console.SetCursorPosition(40, 3);
        String a2 = Console.ReadLine();
        if (Check(a1, "N"))
        {
            PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), p1.Y.ToString());
            y = (char)((int)myEnumValue - 63);
            y = y / 2;
            x = p1.X;
        }
        else b = false;
        if (Check(a2, "N") && b == true)
        {
            x1 = p1.X;
            PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), p1.Y.ToString());
            y1 = (char)((int)myEnumValue - 63);
            y1 = y1 / 2;
            int a = MinMoves(x - 1, y - 1, x1 - 1, y1 - 1);
            Console.WriteLine("MinMoves = " + a);
            b = false;
        }
    }
}

void start()
{
    while (true)
    {
        Console.SetCursorPosition(0, 9);
        Console.WriteLine("Insert Possition(A8,B4,C3....)");
        Console.SetCursorPosition(0, 10);
        Console.WriteLine("Insert Figure(K,Q,B,N,R)");
        int poss = 9;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(30, poss);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(30, poss + 1);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(30, poss);
        string s1 = Console.ReadLine();
        Console.SetCursorPosition(0, 11);
        Console.WriteLine("                          ");
        Console.SetCursorPosition(30, poss + 1);
        string s3 = Console.ReadLine();
        bool b = CheckPoss(s1, s3);
        if (b == true)
        {
            break;
        }
    }

    Console.SetCursorPosition(30, 0);
    Console.Write("Insert NEXT Possition(A8,B4,C3....)");
    string a1 = Console.ReadLine();
    Console.SetCursorPosition(30, 1);
    Console.Write("Insert Figure(K,Q,B,N,R)");
    string c1 = Console.ReadLine();
    Console.SetCursorPosition(30, 30);
    int x1 = p1.X;
    char y1 = p1.Y;
    void King()
    {
        if (Check(a1, c1) && ((Math.Abs(x1 - p1.X) == 1 && Math.Abs(y1 - p1.Y) == 0) || (Math.Abs(x1 - p1.X) == 0 && Math.Abs(y1 - p1.Y) == 1) || (Math.Abs(x1 - p1.X) == 1 && Math.Abs(y1 - p1.Y) == 1))
        )
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }
    }


    void Queen()
    {
        if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == 0 && Math.Abs(y1 - p1.Y) != 0) || (Math.Abs(x1 - p1.X) != 0 && Math.Abs(y1 - p1.Y) == 0))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == Math.Abs(y1 - p1.Y)))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }
    }
    void Rook()
    {
        if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == 0 && Math.Abs(y1 - p1.Y) != 0) || (Math.Abs(x1 - p1.X) != 0 && Math.Abs(y1 - p1.Y) == 0))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }
    }



    void Bishop()
    {
        if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == Math.Abs(y1 - p1.Y)))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }

    }

    void Knight()
    {
        if (Check(a1, c1) && ((Math.Abs(p1.X - x1) == 1 && Math.Abs(p1.Y - y1) == 2) || (Math.Abs(p1.X - x1) == 2 && Math.Abs(p1.Y - y1) == 1)))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }

    }
    void Move()
    {
        Thread.Sleep(1000);
        WriteLinePossition(x1, y1, ' ');
    }
    switch (c1)
    {
        case "K":
            King();
            break;
        case "Q":
            Queen();
            break;
        case "B":
            Bishop();
            break;
        case "N":
            Knight();
            break;
        case "R":
            Rook();
            break;
        default:
            break;
    }
}

bool Check(string s1, string s3)
{
    string letters = "";
    string numbers = "";
    foreach (char c in s1)
    {
        if (char.IsLetter(c))
        {
            letters += c;
        }
        else if (char.IsDigit(c))
        {
            numbers += c;
        }
    }
    bool b = false;
    if (int.TryParse(numbers, out int result1) && char.TryParse(letters, out char result2) && char.TryParse(s3, out char result3))
    {

        foreach (Figures figure in Enum.GetValues(typeof(Figures)))
        {


            if (figure.ToString()[0] == result3)
            {
                b = true;
            }

        }
        if (result1 >= 1 && result1 < 9 && result2 >= 'A' && result2 <= 'H' && b == true)
        {
            p1 = new Possition(result1, result2, result3);


        }
        else
        {
            Console.WriteLine("Insert true data");
            b = false;

        }
    }
    return b;
}

bool CheckPoss(string s1, string s3)
{
    bool b = false;
    string letters = "";
    string numbers = "";

    foreach (char c in s1)
    {
        if (char.IsLetter(c))
        {
            letters += c;
        }
        else if (char.IsDigit(c))
        {
            numbers += c;
        }
    }
    if (int.TryParse(numbers, out int result1) && char.TryParse(letters, out char result2) && char.TryParse(s3, out char result3))
    {

        foreach (Figures figure in Enum.GetValues(typeof(Figures)))
        {


            if (figure.ToString()[0] == result3)
            {
                b = true;
            }

        }
        if (result1 >= 1 && result1 < 9 && result2 >= 'A' && result2 <= 'H' && b == true)
        {
            p1 = new Possition(result1, result2, result3);
            WriteLinePossition(p1.X, p1.Y, p1.Letter);

        }
        else
        {
            Console.WriteLine("Insert true data");
            b = false;

        }
    }
    return b;
}





void WriteLinePossition(int X, char Y, char Letter)
{
    p1.X = X;
    p1.Y = Y;
    p1.Letter = Letter;
    int x1 = 8 - X;
    char y1 = Y;
    PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), y1.ToString());
    y1 = (char)((int)myEnumValue - 63);
    PossY poss;

    Console.SetCursorPosition(y1, x1);
    if ((Y == 'A' || Y == 'C' || Y == 'E' || Y == 'G') && (x1 % 2 == 0))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else if ((Y == 'B' || Y == 'D' || Y == 'F' || Y == 'H') && (x1 % 2 == 1))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

}


void CreateСhessBoard()
{
    Console.SetCursorPosition(0, 0);

    for (int i = 8; i > 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.Write(" ");

    for (char symbol = 'A'; symbol <= 'H'; symbol++)
    {
        Console.Write(symbol + " ");


    }
    Console.SetCursorPosition(1, 0);
    int y = 1;
    for (int i = 8; i > 0; i--)
    {

        for (int j = 1; j < 9; j++)
        {

            if ((i + j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
                Console.Write(" ");
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.Write(" ");

            }
        }
        Console.SetCursorPosition(1, y);
        y++;

    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("");

}

int MinMoves(int startX, int startY, int endX, int endY)
{
    int[] x = { 1, 1, 2, 2, -1, -1, -2, -2 };
    int[] y = { 2, -2, 1, -1, 2, -2, 1, -1 };

    bool[,] visited = new bool[8, 8];
    Point[] points = new Point[64];
    int check = 0, move = 0;

    points[move++] = new Point { X = startX, Y = startY, Moves = 0 };
    visited[startX, startY] = true;

    while (check < move)
    {
        var point = points[check++];

        if (point.X == endX && point.Y == endY)
            return point.Moves;

        for (int i = 0; i < 8; i++)
        {
            int newX = point.X + x[i];
            int newY = point.Y + y[i];

            if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8 && !visited[newX, newY])
            {
                points[move++] = new Point { X = newX, Y = newY, Moves = point.Moves + 1 };
                visited[newX, newY] = true;
            }
        }
    }
    return 0;
}