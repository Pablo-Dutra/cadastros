using apiCadastro.Model;
using apiCadastro.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apiCadastro.Controllers
{
    [ApiController]
    [Route("api/v1/pessoa")]
    public class PessoaController : ControllerBase  
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository ?? throw new ArgumentNullException(nameof(pessoaRepository));
        }
        [Authorize]
        [HttpPost]
        public IActionResult Add([FromForm] PessoaViewModel pessoaView)
        {
            var filePath = Path.Combine("Storage", pessoaView.Foto.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);

            pessoaView.Foto.CopyTo(fileStream);

            var pessoa = new Pessoa(pessoaView.Nome, pessoaView.Codigo, pessoaView.Email, filePath);

            _pessoaRepository.Add(pessoa);

            return Ok();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var pessoas = _pessoaRepository.Get();
            return Ok(pessoas);
        }
        [Authorize]
        [HttpPost]
        [Route("download/{id}")]
        public IActionResult DownloadFoto(int id)
        {
            var pessoa = _pessoaRepository.Get(id);
            
            var dataBytes = System.IO.File.ReadAllBytes(pessoa.foto);

            return File(dataBytes, "image/jpg");
        }
    }
}
