using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBasicoEutiquio
{
    public  class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }

        public Pedido(int id, double total)
        {
            Id = id;
            Fecha = DateTime.Now;
            Total = total;
        }

        public void MostrarPedido()
        {
            Console.WriteLine("\n--- PEDIDO GENERADO ---");
            Console.WriteLine($"Pedido No: {Id}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Total: ${Total}");
        }
    }
}
