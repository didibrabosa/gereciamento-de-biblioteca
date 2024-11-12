using System.Collections.Generic;
using InventarioLivros.Models;
using InventarioLivros.Repositories;

namespace InventarioLivros.Services
{
    public interface ILivroService
    {
        IEnumerable<Livro> GetLivros();
        Livro? GetLivroById(int id);
        void AddLivro(Livro livro);
        void UpdateLivro(Livro livro);
        void DeleteLivro(int id);
    }

    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;

        public LivroService(ILivroRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Livro> GetLivros() => _repository.GetLivros();
        
        public Livro? GetLivroById(int id) => _repository.GetLivroById(id);

        public void AddLivro(Livro livro) => _repository.AddLivro(livro);

        public void UpdateLivro(Livro livro) => _repository.UpdateLivro(livro);

        public void DeleteLivro(int id) => _repository.DeleteLivro(id);
    }
}
