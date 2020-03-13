using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion {
    class Program {
        static void Main(string[] args) {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope()) {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
