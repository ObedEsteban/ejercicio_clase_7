//void adivina()
//{
//    const int Oportunidades = 4;
//    int numeroCPU, numeroUsuario;
//    byte Intentos, BanderaControl;
//    string linea;

//    Random rand = new Random();



//    do
//    {
//        numeroCPU = Convert.ToInt32(rand.Next(100));
//        Console.WriteLine(numeroCPU);
//    } while (!(((numeroCPU >= 1) & (numeroCPU <= 20))));


//    //proceso
//    Intentos = 1;
//    BanderaControl = 0;
//    do
//    {
//        Console.WriteLine("hola estoy pensando en un nujmero, cual crees que es ");
//        numeroUsuario = Convert.ToInt32(Console.ReadLine());
//        if ((numeroUsuario == numeroCPU))
//        {
//            Console.WriteLine("adivinaste");
//            BanderaControl = 1;
//        }
//        else
//        {
//            if (numeroUsuario > numeroCPU)
//                Console.WriteLine("estuviste cerca");
//        }

//        {
//            Console.WriteLine("casi");
//        }

//    Intentos++;

//    } while (!(((Intentos <=Oportunidades) & (BanderaControl == 0))));
//if (BanderaControl == 0)
//{
//        Console.WriteLine("el numero era: " +numeroCPU);
//}

//}
//adivina();



//void buscaMayor()
//{
//    int mayor = 0;
//    int numero = 0;
//    Random numerito = new Random();

//    for (int i = 0; i < 5; i++)
//    {
//        numero = numerito.Next(100);
//        if (numero > mayor)
//        {
//            mayor = numero;
//        }
//    }
//    Console.WriteLine("el numero mayor es " + mayor);
//}
//void buscaMenor()
//{
//    int menor = 100;
//    int numero = 0;
//    Random numerito = new Random();

//    for (int i = 0; i < 5; i++)
//    {
//        numero = numerito.Next(100);
//        if (numero < menor)
//        {
//            menor = numero;
//        }
//    }
//    Console.WriteLine("El número menor es " + menor);
//}
//buscaMenor();
//buscaMayor();


//void arreglos()
//{
//    int[] notas = new int[15];
//    Random rnd = new Random();
//    Console.WriteLine("Cargando información...");
//    for (int i = 0; i < notas.Length; i++)
//    {
//        notas[i] = rnd.Next(100);
//    }
//    Console.WriteLine("Desplegando información:");
//    int mayor = 0;
//    int menor = 100;
//    int promedio = 0;
//    int sum = 0;
//    for (int i = 0; i < notas.Length; i++)
//    {
//        Console.WriteLine(notas[i]);
//        if (notas[i] > mayor)
//        {
//            mayor = notas[i];
//        }
//        if (notas[i] < menor)
//        {
//            menor = notas[i];
//        }
//        sum += notas[i];
//    }
//    promedio = sum / notas.Length;
//    Console.WriteLine("Nota mayor: " + mayor);
//    Console.WriteLine("Nota menor: " + menor);
//    Console.WriteLine("Promedio: " + promedio);
//}
//arreglos();

//void nombres()
//{
//    string[] nombre = new string[11];
//    nombre[0] = "jairo";
//    nombre[1] = "Brandom";
//    nombre[2] = "Hector";
//    nombre[3] = "Fatima";
//    nombre[4] = "Obed";
//    nombre[5] = "Fernando";
//    nombre[6] = "Romeo";
//    nombre[7] = "Mynor";
//    nombre[8] = "Angel";
//    nombre[9] = "Mario";
//    nombre[10] = "Carlos";
    

//    for (int i =0;i <nombre.Length;i++)
//    {
//        Console.WriteLine(i + ";" + nombre[i]);
//    }


//    Random rnd = new Random();

    
//    int ganador1 = rnd.Next(nombre.Length);

    
//    int ganador2 = rnd.Next(nombre.Length);
//    while (ganador1 == ganador2)
//    {
//        ganador2 = rnd.Next(nombre.Length);
//    }

//    Console.WriteLine("primer ganador: " + nombre[ganador1]);
//    Console.WriteLine("segundo ganador: " + nombre[ganador2]);
//}
  

//nombres();
////arreglos
//busca mayor 
//llenar mas nombres 10 // haga una fifa sin que gane lo mismo 