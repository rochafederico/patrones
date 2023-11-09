namespace Patrones.CadenaDeResponsabilidad
{
    public abstract class Aprobador // handler
    {
        protected Aprobador Sucesor;
        public void SetSucesor(Aprobador _sucesor)
        {
            this.Sucesor = _sucesor;
        }
        public abstract void ProcesarSolicitud(Compra compra);
        public void ImprimirProceso(Compra compra)
        {
            Console.WriteLine($"Solicitud {compra.Numero} por el monto {compra.Monto}  aprobada por {this.GetType()}");
        }
    }
}