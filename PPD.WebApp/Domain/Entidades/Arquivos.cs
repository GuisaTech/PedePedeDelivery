using PPD.WebApp.Domain.Enum;

namespace PPD.WebApp.Domain.Entidades
{
    public class Arquivos
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoArquivo TipoUpload { get; private set; }
        public string TipoArquivo { get; private set; }
        public string Base64 { get; private set; }
        public bool Privado { get; private set; }

        public DateTime DataRegistro { get; private set; }
        public bool Removido { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected Arquivos() { }

        public Arquivos(string nome, TipoArquivo tipoUpload, string tipoArquivo, string base64, bool privado, int usuarioId)
        {
            Nome = nome;
            TipoUpload = tipoUpload;
            TipoArquivo = tipoArquivo;
            Base64 = base64;
            Privado = privado;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
            UsuarioId = usuarioId;
        }
    }
}
