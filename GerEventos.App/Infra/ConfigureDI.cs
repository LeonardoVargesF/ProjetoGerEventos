using AutoMapper;
using GerEventos.App.Cadastros;
using GerEventos.App.Models;
using GerEventos.App.Outros;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Repository.Context;
using GerEventos.Repository.Repository;
using GerEventos.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;


namespace GerEventos.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DataBaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Evento>, BaseRepository<Evento>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<EventoPalestrante>, BaseRepository<EventoPalestrante>>();
            Services.AddScoped<IBaseRepository<Palestrante>, BaseRepository<Palestrante>>();
            Services.AddScoped<IBaseRepository<Participante>, BaseRepository<Participante>>();
            Services.AddScoped<IBaseRepository<EventoInscricao>, BaseRepository<EventoInscricao>>();
            // Services
            Services.AddScoped<IBaseService<Evento>, BaseService<Evento>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<EventoPalestrante>, BaseService<EventoPalestrante>>();
            Services.AddScoped<IBaseService<Palestrante>, BaseService<Palestrante>>();
            Services.AddScoped<IBaseService<Participante>, BaseService<Participante>>();
            Services.AddScoped<IBaseService<EventoInscricao>, BaseService<EventoInscricao>>();

            // Formulários

            Services.AddTransient<CadastroEvento, CadastroEvento>();
            Services.AddTransient<CadastroPalestrante, CadastroPalestrante>();
            Services.AddTransient<CadastroParticipante, CadastroParticipante>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroInscricao, CadastroInscricao>();
            Services.AddTransient<CadastroPalestranteEvento, CadastroPalestranteEvento>();
            Services.AddTransient<Relatorio, Relatorio>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Palestrante, PalestranteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Participante, ParticipanteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<EventoPalestrante, EventoPalestranteModel>()
                    .ForMember(d => d.Evento, d => d.MapFrom(x => $"{x.Evento!.Nome}"))
                    .ForMember(d => d.IdEvento, d => d.MapFrom(x => x.Evento!.Id))
                    .ForMember(d => d.Palestrante, d => d.MapFrom(x => $"{x.Palestrante!.Nome}"))
                    .ForMember(d => d.IdPalestrante, d => d.MapFrom(x => x.Palestrante!.Id));
                config.CreateMap<Evento, EventoModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<EventoInscricao, EventoInscricaoModel>()
                    .ForMember(d => d.Evento, d => d.MapFrom(x => $"{x.Evento!.Nome}"))
                    .ForMember(d => d.IdEvento, d => d.MapFrom(x => x.Evento!.Id))
                    .ForMember(d => d.Participante, d => d.MapFrom(x => $"{x.Participante!.Nome}"))
                    .ForMember(d => d.IdParticipante, d => d.MapFrom(x => x.Participante!.Id));
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
