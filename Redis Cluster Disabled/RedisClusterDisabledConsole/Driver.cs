using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace ConsoleRedisApp
{
    public class Driver
    {
        static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { "127.0.0.1:7011", "127.0.0.1:7010", "127.0.0.1:7012" },
            });
        public static void Main(string[] args)
        {
            var db = redis.GetDatabase();
            var pong = db.Ping();
            Console.WriteLine(pong);
            
            
            //1. set data
            db.StringSet($"num", "Test Number");

            //2. get data
            Console.WriteLine(db.StringGet("num"));

            //3. update data
            db.StringSet($"num", "Test Number updated");
            Console.WriteLine(db.StringGet("num"));

            //4. delete data
            db.KeyDelete($"num");
            Console.WriteLine(db.StringGet("num"));
        }
    }
}
