/*
var sale = new SaleWhitTax(15, 1.16m);
var message = sale.GetInfo();

Console.WriteLine(message);

class SaleWhitTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWhitTax (decimal total, decimal tax) : base(total)
    {
        Tax = tax;

    }

    public override string GetInfo()
    {
        return "el total es " + Total + " Impuesto " + Tax;
    }

    public string GetInfo(string message)
    {
        return message;
    }
    public string GetInfo(int a)
    {
        return a.ToString();
    }


}
class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
        return "El total " + Total;
    }
}



*/





/*

var sale = new Sale();

var beer = new Beer();

Some(sale);
Some(beer);



void Some(ISave save)
{
    save.Save();
}


interface ISale
{
    decimal Total { get; set; }

}

interface ISave
{
    public void Save();

}

public class Sale : ISale, ISave
{
    public decimal Total { get; set; }

    public void Save() 
    {
        Console.WriteLine("Se guardo en BD");
    }


}

public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("Se guardo en Servicio");
    }


}

*/


/*

var numbers = new Mylist<int>(5);
var names = new Mylist<string>(5);
var beers = new Mylist<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

names.Add("Roberto");
names.Add("Mario");
names.Add("Daniel");
names.Add("Franco");
names.Add("Jose");
names.Add("Jesus");


beers.Add(new Beer()
{
    Name = "Escudo",
    Price = 2

});

beers.Add(new Beer()
{
    Name = "Sol",
    Price = 2

});

beers.Add(new Beer()
{
    Name = "Polar",
    Price = 5

});

beers.Add(new Beer()
{
    Name = "Regional",
    Price = 6

});

beers.Add(new Beer()
{
    Name = "Escudo",
    Price = 8

});

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());


public class Mylist<T>
{
    private List<T> _list;
    private int _limit;


    public Mylist(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T item) // El numero 6 no forma parte del listado debido a esta condicional
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
    }

    public string GetContent() 
    {
        string content = "";
        foreach (var item in _list)
        {
            content += item + ", ";
        }
        return content;
    }
}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " Precio " + Price;
    }

}


*/

/*


using System.Text.Json;

var alejo = new People()
{
    Name = "Alejandro",
    Age = 37,
};

string json = JsonSerializer.Serialize(alejo);
Console.WriteLine(json);


//Deserializacion-------

string myJson = @"{
    ""Name"": ""Juan"",
    ""Age"":36

}";
People juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan.Name);
Console.WriteLine(juan.Age);

public class People
{
    public string Name { get; set; }

    public int Age { get; set; }
}


*/

// PROGRAMACION FUNCIONAL


/*
int Sub(int a , int b)
    { 
        return a - b; 
    }

Console.WriteLine(Sub(2, 1));


DateTime GetTomorrow(DateTime date)
{
    return DateTime.Now.AddDays(1);
}


*/



/*

using System;

var beer = new Beer()
{
    Name = "guinnes"
};

Console.WriteLine(beer.Name);
Console.WriteLine(toUpper(beer).Name);


Beer toUpper(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };

    return beer2;
}
class Beer
{

    public string Name { get; set; }

}

*/





// PROGRAMACION FUNCIONAL
/*

var show = Show;

Some(show, "Hola Que talco");

string Show(string message) 
{
    return message.ToUpper();
 };

void Some(Func<string,string> fn,string message)
{
    Console.WriteLine("Hace algo aqui");
    Console.WriteLine(fn(message));
    Console.WriteLine("hace algo al final");
}


*/

// FUNCIONES LAMBDA

// EJEJMPLO:

/*

Func<int,int, int> sub = (a, b) => a - b;

Func<int,int> some = a => a * 5;

Func<int, int> some2 = a =>{
    a = a + 1;
    return a * 5;
};

Console.WriteLine(sub(212, 112));
Console.WriteLine(some(5));
Console.WriteLine(some2(5));

*/

// OTRO EJEMPLO:

/*

Some((a, b) => a + b, 6);

void Some(Func<int, int, int> fn, int number)
{
   var result = fn(number, number);
}

*/




// LINQ: es una libreria que nos permite hacer consultas a colecciones de datos. Es similar a SQL
// Ejemplo:


/*

var names = new List<string>()
{
   "Alejandro",
   "Juan",
   "Pedro",
   "Jose",
   "Daniel",
   "Franco",

};

var namesResult = from n in names
                   where n.Length > 4 && n.Length < 7
                   orderby n descending
                   select n;

var namesResult2 = names.Where(n => n.Length > 4 && n.Length < 7)
                       .OrderByDescending(n => n)
                       .Select(n => n);

// Resultado de la consulta LINQ . NamesResult y NamesResult2 son iguales



foreach (var item in namesResult)
{
   Console.WriteLine("Resultado 1 :"+item);
}

foreach (var item in namesResult2)
{
   Console.WriteLine("Resultado 2 :"+item);
}

*/


// Validando si un numero es par o impar_______________________


/*class Program
{
    static void Main(string[] args)
    {
        int numberOne = 9;
        if (numberOne % 2 == 0)
        {
            Console.WriteLine($"{numberOne} Es par");
        }
        else
        {
            Console.WriteLine($"{numberOne} Es impar");
        }
        
    }
}

*/
/*

namespace tips{
    class Program
    {
        static void Main(string[] args)
        {
         const double PI = 3.1416;
         Console.WriteLine("Ingrese el radio del circulo");
            double radio = double.Parse(Console.ReadLine());

            // double area = PI * radio * radio;
            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine($"El area del circulo es {area}");
         
        }
    }
}

*/

