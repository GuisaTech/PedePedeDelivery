﻿using PPD.WebApp.Domain.Enum;

namespace PPD.WebApp.Domain.Entidades
{
    public class RedeSocial
    {
        public int Id { get; private set; }
        public string UrlSite { get; private set; }
        public string UrlInstagram { get; private set; }
        public string NomeInstagram { get; private set; }
        public string UrlYoutube { get; private set; }
        public string NomeYoutube { get; private set; }
        public string UrlFacebook { get; private set; }
        public string NomeFacebook { get; private set; }
        public Titular Titular { get; private set; }

        public DateTime DataRegistro { get; private set; }
        public bool Removido { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected RedeSocial() { }

        public RedeSocial(int usuarioId, string urlSite="", string urlInstagram="", string nomeInstagram="",
            string urlYoutube="", string nomeYoutube="", string urlFacebook="", string nomeFacebook="", Titular titular= Titular.Pessoal)
        {
            UsuarioId = usuarioId;
            UrlSite = urlSite;
            UrlInstagram = urlInstagram;
            NomeInstagram = nomeInstagram;
            UrlYoutube = urlYoutube;
            NomeYoutube = nomeYoutube;
            UrlFacebook = urlFacebook;
            NomeFacebook = nomeFacebook;
            Titular = titular;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
        }
    }
}
