using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinQ 2 Cach
            //Console.WriteLine("Hello World!");
            //int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //// Print only items less than 10.
            //IEnumerable<int> subset = from i in numbers
            //                          where i < 10
            //                          select i;
            //foreach (int i in subset)
            //    Console.WriteLine("Item: {0}", i);

            //Console.WriteLine("-------Danh sach sinh vien thi dau---------");
            //List<SinhVien> Lst = new List<SinhVien>();
            //SinhVien sv1 = new SinhVien();
            //sv1.HoTen = "Thuan";
            //sv1.Diem = 10;
            //Lst.Add(sv1);

            //SinhVien sv2 = new SinhVien();
            //sv2.HoTen = "Tram 1";
            //sv2.Diem = 1;
            //Lst.Add(sv2);

            //SinhVien sv3 = new SinhVien();
            //sv3.HoTen = "Tien";
            //sv3.Diem = 2;
            //Lst.Add(sv3);

            //SinhVien sv4 = new SinhVien();
            //sv4.HoTen = "Hau";
            //sv4.Diem = 3;
            //Lst.Add(sv4);

            //SinhVien sv5 = new SinhVien();
            //sv5.HoTen = "Bong";
            //sv5.Diem = (decimal)9.5;
            //Lst.Add(sv5);

            //SinhVien sv6 = new SinhVien();
            //sv6.HoTen = "Tram 2";
            //sv6.Diem = 1;
            //Lst.Add(sv6);

            //SinhVien sv7 = new SinhVien();
            //sv7.HoTen = "Nha";
            //sv7.Diem = null;
            //Lst.Add(sv7);

            //// LinQ cách 1
            ////var subSV = from sv in Lst
            ////            where sv.Diem.HasValue && sv.Diem.Value > 5
            ////            select sv;

            //// LinQ cách 2 - dung biểu thức Lamda
            //var subSV = Lst.Where(sv => sv.Diem.HasValue && sv.Diem.Value > 5).ToList();


            //foreach (var i in subSV)
            //    Console.WriteLine("Sinh vien [{0}] - Diem {1}", i.HoTen, (i.Diem.HasValue ? i.Diem.Value.ToString() : ""));

            //string[] fruits = { "Chuoi", "Thanh Long", "Sau rieng", "Cam", "Dua hau" };

            //IEnumerable<string> subset = from g in fruits
            //                             where g.Contains(" ")  // Lấy KHoảng trắng trong Name. Trong SQL Where name like "% %"
            //                             orderby g
            //                             select g;

            //foreach (string s in subset)
            //    Console.WriteLine("Item: {0}", s);

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //IEnumerable<int> query = nums.Where(n => n % 2 == 0);

            //foreach (var n in query)
            //{
            //    Console.WriteLine("{0}", n);
            //}
            #endregion
                        Categories[] categories = new[]
            {
                new Categories {CategoryId = 1, CategoryName = "Nuoc ngot" },
                new Categories {CategoryId = 2, CategoryName = "Van phong pham" },
                new Categories {CategoryId = 3, CategoryName = "Thuc pham" }
            };

                        Products[] products = new[]
                        {
                new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
                new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
                new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
};
            //Console.WriteLine("\n LinQ cach 1: ");
            //SelectEverything(products);
            //Console.WriteLine("\n LinQ cach 2: ");
            //SelectEverything2(products);

            //Console.WriteLine("\n LinQ Category cach 2: ");
            //SelectEverythingCategory(categories);

            //Console.WriteLine("\n LinQ Get Name And Description cach 1: ");
            //GetNamesAndDescriptions(products);

            //Console.WriteLine("\n LinQ Get Name And Description cach 2: ");
            //GetNamesAndDescriptions2(products);

            //Console.WriteLine("\n LinQ OverStock cach 1: ");
            //GetOverstock(products);

            //Console.WriteLine("\n LinQ OverStock cach 2: ");
            //GetOverstock2(products);

            //OfTypeAsFilter();

            // Cach 1
            //PetOwner[] petList = GetPetList();

            //var query = from O in petList   // O la nguoi nuoi thi co 1 ds cac con vat
            //            from p in O.Pets    // p la moi Pet trong cac con vat cua nguoi nuoi do
            //            select p;           // Lay ra ten con Pet

            //foreach (var p in query)
            //{
            //    Console.WriteLine(p);
            //}

            //// Cach 2
            //PetOwner[] petOwnerList = GetPetList();

            //IEnumerable<string> query1 = petOwnerList.SelectMany(petOwner => petOwner.Pets);

            //Console.WriteLine("Using SelectMany():");

            //foreach (string pet in query1)
            //{
            //    Console.WriteLine(pet);
            //}

            //AlphabetizeProductNames(products);


            //// Lenh Group by 
            //var query = from p in products
            //            group p by p.CategoryId;  // ==> Cho ra loại Products

            //foreach (var category in query)
            //{
            //    Console.WriteLine("CategoryId: {0}", category.Key);
            //    foreach (Products item in category)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            ///// Lenh Group By Into Cach 1
            //var query = from p in products
            //            group p by p.CategoryId into g
            //            select new
            //            {
            //                Catgory = g.Key,
            //                Prods = g
            //            };

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Catgory);
            //    foreach (Products p in item.Prods)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}

            ////// Cau Lenh Group By Into Cach 2
            //var query1 = products.GroupBy(p => p.CategoryId, p => p);


            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (Products pa in item)
            //    {
            //        Console.WriteLine(pa);
            //    }
            //}


            //GetProductsByCategories(categories, products);

            // 
            // ReverseEverything(products);
        }
        static void SelectEverything(Products[] products)
        {
            var allProducts = from p in products
                              select p;

            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void SelectEverything2(Products[] products)
        {
            var allProducts = products.Select(n => n);

            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        // Category
        static void SelectEverythingCategory (Categories[] categories)
        {
            var allCategories = categories.Select(n => n);
            foreach (var cart in allCategories)
            {
                Console.WriteLine(cart.ToString());
            }
        }

        // Kieu 1
        static void GetNamesAndDescriptions(Products[] products)
        {
            var nameDesc = from p in products
                           select new
                           {
                               p.ProductId,
                               p.ProductName
                           };

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        // Kieu 2
        static void GetNamesAndDescriptions2(Products[] products)
        {
            var nameDesc =
            products.Select(p => new { p.ProductId, p.ProductName });

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void GetOverstock(Products[] products)
        {
            Console.WriteLine("The overstock items!");

            var overstock = from p in products
                            where p.NumberInStock > 25
                            select p;

            foreach (Products c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }


        static void GetOverstock2(Products[] products)
        {
            Console.WriteLine("The overstock items!");

            var overstock = products.Where(p => p.NumberInStock > 25);

            foreach (Products c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }

        static void OfTypeAsFilter()
        {
            // Extract the ints from the ArrayList.
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10,"Dai Hoc Mo","Thuan Lovely", 400, 8, false, new Car(),"TK73", "string data" });

            var myString = myStuff.OfType<string>();        // Lay kieu gi truyen vao kieu do. vd kieu int hay string

            // Prints out 10, 400, and 8.
            foreach (string i in myString)
            {
                Console.WriteLine("String value: {0}", i);
            }
        }

        static PetOwner[] GetPetList()
        {
            PetOwner[] petOwners =
                { new PetOwner { Name="Bảo",
              Pets = new List<string>{ "Chó", "Mèo" } },
          new PetOwner { Name="Thảo",
              Pets = new List<string>{ "Két", "Cá sấu" } },
          new PetOwner { Name="Tâm",
              Pets = new List<string>{ "Chuột", "Chó" } } };
            return petOwners;
        }


        static void AlphabetizeProductNames(Products[] products)
        {
            var subset = from p in products
                         orderby p.ProductName descending       // Sap xep theo thu tu Z --> A
                    select p;

            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }


            //Cau lenh SQL Server
            //Select *
            //from Products
            //Order BY ProductName DESC
        }

        static void AlphabetizeProductNames2(Products[] products)    // Sap xep theo 2 cot thi . Then By
        {
            var subset = products.OrderBy(p => p.ProductName)
                .ThenBy(p => p.ProductId);
            //var subset = products.OrderByDescending(p => p.ProductName);

            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }


        static void GetProductsByCategories(Categories[] categories, Products[] products)       // Ket 2 bang bang tu khoa Join
        {
            var query = from c in categories
                        join p in products
                        on c.CategoryId equals p.CategoryId     // Ket bang lenh equals
                        select new
                        {
                            p.ProductId,
                            p.ProductName,
                            c.CategoryId,
                            c.CategoryName
                        };

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        static void ReverseEverything(Products[] products)       // Reverse là dao ngc
        {
            var allProducts = from p in products
                              select p;

            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }


        static void DisplayConcatNoDups()       // Lenh Distinct la khong trung
        {
            List<string> myCars =
                new List<String> { "Ford", "Honda", "Toyota" };
            List<string> yourCars =
                new List<String> { "BMW", "Toyota", "Hyundai" };

            var carConcat = (from c in myCars select c).
                Concat(from c2 in yourCars select c2);      // Noi bang MyCar vs YourCar

            foreach (string s in carConcat.Distinct())
                Console.WriteLine(s);
        }

        static void DisplayUnion()          // Lenh Union La hop 2 bang
        {
            List<string> myCars =
                new List<String> { "Ford", "Honda", "Toyota" };
            List<string> yourCars =
                new List<String> { "BMW", "Toyota", "Hyundai" };

            var carUnion = (from c in myCars select c).
                Union(from c2 in yourCars select c2);

            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
                Console.WriteLine(s);
        }


        static void DisplayIntersection()       // Lenh Intersection la giao 2 bang
        {
            List<string> myCars =
                new List<String> { "Ford", "Honda", "Toyota" };
            List<string> yourCars =
                new List<String> { "BMW", "Toyota", "Hyundai" };

            var carIntersect = (from c in myCars select c).
                Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common: ");
            foreach (string s in carIntersect)
                Console.WriteLine(s); // Printa Toyota.
        }

        static void DisplayDiff()       // Lenh Except la cai khac nhau, tuc la co ben nay ma khong co ben kia
        {
            List<string> myCars =
                new List<String> { "Ford", "Honda", "Toyota" };
            List<string> yourCars =
                new List<String> { "BMW", "Toyota", "Hyundai" };

            var carDiff = (from c in myCars select c).
                Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you don’t have, but I do:");
            foreach (string s in carDiff)
                Console.WriteLine(s);
        }

        static void TakeOperator()              // Take la lay 3 ==> Tra ve 1, 2, 3
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = (from n in nums
                         select n).Take(3);

            foreach (int num in query)
            {
                Console.WriteLine(num);
            }
        }

        static void TakeOperator2()     // Skip: bỏ qua n phần tử đầu tiên trong dãy, lấy từ phần tử thứ (n + 1) 

        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };   // => KQ: 8, 9
            var query = (from n in nums
                         select n).Skip(7).Take(3); // Bo qua 7 so dau

            foreach (int num in query)
            {
                Console.WriteLine(num);
            }
        }

        static void TakeWhileOperator()     // Theo mot dieu kien nao do
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = (from n in nums
                         select n).TakeWhile(n => n % 5 != 0);

            foreach (int num in query)
            {
                Console.WriteLine(num);
            }
        }

        static void DisplayConcat()         // 
        {
            List<string> myCars =
                new List<String> { "Ford", "Honda", "Toyota" };
            List<string> yourCars =
                new List<String> { "BMW", "Toyota", "Hyundai" };

            var carConcat = (from c in myCars select c).
                Concat(from c2 in yourCars select c2);

            foreach (string s in carConcat)
                Console.WriteLine(s);
        }

        static void AggregateOps()      // Lenh Max, Min, Trung Binh, Sum, vvv
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

            Console.WriteLine("Max temp: {0}",
                (from t in winterTemps select t).Max());

            Console.WriteLine("Min temp: {0}",
                (from t in winterTemps select t).Min());

            Console.WriteLine("Average temp: {0}",
                (from t in winterTemps select t).Average());

            Console.WriteLine("Sum of all temps: {0}",
                (from t in winterTemps select t).Sum());

            Console.WriteLine("Count all temps: {0}", 
            (from t in winterTemps select t).Count());
        }

   

    }
}
