using Exa_2.Data.Entity;

namespace Exa_2.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<Floors> GetPlant();
        Floors GetPlant(int id);
        void AddPLant(Floors floors);
        void UpdatePlant(Floors floors);
        void RemovePlant(Floors floors);
       Task<bool> SaveAllAsync();
        bool plantexists(int Id);


       
    }
}
