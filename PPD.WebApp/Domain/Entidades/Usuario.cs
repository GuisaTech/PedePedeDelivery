namespace PPD.WebApp.Domain.Entidades
{
    //Adicionar Removido e data de registro em todos
    public class Usuario : Entidade
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string? Telefone { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public bool Autorizado { get; private set; }

        public List<Endereco> Enderecos { get; private set; }

        //public int RedeSocialId { get; private set; }
        public RedeSocial RedeSocial { get; private set; }

        //public int EmpresaId { get; private set; }
        public Empresa Empresa { get; private set; }

        public List<ChavePix> ChavesPix { get; private set; }
        public List<ContaBancaria> ContasBancarias { get; private set; }
        public List<Arquivo> Arquivos { get; private set; }

        protected Usuario() { }

        public Usuario(string nome, string cpf, string email, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Autorizado = false;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
            Enderecos= new List<Endereco>();
            ChavesPix = new List<ChavePix>();
            ContasBancarias= new List<ContaBancaria>();
        }

        public void AtualizarInformacoesDePerfil(string telefone, DateTime dataNascimento)
        {
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public void AtualizarEnderecos(Endereco endereco) => Enderecos.Add(endereco);
        public void AtualizarEnderecos(List<Endereco> endereco) => Enderecos = endereco;
        public void AtualizarRedeSocial(RedeSocial redesocial) => RedeSocial = redesocial;
        public void AtualizarEmpresa(Empresa empresa) => Empresa = empresa;
        public void AtualizarChavePix(ChavePix chavePix) => ChavesPix.Add(chavePix);
        public void AtualizarChavePix(List<ChavePix> chavesPix)=> ChavesPix = chavesPix;
        public void AtualizarContaBancaria(ContaBancaria contaBancaria)=> ContasBancarias.Add(contaBancaria);
        public void AtualizarContaBancaria(List<ContaBancaria> contasBancarias) => ContasBancarias= contasBancarias;
        public void AtualizarArquivos(Arquivo arquivos) => Arquivos.Add(arquivos);
        public void AtualizarArquivos(List<Arquivo> arquivos) => Arquivos= arquivos;

        public void AtualizarStatusRemovido(bool removido) => Removido = removido;
        public bool Valido() => true;
    }
}
