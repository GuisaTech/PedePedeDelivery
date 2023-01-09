using PPD.WebApp.Domain.Enum;

namespace PPD.WebApp.Domain.Entidades
{
    public class Arquivo : Entidade
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public ETipoArquivo TipoUpload { get; private set; }
        public string TipoArquivo { get; private set; }
        public string Base64 { get; private set; }
        public bool Privado { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected Arquivo() { }

        public Arquivo(string nome, ETipoArquivo tipoUpload, string tipoArquivo, string base64, bool privado, int usuarioId)
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
