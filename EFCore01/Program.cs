using EFCore01.Contexts;

namespace EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext itiDbContext = new ITIDbContext();
        }
    }
}
