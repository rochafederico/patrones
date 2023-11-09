using System.Collections.Generic;
using Patrones.CadenaDeResponsabilidad;
using Patrones.Comando;
// using Patrones.Decorador;
using Patrones.TemplateMethod;

namespace Patrones
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // GetSingleton();
            // GetTemplateMethod();
            // GetDecorador();
            // GetCommand();
            GetCadenaDeResponsabilidad();
        }
        private static void GetCadenaDeResponsabilidad()
        {
            Aprobador admin = new Administrador();
            Aprobador supervisor = new Supervisor();
            Aprobador repositor = new Repositor();

            repositor.SetSucesor(supervisor);
            supervisor.SetSucesor(admin);

            Compra compra = new()
            {
                Descripcion = "Cafe",
                Numero = 12,
                Monto = 10000
            };

            repositor.ProcesarSolicitud(compra);

            Compra compra2 = new()
            {
                Descripcion = "400 litros de leche",
                Numero = 12,
                Monto = 10000000
            };

            repositor.ProcesarSolicitud(compra2);
        }
        // private static void GetCommand()
        // {
        //     SmartTV tv = new SmartTV();
        //     ComandoAmazon comandoAmazon = new ComandoAmazon(tv);
        //     RemoteControl control = new RemoteControl();
        //     control.SetComando(comandoAmazon);
        //     control.PrecionarBoton();
        // }
        private static void GetDecorador()
        {
            // comprar 2 Hamburguesas:
            // 1 simple
            // IDecorador haburguesaSimple = new DecoradorHamburguesa();
            // Console.WriteLine(haburguesaSimple.GetDescripcion() + haburguesaSimple.GetPrecio());
            // // 1 simple + queso
            // IDecorador haburguesaConQueso = new DecoradorQueso(haburguesaSimple);
            // Console.WriteLine(haburguesaConQueso.GetDescripcion() + haburguesaConQueso.GetPrecio());
        }
        private static void GetTemplateMethod()
        {
            var reclutamientoUno = new ProcesoAccenture();
            reclutamientoUno.Procesar();
        }
        private static void GetSingleton()
        {
            Console.WriteLine("Singleton");
            EventLogger instancia = EventLogger.GetInstance();
            instancia.AddEvent("Evento 1");
            instancia.AddEvent("Evento 2");
            instancia.AddEvent("Evento 3");

            Console.WriteLine("instancia");
            instancia.ShowEvents();

            EventLogger instancia2 = EventLogger.GetInstance();
            Console.WriteLine("instancia2");
            instancia2.ShowEvents();

            EventLogger instancia3 = EventLogger.GetInstance();
            instancia3.AddEvent("Evento 4");
            Console.WriteLine("instancia3");
            instancia2.ShowEvents();
        }
    }
}