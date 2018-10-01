# Primeira semana 

Foram realizados encontros de uma hora e trinta minutos nos dias 27 e 29 de Novembro. Entre os tópicos abordados até agora, estão os seguintes :

## Temas abordados

1* Code Firts (Migrations)
  * Enable-Migrations
  * Add-migrations
  * Update-database
2. Model First (.Edmx)
  * Gerando e entendendo o edmx com o DbContext Gererator do Entity Framework para fazer a reversa do banco de dados utilizando o modelo .xml
3. Reverse Engineer Model to Code Firts
  * Utilizando o DbContext Gererator do Entity Framework para fazer a reversa do banco de dados utilizando o modelo C#
4. Entendendo os estados de um objeto
  * DbContext.Entry(model).state 
5. Operações básicas de Insert
  * dbContext.Entry(model).State = System.Data.Entity.EntityState.Added 
  * dbContext.Model.Add(model)
6. Operações básicas de Update
  * dbContext.Entry(model).State = System.Data.Entity.EntityState.Modified 
  * dbContext.Model.Update(model)
7. Operações básicas de Consulta
  * Find()
  * Diferenças entre First() e FirstOrDefault()
  * ToList()
  * Diferenças entre Sigle() e SingleOrDefault()
8. Log DBContex
  * Utilizar o log do entity para exibir o SQL em modelo Consolte DBContext.Configuration.log = Console.Write; 
