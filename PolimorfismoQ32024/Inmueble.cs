
namespace PolimorfismoQ32024
{
    public class Inmueble
    {
        public string TipoInmueble { get; set; }

        public string Ubicacion { get; set; }

        public double AreaTerreno { get; set; }

        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble} con un área de {AreaTerreno}, con ubicación en {Ubicacion} ha sido vendida por el precio de L{Precio}");
        }
    }
}
