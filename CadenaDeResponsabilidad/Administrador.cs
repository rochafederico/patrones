namespace Patrones.CadenaDeResponsabilidad
{
    public class Administrador : Aprobador
    {
        public override void ProcesarSolicitud(Compra? compra = null)
        {
            if (compra?.Monto < 100000000.0)
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