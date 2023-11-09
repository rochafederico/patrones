namespace Patrones.CadenaDeResponsabilidad
{
    public class Supervisor : Aprobador
    {
        public override void ProcesarSolicitud(Compra? compra = null)
        {
            if (compra?.Monto < 10000000.0)
            {
                this.ImprimirProceso(compra);
            }
            else
            {
                Sucesor?.ProcesarSolicitud(compra);
            }
        }
    }
}