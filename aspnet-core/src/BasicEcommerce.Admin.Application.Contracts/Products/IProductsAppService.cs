using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BasicEcommerce.Admin.Products;

public interface IProductsAppService: ICrudAppService<ProductDto,
    Guid, 
    PagedResultRequestDto,
    CreateUpdateProductDto, 
    CreateUpdateProductDto>
{
    Task<PagedResultDto<ProductInListDto>> GetListFilterAsync(BaseListFilterDto input);
    Task<List<ProductInListDto>> GetListAllAsync();
    Task DeleteMultipleAsync(IEnumerable<Guid> ids);
}