// EXPLICACION DEL USO DEL STATIC VOID MAIN_______________________ Y DE LOS METODOS


/*

using System;

namespace Metodos_Learning
{
    class Program
    {
        static void Main(string[] args)
         {
               
                sumNum(5,20); 
                
         }
        
        static void sumNum(int num1, int num2)
        {
          

            int result = num1 + num2;

            Console.WriteLine($"El resultado de la suma es : {result}");

        }

    }

}


*/


// EJEMPLO DEL USO STATIC VOID MAIN_______________________ Y DE LOS METODOS

/*

using System;

namespace Metodos_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            searchNumPar();

        }

        static void searchNumPar()
        {
            int numLimit = 20;
        //    Validar si un numero es par o impar_______________________
            for (int i = 1; i <= numLimit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Es par");
                }
                else
                {
                    Console.WriteLine($"{i} Es impar");
                }
            }
        }

    }

}

*/


// VIDEO 11___________________________

/*
using System;

namespace Metodos_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divideNum(10,3));

        }

        static double divideNum(double num1, int num2)
        {
            double resultado;

            resultado = num1 / num2;

            return resultado;
        }
        

    }

}

*/





//Uso de condiciona IF

/*
using System;

namespace Metodos_Learning
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());
            if (edad>=18)
            {
            Console.WriteLine("tienes carnet?");

            }
            
            string carnet = Console.ReadLine();

            if (edad >= 18 && carnet.ToLower() == "si")
            {
                Console.WriteLine("puedes conducir vehiculo");
            } 
            else
            {
                Console.WriteLine("no puedes conducir");
            }
        }

    }
}

*/


// esto es un ejemplo del uso ddel operador || (or) en un condicional if

/*
using System;

namespace Metodos_Learning
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Introduce nota 1er parcial");
            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 2do parcial");
            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 3er parcial");
            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >=5 || parcial2 >= 5 || parcial3 >= 5)
            {
                float average = (parcial1 + parcial2 + parcial3) / 3;
                Console.WriteLine($"Tu promedio es : {average}");
            }
            else Console.WriteLine("Devuelve en septiembre");

        }
    }
  
}


*/


/*
using System;

namespace Metodos_Learning
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("introduce tu edad ");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine(" Eres un niño");
            else if (edad < 30) Console.WriteLine("Eres un joven");
            else if (edad < 60) Console.WriteLine("Eres un adulto");
            else Console.WriteLine("Eres un anciano");
           

        }
    }
  
}

*/

/*
using System;

namespace EstructuraSwith
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Elige medio de transporte (coche, avion, tren, barco)");

         string medioTransporte = Console.ReadLine();

            switch (medioTransporte.ToLower())
            {
                case "coche":
                    Console.WriteLine("El coche tiene 100 Km/h");
                    break;

                case "avion":
                    Console.WriteLine("El avion tiene 800 Km/h");
                    break;

                case "tren":
                    Console.WriteLine("El tren tiene 300 Km/h");
                    break;

                case "barco":
                    Console.WriteLine("El barco tiene 180 Km/h");
                    break;

                default:
                    Console.WriteLine("No has elegido un medio de transporte valido");
                    break;
            }

        }
    }
  
}

*/



// EJERCICIO DE ESTRUCTURA SWITCH CON COMISIONES
// Ejemplo de su uso en el video.
/*
using System;

namespace EstructuraSwithComision
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Introduce el N° de mes para el calculo de la comision");

            int mes = Int32.Parse(Console.ReadLine());
    
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Mes Escogido Enero: La comision es de 1000");
                        break;

                    case 2:
                        Console.WriteLine("Mes Escogido Febrero: La comision es de 2000");
                        break;

                    case 3:
                        Console.WriteLine("Mes Escogido Marzo: La comision es de 3000");
                        break;

                    case 4:
                        Console.WriteLine("Mes Escogido Abril: La comision es de 4000");
                        break;

                    case 5:
                        Console.WriteLine("Mes Escogido Mayo: La comision es de 5000");
                        break;

                    case 6:
                        Console.WriteLine("Mes Escogido Junio: La comision es de 6000");
                        break;

                    case 7:
                        Console.WriteLine("Mes Escogido Julio: La comision es de 7000");
                        break;

                    case 8:
                        Console.WriteLine("Mes Escogido Agosto: La comision es de 8000");
                        break;

                    case 9:
                        Console.WriteLine("Mes Escogido Septiembre: La comision es de 9000");
                        break;

                    case 10:
                        Console.WriteLine("Mes Escogido Octubre: La comision es de 10000");
                        break;

                    case 11:
                        Console.WriteLine("Mes Escogido Noviembre: La comision es de 11000");
                        break;

                    case 12:
                        Console.WriteLine("Mes Escogido Diciembre: La comision es de 12000");
                        break;

                    default:
                        Console.WriteLine("No has elegido un mes valido");
                        break;

                }
         
        }
    }
  
}

*/

// Este es un ejemplo de como usar el bucle while

