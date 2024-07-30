
using PolimorfismoQ32024;

//Polimorfismo mediante herencia y sobrecarga
Console.WriteLine("********** Objeto Casa **********");
Casa casa = new Casa();
casa.TipoInmueble = "Apartamento";
casa.Precio = 1000000;
casa.Ubicacion = "La Esperanza, Intibucá";
casa.AreaTerreno = 50;
casa.Vender();
Console.WriteLine("********** Fin Objeto Casa **********");
Console.WriteLine();

Console.WriteLine("********** Objeto Departamento **********");
Departamento departamento = new Departamento(1500000);
departamento.TipoInmueble = "Casa Grande";
departamento.Ubicacion = "Gracias, Lempira";
departamento.AreaTerreno = 150;
departamento.Vender();
Console.WriteLine("********** Fin Objeto Departamento **********");
Console.WriteLine();

Console.WriteLine("********** Objeto Terreno **********");
Terreno terreno = new Terreno("Terreno", 750000);
terreno.Ubicacion = "Tegucigalpa";
terreno.AreaTerreno = 200;
terreno.Vender();

terreno.Vender("Ramon Lopez");
terreno.Vender(10000);
terreno.Vender("Carlos Perez", 5000);
Console.WriteLine("********** Fin Objeto Terreno **********");
Console.WriteLine();

//Polimorfismo mediante Listas
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