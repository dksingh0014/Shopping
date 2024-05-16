using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Product> Products = new()
        {
            new Product
            {
                Name = "IPhone X",
                Discription="This phone is the companies's bigest change to its flagship smart phone.",
                ImageFile="Product_1.png",
                Price=950.00,
                Category="Smart Phone"
            },
             new Product
            {
                Name = "IPhone X1",
                Discription="This phone is the companies's bigest change to its flagship smart phone.",
                ImageFile="Product_2.png",
                Price=850.00,
                Category="Smart Phone"
            },
              new Product
            {
                Name = "IPhone X2",
                Discription="This phone is the companies's bigest change to its flagship smart phone.",
                ImageFile="Product_3.png",
                Price=900.00,
                Category="KK Phone"
            },
               new Product
            {
                Name = "IPhone X3",
                Discription="This phone is the companies's bigest change to its flagship smart phone.",
                ImageFile="Product_4.png",
                Price=700.00,
                Category="Home Phone"
            },
                 new Product
            {
                Name = "IPhone X4",
                Discription="This phone is the companies's bigest change to its flagship smart phone.",
                ImageFile="Product_5.png",
                Price=1000.00,
                Category="KK Phone"
            }
        };
    }
}
