using Exa_2.Data.Entity;

namespace Exa_2.Data.Repository
{
    public class Repository:IRepository
    {
        private readonly DataContext contex;

        public Repository(DataContext contex)
        {
            this.contex = contex;
        }

        public IEnumerable<Floors> GetPlant()
        {
            return this.contex.floors.OrderBy(p => p.Plant_Name);

        }

        public Floors GetPlant(int id)
        {
            return this.contex.floors.Find(id);
        }

        public void AddPLant(Floors floors)
        {
            this.contex.floors.Add(floors);

        }
        public void UpdatePlant(Floors floors)
        {
            this.contex.floors.Update(floors);

        }

        public void RemovePlant(Floors floors)
        {
            this.contex.floors.Remove(floors);

        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.contex.SaveChangesAsync() > 0;

        }

        public bool plantexists(int Id)
        {
            return this.contex.floors.Any(p => p.Id == Id);
        }




       
    }
}
