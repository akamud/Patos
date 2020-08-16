namespace Patos.Dominio
{
    public class Pato
    {
        public Pato(string imagem)
        {
            Imagem = imagem;
        }

        public string Imagem { get; set; }

        public virtual string Quack() => "Quack!";

        public bool Voar() => true;
        public void Nadar()
        {
        }
    }
}
