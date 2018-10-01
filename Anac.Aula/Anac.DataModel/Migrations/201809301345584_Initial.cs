namespace Anac.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habilidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        TipoHabilidade = c.Int(nullable: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DocumentoOficial = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        PerfilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Perfils", t => t.PerfilId, cascadeDelete: true)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.Perfils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "PerfilId", "dbo.Perfils");
            DropForeignKey("dbo.Habilidades", "PessoaId", "dbo.Pessoas");
            DropIndex("dbo.Pessoas", new[] { "PerfilId" });
            DropIndex("dbo.Habilidades", new[] { "PessoaId" });
            DropTable("dbo.Perfils");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Habilidades");
        }
    }
}
