namespace Agenda
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelAgenda : DbContext
    {
        public ModelAgenda()
            : base("name=ModelAgenda")
        {
        }

        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Compromisso> Compromissos { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}