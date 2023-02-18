using AsincronaS4.Entidades;
using AsincronaS4.Negocio;

ClsVariables clsvariables = new ClsVariables();


Variables variables = new Variables ();
Console.WriteLine("Ingresa una palabra: ");
variables.Numero= Console.ReadLine();
Console.WriteLine("La cantidad de letra es: "+ variables.Numero?.Length);
