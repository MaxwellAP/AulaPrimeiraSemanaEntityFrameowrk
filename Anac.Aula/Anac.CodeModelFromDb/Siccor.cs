namespace Anac.CodeModelFromDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Siccor : DbContext
    {
        public Siccor()
            : base("name=Siccor")
        {
        }

        public virtual DbSet<ANDAMENTO_PROCESSO> ANDAMENTO_PROCESSO { get; set; }
        public virtual DbSet<ATIVIDADE> ATIVIDADEs { get; set; }
        public virtual DbSet<ATO_PRATICADO> ATO_PRATICADO { get; set; }
        public virtual DbSet<ATO_PROCESSO> ATO_PROCESSO { get; set; }
        public virtual DbSet<AUTORIDADE> AUTORIDADEs { get; set; }
        public virtual DbSet<COMISSAO_DISCIPLINAR> COMISSAO_DISCIPLINAR { get; set; }
        public virtual DbSet<COMISSAO_DISCIPLINAR_PROCESSO> COMISSAO_DISCIPLINAR_PROCESSO { get; set; }
        public virtual DbSet<CONTEUDO_DECISAO> CONTEUDO_DECISAO { get; set; }
        public virtual DbSet<CORREICAO> CORREICAOs { get; set; }
        public virtual DbSet<DECISAO_JUDICIAL> DECISAO_JUDICIAL { get; set; }
        public virtual DbSet<DEMANDA_ESPECIAL> DEMANDA_ESPECIAL { get; set; }
        public virtual DbSet<DISTRIBUICAO_PROCESSO> DISTRIBUICAO_PROCESSO { get; set; }
        public virtual DbSet<ENDERECO_COMISSAO> ENDERECO_COMISSAO { get; set; }
        public virtual DbSet<ENVOLVIDO_PROCESSO> ENVOLVIDO_PROCESSO { get; set; }
        public virtual DbSet<ESPECIE> ESPECIEs { get; set; }
        public virtual DbSet<FASE_ATO_PROCESSO> FASE_ATO_PROCESSO { get; set; }
        public virtual DbSet<FASE_PROCESSO> FASE_PROCESSO { get; set; }
        public virtual DbSet<INTERESSADO> INTERESSADOes { get; set; }
        public virtual DbSet<JULGAMENTO> JULGAMENTOes { get; set; }
        public virtual DbSet<LOCAL_ORGAO> LOCAL_ORGAO { get; set; }
        public virtual DbSet<MEIO_PUBLICACAO> MEIO_PUBLICACAO { get; set; }
        public virtual DbSet<OBJETO> OBJETOes { get; set; }
        public virtual DbSet<OBJETO_TIPO_PROCESSO> OBJETO_TIPO_PROCESSO { get; set; }
        public virtual DbSet<ORGAO> ORGAOs { get; set; }
        public virtual DbSet<ORGAO_EXTERNO> ORGAO_EXTERNO { get; set; }
        public virtual DbSet<ORGAO_PROLATOR> ORGAO_PROLATOR { get; set; }
        public virtual DbSet<PEDIDO_CERTIDAO> PEDIDO_CERTIDAO { get; set; }
        public virtual DbSet<PROCESSO> PROCESSOes { get; set; }
        public virtual DbSet<PROCESSO_ADMINISTRATIVO_DISCIPLINAR> PROCESSO_ADMINISTRATIVO_DISCIPLINAR { get; set; }
        public virtual DbSet<PROCESSO_ADMINISTRATIVO_GERAL> PROCESSO_ADMINISTRATIVO_GERAL { get; set; }
        public virtual DbSet<PROCESSO_NEGOCIO> PROCESSO_NEGOCIO { get; set; }
        public virtual DbSet<PROCESSO_PORTARIA> PROCESSO_PORTARIA { get; set; }
        public virtual DbSet<PROCESSO_RELACIONADO> PROCESSO_RELACIONADO { get; set; }
        public virtual DbSet<RELATORIO_FINAL> RELATORIO_FINAL { get; set; }
        public virtual DbSet<SICCOR_APLICACAO_LOG> SICCOR_APLICACAO_LOG { get; set; }
        public virtual DbSet<SUSPENSAO_PRESCRICAO> SUSPENSAO_PRESCRICAO { get; set; }
        public virtual DbSet<TIPO_ATIVIDADE> TIPO_ATIVIDADE { get; set; }
        public virtual DbSet<TIPO_CONTEUDO_DECISAO> TIPO_CONTEUDO_DECISAO { get; set; }
        public virtual DbSet<TIPO_DECISAO> TIPO_DECISAO { get; set; }
        public virtual DbSet<TIPO_ENVOLVIMENTO> TIPO_ENVOLVIMENTO { get; set; }
        public virtual DbSet<TIPO_JULGAMENTO> TIPO_JULGAMENTO { get; set; }
        public virtual DbSet<TIPO_PORTARIA> TIPO_PORTARIA { get; set; }
        public virtual DbSet<TIPO_PROCESSO> TIPO_PROCESSO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ANDAMENTO_PROCESSO>()
                .HasMany(e => e.DISTRIBUICAO_PROCESSO)
                .WithRequired(e => e.ANDAMENTO_PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ATO_PRATICADO>()
                .Property(e => e.DS_ATO_PRATICADO)
                .IsUnicode(false);

            modelBuilder.Entity<ATO_PROCESSO>()
                .Property(e => e.DS_ATO_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<AUTORIDADE>()
                .Property(e => e.DS_AUTORIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR>()
                .Property(e => e.SG_UF)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR>()
                .Property(e => e.DS_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR>()
                .Property(e => e.NR_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR>()
                .Property(e => e.DS_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR>()
                .Property(e => e.DS_UNIDADE_SEI)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR>()
                .HasMany(e => e.COMISSAO_DISCIPLINAR_PROCESSO)
                .WithRequired(e => e.COMISSAO_DISCIPLINAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMISSAO_DISCIPLINAR_PROCESSO>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTEUDO_DECISAO>()
                .Property(e => e.DS_CONTEUDO_DECISAO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTEUDO_DECISAO>()
                .HasMany(e => e.DECISAO_JUDICIAL)
                .WithRequired(e => e.CONTEUDO_DECISAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTEUDO_DECISAO>()
                .HasMany(e => e.JULGAMENTOes)
                .WithRequired(e => e.CONTEUDO_DECISAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTEUDO_DECISAO>()
                .HasMany(e => e.RELATORIO_FINAL)
                .WithRequired(e => e.CONTEUDO_DECISAO)
                .HasForeignKey(e => e.ID_TIPO_DECISAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CORREICAO>()
                .Property(e => e.TP_ESPECIE_CORREICAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CORREICAO>()
                .Property(e => e.NR_PORTATIA)
                .IsUnicode(false);

            modelBuilder.Entity<DECISAO_JUDICIAL>()
                .Property(e => e.DS_DECISAO_JUDICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<DEMANDA_ESPECIAL>()
                .Property(e => e.TP_INTERESSADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_COMISSAO>()
                .Property(e => e.DS_ENDERECO_COMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_COMISSAO>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESPECIE>()
                .Property(e => e.DS_ESPECIE)
                .IsUnicode(false);

            modelBuilder.Entity<ESPECIE>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FASE_ATO_PROCESSO>()
                .HasMany(e => e.ANDAMENTO_PROCESSO)
                .WithRequired(e => e.FASE_ATO_PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FASE_PROCESSO>()
                .Property(e => e.DS_FASE_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<FASE_PROCESSO>()
                .HasMany(e => e.FASE_ATO_PROCESSO)
                .WithRequired(e => e.FASE_PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INTERESSADO>()
                .Property(e => e.TP_INTERESSADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INTERESSADO>()
                .Property(e => e.TP_ORGAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JULGAMENTO>()
                .Property(e => e.DS_DETALHAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<LOCAL_ORGAO>()
                .Property(e => e.DS_LOCAL_ORGAO)
                .IsUnicode(false);

            modelBuilder.Entity<LOCAL_ORGAO>()
                .HasMany(e => e.COMISSAO_DISCIPLINAR)
                .WithRequired(e => e.LOCAL_ORGAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MEIO_PUBLICACAO>()
                .Property(e => e.DS_MEIO_PUBLICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<MEIO_PUBLICACAO>()
                .HasMany(e => e.JULGAMENTOes)
                .WithRequired(e => e.MEIO_PUBLICACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OBJETO>()
                .Property(e => e.DS_OBJETO)
                .IsUnicode(false);

            modelBuilder.Entity<OBJETO>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OBJETO>()
                .HasMany(e => e.CORREICAOs)
                .WithRequired(e => e.OBJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OBJETO>()
                .HasMany(e => e.OBJETO_TIPO_PROCESSO)
                .WithRequired(e => e.OBJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORGAO>()
                .Property(e => e.NM_ORGAO)
                .IsUnicode(false);

            modelBuilder.Entity<ORGAO_EXTERNO>()
                .Property(e => e.NM_ORGAO_EXTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ORGAO_PROLATOR>()
                .Property(e => e.DS_ORGAO_PROLATOR)
                .IsUnicode(false);

            modelBuilder.Entity<ORGAO_PROLATOR>()
                .HasMany(e => e.DECISAO_JUDICIAL)
                .WithRequired(e => e.ORGAO_PROLATOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .Property(e => e.NR_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO>()
                .Property(e => e.TP_ARMAZENAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.ANDAMENTO_PROCESSO)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.COMISSAO_DISCIPLINAR_PROCESSO)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.CORREICAOs)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.DECISAO_JUDICIAL)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.DEMANDA_ESPECIAL)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.INTERESSADOes)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.JULGAMENTOes)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.PROCESSO_ADMINISTRATIVO_DISCIPLINAR)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.PROCESSO_ADMINISTRATIVO_GERAL)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.PROCESSO_PORTARIA)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.PROCESSO_RELACIONADO)
                .WithRequired(e => e.PROCESSO)
                .HasForeignKey(e => e.ID_PROCESSO_PRINCIPAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.PROCESSO_RELACIONADO1)
                .WithRequired(e => e.PROCESSO1)
                .HasForeignKey(e => e.ID_PROCESSO_RELACIONADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.RELATORIO_FINAL)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO>()
                .HasMany(e => e.SUSPENSAO_PRESCRICAO)
                .WithRequired(e => e.PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROCESSO_ADMINISTRATIVO_DISCIPLINAR>()
                .Property(e => e.NR_PROCESSO_APOIO_COMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_ADMINISTRATIVO_DISCIPLINAR>()
                .Property(e => e.TX_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_ADMINISTRATIVO_GERAL>()
                .Property(e => e.TP_INTERESSADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_ADMINISTRATIVO_GERAL>()
                .Property(e => e.DS_ASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_NEGOCIO>()
                .Property(e => e.NM_PROCESSO_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.NR_PORTARIA)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.SN_PORTARIA_INSTAURACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.TP_MEIO_PUBLICACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.NR_SECAO_DIARIO_OFICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.NR_PAGINA_DIARIO_OFICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.NR_VOLUME_BOLETIM_PESSOAL_SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_PORTARIA>()
                .Property(e => e.NR_BOLETIM_PESSOAL_SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESSO_RELACIONADO>()
                .Property(e => e.TP_RELACIONAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RELATORIO_FINAL>()
                .Property(e => e.DS_DETALHAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SICCOR_APLICACAO_LOG>()
                .Property(e => e.DS_PONTO_OCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<SICCOR_APLICACAO_LOG>()
                .Property(e => e.DS_NIVEL_OCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<SICCOR_APLICACAO_LOG>()
                .Property(e => e.DS_USUARIO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<SICCOR_APLICACAO_LOG>()
                .Property(e => e.DS_MENSAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<SICCOR_APLICACAO_LOG>()
                .Property(e => e.DS_EXCECAO)
                .IsUnicode(false);

            modelBuilder.Entity<SUSPENSAO_PRESCRICAO>()
                .Property(e => e.DS_SUSPENSAO_PRESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ATIVIDADE>()
                .Property(e => e.DS_ATIVIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CONTEUDO_DECISAO>()
                .Property(e => e.DS_TIPO_CONTEUDO_DECISAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CONTEUDO_DECISAO>()
                .HasMany(e => e.CONTEUDO_DECISAO)
                .WithRequired(e => e.TIPO_CONTEUDO_DECISAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_DECISAO>()
                .Property(e => e.DS_TIPO_DECISAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DECISAO>()
                .HasMany(e => e.DECISAO_JUDICIAL)
                .WithRequired(e => e.TIPO_DECISAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_ENVOLVIMENTO>()
                .Property(e => e.DS_TIPO_ENVOLVIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ENVOLVIMENTO>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ENVOLVIMENTO>()
                .HasMany(e => e.ENVOLVIDO_PROCESSO)
                .WithRequired(e => e.TIPO_ENVOLVIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_JULGAMENTO>()
                .Property(e => e.DS_TIPO_JULGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_JULGAMENTO>()
                .HasMany(e => e.JULGAMENTOes)
                .WithRequired(e => e.TIPO_JULGAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_PORTARIA>()
                .Property(e => e.DS_TIPO_PORTARIA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PROCESSO>()
                .Property(e => e.DS_TIPO_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PROCESSO>()
                .Property(e => e.SN_REGISTRO_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PROCESSO>()
                .HasMany(e => e.OBJETO_TIPO_PROCESSO)
                .WithRequired(e => e.TIPO_PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_PROCESSO>()
                .HasMany(e => e.PROCESSOes)
                .WithRequired(e => e.TIPO_PROCESSO)
                .WillCascadeOnDelete(false);
        }
    }
}
