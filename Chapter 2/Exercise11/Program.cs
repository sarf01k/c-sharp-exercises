using System.Text;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char racter = '\u00A9';

            Console.WriteLine($@"
                                                            {racter}
                                                    {racter}        {racter}
                                            {racter}                 {racter}
                                    {racter}                          {racter}
                            {racter}                                   {racter}
                    {racter}                                            {racter}
            {racter}        {racter}        {racter}        {racter}        {racter}        {racter}        {racter}");
        }
    }
}