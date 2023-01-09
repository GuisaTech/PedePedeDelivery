namespace PPD.WebApp.Domain.Entidades
{
    public abstract class Entidade
    {
        public bool Removido { get; set; }
        public DateTime DataRegistro { get; set; }

        public void AtualizarStatusRemovido(bool removido) => Removido = removido;

    }
}
