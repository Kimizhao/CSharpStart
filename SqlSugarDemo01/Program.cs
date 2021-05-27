using SqlSugar;
using System;

namespace SqlSugarDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //创建数据库对象
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=192.168.10.77;userid=root;pwd=123qwe!@#;port=3306;database=YGVIRemoteEmission;sslmode=none;",//连接符字串
                //ConnectionString = "server=192.168.10.77;uid=sa;pwd=sa123!@#;database=ElecDB3;",//连接符字串
                //DbType = DbType.SqlServer,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute//从特性读取主键自增信息
            });

            //db.DbFirst.CreateClassFile("c:\\Demo\\1", "Models");
            db.DbFirst.IsCreateAttribute().CreateClassFile("C:\\Demo\\YGVIRemoteEmission", "Models");
            //db.DbFirst.IsCreateDefaultValue().CreateClassFile("c:\\Demo\\6", "Models");


            //简单用法

            //var getFirst = db.Queryable<User>().First(it => it.UserName == "admin");//查询单条

            //var getAll = db.Queryable<VehicleInfo>().ToList();

            //var dt = db.Ado.UseStoredProcedure().GetDataTable("usp_GetUserAreasVehicle", new { uid = getFirst.UserID});
            //var dt = db.Ado.UseStoredProcedure().SqlQuery<areas>("usp_GetUserAreasVehicle", new { uid = getFirst.UserID });

            //if (dt != null && dt.Rows.Count > 0)
            //{

            //}

            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    Console.WriteLine($"{dt.Rows.Count}");
            //}

            //if (getAll != null)
            //{
                //Console.WriteLine($"{getAll.Count}");
            //}
        }
    }
}
