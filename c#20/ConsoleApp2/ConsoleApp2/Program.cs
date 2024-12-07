using System;
//задание 1
// public class Firma
// {
//     public string Name { get; set; }
//     public DateTime Founded { get; set; }
//     public string Profile { get; set; }
//     public string Director { get; set; }
//     public int Employee { get; set; }
//     public string Address { get; set; }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var firms = new List<Firma>
//         {
//             new Firma { Name = "FoodCorp", Founded = new DateTime(2000, 5, 1), Profile = "Marketing", Director = "Ivanov", Employee = 150, Address = "Odessa" },
//             new Firma { Name = "Kuna", Founded = new DateTime(2015, 8, 15), Profile = "IT", Director = "Petrov", Employee = 300, Address = "Kiev" },
//             new Firma { Name = "Fico", Founded = new DateTime(2017, 3, 10), Profile = "Marketing", Director = "White", Employee = 80, Address = "London" },
//             new Firma { Name = "ZHA", Founded = new DateTime(2024, 9, 11), Profile = "IT", Director = "Morozov", Employee = 20, Address = "New York" },
//             new Firma { Name = "AgroFood", Founded =new DateTime(2014, 5, 11) , Profile = "Agriculture", Director = "Smith", Employee = 70, Address = "Chicago" },
//             new Firma { Name = "GreenEnergy", Founded = new DateTime(1900, 5, 21), Profile = "Energy", Director = "Clark", Employee = 220, Address = "Paris" },
//             new Firma { Name = "DigitalMedia", Founded = new DateTime(2023, 11, 15), Profile = "Marketing", Director = "Adams", Employee = 180, Address = "San Francisco" },
//             new Firma { Name = "TravelEase", Founded = new DateTime(2019, 6, 30), Profile = "Tourism", Director = "White", Employee = 60, Address = "Barcelona" },
//             new Firma { Name = "AgroWorld", Founded = new DateTime(2018, 8, 25), Profile = "Agriculture", Director = "Wilson", Employee = 95, Address = "London" },
//             new Firma { Name = "EcoLogix", Founded = new DateTime(2021, 7, 20), Profile = "Environmental", Director = "Green", Employee = 110, Address = "Amsterdam" }
//         };
//         
//         Console.WriteLine("Все фирмы:");
//         foreach (var firm in firms)
//             Console.WriteLine($"{firm.Name}, {firm.Profile}, {firm.Director}, {firm.Employee} сотрудников, {firm.Address}");
//
//         Console.WriteLine("\nФирмы с Food в названии:");
//         var food = firms.Where(f => f.Name.Contains("Food"));
//         foreach (var firm in food)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы в области маркетинга:");
//         var marketing = firms.Where(f => f.Profile == "Marketing");
//         foreach (var firm in marketing)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы в области маркетинга или IT:");
//         var marketingorIT = firms.Where(f => f.Profile == "Marketing" || f.Profile == "IT");
//         foreach (var firm in marketingorIT)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы с количеством сотрудников > 100:");
//         var largefirms = firms.Where(f => f.Employee > 100);
//         foreach (var firm in largefirms)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы с количеством сотрудников от 100 до 300:");
//         var SizeFirms = firms.Where(f => f.Employee >= 100 && f.Employee <= 300);
//         foreach (var firm in SizeFirms)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы находящиеся в Лондоне:");
//         var london = firms.Where(f => f.Address == "London");
//         foreach (var firm in london)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы с директором по фамилии White:");
//         var white = firms.Where(f => f.Director.Contains("White"));
//         foreach (var firm in white)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы основанные больше двух лет назад:");
//         var oldFirms = firms.Where(f => (DateTime.Now - f.Founded).TotalDays > 730);
//         foreach (var firm in oldFirms)
//             Console.WriteLine(firm.Name);
//
//         Console.WriteLine("\nФирмы с даты основания которых прошло 123 дня:");
//         var oldFirms2 = firms.Where(f => (DateTime.Now - f.Founded).TotalDays > 123);
//         foreach (var firm in oldFirms2)
//             Console.WriteLine(firm.Name);
//     }
// }



