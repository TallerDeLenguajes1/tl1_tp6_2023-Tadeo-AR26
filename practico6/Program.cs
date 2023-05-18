// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("El valor de a:"+a);
Console.WriteLine("El valor de b:"+b);
*/

// Ejercicio01
/*int a = 0;
bool esNumero = false;
string? StringNumero = "";
string? NumeroInvertido = "";

while(!esNumero){
    Console.WriteLine("Escriba un numero");
    StringNumero = Console.ReadLine();
    esNumero = int.TryParse(StringNumero, out a);
    if(!esNumero){
        Console.WriteLine("No se ha ingresado un numero valido");
    }
    else{
        for(int i = StringNumero.Length-1; i>=0; i--){
            NumeroInvertido += StringNumero[i];
        }
    }
}

Console.WriteLine("El numero invertido es: "+NumeroInvertido);
*/

//Ejercicio02 - CalculadoraV1

string? operacion = "";
int a = 0, b = 0;
float resultado;
do{
    Console.WriteLine("Ingrese la operacion que desea realizar");
    Console.WriteLine("Suma: +");
    Console.WriteLine("Resta: -");
    Console.WriteLine("Multiplicacion: *");
    Console.WriteLine("Division: /");
    operacion = Console.ReadLine();
    switch(operacion)
    {
    case "+":
        Console.WriteLine("Ingrese los numeros que desea sumar");
        bool control = int.TryParse(Console.ReadLine(), out a);
        bool control2 = int.TryParse(Console.ReadLine(), out b);
        resultado = a+b;
        Console.WriteLine(resultado);
        break;
    case "-":
        Console.WriteLine("Ingrese los numeros que desea restar");
        control = int.TryParse(Console.ReadLine(), out a);
        control2 = int.TryParse(Console.ReadLine(), out b);
        resultado = a-b;
        Console.WriteLine(resultado);
        break;
    case "*":
        Console.WriteLine("Ingrese los numeros que desea multiplicar");
        control = int.TryParse(Console.ReadLine(), out a);
        control2 = int.TryParse(Console.ReadLine(), out b);
        resultado = a*b;
        Console.WriteLine(resultado);
        break;
    case "/":
        Console.WriteLine("Ingrese los numeros que desea dividir");
        control = int.TryParse(Console.ReadLine(), out a);
        control2 = int.TryParse(Console.ReadLine(), out b);
        resultado = a/b;
        Console.WriteLine(resultado);
        break;
    }
    Console.WriteLine("Ingrese y si desea finalizar las operaciones");
    operacion = Console.ReadLine();
}while(operacion != "y");
