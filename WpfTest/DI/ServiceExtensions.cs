using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest
{
    public static class ServiceExtensions
    {
        public static ServiceProvider serviceProvider = new ServiceCollection()
            .AddSingleton<AppViewModel>()
            .BuildServiceProvider();
        public static AppViewModel appViewModel = serviceProvider.GetService<AppViewModel>();
    }
}
