using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BasicEcommerce.Admin.ProductCategories;
public interface IProductCategoriesAppService : ICrudAppService<ProductCategoryDto,
    Guid, 
    PagedResultRequestDto,
    CreateUpdateProductCategoryDto, 
    CreateUpdateProductCategoryDto>
{
}