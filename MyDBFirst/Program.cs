using System.Data;

namespace MyDBFirst
{
    public class Program
    {
        
        public static void Main()
        {
            SqlDB db = new SqlDB();
            db.TestConnection();            
        }
    }
}