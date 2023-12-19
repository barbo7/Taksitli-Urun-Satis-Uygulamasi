using System;
using System.Data.Entity;
using TahsilatUyg_.DBModel; // Veritabanı bağlamınızın namespacesini ekleyin


namespace TahsilatUyg_
{
    public class Startup
    {
        public void Configuration()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UrunTahsilatDBContext>());

            using (var context = new UrunTahsilatDBContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}
