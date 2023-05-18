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
int a = 0;
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

