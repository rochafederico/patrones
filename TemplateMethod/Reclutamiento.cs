using System.Collections.Generic;

namespace Patrones.TemplateMethod
{
    internal abstract class Reclutamiento
    {
        public virtual void Reclutar(){
            Console.WriteLine("Aplica preuba tecnica");
        }
    }
}