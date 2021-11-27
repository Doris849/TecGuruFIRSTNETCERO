using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioPolimorfismo
{
    public abstract class Viaje
    {
        public DateTime HorarioSalida { get; set; }
        public DateTime HorarioLlegada { get; set; }

        public int TotalAsientos { get; set; }

        public decimal CostoxAsientos { get; set; }

        public abstract decimal GananciaViaje();


        //public decimal GananciaViaje( decimal costoxasientos, int totalasientos)
        //{
        //    return (costoxasientos * totalasientos);
        //}

        //Ejercicio Final POO
        //****ejercicio Crear clase base Viaje en carpeta EjercicioPolimorfismo ->crearla
        //*nota implementar alguna manera de polimorfismo
        //La clase Viaje tendra las siguientes propiedades: 
        //HorarioSalida DateTime, HorarioLLegada  DateTime,
        //int TotalAsientos, costoXasiento en  decimal,
        //accion GananciaViaje decimal "costoXasiento X TotalAsientos"   

        //Heredar Viaje en las clases Suburban y Autobus
        //ambos vehiculos tienen de propiedad: matricula

        //***Con opcion a crear clase base de vehiculo matricula***

        //En un metodo aparte en program Soliciten cantidad de asientos inmediatam


    }
}
