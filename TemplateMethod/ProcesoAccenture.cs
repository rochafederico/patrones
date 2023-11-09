namespace Patrones.TemplateMethod
{
    public class ProcesoAccenture : ProcesoReclutamiento
    {
        private string? urlCv;
        private string? entrevista;
        private string? firma;
        private int sueldo;

        public ProcesoAccenture()
        {
        }

        public override bool RecibirCV()
        {
            try
            {
                Console.WriteLine("Ingresa la url de tu CV");
                this.urlCv = Console.ReadLine();
                return true;
            }
            catch
            {
            }
            return false;
        }
        public override bool FirmarContrato()
        {
            try
            {
                Console.WriteLine("Ingresa tu nombre completo para firmar el contrato");
                this.firma = Console.ReadLine();

                Console.WriteLine("- Url CV:");
                Console.WriteLine(this.urlCv);
                Console.WriteLine("- Tu experienivia es:");
                Console.WriteLine(this.entrevista);
                Console.WriteLine("- Firma:");
                Console.WriteLine(this.firma);
                Console.WriteLine("- Sueldo:");
                Console.WriteLine(this.sueldo);
                return true;
            }
            catch
            {
            }
            return false;
        }

        public override bool RealizarEntrevista()
        {
            try
            {
                Console.WriteLine("Que sabes hacer/?");
                this.entrevista = Console.ReadLine();
                return true;
            }
            catch
            {
            }
            return false;
        }

        public override bool RealizaPruebaTecnica()
        {
            Console.WriteLine("Cuanto es 1 + 1?");
            var aceptaOferta = Console.ReadLine();
            return aceptaOferta == "2";
        }

        public override bool OfertaInicial()
        {
            Console.WriteLine("Te ofrecemos 400 dolares, responde 'si' o 'no'");
            var aceptaOferta = Console.ReadLine();
            var result = aceptaOferta == "si";
            if (result)
            {
                this.sueldo = 400;
            }
            return result;
        }

        public override bool OfertaSegunda()
        {
            Console.WriteLine("Te ofrecemos 600 dolares, responde 'si' o 'no'");
            var aceptaOferta = Console.ReadLine();
            var result = aceptaOferta == "si";
            if (result)
            {
                this.sueldo = 600;
            }
            return result;
        }
    }
}