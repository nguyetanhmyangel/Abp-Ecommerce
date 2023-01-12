using System;

namespace BasicEcommerce.Admin.Products;

public class ProductListFilterDto: BaseListFilterDto
{
    public Guid? CategoryId { get; set; }
}

/*
 remember use command: "abp generate-proxy -t ng" in terminal angular when change code
 */