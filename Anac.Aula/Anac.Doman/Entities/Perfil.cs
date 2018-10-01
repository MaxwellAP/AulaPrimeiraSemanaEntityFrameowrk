using System.Collections.Generic;

namespace Anac.Doman.Entities
{
    /// <summary>
    /// Uma classe POCO que representa o Perfil de uma Pessoa
    /// Vejam que um perfil por ter várias pessoas associadadas
    /// </summary>
    public class Perfil
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Pessoa> Pessoas { get; set; }
    }
}
