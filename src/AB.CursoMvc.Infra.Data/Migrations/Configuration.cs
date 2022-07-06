    using AB.CursoMvc.Infra.Data.Context;
    using System.Data.Entity.Migrations;
   

    namespace AB.CursoMvc.Infra.Data.Migrations
{ 
    internal sealed class Configuration : DbMigrationsConfiguration<CursoMvcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CursoMvcContext context)
        {
            
        }
    }
}
