using System;

namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
