using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Sqlite;
using SQLite;
using Xamarin.Forms;

namespace DAO
{
    public class Context
    {
        internal SQLiteConnection database;

        internal Context()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();


            //database.CreateTable<ConfiguracaoDTO>();

        }
    }
}
