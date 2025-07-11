using System;
using System.Collections.Generic;
using Shopping.Client.Models;

namespace Shopping.Client.Data
{
	public static class ProductContext
	{
		public static readonly List<Product> Products = new List<Product>
		{
			new Product()
			{
				Name = "iphone",
				Description = "phone by apple",
				ImageFile = "product.jpeg",
				Price = 840.00M,
				Category = "SM"
			},
             new Product()
            {
                Name = "xiamoi",
                Description = "phone by xxaxa",
                ImageFile = "product.jpeg",
                Price = 520.00M,
                Category = "SM"
            },
        };
	}
}