/*
using System;

namespace UsoBuclewhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar al bucle? (si/no)");
            string respuesta = Console.ReadLine();

            while (respuesta.ToLower() != "no")
            {
                Console.WriteLine("Estas dentro del bucle");
                Console.WriteLine("Introduce tu nombre, por favor");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Hola, {nombre} saldrs del bucle si escribes no");
                Console.WriteLine("Deseas repetir el bucle? (si/no)");
                respuesta = Console.ReadLine();


            }
            Console.WriteLine("Has salido del bucle");

         
        }
    }
  
}

*/



/*
// Ejercicio de bucle while 

//Genera un un numero aleatorio entre 1 y 100 y pide al usuario que lo adivine. Si el usuario introduce un numero bajo,
//debe mostrar el mensaje "El numero que estas buscando es mayor". Si el usuario introduce un numero alto, debe mostrar el mensaje
//"El numero que estas buscando es menor". El programa debe terminar cuando el usuario introduzca el numero correcto y mostrar
//el mensaje "Has acertado" y el numero de intentos que ha necesitado el usuario para acertarlo.

using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int numeroUsuario = 0;
            int intentos = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                Console.WriteLine("Introduce un numero");
                numeroUsuario = Int32.Parse(Console.ReadLine());
                intentos++;

                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es mayor");
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es menor");
                }
                else
                {
                    Console.WriteLine($"--> Has acertado..!!! en {intentos} intentos");
                }
            }
        }
    }
}

*/




// Excepciones y uso do while
// eceptcion es un error que se produce en tiempo de ejecucion. Try catch es un bloque de codigo que nos permite capturar
// una excepcion y manejarla. El bloque finally se ejecuta siempre, haya o no haya excepcion.


/*
using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int numeroUsuario = 0;
            int intentos = 0;
            Console.WriteLine("Introduce un numero");

            do{
                intentos++;
                
                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Debes introducir un valor numerico, Por defecto se asignara el valor 0");
                    Console.WriteLine(ex.Message);
                    numeroUsuario = 0;
                }

                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es mayor");
                }
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es menor");
                }
                
                }while (numeroUsuario != numeroAleatorio);
            
                Console.WriteLine($"--> Has acertado..!!! en {intentos} intentos");

                Console.WriteLine("apartir de esta linea de codigo el programa continua");
        }
    }
}
    

*/


//Conflictos de excepciones.
/*

using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int numeroUsuario = 0;
            int intentos = 0;
            Console.WriteLine("Introduce un numero");

            do{
                intentos++;
                
                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
                // con esto capturamos todad las excepciones que se produzcan menos la de tipo FormatException
                // Esto se denomina filtrado de excepciones
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error, Se tomara el valor 0");
                    // Console.WriteLine(ex.Message);
                    numeroUsuario = 0;
                }
              
                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es mayor");
                }
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es menor");
                }
                
                
               
            } while (numeroUsuario != numeroAleatorio);
                Console.WriteLine($"--> Has acertado..!!! en {intentos} intentos");

                Console.WriteLine("apartir de esta linea de codigo el programa continua");
        }
    }
}

*/




// En este ejemplo se muestra como usar el checked para controlar el desbordamiento de un numero entero

/*
using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
           

           int numero = int.MaxValue;
           int resultado = checked(numero + 20);
              Console.WriteLine(resultado);
        }
    }
}

*/



// Este ejemplo muestra como usar el throw new para lanzar una excepcion
/*
using System;
namespace LanzamientoExcepciones
{
        class Program
        {
            static void Main(string[] args)
            {
            
                Console.WriteLine("Introduce un numero entre 1 y 12");
                int numeroMes = Int32.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine(NombreDelMes(numeroMes));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Mensagge de la excepcion: " + ex.Message);

                }
               
                Console.WriteLine("apartir de esta linea de codigo el programa continua");

            

            }
             public static string NombreDelMes(int mes)
            {
                switch (mes)
                {
                    case 1:
                        return "Enero";
                    case 2:
                        return "Febrero";
                    case 3:
                        return "Marzo";
                    case 4:
                        return "Abril";
                    case 5:
                        return "Mayo";
                    case 6:
                        return "Junio";
                    case 7:
                        return "Julio";
                    case 8:
                        return "Agosto";
                    case 9:
                        return "Septiembre";
                    case 10:
                        return "Octubre";
                    case 11:
                        return "Noviembre";
                    case 12:
                        return "Diciembre";

                    default:
                        throw new ArgumentOutOfRangeException("mes", "El mes debe estar entre 1 y 12");

                 }
            }
        }
}


*/

// Este es un ejemplo de como usar el bloque finally
/*
using System;
namespace BloqueFinally
{
        class Program
        {
            static void Main(string[] args)
            {
            
                System.IO.StreamReader archivo = null;

                try
                {
                    string linea;
                    int contador = 0;
                    string ruta = @"C:\Users\aluces\Desktop\Prueba_finnaly.txt";
                    archivo = new System.IO.StreamReader(ruta);

                    while ((linea = archivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                        contador++;
                    }
                    Console.WriteLine($"El archivo tiene {contador} lineas");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha habido un error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (archivo != null) archivo.Close();
                        
                    Console.WriteLine("Se ha cerrado el archivo");
                    
                }   
          
            }
        }
}
*/

/*
using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();
            double distancia = origen.DistanciaHasta(otroPunto);
            Console.WriteLine($"La distancia entre los puntos es {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
*/

