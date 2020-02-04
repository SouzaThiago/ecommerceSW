using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EcommerceSW.Service.Contracts
{
    public interface IPromocaoService
    {
        List<SelectListItem> ListarPromocoes();
    }
}
