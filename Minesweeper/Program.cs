using Autofac;
using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość pól(enter) i ilość min żeby wyświetlić planszę ");
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
