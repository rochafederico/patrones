namespace Patrones.CadenaDeResponsabilidad
{
    public class Repositor : Aprobador
    {
        public override void ProcesarSolicitud(Compra? compra = null)
        {
            Sucesor?.ProcesarSolicitud(compra);
        }
    }
}