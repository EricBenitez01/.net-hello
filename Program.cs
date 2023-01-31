/*Console.WriteLine("introduce tu nombre");
string Nombre = Console.ReadLine();


Console.WriteLine("Hola, " + Nombre);

Console.WriteLine("introduce la hora");
int time = int.Parse(Console.ReadLine());


Console.WriteLine("Son las, " + time + " pm");
Cliente Roberto = new Cliente("roberto", 1150213296, "moreno 50", "leonetkd@gmail.com");
Roberto.Escribe();


public struct Cliente 
{
     
    public string Person {get; set;}
    public int Telefono { get; set; }
    public string Direccion { get; set; }
    public string Mails { get; set; }


    public Cliente(string person,int telefono,string direccion,string email)
        {
        Person = person;
        Telefono =telefono;
        Direccion = direccion;    
        Mails= email;       
        }
    
    public void Escribe()
    {
        Console.WriteLine("Tu nombre es "+ Person);
        Console.WriteLine( "tu numero de telefono es " + Telefono);
        Console.WriteLine("Tu direccion es " + Direccion);
        Console.WriteLine("tu numero de mail es " + Mails);
    }
}


Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:



int j = 1;
int i = 0;
Console.WriteLine("Escribe un numero para ser multiplicado");
i = Convert.ToInt32(Console.ReadLine());


while (j <= 10) 
{
    Console.WriteLine(j * i + "este es el resultado");
    j++;
}


Console.WriteLine("Escribe un numero");
int numero= Convert.ToInt32(Console.ReadLine());


do
{
    if (numero>0)
    {
        Console.WriteLine("este numero es positivo");
        
    }
    else if (numero<0)
    {
        
        Console.WriteLine("Este numero es negativo");
    }
    break;
} while (numero < 0 || numero > 0);*/
