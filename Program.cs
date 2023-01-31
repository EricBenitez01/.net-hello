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
} while (numero < 0 || numero > 0);
Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón
int producto = 150;
Console.WriteLine("Escribe tu nombre tu mail y tu cupon si lo tienes" );
string?[] datos = new string[3];  
for( int i = 0;i < datos.Length; i++)
{
   datos[i]= Console.ReadLine();
}
if (datos[2] == "agua")
{
    Console.WriteLine("Tu cupón tiene un 20% de descuento, pagas " + (producto * 0.80).ToString("0.00") + " en vez de " + producto.ToString("0.00"));

}
else
{
    Console.WriteLine("El valor de tu producto es " + producto );
}
*/


using System.ComponentModel;

Console.WriteLine("Elije uno de los siguientes lenguajes segun el numero de opcion que corresponda: \n1)C#\n2)Javascript\n3)Java");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        {
            Console.WriteLine ("Elejiste C#");
        }
         break;
    case 2:
        {
            Console.WriteLine("Elejiste Javascript");
        }
        break;
    case 3:
        {
            Console.WriteLine("Elejiste Java");
        }
        break;
            

}           