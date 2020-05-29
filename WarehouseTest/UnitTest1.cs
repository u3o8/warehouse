using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLibrary.Models;
using WarehouseLibrary.My_Exceptions;

namespace WarehouseTest
{
    // Тестируем методы, которые работают с пользователями
    //
    [TestClass]
    public class TestUser
    {
        // Тестируем методы, которые работают с пользователем.
        //
        [TestClass]
        public class TestCustomer
        {
            // Тестируем регистрацию.
            //
            [TestClass]
            public class TestRegistration
            {
                // Успешная регистрация.
                [TestMethod]
                public void TestNewCustomer()
                {
                    Warehouse warehouse = new Warehouse();
                    const int n = 7;
                    for (int i = 0; i < n; i++)
                        warehouse.RegistrationCustomer(new Customer()
                        {
                            Login = $"Customer{i}",
                            Password = "123456",
                            Adress = "naukova 53"
                        });
                    Assert.AreEqual("Customer6", warehouse.Customers[6].Login);
                    Assert.AreEqual("Customer2", warehouse.Customers[2].Login);
                    Assert.AreEqual("123456", warehouse.Customers[0].Password);
                }

                // Регистрация, если логин уже занят.
                [TestMethod]
                [ExpectedException(typeof(LoginException),
                    "Invalid login! This login already exists.")]
                public void TestExceptionExistingLogin()
                {
                    Warehouse warehouse = new Warehouse();
                    const int n = 7;
                    for (int i = 0; i < n; i++)
                        warehouse.RegistrationCustomer(new Customer()
                        {
                            Login = $"Login",
                            Password = "1321312323",
                            Adress = "pushkinskaya 22"
                        });
                }

                // Регистрация при введении логина администратора.
                [TestMethod]
                [ExpectedException(typeof(LoginException),
                   "Invalid login! This login already exists.")]
                public void TestExceptionAdminLogin()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = $"admin",
                        Password = "a8wk203jssd",
                        Adress = "pushkinskaya 22"
                    });
                }

