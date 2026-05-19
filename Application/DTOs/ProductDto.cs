using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs;

public class ProductDto
{
    public int Id { get; set; }

    public string ProductName { get; set; } = string.Empty;
}
public class CreateProductDto
{
    public string ProductName { get; set; } = string.Empty;
}
public class UpdateProductDto
{
    public string ProductName { get; set; } = string.Empty;
}