/*

using System;
namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }
        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            Punto otroPunto = new Punto();
            double distancia = origen.DistanciaHasta(otroPunto);
            Console.WriteLine($"La distancia entre los puntos es {distancia}");
            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
*/




// Uso del Array

/*
using System.Runtime.InteropServices.Marshalling;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primer Ejemplo de uso de array

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Alejandro", 37);
            arrayEmpleados[1] = new Empleados("Juan", 36);

            foreach (Empleados item in arrayEmpleados)
            {
                Console.WriteLine(item.nombre + " " + item.edad);
            }

            // Segundo ejemplo

            Jugadores[] arrayJugadores = new Jugadores[3];

            arrayJugadores[0] = new Jugadores("Messi", "Barcelona");
            arrayJugadores[1] = new Jugadores("Cristiano", "Juventus");
            arrayJugadores[2] = new Jugadores("Neymar", "PSG");

            foreach (Jugadores item in arrayJugadores)
            {
                Console.WriteLine(item.nombre + " " + item.team);
            }

            // Array de tipo  anonimo

            var personas = new[]
            {
                new {nombre = "Alejandro", edad = 37, sexo =  "Masculino"},
                new {nombre = "Juan", edad = 36, sexo =  "Masculino"},
                new {nombre = "Maria", edad = 35, sexo =  "Femenino"},
                new {nombre = "Jose", edad = 34, sexo =  "Masculino"},
                new {nombre = "Ana", edad = 33, sexo =  "Femenino"}
            };

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }
         

        }

        //Classe del primer ejemplo
        class Empleados
        {
            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
      
            public string nombre;
            public int edad;

    
        }

        //Classe del segundo ejemplo

        class Jugadores
        {
            public Jugadores(string nombre, string team)
            {
                this.nombre = nombre;
                this.team = team;
            }

            public string nombre;
            public string team;
        }
    }
}

*/


// Arrays V Arrays por parámetros. Vídeo 40
// USO DEL BUCLE FOR

/*

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primer Ejemplo de uso de array

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Alejandro", 37);
            arrayEmpleados[1] = new Empleados("Juan", 36);
            arrayEmpleados[2] = new Empleados("Maria", 35);

        


            // Array de tipo  anonimo

            var personas = new[]
            {
                new {nombre = "Alejandro", edad = 37, sexo =  "Masculino"},
                new {nombre = "Juan", edad = 36, sexo =  "Masculino"},
                new {nombre = "Maria", edad = 35, sexo =  "Femenino"},
                new {nombre = "Jose", edad = 34, sexo =  "Masculino"},
                new {nombre = "Ana", edad = 33, sexo =  "Femenino"}
            };   



            // EJEMPLO BUCLE FOR

            var valores = new[]{13,45,78,12,55,33,4,90};

            // for (int i = 0; i < arrayEmpleados.Length; i++)
            // {
            //     Console.WriteLine(arrayEmpleados[i].getInfo());
            // }

            // foreach (var item in arrayEmpleados)
            // {
                
            //     Console.WriteLine(item.getInfo());
            // }

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }



        }

        //Classe del primer ejemplo
        class Empleados
        {
            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
      
            private string nombre;
            private int edad;

             public String getInfo()
            {
                 return "Nombre: " + nombre + " Edad: " + edad;
            }


    
        }
       
        
    }
}

*/



// Curso C#. Arrays V Arrays por parámetros. Vídeo 40
/*
namespace UsoArrays
{
    class Program
    {
            static void Main(string[] args)
            {
            
                int [] numeros =  new int[4];

                numeros[0] = 5;
                numeros[1] = 10;
                numeros[2] = 15;
                numeros[3] = 20;

                ProcesaDatos(numeros);

                foreach (var item in numeros)
                {
                    Console.WriteLine(item);
                }
                 
            }

            static void ProcesaDatos(int[] datos)
            {

               for (int i = 0; i < datos.Length; i++)
               {
                   datos[i] += 10;

               }
 
            }
    }
}
*/


/*

namespace UsoArrays
{
    class Program
    {
            static void Main(string[] args)
            {
            
                
                int[] datos = LeerDatos();

                
                Console.WriteLine("Los datos introducidos son: ");
                foreach (var item in datos)
                {
                    Console.WriteLine(item);
                }
                
                
                 
            }

            static int[] LeerDatos()
            {
                Console.WriteLine("Cuantos datos quieres introducir?");
                string respuesta = Console.ReadLine();
                int numDatos = Int32.Parse(respuesta);

                int[] datos = new int[numDatos];

                for (int i = 0; i < datos.Length; i++)
                {
                    Console.WriteLine("Introduce el dato #" + (i + 1));
                    respuesta = Console.ReadLine();
                    datos[i] = Int32.Parse(respuesta);
                }

                return datos;

            }
         
    }
}

*/


