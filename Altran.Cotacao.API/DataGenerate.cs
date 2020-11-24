using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Infra.Data.Contextos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace Altran.Cotacao.API
{
    public class DataGenerate
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Contexto(serviceProvider.GetRequiredService<DbContextOptions<Contexto>>()))
            {
                if (context.Produtos.Any())
                {
                    return;
                }

                context.Produtos.AddRange(
                    new Produto()
                    { Id = 1, Product = "DT30F", Family_Id = "DTU", Class = "Standart", Gender = "F", Age = 30, Rate = 2.29m },
                    new Produto
                    { Id = 2, Product = "DT30F", Family_Id = "DTU", Class = "Standart", Gender = "M", Age = 30, Rate = 3.05m },
                    new Produto
                    { Id = 3, Product = "DT30F", Family_Id = "DTU", Class = "A", Gender = "F", Age = 30, Rate = 5.71m },
                    new Produto
                    { Id = 4, Product = "DT30F", Family_Id = "DTU", Class = "A", Gender = "M", Age = 30, Rate = 8.77m },
                    new Produto
                    { Id = 5, Product = "AB10F", Family_Id = "ABDU", Class = "Standard", Gender = "F", Age = 30, Rate = 2.65m },
                    new Produto
                    { Id = 6, Product = "AB10F", Family_Id = "ABDU", Class = "Standard", Gender = "M", Age = 30, Rate = 3.59m },
                    new Produto
                    { Id = 7, Product = "AB10F", Family_Id = "ABDU", Class = "A", Gender = "F", Age = 30, Rate = 2.77m },
                    new Produto
                    { Id = 8, Product = "AB10F", Family_Id = "ABDU", Class = "A", Gender = "M", Age = 30, Rate = 1.83m },
                    new Produto
                    { Id = 9, Product = "AB15F", Family_Id = "ABDU", Class = "Standard", Gender = "F", Age = 30, Rate = 2.65m },
                    new Produto
                    { Id = 10, Product = "AB15F", Family_Id = "ABDU", Class = "Standard", Gender = "M", Age = 30, Rate = 3.59m },
                    new Produto
                    { Id = 11, Product = "AB15F", Family_Id = "ABDU", Class = "A", Gender = "F", Age = 30, Rate = 3.00m },
                    new Produto
                    { Id = 12, Product = "AB15F", Family_Id = "ABDU", Class = "A", Gender = "M", Age = 30, Rate = 3.88m },
                    new Produto
                    { Id = 13, Product = "PD05F", Family_Id = "PDU", Class = "Standard", Gender = "F", Age = 30, Rate = 12.36m },
                    new Produto
                    { Id = 14, Product = "PD05F", Family_Id = "PDU", Class = "Standard", Gender = "M", Age = 30, Rate = 13.14m },
                    new Produto
                    { Id = 15, Product = "PD05F", Family_Id = "PDU", Class = "A", Gender = "F", Age = 30, Rate = 13.75m },
                    new Produto
                    { Id = 16, Product = "PD05F", Family_Id = "PDU", Class = "A", Gender = "M", Age = 30, Rate = 12.88m }
                    );
                context.SaveChanges();
            }
        }
    }
}
