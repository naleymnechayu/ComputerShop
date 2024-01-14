using ComputerShop.Interfaces;
using ComputerShop.Models;

namespace ComputerShop.Mocks
{
    public class MockProduct : IAllProducts {

        private readonly IProductCategory _productCategory = new MockCategory();

        public IEnumerable<Products> Products{
            get {
                return new List<Products>()
                {
                    new Products{
                        Id = 0,
                        Name = "Ноутбук Lenovo",
                        ShortDesc = "Мощный ноутбук",
                        Description = "Хороший ноутбук за свои деньги",
                        img = "/img/product/team-fredi-8HRKoay8VJE-unsplash.jpeg",
                        price = 50000,
                        isHit = false,
                        count = 3,
                        Category = _productCategory.GetCategories.ElementAt(0)
                    },
                     new Products{
                        Id = 1,
                        Name = "Ноутбук Asus",
                        ShortDesc = "Супер ощный ноутбук",
                        Description = "Дорого-богато",
                        img = "/img/product/Galaxy-Book-Flex-15_3_large.jpg",
                        price = 300,
                        isHit = true,
                        count = 12,
                        Category = _productCategory.GetCategories.ElementAt(0)
                    },
                      new Products{
                        Id = 2,
                        Name = "Ноутбук Sumsung",
                        ShortDesc = "Один из лучших бюджетных ноутбуков",
                        Description = "вашему корману понравиться",
                        img = "/img/product/pasted image 0.png",
                        price = 200,
                        isHit = true,
                        count = 3,
                        Category = _productCategory.GetCategories.ElementAt(0)
                    },
                       new Products{
                        Id = 3,
                        Name = "Ноутбук Apple",
                        ShortDesc = "ноутбук для работы",
                        Description = "самое то,если вы фанат apple",
                        img = "/img/product/pasted image 1 (1).png",
                        price = 5100,
                        isHit = true,
                        count = 10,
                        Category = _productCategory.GetCategories.ElementAt(0)
                    },
                       new Products{
                        Id = 4,
                        Name = "Ноутбук Lenovo 2",
                        ShortDesc = "Приемлемый ноутбук",
                        Description = "Хит продаж последных лет",
                        img = "/img/product/popa.jpg",
                        price = 50000,
                        isHit = true,
                        count = 10,
                        Category = _productCategory.GetCategories.ElementAt(0)
                    },
                    new Products{
                        Id = 5,
                        Name = "Телефон Lenovo",
                        ShortDesc = "Мощный телефон",
                        Description = "один из лучших на рынке",
                        img = "/img/product/tel 1.jpeg",
                        price = 50000,
                        isHit = true,
                        count = 10,
                        Category = _productCategory.GetCategories.ElementAt(1)
                    },
                    new Products{
                        Id = 6,
                        Name = "Планшет Lenovo",
                        ShortDesc = "Мощный планшет",
                        Description = "один из лучших на рынке",
                        img = "/img/product/pl 1.jpeg",
                        price = 50000,
                        isHit = false,
                        count = 2,
                        Category = _productCategory.GetCategories.ElementAt(2)
                    },
                    new Products{
                        Id = 7,
                        Name = "ЦП Lenovo",
                        ShortDesc = "Мощный процессор",
                        Description = "подойдет для вашего устройства",
                        img = "/img/product/zepe.jpeg",
                        price = 50000,
                        isHit = false,
                        count = 4,
                        Category = _productCategory.GetCategories.ElementAt(3)
                    },
                    new Products{
                        Id = 8,
                        Name = "Планшет асус",
                        ShortDesc = "Самый мощьный на рынке",
                        Description = "Заставит любые игры и программы летать",
                        img = "/img/product/planshet.jpeg",
                        price = 44000,
                        isHit = false,
                        count = 25,
                        Category = _productCategory.GetCategories.ElementAt(2)
                    }
                };
            }
        }
        public IEnumerable<Products> GetFavouriteProduct { get; set; }
        public Products GetObjectProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