/*
using System;

namespace Herencia
{
            class Program
            {
                    static void Main(string[] args)
                    {
                    
                        Caballo Babieca = new Caballo("Babieca");
                        Humano Alejandro = new Humano("Alejandro");
                        Gorila Copito = new Gorila("Copito");

                        Mamiferos[] almaceAnimales = new Mamiferos[4];

                        Caballo[] almacenDeCaballos = new Caballo[4];

                        almaceAnimales[0] = Babieca;
                        almaceAnimales[1] = new Caballo("Pirri");
                        almaceAnimales[2] = new Caballo("Bucéfalo");
                        almaceAnimales[3] =  Alejandro;   

                               

                        for (int i = 0; i < almaceAnimales.Length; i++)
                        {
                            almaceAnimales[i].getNombre();
                        }

                        

                        
                        Alejandro.getNombre();
                        Babieca.getNombre();
                        Copito.getNombre();
                        
        
                        
                    }
            }       
            class Mamiferos
            {
                // Constructor

                public Mamiferos(String nombre)
                {
                    nombreSerVivo = nombre;

                    
                }
                
                public void respirar()
                {
                    Console.WriteLine("Soy capaz de respirar");
    
                }

                 public virtual void pensar()
                {
                    Console.WriteLine("Pensamiento básico instintivo");
                }


                public void cuidarCrias()
                {
                    Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
                }

                public void getNombre()
                {
                    Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
                }

                private String nombreSerVivo;
            }

            class Caballo : Mamiferos
            {
                public Caballo(String nombreCaballo) : base(nombreCaballo)
                {

                }
                public void galopar()
                {
                    Console.WriteLine("Soy capaz de galopar");
                }

             }

            class Humano : Mamiferos
            {

                public Humano(String nombreHumano) : base(nombreHumano)
                {

                }
                public void pensar()
                {
                    Console.WriteLine("Soy capaz de pensar ¿?");
                }

            }

            class Gorila : Mamiferos
            {
                public Gorila(String nombreGorila) : base(nombreGorila)
                {

                }

                   public void pensar()
                {
                    Console.WriteLine("Pensamiento instintivo avanzado");
                }
                public void trepar()
                {
                    Console.WriteLine("Soy capaz de trepar");
                }

            }
    
}

*/


//Uso  del metodo de acceso privado mediante la palabra reservada public


/*
using System;

namespace Herencia
{

    class Program
    {
        static void Main(string[] args) 
        {
            // Acceso permitido

            Miclass miObjeto = new Miclass();
            miObjeto.MetodoPublico();
            miObjeto.NombrePublico2();
        }
    }

    // MEtodo de acceso privado

    

    public class Miclass
    {
        public Miclass()
        {
            // Constructor principal
        }

        public void MetodoPublico()
        {
            Console.WriteLine("Método público llamado.");
        }

        private void NombrePublico()
        {
            Console.WriteLine("ALEJANDRO2");
        }
        // control de acceso a NombrePublico
        public void NombrePublico2()
        {
            NombrePublico();
        }
        
    }

    


}
*/





// Uso del private en un metodo de acceso privado


/*
using System;

namespace Herencia
{

    class Program
    {
        static void Main(string[] args) 
        {
           
            Miclass miObjeto = new Miclass();
            miObjeto.MetodoAccesible(); // Acceso permitido a través de un método público
            //miObjeto.MetodoPrivado();//Acceso denegado fuera de la clase.
            
        }
    }

    // MEtodo de acceso privado

    public class Miclass
    {
        private string nombrePrivado;

        private void MetodoPrivado()
        {
            Console.WriteLine("Método privado llamado." + nombrePrivado);
        }

        public void MetodoAccesible()
        {
            nombrePrivado = "Alejandro"; // Acceso permitido dentro de la clase
            MetodoPrivado(); // Acceso permitido dentro de la clase
            
        }
        
    }

}

*/




/*

Creación de tres clases
•	Avión 
•	Vehículo	
•	Coche

Métodos comunes a las tres clases
•	Arrancar motor
•	Parar motor

Método virtual

• Conducir

*/




//SOLUCION EJERCICIO PRÁCTICO________________________________________________

/*

using System;

namespace EjercicioPractico
{

    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Probando Avion...");
            Avion miAvion = new Avion();
            miAvion.ArrancarMotor("tracatrafftracatrafff");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.PararMotor("Polofffffssshh");

            Console.WriteLine("Probando Coche...");
            Coche miCoche = new Coche();
            miCoche.ArrancarMotor("runrunrurnnnn");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frena();
            miCoche.PararMotor("buung");
            
        }
    }

    // MEtodo de acceso privado

    class Vehiculo
    {
        public void ArrancarMotor(String sonidoAlArrancar)
        {
            Console.WriteLine("Arrancando motor..." + sonidoAlArrancar);
        }
       

        public void PararMotor( String sonidoAlParar )
        {
            Console.WriteLine("Parando motor..." + sonidoAlParar);
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Metodo generico para el metodo conducir...!!");
        }
        
    }

    class Avion : Vehiculo
    {
        public  void Aterrizar()
        {
            Console.WriteLine("Aterrizando...");
        }
        public  void Despegar()
        {
            Console.WriteLine("Dezpegando...");
        }

        public override void Conducir()
        {
            Console.WriteLine("Conduciendo mirando al cielo !!");
        }
    }

    class Coche : Vehiculo
    {
        public  void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }
         public  void Frena()
        {
            Console.WriteLine("Frenando...");
        }

        public override void Conducir()
        {
            Console.WriteLine("Conduciendo mirando al frente de la carretera !!");
        }
    }

}

*/





//SOLUCION EJERCICIO PRÁCTICO________________________________________________USO DE INTERFACES.

