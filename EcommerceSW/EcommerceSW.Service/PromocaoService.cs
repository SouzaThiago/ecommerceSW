using EcommerceSW.Domain;
using EcommerceSW.Service.Contracts;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EcommerceSW.Service
{
    public class PromocaoService : IPromocaoService
    {
        public PromocaoService()
        {
        }

        public List<SelectListItem> ListarPromocoes()
        {
            var promocoes = GetPromocoes();
            List<SelectListItem> result = new List<SelectListItem>() { new SelectListItem() { Text = null, Value = null } };

            foreach (var promocao in promocoes)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = promocao,
                    Value = promocao
                };

                result.Add(item);
            }

            return result;
        }

        private static List<string> GetPromocoes()
        {
            return new List<string>() 
            { 
                TipoPromocao.pagueUmLeveDois, 
                TipoPromocao.tresPorDezReais
            };
        }
    }
}
