namespace Patos.Dominio
{
    public class PatoB : Pato
    {
        public PatoB() : base("pato1.png")
        {
        }

        public override string Quack() => "Squeeeeeek!";
    }
}