//задание 2 
// public class Firma
// {
//     public string Name { get; set; }
//     public DateTime Founded { get; set; }
//     public string Profile { get; set; }
//     public string Director { get; set; }
//     public int Employee { get; set; }
//     public string Address { get; set; }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var firms = new List<Firma>
//         {
//             new Firma { Name = "FoodCorp", Founded = new DateTime(2000, 5, 1), Profile = "Marketing", Director = "Ivanov", Employee = 150, Address = "Odessa" },
//             new Firma { Name = "Kuna", Founded = new DateTime(2015, 8, 15), Profile = "IT", Director = "Petrov", Employee = 300, Address = "Kiev" },
//             new Firma { Name = "Fico", Founded = new DateTime(2017, 3, 10), Profile = "Marketing", Director = "White", Employee = 80, Address = "London" },
//             new Firma { Name = "ZHA", Founded = new DateTime(2024, 9, 11), Profile = "IT", Director = "Morozov", Employee = 20, Address = "New York" },
//             new Firma { Name = "AgroFood", Founded =new DateTime(2014, 5, 11) , Profile = "Agriculture", Director = "Smith", Employee = 70, Address = "Chicago" },
//             new Firma { Name = "GreenEnergy", Founded = new DateTime(1900, 5, 21), Profile = "Energy", Director = "Clark", Employee = 220, Address = "Paris" },
//             new Firma { Name = "DigitalMedia", Founded = new DateTime(2023, 11, 15), Profile = "Marketing", Director = "Adams", Employee = 180, Address = "San Francisco" },
//             new Firma { Name = "TravelEase", Founded = new DateTime(2019, 6, 30), Profile = "Tourism", Director = "White", Employee = 60, Address = "Barcelona" },
//             new Firma { Name = "AgroWorld", Founded = new DateTime(2018, 8, 25), Profile = "Agriculture", Director = "Wilson", Employee = 95, Address = "London" },
//             new Firma { Name = "EcoLogix", Founded = new DateTime(2021, 7, 20), Profile = "Environmental", Director = "Green", Employee = 110, Address = "Amsterdam" }
//         };
//         
//         Console.WriteLine("Все фирмы:");
//         foreach (var firm in firms)
//             Console.WriteLine($"{firm.Name}, {firm.Profile}, {firm.Director}, {firm.Employee} сотрудников, {firm.Address}");
//
//        Console.WriteLine("Фирмы с Food в названии:");
//         firms.Where(f => f.Name.Contains("Food"))
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы в области маркетинга:");
//         firms.Where(f => f.Profile == "Marketing")
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы в области маркетинга или IT:");
//         firms.Where(f => f.Profile == "Marketing" || f.Profile == "IT")
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы с количеством сотрудников > 100:");
//         firms.Where(f => f.Employee > 100)
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы с количеством сотрудников от 100 до 300:");
//         firms.Where(f => f.Employee >= 100 && f.Employee <= 300)
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы находящиеся в Лондоне:");
//         firms.Where(f => f.Address == "London")
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы с директором по фамилии White:");
//         firms.Where(f => f.Director.Contains("White"))
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы, основанные больше двух лет назад:");
//         firms.Where(f => (DateTime.Now - f.Founded).TotalDays > 730)
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//
//         Console.WriteLine("\nФирмы с даты основания которых прошло 123 дня:");
//         firms.Where(f => (DateTime.Now - f.Founded).TotalDays > 123)
//              .ToList()
//              .ForEach(f => Console.WriteLine(f.Name));
//     }
// }


