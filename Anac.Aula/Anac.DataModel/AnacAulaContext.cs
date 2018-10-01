using System.Data.Entity;
using Anac.Doman.Entities;

namespace Anac.DataModel
{
    /// <summary>
    /// Nossa Classe padrão de acesso a dados de nosso projeto de estudos DemoWare.
    /// </summary>
    public class AnacAulaContext : DbContext
    {
        /// <summary>
        /// Aqui temos o contructor do nosso contexto de acesso a Dados.
        /// Lembro que a classe DBContext tem uma séria de sobrecargas em seu constructo, sendo assim, podem estudar esses sobrecargas na documentação Oficial.
        /// https://msdn.microsoft.com/en-us/library/system.data.entity.dbcontext.dbcontext(v=vs.113).aspx
        /// </summary>
        public AnacAulaContext()
        {
            //Habilida o log padrão em modo Debug para visualizar as Querys que são executadas pelo Entity
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            
            //Aqui desabilitamos por padrão o LazyLoading do projeto
            Configuration.LazyLoadingEnabled = false;

            //Aqui desabilitamos por padrão o Proxy do projeto
            Configuration.ProxyCreationEnabled = false;
        }

        //Aqui declaramos os DBSet padrão de nosso projeto.
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
    }
}
