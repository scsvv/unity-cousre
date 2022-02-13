bool f = false;
bool t = true;

// and or not 
/*
// И - && - TRUE -> TRUE TRUE 
Console.WriteLine("true and true = " + (t && t));   // true
Console.WriteLine("false and true = " + (f && t));  //false
Console.WriteLine("false and false= " + (f && t));  //false

Console.WriteLine("--------------------------");

// Или - || -> TRUE -> TRUE
Console.WriteLine("true or true = " + (t || t));    //true
Console.WriteLine("true or false = " + (t || f));   //true
Console.WriteLine("false or false = " + (f || f));  //false


Console.WriteLine("--------------------------");
// not 
Console.WriteLine(!true); 
Console.WriteLine(!false);

Console.WriteLine("--------------------------");
Console.WriteLine(10 < 100);
Console.WriteLine(10 > 100);
Console.WriteLine(10 != 100);
Console.WriteLine(100 == 100);
*/
//

int x;
Console.WriteLine("Enter your naumber");
x = Convert.ToInt16(Console.ReadLine());

if (x > 10) //
{
    Console.WriteLine("More than 10");
}
else
{
    Console.WriteLine("Less than 10");
}



// true false | 3 x not | 4 x and | 5 x or = True;

// true false | 6 x not (3) | 5 x and (2) | 7 x or (3) = True;


Console.WriteLine(!(!true && true) && (!false || false) || false || true && (true && true) || false || true && true && !false);