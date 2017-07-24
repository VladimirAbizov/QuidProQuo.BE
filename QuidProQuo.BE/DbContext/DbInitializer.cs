using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuidProQuo.BE.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<QpqContext>
    {
        // аккаунты
        private void SeedAccounts(QpqContext db)
        {
            db.Accounts.Add(new Account
            {
                ID = 1,
                Login = "admin",
                Password = "123",                                                          
                Profile = new Profile { Address = "Samara", Email = "oao@cat.ru" }
            });
        }

        // объявление (услуга)
        private void SeedOrderService(QpqContext db)
        {
            db.ServiceOrders.Add(new ServiceOrder
            {
                DateTime = "05.08.2000",
                objectBase = new Service
                {
                    Title = "service"
                }
            });
        }

        // объявление (вещь)
        private void SeedOrderThing(QpqContext db)
        {
            db.ServiceOrders.Add(new ServiceOrder
            {
                DateTime = "01.01.1111",
                objectBase = new Thing
                {
                    Title = "thing"
                }
            });
        }
        // категории вещей
        private void SeedCategoriesOfThings(QpqContext db)
        {
            db.CategoryItems.Add(new CategoryItem
            {
                ID = 1,
                Title = "Продукты",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Молочные продукты", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Мясо, птица, яйца", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Рыба, морепродукты", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Овощи", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Фрукты, ягоды", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Грибы", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Бакалея", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Продукты пчеловодства", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Консервированная продукция", CategoryType = CategoryType.Thing },
                }
            });
            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Одежда, обувь, аксессуары",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem
                    {
                        Title = "Женский гардероб ",
                        CategoryType = CategoryType.Thing
                    },
                    new CategoryItem
                    {
                        Title = "Мужской гардероб",
                        CategoryType = CategoryType.Thing 
                    },
                    new CategoryItem {Title = "Детский гардероб", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Спецодежда", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Охота, рыбалка, походы",
                CategoryType = CategoryType.Thing,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Билеты",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Авиабилеты", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Ж/д билеты", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Отдых и путешествия", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Концерты, выставки, музеи", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Транспорт",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Легковые автомобили", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Грузовые автомобили", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Прицепы", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Велосипеды", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Мотоциклы, скутеры, снегоходы", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Запчасти", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Автоизделия", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Недвижимость",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Квартиры", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Комнаты", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Дома, дачи, коттеджи", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Земельные участки", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Гаражи", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Коммерческая недвижимость", CategoryType = CategoryType.Thing },
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Творчество",
                CategoryType = CategoryType.Thing,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Музыкальные инструменты", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Работы, поделки, произведения искусства", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Материалы, инструменты для творчества", CategoryType = CategoryType.Thing },
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Отдых",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Настольные игры", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Книги", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Спортивные товары", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Коллекционирование", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Для детей",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Игрушки", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Учебники и учебные пособия", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Электроника и электротовары",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Бытовая техника", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Компьютеры", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Фото и видео", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Принтеры, сканеры, плоттеры", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Связь", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Игры, софт, развлечения", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Для дома",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Посуда", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Мебель и интерьер", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Строительные материалы", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Живой мир",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Животные", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Растения", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Зоотовары", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Для растений", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Красота и здоровье",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Косметика", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Парфюмерия", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Оптика", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Товары для офиса",
                CategoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Канцтовары", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Бумага, бумажные изделия", CategoryType = CategoryType.Thing },
                    new CategoryItem {Title = "Оргтехника", CategoryType = CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Другое",
                CategoryType = CategoryType.Thing,
                IsCategory = true
            });
        }
        
        // категории услуг
        private void SeedCategoriesOfServices(QpqContext db)
        {
            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Ремонт",
                CategoryType = CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Сантехника", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Электроника", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Авто, мото, вело", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Строительный ремонт", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Косметический ремонт", CategoryType = CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Установка оборудования",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Обучение",
                CategoryType = CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Творчество", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Репетиторские услуги", CategoryType = CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Фотосъёмка/видеосъемка",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Транспортные услуги",
                CategoryType = CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Грузоперевозки", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Пассажирские перевозки", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Аренда и прокат", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Спецтехника", CategoryType = CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Уборка и помощь по хозяйству",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Консультация",
                CategoryType = CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Помощь в оформлении документов", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Услуги переводчиков", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Консультация юриста", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Бухгалтерское сопровождение", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Астрология, гадания", CategoryType = CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Организация мероприятий",
                CategoryType = CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Ведущий", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Оформление праздника", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Детские праздники", CategoryType = CategoryType.Service },
                    new CategoryItem {Title = "Бухгалтерское сопровождение", CategoryType = CategoryType.Service },
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Удалённая работа",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Искусство",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Сад, благоустройство",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Уход за животными",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Реклама",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Няньки, сиделки",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "IT-услуги",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Другое",
                CategoryType = CategoryType.Service,
                IsCategory = true
            });
        }

        protected override void Seed(QpqContext db)
        { 
            SeedAccounts(db);
            SeedOrderService(db);
            SeedOrderThing(db);
            SeedCategoriesOfThings(db);
            SeedCategoriesOfServices(db);

            base.Seed(db);
        }
    }
}