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
            db.StringSet($"num", "Test Number");
            Console.WriteLine(db.StringGet("num"));
            
        }
    }
}
