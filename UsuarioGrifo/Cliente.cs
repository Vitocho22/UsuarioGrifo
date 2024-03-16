using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioGrifo
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente(string nombres, double saldo, double litrosCargados) : base(nombres, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }
}
