using apiCadastro.Model;

namespace apiCadastro.Infraestrutura
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public List<Pessoa> Get()
        {
            return _context.Pessoas.ToList();
        }

        public Pessoa? Get(int id)
        {
            return _context.Pessoas.Find(id);
        }
    }
}
