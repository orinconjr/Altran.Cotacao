using Altran.Cotacao.Aplicacao.Interfaces;
using Altran.Cotacao.Aplicacao.Servicos;
using Altran.Cotacao.Dominio.Interfaces.Repositorios;
using Altran.Cotacao.Dominio.Interfaces.Servicos;
using Altran.Cotacao.Dominio.Servicos;
using Altran.Cotacao.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IProdutoApp, ProdutoApp>();
            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IProdutoServico, Altran.Cotacao.Dominio.Servicos.ProdutoServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
        }
    }
}