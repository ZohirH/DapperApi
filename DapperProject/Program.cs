
using System.Runtime.InteropServices;
using Domain;
using Service;




while (true)
{

    Console.WriteLine("departmentService=>deparment");
    Console.WriteLine("employeeService=>employee");
    Console.WriteLine("manager=>manager");
    Console.WriteLine("stop=>stop");

    Console.Write("Vedite text:");
    string text = Console.ReadLine();

    if(text == "stop")
    {
        break;
    }


    if (text == "department")
    {
        DepartmentService departmentService = new DepartmentService();
        text = Console.ReadLine();
        if(text == "GET")
        {
        var res = departmentService.GetDepartment();
        foreach (var item in res)
        {
            Console.WriteLine("\n");
            Console.WriteLine(item.Id + "," + item.Name + ", " + item.FirsName + ", " + item.LastName + " ," + item.Gender);
        }
        Console.WriteLine("----------------------------------");
        }
        else if (text == "insert")
        {
            Department department = new Department();

            department.Name = Console.ReadLine();


            var insert1 = departmentService.Insert(department);

            if (insert1 != null) Console.WriteLine("1 records!!!!!!!");
            else Console.WriteLine(" 0 records?????");
            Console.WriteLine("------------------------------------------");
        }else if (text == "update")
        {
            Department department1 = new Department();
            department1.Name = Console.ReadLine();

            int Id = int.Parse(Console.ReadLine());
            var update = departmentService.Update(department1, Id);

            if (update != null) Console.WriteLine("1 records in Updates!!!!!!!");
            else Console.WriteLine(" 0 records Updates?????");
            Console.WriteLine("-------------------------------------");
        }
    }





    if (text == "employee")
    {


        EmployeeService employeeService = new EmployeeService();
        var list = employeeService.GetEmployee();
        foreach (var item in list)
        {
            Console.WriteLine("\n");
            Console.WriteLine(item.FirsName + ", " + item.LastName + " ," + item.Gender + "," + item.BirthDate + ", " + item.HireDate + "," + item.Name);
        }
        Console.WriteLine("----------------------------------");


        Employee employee = new Employee();
        employee.BirthDate = DateTime.Parse(Console.ReadLine());
        employee.FirsName = Console.ReadLine();
        employee.LastName = Console.ReadLine();
        employee.Gender = Console.ReadLine();

        employee.HireDate = DateTime.Parse(Console.ReadLine());


        var insert11 = employeeService.Insert(employee);
        if (insert11 != null) Console.WriteLine(" 1 records in database!!!!!!!");
        else
            Console.WriteLine(" not records in database???????");

        Console.WriteLine("-----------------------------------------");
        Employee employee1 = new Employee();
        employee1.BirthDate = DateTime.Parse(Console.ReadLine());
        employee1.FirsName = Console.ReadLine();
        employee1.LastName = Console.ReadLine();
        employee1.Gender = Console.ReadLine();

        employee1.HireDate = DateTime.Parse(Console.ReadLine());

        int Id = int.Parse(Console.ReadLine());

        var update11 = employeeService.Update(employee1, Id);
        if (update11 != null) Console.WriteLine(" 1 records Updates  in database!!!!!!!");
        else
            Console.WriteLine(" not records in database???????");
     }










    if (text == "manager")
    {


        ManagerService managerService = new ManagerService();
        var lists = managerService.GetDepartmentManager();
        foreach (var item1 in lists)
        {
            Console.WriteLine(item1.FirsName + ", " + item1.LastName + ", " + item1.Gender + ", " + item1.Name);

        }


        DepartmentManager manager = new DepartmentManager();
        manager.EmployeeId = int.Parse(Console.ReadLine());

        manager.DepartmentId = int.Parse(Console.ReadLine());
        manager.FromDate = DateTime.Parse(Console.ReadLine());
        manager.ToDate = DateTime.Parse(Console.ReadLine());
        var managerlist = managerService.ManagerInsert(manager);
        if (managerlist != null) Console.WriteLine(" i records in database");
        else Console.WriteLine(" not records ");
        Console.WriteLine("-------------------------------");

        
    }

}

Console.ReadLine();