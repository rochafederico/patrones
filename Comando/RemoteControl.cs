namespace Patrones.Comando
{
    public class RemoteControl // receptor
    {
        private IComando _comando;
        public void SetComando(IComando comando)
        {
            this._comando = comando;
        }
        public void PrecionarBoton()
        {
            this._comando.Ejecutar();
        }
    }
}