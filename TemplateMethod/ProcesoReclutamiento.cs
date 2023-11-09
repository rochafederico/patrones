
namespace Patrones.TemplateMethod
{
    public abstract class ProcesoReclutamiento
    {
        public abstract bool RecibirCV();
        public abstract bool RealizarEntrevista();
        public abstract bool RealizaPruebaTecnica();
        public abstract bool OfertaInicial();
        public abstract bool OfertaSegunda();
        public abstract bool FirmarContrato();
        public void Procesar()
        {
            this.RecibirCV();
            this.RealizarEntrevista();
            this.RealizaPruebaTecnica();

            var result = this.OfertaInicial();
            if (!result)
            {
                result = this.OfertaSegunda();
            }

            if (result)
            {
                this.FirmarContrato();
            }
        }
    }
}