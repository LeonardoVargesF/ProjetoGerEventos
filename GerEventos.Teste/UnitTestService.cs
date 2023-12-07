using System.Text.Json;
using AutoMapper;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Repository.Context;
using GerEventos.Repository.Repository;
using GerEventos.Service.Services;
using GerEventos.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GerEventos.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "GerEventos";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Cidade, Cidade>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestPalestrante()
        {
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Cidade>>();
            var cidade = new Cidade
            {
                Nome = "Aracatuba",
                Estado = "Sao Paulo"
            };

            var result = _userService?.Add<Cidade, Cidade, CidadeValidator>(cidade);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
