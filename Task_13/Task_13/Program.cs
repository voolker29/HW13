using Task_13;

var p = new Pair<string, int>("4",1);
var q = new ComparablePair<string, int>("3",2);
var result =  q.CompareTo(p);

if (result == 1)
{
    Console.WriteLine("q больше p");
}
else if (result == 0)
{
    Console.WriteLine("q равна p");
}
else 
{
    Console.WriteLine("q меньше  p");
}