//задание 3
// public class Employee
// {
//     public string FullName { get; set; }
//     public string Position { get; set; }
//     public string PhoneNumber { get; set; }
//     public string Email { get; set; }
//     public decimal Salary { get; set; }
// }
//
// public class Firma
// {
//     public string Name { get; set; }
//     public DateTime Founded { get; set; }
//     public string Profile { get; set; }
//     public string Director { get; set; }
//     public int EmployeeCount => Employees.Count;
//     public string Address { get; set; }
//     public List<Employee> Employees { get; set; } = new List<Employee>();
// }
//
// class Program
// {
//     static void Main()
//     {
//         var firms = new List<Firma>
//         {
//             new Firma
//             {
//                 Name = "FoodCorp",
//                 Founded = new DateTime(2000, 5, 1),
//                 Profile = "Marketing",
//                 Director = "Ivanov",
//                 Address = "Odessa",
//                 Employees = new List<Employee>
//                 {
//                     new Employee { FullName = "Lionel Petrovich", Position = "Manager", PhoneNumber = "2312345678", Email = "dilionel@gmail.com", Salary = 15000 },
//                     new Employee { FullName = "Tomas Clark ", Position = "Sales", PhoneNumber = "2387654321", Email = "clark221@gmail.com", Salary = 20000 }
//                 }
//             },
//             new Firma
//             {
//                 Name = "Kuna",
//                 Founded = new DateTime(2015, 8, 15),
//                 Profile = "IT",
//                 Director = "Petrov",
//                 Address = "Kiev",
//                 Employees = new List<Employee>
//                 {
//                     new Employee { FullName = "Egor Adams", Position = "Developer", PhoneNumber = "123456789", Email = "adam@gmail.com", Salary = 30000 },
//                     new Employee { FullName = "John Doe", Position = "Manager", PhoneNumber = "987654321`", Email = "jdoe@gmail.com", Salary = 25000 }
//                 }
//             }
//         };
//
//         Console.WriteLine("Сотрудники FoodCorp:");
//         var employeesOfFoodCorp = firms
//             .Where(f => f.Name == "FoodCorp")
//             .SelectMany(f => f.Employees)
//             .ToList();
//         employeesOfFoodCorp.ForEach(e => Console.WriteLine(e.FullName));
//
//         Console.WriteLine("\nСотрудники FoodCorp с зарплатой больше 10000:");
//         var highSalaryEmployees = firms
//             .Where(f => f.Name == "FoodCorp")
//             .SelectMany(f => f.Employees)
//             .Where(e => e.Salary > 10000)
//             .ToList();
//         highSalaryEmployees.ForEach(e => Console.WriteLine(e.FullName));
//
//         Console.WriteLine("\nСотрудники всех фирм с должностью Manager:");
//         var managers = firms
//             .SelectMany(f => f.Employees)
//             .Where(e => e.Position == "Manager")
//             .ToList();
//         managers.ForEach(e => Console.WriteLine(e.FullName));
//
//         Console.WriteLine("\nСотрудники с телефоном, начинающимся на 23:");
//         var phone23Employees = firms
//             .SelectMany(f => f.Employees)
//             .Where(e => e.PhoneNumber.StartsWith("23"))
//             .ToList();
//         phone23Employees.ForEach(e => Console.WriteLine(e.FullName));
//
//         Console.WriteLine("\nСотрудники с email, начинающимся на d':");
//         var emailDiEmployees = firms
//             .SelectMany(f => f.Employees)
//             .Where(e => e.Email.StartsWith("di", StringComparison.OrdinalIgnoreCase))
//             .ToList();
//         emailDiEmployees.ForEach(e => Console.WriteLine(e.FullName));
//
//         Console.WriteLine("\nСотрудники с именем Lionel:");
//         var lionels = firms
//             .SelectMany(f => f.Employees)
//             .Where(e => e.FullName.Contains("Lionel"))
//             .ToList();
//         lionels.ForEach(e => Console.WriteLine(e.FullName));
//     }
// }





