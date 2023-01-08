using Microsoft.AspNetCore.Mvc;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Domain.Enum;
using PPD.WebApp.Infrastructure.Repository;
using PPD.WebApp.Infrastructure.Repository.Interfaces;
using PPD.WebApp.Models;
using System.Collections;
using System.Diagnostics;

namespace PPD.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository= usuarioRepository;
        }

        public async Task<IActionResult> Index()
        {
            //Usuario usuario = new Usuario("Gustavo Ferreira dos Santos", "08705565502", "dev.gustavo.santos@hotmail.com", "G428289393!g");
            //Empresa empresa = new Empresa("GuisaTech Desenvolvimento de Sistemas LTDA", "GuisaTech", "43590448000176", "GuisaTech", "73999020709", "dev.gustavo.santos@hotmail.com", "Rua do Pelourinho", 801, "Capoeiruçu", "44300000", "Cachoeira", "Bahia", "Condominio Royalle, Edificio Paris 801", "Pizzaria Tukanas");
            //Endereco endereco1 = new Endereco("Rua do Roxo", 202, "Capoeiruçu", "44300000", "Cachoeira", "Bahia", usuario.Id);
            //Endereco endereco2 = new Endereco("Rua do Peloruinho", 202, "Capoeiruçu", "44500000", "Cachoeira", "Bahia", usuario.Id);
            //ChavePix chavePix1 = new ChavePix(TipoChavePix.Cpf, "08705565502",true, Titular.Pessoal, usuario.Id);
            //ChavePix chavePix2 = new ChavePix(TipoChavePix.Email, "dev.gustavo.santos@hotmail.com", true, Titular.Empresa, usuario.Id);
            //ContaBancaria contaBancaria1 = new ContaBancaria("1962", "436423", "033", "08705565502", true, Titular.Pessoal, usuario.Id);
            //RedeSocial redeSocial = new RedeSocial(usuario.Id, "guisatech.com", "@GuisaTech", "GuisaTech", "www.youtube.com/Guisatech", "Guisatech");

            //usuario.AtualizarEmpresa(empresa);
            //usuario.AtualizarRedeSocial(redeSocial);
            //usuario.AtualizarContaBancaria(contaBancaria1);

            //usuario.AtualizarChavePix(chavePix1);
            //usuario.AtualizarChavePix(chavePix2);

            //usuario.AtualizarEnderecos(endereco1);
            //usuario.AtualizarEnderecos(endereco2);

            //_usuarioRepository.Adicionar(usuario);

            ///Atualizando
            var usuario = await _usuarioRepository.ObterPeloIdAsync(4);
            //usuario.AtualizarInformacoesDePerfil("73999020709", DateTime.Parse("22-11-2000"));

            //_usuarioRepository.Atualizar(usuario);

            //Removendo
            _usuarioRepository.Remover(usuario);



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}