namespace Patrones.Comando
{
    public class ComandoAmazon : IComando // comando
    {
        private SmartTV tv;
        public ComandoAmazon(SmartTV _tv)
        {
            this.tv = _tv;
        }

        public void Ejecutar()
        {
            tv.AbreAmazon();
        }
    }
}