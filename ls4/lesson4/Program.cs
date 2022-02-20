//i j k 
int sum = 0; 

for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        sum = sum + i; 
    }
}
Console.WriteLine(sum);

// 1 1 2 3 5 8 11 19 30 49 79 

int f = 1;
int s = 1;

for (int i = 1; i <= 10; i++)
{
    int z = f + s;
    Console.WriteLine(z);

    f = s;
    s = z; 
}


/*
string password = "asd";
string userPassword = Console.ReadLine();
int trying = 3;

while (password != userPassword && trying > 0)
{
    userPassword = Console.ReadLine();
    trying--;
}


string move = Console.ReadLine();

if (move == "a")
{
    Console.WriteLine("Left");
}
else if (move == "s")
{
    Console.WriteLine("Back");
}
else if(move == "d") 
{
    Console.WriteLine("Right");
}
else if(move == "w") 
{
    Console.WriteLine("Forward");
}
else
{
    Console.WriteLine(move);
}

string password = "asd";
string userPassword = Console.ReadLine();


if (password == userPassword)
{
    Console.WriteLine("Welcome");
}
else 
{
    Console.WriteLine("Incorrect");
}



int x = Convert.ToInt16(Console.ReadLine());

if (x%2 == 0)
{
    Console.WriteLine("Ja");
}
else
{
    Console.WriteLine("No");
}


int x = 100;
{
    int v = 200;
    
    {
        int z = 400;
        Console.WriteLine(x + v + z);
    }
    
}

*/