/*

using System;

namespace Herencia
{
            class Program
            {
                    static void Main(string[] args)
                    {
                    
                        Caballo Babieca = new Caballo("Babieca");
                        Humano Alejandro = new Humano("Alejandro");
                        Gorila Copito = new Gorila("Copito");

                        Mamiferos[] almaceAnimales = new Mamiferos[4];

                        Caballo[] almacenDeCaballos = new Caballo[4];

                        almaceAnimales[0] = Babieca;
                        almaceAnimales[1] = new Caballo("Pirri");
                        almaceAnimales[2] = new Caballo("Bucéfalo");
                        almaceAnimales[3] =  Alejandro; 



                        Alejandro.getNombre();
                        Babieca.getNombre();
                        Copito.getNombre();

                        Ballena ballena = new Ballena("Wally");
                        ballena.nadar();
                        Console.WriteLine("Numero de patas de salto de Caballo: " + Babieca.numeroPatas());
                        Console.WriteLine("Numero de patas de Gorila: " + Copito.numeroPatas());


                        // Uso de interfaces
                        

   
                    }
            }   


            // INTERFACES
            // Solo se escribe, La interfaz No modifica nada. 
            interface IMamiferosTerrestres
            {
                int numeroPatas();
            }

            interface IAnimalesYDeportes
            {
                String tipoDeporte();

                Boolean esOlimpico();
                
            }

            interface ISaltoConPatas
            {
                int numeroPatas();
            }



            //AQUI INICIARAN LAS CLASES_______________________________


            class Mamiferos
            {
                // Constructor

                public Mamiferos(String nombre)
                {
                    nombreSerVivo = nombre;

                    
                }
                
                public void respirar()
                {
                    Console.WriteLine("Soy capaz de respirar");
    
                }

                 public virtual void pensar()
                {
                    Console.WriteLine("Pensamiento básico instintivo");
                }


                public void cuidarCrias()
                {
                    Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
                }

                public void getNombre()
                {
                    Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
                }

              

                private String nombreSerVivo;
            }

            class Ballena : Mamiferos
            {
                public Ballena(String nombreBallena) : base(nombreBallena)
                {

                }
                public void nadar()
                {
                    Console.WriteLine("Soy capaz de nadar");
                }

             }

            class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes,ISaltoConPatas
            {
                public Caballo(String nombreCaballo) : base(nombreCaballo)
                {

                }
                public void galopar()
                {
                    Console.WriteLine("Soy capaz de galopar");
                }

                int IMamiferosTerrestres.numeroPatas()
                {
                    return 4;
                }

                int ISaltoConPatas.numeroPatas()
                {
                    return 2;
                }

                public String tipoDeporte()
                {
                    return "Hipica";
                }

                public Boolean esOlimpico()
                {
                    return true;
                }

        internal string numeroPatas()
        {
            throw new NotImplementedException();
        }
    }
         

            class Humano : Mamiferos
            {
                public Humano(String nombreHumano) : base(nombreHumano)
                {

                }
                public void pensar()
                {
                    Console.WriteLine("Soy capaz de pensar ¿?");
                }   

            }
      

            class Gorila : Mamiferos, IMamiferosTerrestres
            {
                public Gorila(String nombreGorila) : base(nombreGorila)
                {

                }

                   public void pensar()
                {
                    Console.WriteLine("Pensamiento instintivo avanzado");
                }
                public void trepar()
                {
                    Console.WriteLine("Soy capaz de trepar");
                }
                public int numeroPatas()
                {
                    return 2;
                }

            }
    
}



*/



//Ejericio Avisos de trafico_______________________________________________________

/*

using System;


namespace Aprendiendo_CSharp
{
            
     class Program
    {
        static void Main(string[] args)
        {

            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Sancion de trafico", "Leve", "01/01/2024");


            av2.getFecha();
            av2.MostrarAviso();
            

        }
    }
}


*/




