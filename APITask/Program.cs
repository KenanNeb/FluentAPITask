namespace APITask;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppContext())
        {
            Groups groups1 = new Groups() { Name = "FBAS2214", Rating = 5, Year = 2 };
            Groups groups2 = new Groups() { Name = "FBAT1215", Rating = 5, Year = 2 };
            Departments departments = new Departments() { Name = "Dep1", Financing = 19800 };
            Faculties faculties1 = new Faculties() { Name = "Fac1" };
            Faculties faculties2 = new Faculties() { Name = "Fac2" };

            Teachers teachers1 = new Teachers()
            {
                Name = "Ferhaq",
                Surname = "Qehramanli",
                EmploymentDate = new DateTime(2014, 03, 08),
                Premium = 350,
                Salary = 940
            };

            Teachers teachers2 = new Teachers()
            {
                Name = "Rami",
                Surname = "Ceferov",
                EmploymentDate = new DateTime(2012, 01, 01),
                Premium = 650,
                Salary = 1240
            };

            db.Add(groups1);
            db.Add(groups2);
            db.Add(departments);
            db.Add(faculties1);
            db.Add(faculties2);
            db.Add(teachers1);
            db.Add(teachers2);
            db.SaveChanges();
        }
    }
}