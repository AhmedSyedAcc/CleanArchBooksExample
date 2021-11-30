using CleanArch.Application.Interface;
using CleanArch.Application.Services;
using CleanArch.Domain.RepositoryInterface;
using CLeanArch.Infra.data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterUser(IServiceCollection services)
        {
            services.AddScoped<IBookServices, BookServices>();

            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