/*



using System;

namespace Herencia
{
            class Program
            {
                    static void Main(string[] args)
                    {
                    
                        Lagartija Juancho = new Lagartija("Juancho");
                        Juancho.respirar();

                        Humano Alejandro = new Humano("Alejandro");
                        Alejandro.respirar();

                        Alejandro.getNombre();


   
                    }
            }   


            // INTERFACES
            // Solo se escribe, La interfaz No modifica nada. 
            interface IMamiferosTerrestres
            {
                int numeroPatas();
            }

            interface IAnimalesYDeportes
            {
                String tipoDeporte();

                Boolean esOlimpico();
                
            }

            interface ISaltoConPatas
            {
                int numeroPatas();
            }




            // CREACION DE CLASES ABSTRACTAS

            abstract class Animales
            {
                public void respirar()
                {
                    Console.WriteLine("Soy capaz de respirar");
    
                }

                 public abstract void getNombre();
            }

            class Lagartija : Animales
            {
                public Lagartija(String nombreLagartija)
                {
                    nombreReptil = nombreLagartija;
                }
                public override void getNombre()
                {
                    Console.WriteLine("El nombre del reptil es: " + nombreReptil);
                }

                private String nombreReptil;
            }

            //AQUI INICIARAN LAS CLASES_______________________________


            class Mamiferos:Animales
            {
                // Constructor

                public Mamiferos(String nombre)
                {
                    nombreSerVivo = nombre;

                    
                }
                
                public void respirar()
                {
                    Console.WriteLine("Soy capaz de respirar");
    
                }

                 public virtual void pensar()
                {
                    Console.WriteLine("Pensamiento básico instintivo");
                }


                public void cuidarCrias()
                {
                    Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
                }

                public override void getNombre()
                {
                    Console.WriteLine("El nombre del mamifero ser vivo es: " + nombreSerVivo);
                }

              

                private String nombreSerVivo;
            }

            class Ballena : Mamiferos
            {
                public Ballena(String nombreBallena) : base(nombreBallena)
                {

                }
                public void nadar()
                {
                    Console.WriteLine("Soy capaz de nadar");
                }

             }

            class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes,ISaltoConPatas
            {
                public Caballo(String nombreCaballo) : base(nombreCaballo)
                {

                }
                public void galopar()
                {
                    Console.WriteLine("Soy capaz de galopar");
                }

                int IMamiferosTerrestres.numeroPatas()
                {
                    return 4;
                }

                int ISaltoConPatas.numeroPatas()
                {
                    return 2;
                }

                public String tipoDeporte()
                {
                    return "Hipica";
                }

                public Boolean esOlimpico()
                {
                    return true;
                }

        internal string numeroPatas()
        {
            throw new NotImplementedException();
        }
    }
         

            class Humano : Mamiferos
            {
                public Humano(String nombreHumano) : base(nombreHumano)
                {

                }
                public void pensar()
                {
                    Console.WriteLine("Soy capaz de pensar ¿?");
                }   

            }
      

            class Gorila : Mamiferos, IMamiferosTerrestres
            {
                public Gorila(String nombreGorila) : base(nombreGorila)
                {

                }

                   public void pensar()
                {
                    Console.WriteLine("Pensamiento instintivo avanzado");
                }
                public void trepar()
                {
                    Console.WriteLine("Soy capaz de trepar");
                }
                public int numeroPatas()
                {
                    return 2;
                }

            }
            
    
}

*/



/*
// PropiedadesdeAcceso

using System;
namespace PropiedadesdeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Alejandro = new Empleado("Alejandro", 37, 2000);
            
            Alejandro.SALARIO = -3000;
            // Alejandro.SALARIO += 580;
            Console.WriteLine(Alejandro.SALARIO);
        }
    }

    class Empleado
    {
        public Empleado(string nombre, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public double Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El sueldo no puede ser negativo");
                    sueldo = 0;
                }
                else
                {
                    sueldo = value;
                }
            }
        }

        public double SALARIO
        {
       

            get
            {
                return sueldo;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El sueldo no puede ser negativo");
                    sueldo = 0;
                }
                else
                {
                    sueldo = value;
                }
            }

        }
    

        private string nombre;
        private int edad;
        private double sueldo;
    }

}
*/



//USO DEL STRUCT____________________________________
/*
using System;
namespace Structs_y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);

            empleado1.cambiarSueldo(empleado1, 1000);

            Console.WriteLine(empleado1.ToString());
            
            
            
        }
    }

    public struct Empleado
    {
        public Empleado(double sueldo, double comision)
        {
            this.sueldo = sueldo;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("El sueldo es {0} y la comision es {1}", sueldo, comision);
        }

        public void cambiarSueldo(Empleado empleado, double incremento)
        {
            empleado.sueldo += incremento;
            empleado.comision += incremento;
        }
       

        private double sueldo;
        private double comision;
    }

}
*/




// USO DEL ENUM__________________
/*

using System;
namespace Structs_y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado Alejandro = new Empleado(Bonus.alto, 2000);
            Console.WriteLine("El salario del empleado es  : " + Alejandro.getSalario());

        }
    }

    class Empleado
    {
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + bonus;
        }
        private double salario,bonus;

    }
    enum Bonus {bajo = 500, medio = 1000, alto = 1500};
    
}



*/




//USO DE DESTRUCTORES_______________________

/*
using System;
using System.IO;
namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intanciamos la clese y metodos creados
            ManejoArchivo archivo = new ManejoArchivo();
            archivo.mensaje();

        }
    }


    class ManejoArchivo
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivo()
        {
            archivo = new StreamReader(@"C:\Users\aluces\Desktop\Prueba_finnaly.txt");

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
            Console.WriteLine($"El archivo tiene {contador} lineas");
        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }


        // Destructor
        ~ManejoArchivo()
        {
            archivo.Close();
            
        }
    }


    
    
}
*/








// uso de GENERICOS_______________________

/*
using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            almacenObjetos archivos = new almacenObjetos(4);
            // archivos.agregaObjeto("Alejandro");
            // archivos.agregaObjeto("Juan");
            // archivos.agregaObjeto("Maria");
            // archivos.agregaObjeto("Jose");

            archivos.agregaObjeto(new Empleado(2000));
            archivos.agregaObjeto(new Empleado(2500));
            archivos.agregaObjeto(new Empleado(3000));
            archivos.agregaObjeto(new Empleado(3500));

            Empleado salarioEmpleado = (Empleado)archivos.getObjeto(3);

            Console.WriteLine(salarioEmpleado.getSueldo());
            
            


        }
    }
    
    class almacenObjetos
    {
        public almacenObjetos(int z)
        {
            datosElemento = new object[z];
        }

        public void agregaObjeto(object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public object getObjeto(int i)
        {
            return datosElemento[i];
        }
        private Object[] datosElemento;

        private int i = 0;

    }

    class Empleado
    {
        public Empleado(double sueldo)
        {
            this.sueldo = sueldo;
        }

        public double getSueldo()
        {
            return sueldo;
        }

        private double sueldo;
    }
    
}

*/

