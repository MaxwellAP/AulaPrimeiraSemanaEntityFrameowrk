using System;
using System.Collections.Generic;

namespace Anac.Doman.Entities
{
    /// <summary>
    /// Classe POCO que representa uma pessoa
    /// Em nosso mapeamento uma pessoa tem várias habilidade e um único Peril
    /// </summary>
    public class Pessoa
    {
        public Pessoa()
        {
            Habilidades = new List<Habilidade>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string DocumentoOficial { get; set; }
        public DateTime DataNascimento { get; set; }

        
        /// <summary>
        /// O padrão de mapeamento de chave estrangeira é UperCamelCase EntitidadeID
        /// Exemplo PerfilId
        /// </summary>
        public int PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }

        /// <summary>
        /// Se a coleção estiver como virtual e o Lazy Loading habilidade, automaticamente a coleção será carregada.
        /// </summary>
        public virtual List<Habilidade> Habilidades { get; set; }
    }
}
