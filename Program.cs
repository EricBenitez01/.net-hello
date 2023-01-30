/*Console.WriteLine("introduce tu nombre");
string Nombre = Console.ReadLine();


Console.WriteLine("Hola, " + Nombre);

Console.WriteLine("introduce la hora");
int time = int.Parse(Console.ReadLine());


Console.WriteLine("Son las, " + time + " pm");*/
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


