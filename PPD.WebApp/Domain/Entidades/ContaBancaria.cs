using PPD.WebApp.Domain.Enum;

namespace PPD.WebApp.Domain.Entidades
{
    public class ContaBancaria
    {
        public int Id { get; private set; }
        public string Agencia { get; private set; }
        public string DigitoAgencia { get; private set; }
        public string Conta { get; private set; }
        public string DigitoConta { get; private set; }
        public string CodigoBanco { get; private set; }
        public string CpfTitular { get; private set; }
        public bool SouTitular { get; private set; }
        public Titular Titular { get; private set; }

        public DateTime DataRegistro { get; private set; }
        public bool Removido { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected ContaBancaria() { }

        public ContaBancaria(string agencia, string conta, string codigoBanco, string cpfTitular, bool souTitular, Titular titular, int usuarioId, string digitoAgencia = "", string digitoConta = "")
        {
            Agencia = agencia;
            DigitoAgencia = digitoAgencia;
            Conta = conta;
            DigitoConta = digitoConta;
            CodigoBanco = codigoBanco;
            CpfTitular = cpfTitular;
            SouTitular = souTitular;
            Titular = titular;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
            UsuarioId = usuarioId;
        }
    }
}
