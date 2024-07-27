
//Polimorfismo mediante Listas
using PolimorfismoQ32024;

List<Edificio> edificioLista = new List<Edificio>();
string opcion = "";

do
{
    Edificio edificio = new Edificio();
    Console.WriteLine("Ingrese tipo de edificio:");
    edificio.Tipo = Console.ReadLine();
    Console.WriteLine("Ingrese el precio:");
    edificio.Precio = Convert.ToDouble(Console.ReadLine());
    edificioLista.Add(edificio);
    Console.WriteLine("¿Desea continuar? (S/N o s/n)");
    opcion = Console.ReadLine();
} while (opcion.ToUpper() != "N");

Console.WriteLine();
Console.WriteLine("********** LISTA DE EDIFICIOS **********");
foreach(Edificio edificio in edificioLista)
{
    edificio.Vender();
}