                // Регистрация при длином пароле.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                   "Your password is too long")]
                public void TestExceptionLongPassword()
                {
                    Warehouse warehouse = new Warehouse();
                    string password = "";
                    for (int i = 0; i < 15; ++i)
                    {
                        password += "a";
                    }
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = $"weewx",
                        Password = password,
                        Adress = "pushkinskaya 22"
                    });
                }

                // Регистрация при коротком пароле.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                   "Your password is too short")]
                public void TestExceptionShortPassword()
                {
                    Warehouse warehouse = new Warehouse();
                    string password = "";
                    for (int i = 0; i < 5; ++i)
                    {
                        password += "a";
                    }
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = $"weewx",
                        Password = password,
                        Adress = "pushkinskaya 22"
                    });
                }

                // Регистрация при вводе недопустимых символов.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                  "You entered invalid characters")]
                public void TestExceptionInvalidCharactersPassword()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = $"weewx",
                        Password = "a8wk20&jssd",
                        Adress = "pushkinskaya 22"
                    });
                }

                // Регистрация при длином логине.
                [TestMethod]
                [ExpectedException(typeof(LoginException),
                 "Your login is too long")]
                public void TestExceptionLongLogin()
                {
                    Warehouse warehouse = new Warehouse();
                    string login = "";
                    for (int i = 0; i < 17; ++i)
                    {
                        login += "a";
                    }
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = login,
                        Password = "12345678",
                        Adress = "pushkinskaya 22"
                    });
                }

                // Регистрация при коротком пароле.
                [TestMethod]
                [ExpectedException(typeof(LoginException),
                 "Your login is too short")]
                public void TestExceptionShortLogin()
                {
                    Warehouse warehouse = new Warehouse();
                    string login = "";
                    for (int i = 0; i < 2; ++i)
                    {
                        login += "a";
                    }
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = login,
                        Password = "12345678",
                        Adress = "pushkinskaya 22"
                    });
                }

                // Регистрация при вводе недопустимых символов.
                [TestMethod]
                [ExpectedException(typeof(LoginException),
                 "You entered invalid characters")]
                public void TestExceptionInvalidCharactersLogin()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = "293*sa",
                        Password = "12345678",
                        Adress = "pushkinskaya 22"
                    });
                }

            }

            // Тестируем аутентификацию.
            //
            [TestMethod]
            public void TestAuthentication()
            {
                Warehouse warehouse = new Warehouse();
                const int n = 2;
                for (int i = 0; i < n; i++)
                {
                    warehouse.RegistrationCustomer(new Customer()
                    {
                        Login = $"Customer{i}",
                        Password = "123456",
                        Adress = "saltovskaya 33"
                    });
                }
                Assert.IsTrue(warehouse.AuthenticationCustomer(new Customer()
                {
                    Login = "Customer0",
                    Password = "123456"
                }));
                Assert.IsTrue(warehouse.AuthenticationCustomer(new Customer()
                {
                    Login = "Customer1",
                    Password = "123456"
                }));
                Assert.IsFalse(warehouse.AuthenticationCustomer(new Customer()
                {
                    Login = "Customer0",
                    Password = "123656"
                }));
                Assert.IsFalse(warehouse.AuthenticationCustomer(new Customer()
                {
                    Login = "Customer33",
                    Password = "123456"
                }));
            }


        }

        // Тестируем методы, которые работают с администратором.
        //
        [TestClass]
        public class TestAdmin
        {
            // Тестируем аутентификацию.
            [TestMethod]
            public void TestAuthentication()
            {
                Warehouse warehouse = new Warehouse();
                Assert.IsTrue(warehouse.AuthenticationAdmin(new Admin()
                {
                    Login = "admin",
                    Password = "admin"
                }));
                Assert.IsFalse(warehouse.AuthenticationAdmin(new Admin()
                {
                    Login = "Admin",
                    Password = "Admin"
                }));
            }

            // Тестируем изменение пароля.
            //
            [TestClass]
            public class TestChangePassword
            {
                // Успешная смена пароля.
                [TestMethod]
                public void TestChange()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.ChangePassword(warehouse.Admin.Password, "d8wdhw98");
                    Assert.AreEqual("d8wdhw98", warehouse.Admin.Password);
                }

                // Ввод одинаковых паролей.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                    "Passwords are the same.")]
                public void TestChangeTheSame()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.ChangePassword(warehouse.Admin.Password, warehouse.Admin.Password);
                }

                // Ввод неправильного текущего пароля.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                    "Current password is incorrect")]
                public void TestIncorrectCurrent()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.ChangePassword(warehouse.Admin.Password + "23231", warehouse.Admin.Password);
                }

                // Ввод короткого пароля.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                    "Your password is too short")]
                public void TestShortPassword()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.ChangePassword(warehouse.Admin.Password, "weq");
                }

                // Ввод длинного пароля.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                    "Your password is too long")]
                public void TestLongPassword()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.ChangePassword(warehouse.Admin.Password, "1111111111111111111111");
                }

                // Ввод недопустимых символов.
                [TestMethod]
                [ExpectedException(typeof(PasswordException),
                    "You entered invalid characters")]
                public void TestInvalidCharacters()
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.ChangePassword(warehouse.Admin.Password, "w2323**eq");
                }

            }

        }

    }


    // Тестируем поставку.
    //
    [TestClass]
    public class TestSupply
    {
        // Создание поставки.
        // Сохранение и загрузка файла также.
        [TestMethod]
        public void TestSupplyLoadSave()
        {
            const int n = 100;
            Warehouse warehouse = new Warehouse();

            // Cоздаю тестовые порции, т.к. поставка порция + дата.
            List<Portion> testPortions = new List<Portion>(); 
            for (int i = 0; i < n; i++)
            {
                // Cоздаю продукт, который является частью класса порция.
                Product newProduct = new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = i * 10,
                    Unit = "kg",
                    DateTime = DateTime.Now
                };

                // После этого создаю саму порцию.
                testPortions.Add(new Portion()
                {
                    Product = newProduct,
                    Amount = (i + 3) * 2
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));
            Assert.AreEqual("Product0", warehouse.Products[0].Name);
            Assert.AreEqual("Product99", warehouse.Products[99].Name);
            Assert.AreEqual("Product22", warehouse.Products[22].Name);
            Assert.AreEqual(8, warehouse.Products[8].Id);
            Assert.AreEqual("kg", warehouse.Products[84].Unit);
            Assert.AreEqual(80, warehouse.Products[8].Price);
            Assert.IsNotNull(warehouse.PurchaseInvoices);

            // Проверяем в файле.
            warehouse.Save(); 
            warehouse.Load();

            Assert.AreEqual(8, warehouse.Products[8].Id);
            Assert.AreEqual("kg", warehouse.Products[84].Unit);


        }

        // Создание поставки с одинаковыми продуктами.
        [TestMethod]
        public void TestSupplyTheSame() 
        {
            const int n = 100;
            Warehouse warehouse = new Warehouse();

            // Cоздаю тестовые порции, т.к. поставка порция + дата.
            List<Portion> testPortions = new List<Portion>(); 
            for (int i = 0; i < n; i++)
            {
                // Cоздаю продукт, который является частью класса порция.
                Product new_product = new Product()
                {
                    Id = 12345678,
                    Name = $"Product 34",
                    Price = 228,
                    Unit = "kg",
                    DateTime = DateTime.Now,
                };

                // После этого создаю саму порцию.
                testPortions.Add(new Portion()
                {
                    Product = new_product,
                    Amount = 5
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));
            Assert.AreEqual("Product 34", warehouse.Products[0].Name);
            Assert.AreEqual(500, warehouse.Products[0].Amount);
        }
    }

    // Добавление товара в корзину.
    //
    [TestClass]
    public class TestAddBasket
    { 
        [TestMethod]
        public void TestAdd()
        {
            // Продукция.
            const int n = 100;
            Warehouse warehouse = new Warehouse();

            // Cоздаю тестовые порции, т.к. поставка порция + дата.
            List<Portion> testPortions = new List<Portion>();
            for (int i = 0; i < n; i++)
            {
                // Cоздаю продукт, который является частью класса порция.
                Product newProduct = new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = i * 10,
                    Unit = "kg",
                    DateTime = DateTime.Now
                };

                // После этого создаю саму порцию.
                testPortions.Add(new Portion()
                {
                    Product = newProduct,
                    Amount = (i + 3) * 2
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));

            // Создаем пользователя. Заходим в аккаунт.
            warehouse.RegistrationCustomer(new Customer()
            {
                Login = $"Customer",
                Password = "123456",
                Adress = "saltovskaya 33"
            });
            warehouse.AuthenticationCustomer(new Customer()
            {
                Login = "Customer",
                Password = "123456"
            });

            Assert.AreEqual("Customer", ((Customer)warehouse.UserNow).Login);

            // Само тестирование.

            for (int i = 0; i < 4; ++i)
            {
                warehouse.AddBasket(warehouse.Products[i], (i * 1.1));
            }

            Assert.AreEqual(warehouse.Products[1], ((Customer)warehouse.UserNow).Basket[1].Product);
            Assert.AreEqual((3 * 1.1), ((Customer)warehouse.UserNow).Basket[3].Amount);
        }
    }

    // Тестирование методов, которые работают с заказами.
    //
    [TestClass]
    public class TestOrder
    {
        Warehouse warehouse = new Warehouse();
        //cоздание заказа
        [TestMethod]
        public void Order()
        {
            // Продукция.
            const int n = 100;
            Warehouse warehouse = new Warehouse();

            // Cоздаю тестовые порции, т.к. поставка порция + дата.
            List<Portion> testPortions = new List<Portion>();
            for (int i = 0; i < n; i++)
            {
                // Cоздаю продукт, который является частью класса порция.
                Product newProduct = new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = i * 10,
                    Unit = "kg",
                    DateTime = DateTime.Now
                };

                // После этого создаю саму порцию.
                testPortions.Add(new Portion()
                {
                    Product = newProduct,
                    Amount = (i + 10) * 2
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));

            // Создаем пользователя. Заходим в аккаунт.
            warehouse.RegistrationCustomer(new Customer()
            {
                Login = $"Customer",
                Password = "123456",
                Adress = "saltovskaya 33"
            });
            warehouse.AuthenticationCustomer(new Customer()
            {
                Login = "Customer",
                Password = "123456"
            });

            for (int i = 0; i < 10; ++i)
            {
                warehouse.AddBasket(warehouse.Products[i], 10);
            }

            // Само тестирование.

            warehouse.CreateNewOrder();

            // Пустая корзина.
            Assert.AreEqual(0, ((Customer)warehouse.UserNow).Basket.Count);

            // Счет стоимости заказа. GetTotal()
            Assert.AreEqual(4500, warehouse.Orders[0].TotalPrice);

            // Содержание заказа.
            Assert.AreEqual(warehouse.Products[3], warehouse.Orders[0].Portions[3].Product);

            // Проверяем метод СonfirmationOfOrder(Order targetOrder) и DeleteOrder(Order order), который он вызывает
            warehouse.СonfirmationOfOrder(warehouse.Orders[0]);
            Assert.AreEqual(0, warehouse.Orders.Count);
            Assert.AreNotEqual(0, warehouse.SalesInvoices);

        }
    }


}
