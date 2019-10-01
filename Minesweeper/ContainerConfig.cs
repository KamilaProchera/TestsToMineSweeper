using Autofac;
using MinesweeperLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Minesweeper
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LoadABoard>().As<ILoadABoard>();
            builder.RegisterType<Dig>().As<IDig>();
            builder.RegisterType<CheckPosition>().As<ICheckPosition>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MinesweeperLibrary))).Where(t => t.Namespace.Contains("FillInBoard"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name=="I"+t.Name));
            return builder.Build();

        }

    }
}
