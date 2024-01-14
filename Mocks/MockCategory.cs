using ComputerShop.Interfaces;
using ComputerShop.Models;

namespace ComputerShop.Mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> GetCategories
        {
            get {
                return new List<Category>
                {
                    new Category {Id = 1, Name = "Ноутбуки", Description = "Переносной компьютер, в корпусе которого объединены типичные компоненты персонального компьютера, включая дисплей, клавиатуру, тачпад и аккумуляторные батареи."},
                    new Category {Id = 2, Name = "Телефоны", Description = "Аппарат для передачи и приёма звука на расстоянии. Современные телефоны осуществляют передачу посредством электрических сигналов."},
                    new Category {Id = 3, Name = "Планшеты", Description = "Электронное устройство с сенсорным экраном. Позволяет управлять компьютерными программами при помощи прикосновений пальцев к объектам на экране."},
                    new Category {Id = 4, Name = "ЦП", Description = "Электронный блок либо интегральная схема, исполняющая машинные инструкции (код программ), главная часть аппаратного обеспечения компьютера или программируемого логического контроллера."},
                };
            }
        }
    }
}
