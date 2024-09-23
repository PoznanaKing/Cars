using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{

    


    internal class Program
    {
        public static List<Car> carList = new List<Car>();
        static Connection conn = new Connection();
        public static void Feladat1()
        {
            conn.connection.Open();

            string sqlCode1 = "SELECT * FROM `cars` WHERE 1;";
            MySqlCommand cmd = new MySqlCommand(sqlCode1, conn.connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            do
            {
                Car temp = new Car();
                temp.Id = dr.GetInt32(0);
                temp.Brand = dr.GetString(1);
                temp.Type = dr.GetString(2);
                temp.License_Number = dr.GetString(3);
                temp.ReleaseDate = dr.GetDateTime(4);

                carList.Add(temp);
            } while (dr.Read());
            
            dr.Close();

            conn.connection.Close();
        }
        static void Main(string[] args)
        {
            Feladat1();
            Console.WriteLine("Első feladat: ");
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine($"{carList[i].Brand} | {carList[i].License_Number}");
            }
            Console.ReadKey ();

        }
    }
}
