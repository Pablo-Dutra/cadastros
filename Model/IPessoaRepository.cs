namespace apiCadastro.Model
{
    public interface IPessoaRepository
    {
        void Add(Pessoa pessoa);
        List<Pessoa> Get();
        Pessoa? Get(int id);
    }
}
