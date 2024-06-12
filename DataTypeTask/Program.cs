//Task1
//int num = 4564; //ededi burdanda daxil ede bilerik, istifadeciden de ala bilerik
int num ;

Console.WriteLine("Zehmet olmasa bir eded girin: ");
string input1 = Console.ReadLine();

int.TryParse(input1, out num); 

bool dordReqemli = num >= 1000 && num <= 9999;

bool bolme3veya7 = num % 3 == 0 || num % 7 == 0;


if (dordReqemli && bolme3veya7)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}



//Task2

string name = "Nazrin";

if (name == "Nazrin")
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}



//Task3 
int n;

Console.WriteLine("Zehmet olmasa, bir natural eded daxil edin: ");
string input2 = Console.ReadLine();

int.TryParse(input2, out n);

if (n > 0)
{
    int sonReqem = n % 10;
    Console.WriteLine("Ededin sağdan birinci reqemi: " + sonReqem);
}
else
{
    Console.WriteLine("Yazdiginiz eded natural eded deyil!");
}

