using Anac.Doman.Entities;

namespace Anac.DataModel.Migrations
{
    using System.Data.Entity.Migrations;
    
    internal sealed class Configuration : DbMigrationsConfiguration<Anac.DataModel.AnacAulaContext>
    {
        /// <summary>
        /// Essa propriedade abilita as migrações automaticas do Migrations. Sendo assim, a cada alterações em classe de domínio mapeada no Context ele ira alterar o Banco de dados.
        /// Não recomeno habilitar essa propriedade.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Esse método é responsável por realizar a carga inicial em seus banco de dados.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(Anac.DataModel.AnacAulaContext context)
        {
            context.Perfils.AddOrUpdate(x => x.Id,
                new Perfil() { Id = 1, Descricao = "Administrador" },
                new Perfil() { Id = 2, Descricao = "Analista" },
                new Perfil() { Id = 3, Descricao = "Secrataria" }
            );
        }
    }
}
