using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ProductRepository : Repository<SpGetProductById>, IProductRepository
    {
        private readonly adventureworksdbContext _repositoryPatternDemoContextContext;

        public ProductRepository(adventureworksdbContext repositoryPatternDemoContextContext) : base(repositoryPatternDemoContextContext)
        {
            _repositoryPatternDemoContextContext = repositoryPatternDemoContextContext;
        }

        
        public new async Task<IEnumerable<SpGetProductById>> GetProductById()
        {
            DbCommand cmd = _repositoryPatternDemoContextContext.Database.GetDbConnection().CreateCommand();

            cmd.CommandText = "dbo.GetProductById";
            cmd.CommandType = CommandType.StoredProcedure;

           // cmd.Parameters.Add(new SqlParameter("@ProductKey", SqlDbType.Int));

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            await cmd.ExecuteNonQueryAsync();
            DbDataReader reader1 = cmd.ExecuteReader();

            var list = new List<SpGetProductById>();

            using (var reader = reader1)
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        string productkey = reader["ProductKey"].ToString() as string ?? default(string);
                        string name = reader["EnglishProductName"].ToString() as string ?? default(string);
                        string descrption = reader["EnglishDescription"].ToString() as string ?? default(string);
                        string category = reader["EnglishProductSubcategoryName"].ToString() as string ?? default(string);
                        list.Add(new SpGetProductById { ProductKey=productkey, EnglishProductName = name, EnglishDescription = descrption, EnglishProductSubcategoryName = category });
                    }
                }
                reader.NextResult();
            }
            reader1.Dispose();
            cmd.Dispose();
            return list;
        }
    }
}