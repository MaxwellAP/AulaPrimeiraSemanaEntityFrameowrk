using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anac.DataModel;
using Anac.Doman.Entities;
using Anac.Doman.Entities.Enuns;

namespace Anac.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectPessoaProjectionQuery();
            //SelectPessoaLazyLoading();
            //SelectPessoas()
            //SelectPessoaExplicitLoading();
            //SelectPessoaEagerLoading();
            //SelectPessoasRuim();
            //SelectPessoaComVariasArgumentos();

            //InsertPessoa();
            //InsertVariasPessoas();
            //InsertPessoaComHabilidades();
            //InsertPessoaComHabilidades1();
            InserindoComControleProxy();


            //QueryAndUpdate();
            //QueryAndUpdateDisconnected();
            //DeleteAndUpdateDisconnected();
            QueryWithTrancking();


            Console.ReadKey();
        }

        private static void QueryWithTrancking()
        {
            using (var context = new AnacAulaContext())
            {
                
            }
        }

        private static void InserindoComControleProxy()
        {
            using (var context = new AnacAulaContext())
            {
                context.Configuration.ProxyCreationEnabled = true;

                var pessoaSemProxy = new Pessoa
                {
                    Nome = "Maxwell Sem Proxy",
                    DataNascimento = DateTime.Now,
                    Perfil = new Perfil { Id = 1 },
                    DocumentoOficial = "123"
                };

                var pessoa = context.Pessoas.Create();
                pessoa.Nome = "Maxwell Proxy";
                pessoa.DataNascimento = DateTime.Now;
                pessoa.Perfil = new Perfil{Id = 1};
                pessoa.DocumentoOficial = "123";

                context.Pessoas.Add(pessoa);
                context.Pessoas.Add(pessoaSemProxy);

                context.SaveChanges();

            }
        }

        private static void SelectPessoaProjectionQuery()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.Write;
                var pessoa = context.Pessoas.Select(n => new { n.Nome, n.DataNascimento }).ToList();

            }
        }

        /// <summary>
        /// Aqui falar a respeito do lazyLoading
        /// </summary>
        private static void SelectPessoaLazyLoading()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.Write;
                var pessoa = context.Pessoas.FirstOrDefault(x => x.Id == 3);
            }
        }


        private static void SelectPessoaExplicitLoading()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.Write;

                var pessoa = context.Pessoas.FirstOrDefault(x => x.Id == 3);
                context.Entry(pessoa).Collection(n => n.Habilidades).Load();
            }
        }

        private static void SelectPessoaEagerLoading()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.Write;
                var pessoa = context.Pessoas.Include(x => x.Habilidades).FirstOrDefault(x => x.Id == 3);
            }
        }



        private static void DeleteById()
        {


            var key = 4;

            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                var pessoa = context.Pessoas.Find(key);

                context.Pessoas.Remove(pessoa);
                context.SaveChanges();
            }


        }
        private static void DeleteAndUpdateDisconnected()
        {
            Pessoa pessoa;

            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                pessoa = context.Pessoas.FirstOrDefault();
            }


            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Pessoas.Attach(pessoa);

                context.Pessoas.Remove(pessoa);
                context.SaveChanges();
            }

            //using (var context = new AnacAulaContext())
            //{
            //    context.Database.Log = Console.WriteLine;                
            //    context.Entry(pessoa).State = EntityState.Deleted;
            //    context.SaveChanges();
            //}

        }

        private static void QueryAndUpdateDisconnected()
        {
            Pessoa pessoa;

            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                pessoa = context.Pessoas.FirstOrDefault();
            }

            pessoa.Nome = "Fulado de tal";

            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Pessoas.Attach(pessoa);
                //context.Pessoas.Add(pessoa);
                context.Entry(pessoa).State = EntityState.Modified;


                context.SaveChanges();
            }

        }
        private static void QueryAndUpdate()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;

                var pessoa = context.Pessoas.FirstOrDefault();
                pessoa.DataNascimento = DateTime.Now;
                context.SaveChanges();
            }
        }

        private static void SelectPessoaComVariasArgumentos()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.Write;

                var query = context.Pessoas.Where(x => x.Nome.Contains("Fulano") );
                query = query.Where(x => x.DataNascimento < DateTime.Now);

                var resultado = query.ToList();

            }
        }

        /// <summary>
        /// Retorna todas as pessoas e depois executa o laço e memória do Server
        /// </summary>
        private static void SelectPessoas()
        {
            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                var pessoas = context.Pessoas.ToList();

                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine(pessoa.Nome);
                }
            }
        }

        /// <summary>
        /// Exemplos de como utilizar o FirsOrDefault
        /// </summary>
        private static void FirsOrDefault()
        {
            using (var context = new AnacAulaContext())
            {
                var pessoa = context.Pessoas.Where(x => x.Nome.Contains("Max")).FirstOrDefault();

                var pessoa1 = context.Pessoas.FirstOrDefault(x => x.Nome.Contains("Max"));

                var pessoaPaginada = context.Pessoas.Where(x => x.Nome.Contains("Max"))
                    .OrderBy(x => x.Nome)
                    .Skip(1).Take(1)
                    .FirstOrDefault();


            }
        }

        /// <summary>
        /// Exemplo de pesquisar pessoas de uma maneira Ruim
        /// 
        /// </summary>
        private static void SelectPessoasRuim()
        {
            using (var context = new AnacAulaContext())
            {
                foreach (var pessoa in context.Pessoas)
                {
                    Console.WriteLine(pessoa.Nome);
                }
            }
        }

        #region Exemplos de Insert

        /// <summary>
        /// Aqui inserimos mais de uma pessoa utilizando o método AddRange do DBSet
        /// </summary>
        private static void InsertVariasPessoas()
        {

            var pessoa = new Pessoa
            {
                Nome = "Maxwell",
                DataNascimento = new DateTime(1987, 12, 16),
                PerfilId = 1,
                DocumentoOficial = "123"
            };

            var pessoa2 = new Pessoa
            {
                Nome = "Maxwell",
                DataNascimento = new DateTime(1987, 12, 16),
                PerfilId = 1,
                DocumentoOficial = "123"
            };


            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Pessoas.AddRange(new List<Pessoa> { pessoa, pessoa2 });
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Aqui inserimos uma pessoa utilizando a maneira convencional Add e SaveChanges
        /// </summary>
        private static void InsertPessoa()
        {
            var pessoa = new Pessoa
            {
                Nome = "Maxwell",
                DataNascimento = new DateTime(1987, 12, 16),
                PerfilId = 1
            };

            using (var context = new AnacAulaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Pessoas.Add(pessoa);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Aqui inserimos uma pessoa com várias Habilidades. No entando, adicionamos a pessoa ao contexto e em seguinda as habilidades.
        /// </summary>
        private static void InsertPessoaComHabilidades()
        {

            using (var context = new AnacAulaContext())
            {


                var pessoa = new Pessoa
                {
                    Nome = "Fulano de tal",
                    DataNascimento = new DateTime(1987, 12, 16),
                    DocumentoOficial = "15454",
                    PerfilId = 1
                };

                var habilidade = new Habilidade
                {
                    Descricao = "Atirar",
                    TipoHabilidade = TipoHabilidade.Atirar
                };

                var habilidade1 = new Habilidade
                {
                    Descricao = "Condificar",
                    TipoHabilidade = TipoHabilidade.Codificar
                };

                context.Pessoas.Add(pessoa);

                pessoa.Habilidades.Add(habilidade1);
                pessoa.Habilidades.Add(habilidade);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Aqui um segundo exemplo de inserir uma pessoa e várias habilidades.
        /// </summary>
        private static void InsertPessoaComHabilidades1()
        {

            using (var context = new AnacAulaContext())
            {


                var pessoa = new Pessoa
                {
                    Nome = "Fulano de tal",
                    DataNascimento = new DateTime(1987, 12, 16),
                    DocumentoOficial = "15454",
                    PerfilId = 1,
                    Habilidades = new List<Habilidade>{
                        new Habilidade
                        {
                            Descricao = "Atirar",
                            TipoHabilidade = TipoHabilidade.Atirar
                        },
                        new Habilidade
                        {
                            Descricao = "Programador C#",
                            TipoHabilidade = TipoHabilidade.Codificar
                        }
                    }
                };



                context.Pessoas.Add(pessoa);


                context.SaveChanges();
            }
        }

        #endregion

    }
}
