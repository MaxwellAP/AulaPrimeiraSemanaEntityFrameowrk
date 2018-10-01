using Anac.Doman.Entities.Enuns;
namespace Anac.Doman.Entities
{
    /// <summary>
    /// Uma classe POCO que representa as habilidades de uma pessoa. No mapeamento, vejam que cada Habilidade tem ao menos uma pessoa.
    /// TipoHabilidade é um enum para mostrar que o EntityFramework faz o Cast de um Enum para um propriedade do Tipo Int em nossa Base de dados
    /// </summary>
    public class Habilidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoHabilidade TipoHabilidade { get; set; }
        
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}
