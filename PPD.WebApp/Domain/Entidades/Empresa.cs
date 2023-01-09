namespace PPD.WebApp.Domain.Entidades
{
    public class Empresa : Entidade
    {
        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string ApelidoUrl { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string InformacaoEndereco { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string? Complemento { get; private set; }
        public string? Referencia { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected Empresa() { }

        public Empresa(string razaoSocial, string nomeFantasia, string cnpj, string apelidoUrl, string telefone, string email, string informacaoEndereco, int numero, string bairro, string cep, string cidade, string estado, string complemento = "", string referencia = "")
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            ApelidoUrl = apelidoUrl;
            Telefone = telefone;
            Email = email;
            InformacaoEndereco = informacaoEndereco;
            Numero = numero;
            Bairro = bairro;
            Estado= estado;
            CEP = cep;
            Cidade = cidade;
            Complemento = complemento;
            Referencia = referencia;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
        }

        public void AdicionarUsuario(Usuario usuario) => Usuario = usuario;

    }
}
