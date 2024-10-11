// See https://aka.ms/new-console-template for more information
uppgift2();
void uppgift1(){
Console.WriteLine("skriv din först din längd och sedan din vikt");
string text = Console.ReadLine();
string text2 = Console.ReadLine();
double tal = double.Parse(text);
double tal2 = double.Parse(text2);
double b = tal2 / (tal * tal);

if (b >= 0.00185 && b <= 0.00249)
{
    Console.WriteLine("ditt bmi är normalt " + b);
}

else if (b >= 0.0025)
{
    Console.WriteLine("du är tjock " + b);
}

else
{
    Console.WriteLine("käka mat " + b);
}
}

void uppgift2(){

Console.WriteLine("skriv in en månads nummer");
string nm= Console.ReadLine();
int månadn= int.Parse(nm); 

if(måndan%0){
 Console.WriteLine("den har 31 dagar");
}   
}