// uso de GENERICOS II_______________________

/*
using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            almacenObjetos<DateTime> archivos = new almacenObjetos<DateTime>(4);

            // archivos.agregaObjeto("Alejandro");
            // archivos.agregaObjeto("Juan");
            // archivos.agregaObjeto("Maria");
            // archivos.agregaObjeto("Jose");

            // archivos.agregaObjeto(new Empleado(2000));
            // archivos.agregaObjeto(new Empleado(2500));
            // archivos.agregaObjeto(new Empleado(3000));
            // archivos.agregaObjeto(new Empleado(3500));

            archivos.agregaObjeto(new DateTime());
            archivos.agregaObjeto(new DateTime());
            archivos.agregaObjeto(new DateTime());
            archivos.agregaObjeto(new DateTime());

            DateTime nameEmpleado = archivos.getObjeto(3);

            Console.WriteLine(nameEmpleado);

            
            


        }
    }
    
    class almacenObjetos<T>
    {
        public almacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void agregaObjeto( T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public  T getObjeto(int i)
        {
            return datosElemento[i];
        }
        private T [] datosElemento;

        private int i = 0;

    }

    class Empleado
    {
        public Empleado(double sueldo)
        {
            this.sueldo = sueldo;
        }

        public double getSueldo()
        {
            return sueldo;
        }

        private double sueldo;
    }
    
}

*/





// uso de GENERICOS III_______________________ CON RESTRICCIONES
/*
using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleados<Secretaria> empleados = new AlmacenEmpleados<Secretaria>(3);

            empleados.agregar(new Secretaria(1000));
            empleados.agregar(new Secretaria(2000));
            empleados.agregar(new Secretaria(3000));

            AlmacenEmpleados<Director> empleados2 = new AlmacenEmpleados<Director>(3);

            empleados2.agregar(new Director(1000));
            empleados2.agregar(new Director(2000));
            empleados2.agregar(new Director(3000));



            // Esto da error porque no cumple con la restriccion de la interfaz IParaEmpleados

            // AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpleados<Estudiante>(3);

            // Empleado3.agregar(new Estudiante(1000));
            // Empleado3.agregar(new Estudiante(2000));
            // Empleado3.agregar(new Estudiante(3000));

          

        }
    }

    class AlmacenEmpleados<T> where T: IParaEmpleados
    {
        public AlmacenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void agregar(T obj)
        {
            datosEmpleados[i] = obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleados[i];
        }
        private int i = 0;
        private T[] datosEmpleados;

    }

    class Director:IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }


    }

    class Secretaria: IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;

         public double getSalario()
        {
            return salario;
        }

    }

    class Electricista: IParaEmpleados
    {

         public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;

         public double getSalario()
        {
            return salario;
        }

    }

    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }
        private double edad;

    }

    interface IParaEmpleados
    {
        double getSalario();
    }
    
   
}

*/







//COLECCTION_

/*
using System;
using System.Collections.Generic; // Para usar las colecciones

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> numeros = new List<int>(); // Creacion de una lista de tipo int
               
               int[] listaNumeros = new int[]{1,22,13,44,5}; // Creacion de un array de tipo int
                for (int i = 0; i < listaNumeros.Length; i++)//
                {
                    numeros.Add(listaNumeros[i]);// Añadimos los elementos del array a la lista. De listaNumeros a numeros
                }

               for (int i = 0; i < listaNumeros.Length; i++)
               {
                   Console.WriteLine(numeros[i]);
               }
        
        }
    }
    
}
*/





// USO DEL List<T>_______________________
/*
using System;
using System.Collections.Generic; // Para usar las colecciones

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> numeros = new List<int>(); // Creacion de una lista de tipo int
                Console.WriteLine("Introduce elemntos a la lista(0 para salir)");

                int elemento = 1;

                while (elemento != 0)
                {
                    
                    elemento = Int32.Parse(Console.ReadLine());
                    numeros.Add(elemento);
                }
               numeros.RemoveAt(numeros.Count-1);

                Console.WriteLine("Los elementos de la lista son: ");

                foreach (var item in numeros)
                {
                    Console.WriteLine(item);
                }

        }
   
    }
    
}
*/


// USO DEL List<T>_______________________
/*
using System;
using System.Collections.Generic; // Para usar las colecciones

namespace UsoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>(); // Creacion de una lista de tipo int

            foreach (var item in new int[] { 1, 2, 3, 4, 5 })
            {
                numeros.AddLast(item);
                
            }
            numeros.Remove(3);
            LinkedListNode<int> nodoAdd = new LinkedListNode<int>(500);
            numeros.AddFirst(nodoAdd);

            // foreach (var item in numeros)
            // {
            //     Console.WriteLine("El resultado es: "+item);
            // }

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int dato = nodo.Value;
                Console.WriteLine("El resultado es nodo: "+dato);
            }

        }

    }
    
}
*/

// ALGOTITMO----------------------------------------------
using System;
using System.Text.RegularExpressions;

namespace Solution
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = "hell5o wor6ld";
            int number = GetNumberFromString(input);
            Console.WriteLine(number);
        }

        static int GetNumberFromString(string s)
        {
            string digitsOnly = Regex.Replace(s, "[^0-9]", "");
            int number = int.Parse(digitsOnly);
            return number;
        }
    }

}





