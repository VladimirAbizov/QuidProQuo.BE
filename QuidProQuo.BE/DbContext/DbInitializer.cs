using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;

namespace QuidProQuo.BE.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<QpqContext>
    {
        // аккаунты
        private static void SeedAccounts(QpqContext db)
        {
            db.Accounts.Add(new Account
            {
                ID = 1,
                Login = "admin",
                Password = "123",                                                          
                Profile = new Profile
                {
                    Address = "Samara",
                    Email = "oao@cat.ru",
                    PhoneNumber = "89870010000",
                    Orders = new List<OrderBase>
                    {
                        new ServiceOrder
                        {
                            DateTime = "05.08.2000",
                            ObjectBase = new Service
                            {
                                Title = "any service",
                                Description = "anything service"
                            }
                        },
                        new ThingOrder
                        {
                            DateTime = "01.01.1111",
                            ObjectBase = new Thing
                            {
                                Title = "any thing",
                                Description = "anything thing"
                            }
                        }
                    }
                }
            });
        }
        
        // категории вещей
        private static void SeedCategoriesOfThings(QpqContext db)
        {
            db.CategoryItems.Add(new CategoryItem
            {
                ID = 1,
                Title = "Продукты",
                categoryType = CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Молочные продукты", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Мясо, птица, яйца", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Рыба, морепродукты", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Овощи", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Фрукты, ягоды", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Грибы", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Бакалея", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Продукты пчеловодства", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Консервированная продукция", categoryType= CategoryType.Thing },
                }
            });
            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Одежда, обувь, аксессуары",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem
                    {
                        Title = "Женский гардероб ",
                        categoryType= CategoryType.Thing
                    },
                    new CategoryItem
                    {
                        Title = "Мужской гардероб",
                        categoryType= CategoryType.Thing 
                    },
                    new CategoryItem {Title = "Детский гардероб", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Спецодежда", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Охота, рыбалка, походы",
                categoryType= CategoryType.Thing,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Билеты",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Авиабилеты", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Ж/д билеты", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Отдых и путешествия", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Концерты, выставки, музеи", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Транспорт",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Легковые автомобили", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Грузовые автомобили", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Прицепы", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Велосипеды", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Мотоциклы, скутеры, снегоходы", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Запчасти", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Автоизделия", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Недвижимость",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Квартиры", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Комнаты", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Дома, дачи, коттеджи", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Земельные участки", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Гаражи", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Коммерческая недвижимость", categoryType= CategoryType.Thing },
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Творчество",
                categoryType= CategoryType.Thing,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Музыкальные инструменты", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Работы, поделки, произведения искусства", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Материалы, инструменты для творчества", categoryType= CategoryType.Thing },
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Отдых",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Настольные игры", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Книги", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Спортивные товары", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Коллекционирование", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Для детей",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Игрушки", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Учебники и учебные пособия", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Электроника и электротовары",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Бытовая техника", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Компьютеры", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Фото и видео", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Принтеры, сканеры, плоттеры", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Связь", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Игры, софт, развлечения", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Для дома",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Посуда", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Мебель и интерьер", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Строительные материалы", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Живой мир",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Животные", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Растения", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Зоотовары", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Для растений", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Красота и здоровье",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Косметика", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Парфюмерия", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Оптика", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Товары для офиса",
                categoryType= CategoryType.Thing,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Канцтовары", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Бумага, бумажные изделия", categoryType= CategoryType.Thing },
                    new CategoryItem {Title = "Оргтехника", categoryType= CategoryType.Thing }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Другое",
                categoryType= CategoryType.Thing,
                IsCategory = true
            });
        }
        
        // категории услуг
        private static void SeedCategoriesOfServices(QpqContext db)
        {
            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Ремонт",
                categoryType= CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Сантехника", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Электроника", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Авто, мото, вело", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Строительный ремонт", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Косметический ремонт", categoryType= CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Установка оборудования",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Обучение",
                categoryType= CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Творчество", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Репетиторские услуги", categoryType= CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Фотосъёмка/видеосъемка",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Транспортные услуги",
                categoryType= CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Грузоперевозки", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Пассажирские перевозки", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Аренда и прокат", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Спецтехника", categoryType= CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Уборка и помощь по хозяйству",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Консультация",
                categoryType= CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Помощь в оформлении документов", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Услуги переводчиков", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Консультация юриста", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Бухгалтерское сопровождение", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Астрология, гадания", categoryType= CategoryType.Service }
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Организация мероприятий",
                categoryType= CategoryType.Service,
                IsCategory = true,
                Subcategories = new List<CategoryItem>
                {
                    new CategoryItem {Title = "Ведущий", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Оформление праздника", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Детские праздники", categoryType= CategoryType.Service },
                    new CategoryItem {Title = "Бухгалтерское сопровождение", categoryType= CategoryType.Service },
                }
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Удалённая работа",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Искусство",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Сад, благоустройство",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Уход за животными",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Реклама",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Няньки, сиделки",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "IT-услуги",
                categoryType= CategoryType.Service,
                IsCategory = true
            });

            db.CategoryItems.Add(new CategoryItem
            {
                Title = "Другое",
                categoryType= CategoryType.Service,
                IsCategory = true
            });
        }

        // объявление (услуга)
        private static void SeedOrderService(QpqContext db)
        {     
        }

        // объявление (вещь)
        private static void SeedOrderThing(QpqContext db)
        {
        }
        protected override void Seed(QpqContext db)
        { 
            SeedAccounts(db);
            //SeedOrderService(db);
            //SeedOrderThing(db);
            SeedCategoriesOfThings(db);
            SeedCategoriesOfServices(db);

            base.Seed(db);
        }
    }
}