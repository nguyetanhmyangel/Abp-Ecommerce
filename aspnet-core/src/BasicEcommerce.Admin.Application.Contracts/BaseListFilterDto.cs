using Volo.Abp.Application.Dtos;

namespace BasicEcommerce.Admin;

public class BaseListFilterDto: PagedResultRequestDto
{
    public string Keyword { get; set; }
}