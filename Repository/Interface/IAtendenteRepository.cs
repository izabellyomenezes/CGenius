using CGenius.Models;

namespace CGenius.Repository.Interface
{
    public interface IAtendenteRepository
    {
        Task<IEnumerable<Atendente>> GetAtendentes();
        Task<Atendente> GetAtendente(string cpfAtendente);
        Task<Atendente> AddAtendente(Atendente atendente);
        Task<Atendente> UpdateAtendente(Atendente atendente);
        void DeleteAtendente(string cpfAtendente);
    }
}
