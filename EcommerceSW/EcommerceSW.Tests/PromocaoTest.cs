using EcommerceSW.Domain;
using EcommerceSW.Service;
using System.Collections.Generic;
using Xunit;

namespace EcommerceSW.Tests
{
    public class PromocaoTest
    {
        public PromocaoTest()
        {
        }

        [Fact]
        public void RecuperarPromocoesSucesso()
        {
            PromocaoService promocaoService = new PromocaoService();

            var resultado = promocaoService.ListarPromocoes();

            List<string> esperado = new List<string> { "defaut", TipoPromocao.pagueUmLeveDois, TipoPromocao.tresPorDezReais };

            Assert.Equal(esperado.Count, resultado.Count);
        }
    }
}
