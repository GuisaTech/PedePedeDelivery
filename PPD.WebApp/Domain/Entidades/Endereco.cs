namespace PPD.WebApp.Domain.Entidades
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string InformacaoEndereco { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Complemento { get; private set; }
        public string Referencia { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public bool Removido { get; private set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        protected Endereco() { }
        
        public Endereco(
            string informacaoEndereco, int numero, string bairro, string cEP, string cidade, int usuarioId,
            string complemento = "", string referencia = "")
        {
            InformacaoEndereco = informacaoEndereco;
            Numero = numero;
            Bairro = bairro;
            CEP = cEP;
            Cidade = cidade;
            Complemento = complemento;
            Referencia = referencia;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
            UsuarioId = usuarioId;
        }
    }
}
