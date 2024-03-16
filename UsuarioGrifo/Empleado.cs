using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioGrifo
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombres, double saldo, double sueldo) : base(nombres, saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
