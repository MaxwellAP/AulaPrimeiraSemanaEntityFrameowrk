# Primeira semana 

Foram realizados encontros de uma hora e trinta minutos nos dias 27 e 29 de Novembro. Entre os tópicos abordados até agora, estão os seguintes :

## Temas abordados

* Code Firts (Migrations)
  * Enable-Migrations
  * Add-migrations
  * Update-database
* Model First (.Edmx)
  * Gerando e entendendo o edmx com o DbContext Gererator do Entity Framework para fazer a reversa do banco de dados utilizando o modelo .xml
* Reverse Engineer Model to Code Firts
  * Utilizando o DbContext Gererator do Entity Framework para fazer a reversa do banco de dados utilizando o modelo C#
* Entendendo os estados de um objeto
  * DbContext.Entry(model).state 
* Operações básicas de Insert
  * dbContext.Entry(model).State = System.Data.Entity.EntityState.Added 
  * dbContext.Model.Add(model)
* Operações básicas de Update
  * dbContext.Entry(model).State = System.Data.Entity.EntityState.Modified 
  * dbContext.Model.Update(model)
* Operações básicas de Consulta
  * Find()
  * Diferenças entre First() e FirstOrDefault()
  * ToList()
  * Diferenças entre Sigle() e SingleOrDefault()
  * Eager Loading 
  * Lazy Loading 
  * Explicit loading 
  * Projections
* Log DBContex
  * Utilizar o log do entity para exibir o SQL em modelo Consolte DBContext.Configuration.log = Console.Write; 
  
  ## Fontes de pesquisa e estudo.
  <https://docs.microsoft.com/pt-br/ef/>
  <http://thedatafarm.com/blog/>
  <http://www.entityframeworktutorial.net>
