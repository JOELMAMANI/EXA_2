namespace Exa_2.Data
{
    public class SeedDB
    {
        private readonly DataContext contex;
        private Random random;

        public SeedDB(DataContext contex)
        {
            this.contex = contex;
            this.random = new Random();
        }
        public async Task SeedAsync()
        {
            await this.contex.Database.EnsureCreatedAsync();

            if (this.contex.floors.Any())
            {
                this.AddProduct("primer_producto");
                this.AddProduct("segundo_producto");
                this.AddProduct("tercer_producto");
                await this.contex.SaveChangesAsync();


            }


            if (this.contex.irrigations.Any())
            {
                this.AddProduct("primera_ciudad");
                this.AddProduct("segunda_ciudad");
                this.AddProduct("tercera_ciudad");
                await this.contex.SaveChangesAsync();


            }
           

        }


        private void AddProduct(string name)
        {
            this.contex.floors.Add(new Entity.Floors
            {
                Plant_Name= name,
                Plant_Description= name,
                Plant_family=name,
                Plant_Type=name,
                Plant_cost=this.random.Next(100),
                Planting_amount=this.random.Next(100),
                
               

            });


            this.contex.irrigations.Add(new Entity.Irrigation
            {
                Plantation_Name=name,
                Plantation_Description=name,
                Plantation_Type=name,   

            });
           
        }
    }
}
