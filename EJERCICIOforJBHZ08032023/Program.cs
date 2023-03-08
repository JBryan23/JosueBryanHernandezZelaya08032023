// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("===============================");
Console.WriteLine("Bienvenido usuario inteligente");
Console.WriteLine("===============================");
Console.WriteLine();

Console.Write(@"Porfavor ingrese un numero entero que seria la altura 
del triangulo a mostrar: ");

int entero = int.Parse(Console.ReadLine());
for (int y = 1; y<= entero; y++){
    for(int x = 1; x<= y; x++){
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.Write("Muchas gracias por utilizar el programa");