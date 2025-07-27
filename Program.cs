using System;
using EF_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mainMenu =
            {
                "||═══════════════════════════════════════════════════════||",
                "||                MENU - CHOOSE OPTION :                 ||",
                "||═══════════════════════════════════════════════════════||",
                "|| [1-]  =>  ADD                                         ||",
                "|| [2-]  =>  ASSIGN                                      ||",
                "|| [3-]  =>  EDIT                                        ||",
                "|| [4-]  =>  DISPLAY                                     ||",
                "|| [5-]  =>  DELETE                                      ||",
                "|| [6-]  =>  EXIT                                        ||",
                "||═══════════════════════════════════════════════════════||",
            };

            int menuOpt = 1;
            bool menuLoop = true;

            do
            {
                Console.Clear();
                for (int i = 0; i < mainMenu.Length; i++)
                {
                    if (i == menuOpt + 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainMenu[i]);
                        Console.SetCursorPosition(59, menuOpt + 2);
                        Console.WriteLine(" <<");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(mainMenu[i]);
                    }

                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        menuOpt--;
                        if (menuOpt == 0) menuOpt = 6;
                        break;
                    case ConsoleKey.DownArrow:
                        menuOpt++;
                        if (menuOpt == 7) menuOpt = 1;
                        break;
                    case ConsoleKey.Enter:
                        switch (menuOpt)
                        {
                            case 1:
                                addMenu();
                                break;
                            case 2:
                                assignMenu();
                                break;
                            case 3:
                                editMenu();
                                break;
                            case 4:
                                displayMenu();
                                break;
                            case 5:
                                deleteMenu();
                                break;
                            case 6:
                                menuLoop = false;
                                break;
                            default: break;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (menuLoop);
        }

        public static void addMenu()
        {
            string[] AddMenu =
            {
                "||═══════════════════════════════════════════════════════||",
                "||                  MENU - ADD OPTION :                  ||",
                "||═══════════════════════════════════════════════════════||",
                "|| [1-]  =>  ADD EMPLOYEE                                ||",
                "|| [2-]  =>  ADD DEPARTMENT                              ||",
                "|| [3-]  =>  ADD PROJECT                                 ||",
                "|| {4-}  =>  EXIT                                        ||",
                "||═══════════════════════════════════════════════════════||",
            };
            int addOpt = 1;
            bool addLoop = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < AddMenu.Length; i++)
                {
                    if (i == addOpt + 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(AddMenu[i]);
                        Console.SetCursorPosition(59, addOpt + 2);
                        Console.WriteLine(" <<");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(AddMenu[i]);
                    }

                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        addOpt--;
                        if (addOpt == 0) addOpt = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        addOpt++;
                        if (addOpt == 5) addOpt = 1;
                        break;
                    case ConsoleKey.Enter:
                        switch (addOpt)
                        {
                            case 1:
                                AddEmployee();
                                break;
                            case 2:
                                AddDepartment();
                                break;
                            case 3:
                                AddProject();
                                break;
                            case 4:
                                addLoop = false;
                                break;
                            default: break;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (addLoop);
        }

        public static void assignMenu()
        {
            string[] AssignMenu =
            {
                "||═══════════════════════════════════════════════════════||",
                "||                 MENU - ASSIGN OPTION :                ||",
                "||═══════════════════════════════════════════════════════||",
                "|| [1-]  =>  ASSIGN EMPLOYEE TO DEPARTMENT               ||",
                "|| [2-]  =>  ASSIGN EMPLOYEE TO PROJECT                  ||",
                "|| [3-]  =>  REMOVE EMPLOYEE FROM PROJECT                ||",
                "|| {4-}  =>  EXIT                                        ||",
                "||═══════════════════════════════════════════════════════||",
            };
            int assignOpt = 1;
            bool assignLoop = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < AssignMenu.Length; i++)
                {
                    if (i == assignOpt + 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(AssignMenu[i]);
                        Console.SetCursorPosition(59, assignOpt + 2);
                        Console.WriteLine(" <<");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(AssignMenu[i]);
                    }

                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        assignOpt--;
                        if (assignOpt == 0) assignOpt = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        assignOpt++;
                        if (assignOpt == 5) assignOpt = 1;
                        break;
                    case ConsoleKey.Enter:
                        switch (assignOpt)
                        {
                            case 1:
                                AssignEmployeeToDepartment();
                                break;
                            case 2:
                                AssignEmployeeToProject();
                                break;
                            case 3:
                                RemoveEmployeeFromProject();
                                break;
                            case 4:
                                assignLoop = false;
                                break;
                            default: break;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (assignLoop);
        }

        public static void displayMenu()
        {
            string[] DisplayMenu =
            {
        "||═══════════════════════════════════════════════════════||",
        "||                  MENU - ADD OPTION :                  ||",
        "||═══════════════════════════════════════════════════════||",
        "|| [1-]  =>  DISPLAY EMPLOYEE                            ||",
        "|| [2-]  =>  DISPLAY DEPARTMENT                          ||",
        "|| [3-]  =>  DISPLAY PROJECT                             ||",
        "|| {4-}  =>  EXIT                                        ||",
        "||═══════════════════════════════════════════════════════||",
    };
            int displayOpt = 1;
            bool DisplayLoop = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < DisplayMenu.Length; i++)
                {
                    if (i == displayOpt + 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(DisplayMenu[i]);
                        Console.SetCursorPosition(59, displayOpt + 2);
                        Console.WriteLine(" <<");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(DisplayMenu[i]);
                    }

                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        displayOpt--;
                        if (displayOpt == 0) displayOpt = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        displayOpt++;
                        if (displayOpt == 5) displayOpt = 1;
                        break;
                    case ConsoleKey.Enter:
                        switch (displayOpt)
                        {
                            case 1:
                                DisplayEmployees();
                                break;
                            case 2:
                                DisplayDepartments();
                                break;
                            case 3:
                                DisplayProjects();
                                break;
                            case 4:
                                DisplayLoop = false;
                                break;
                            default: break;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (DisplayLoop);
        }

        public static void deleteMenu()
        {
            string[] DeleteMenu =
            {
        "||═══════════════════════════════════════════════════════||",
        "||                  MENU - ADD OPTION :                  ||",
        "||═══════════════════════════════════════════════════════||",
        "|| [1-]  =>  DELETE EMPLOYEE                             ||",
        "|| [2-]  =>  DELETE DEPARTMENT                           ||",        
        "|| [3-]  =>  DELETE PROJECT                              ||",        
        "|| {4-}  =>  EXIT                                        ||",
        "||═══════════════════════════════════════════════════════||",
    };
            int delOpt = 1;
            bool delLoop = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < DeleteMenu.Length; i++)
                {
                    if (i == delOpt + 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(DeleteMenu[i]);
                        Console.SetCursorPosition(59, delOpt + 2);
                        Console.WriteLine(" <<");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(DeleteMenu[i]);
                    }

                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        delOpt--;
                        if (delOpt == 0) delOpt = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        delOpt++;
                        if (delOpt == 5) delOpt = 1;
                        break;
                    case ConsoleKey.Enter:
                        switch (delOpt)
                        {
                            case 1:
                                DeleteEmployee();
                                break;
                            case 2:
                                DeleteDepartment();
                                break;
                            case 3:
                                DeleteProject();
                                break;
                            case 4:
                                delLoop = false;
                                break;
                            default: break;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (delLoop);
        }
  
        public static void editMenu()
        {
            string[] EditMenu =
            {
                "||═══════════════════════════════════════════════════════||",
                "||                MENU - CHOOSE OPTION :                 ||",
                "||═══════════════════════════════════════════════════════||",
                "|| [1-]  =>  EDIT EMPLOYEE                               ||",
                "|| [2-]  =>  EDIT DEPARTMENT                             ||",
                "|| [3-]  =>  EDIT PROJECT                                ||",
                "|| [4-]  =>  EXIT                                        ||",
                "||═══════════════════════════════════════════════════════||",
            };
            int editOpt = 1;
            bool editLoop = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < EditMenu.Length; i++)
                {
                    if (i == editOpt + 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(EditMenu[i]);
                        Console.SetCursorPosition(59, editOpt + 2);
                        Console.WriteLine(" <<");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(EditMenu[i]);
                    }

                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        editOpt--;
                        if (editOpt == 0) editOpt = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        editOpt++;
                        if (editOpt == 5) editOpt = 1;
                        break;
                    case ConsoleKey.Enter:
                        switch (editOpt)
                        {
                            case 1:
                                EditEmployee();
                                break;
                            case 2:
                                EditDepartmentData();
                                break;
                            case 3:
                                EditProjectData();
                                break;
                            case 4:
                                editLoop = false;
                                break;
                            default: break;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (editLoop);
        }

        public static void AddEmployee()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                var employee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName
                };
                db.Employees.Add(employee);
                db.SaveChanges();
                Console.WriteLine("Employee added successfully!");
                Console.ReadKey();
            }
        }

        public static void AddDepartment()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Department Name: ");
                string name = Console.ReadLine();
                var dept = new Department { Name = name };
                db.Departments.Add(dept);
                db.SaveChanges();
                Console.WriteLine("Department added successfully!");
                Console.ReadKey();
            }
        }

        public static void AddProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Project Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Start Date (yyyy-mm-dd): ");
                DateTime start = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter End Date (yyyy-mm-dd): ");
                DateTime end = DateTime.Parse(Console.ReadLine());

                var project = new Project
                {
                    Name = name,
                    StartDate = start,
                    EndDate = end
                };

                db.Projects.Add(project);
                db.SaveChanges();

                Console.WriteLine("Project added successfully!");
            }
        }

        public static void AssignEmployeeToProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Project ID: ");
                int projectId = int.Parse(Console.ReadLine());
                Console.Write("Enter Role: ");
                string role = Console.ReadLine();

                var employee = db.Employees.FirstOrDefault(e => e.EmployeeId == empId);
                var project = db.Projects.FirstOrDefault(p => p.ProjectId == projectId);

                if (employee != null && project != null)
                {

                    var empProject = new EmployeeProject
                    {
                        EmployeeId = empId,
                        ProjectId = projectId,
                        Role = role
                    };

                    db.EmployeeProjects.Add(empProject);
                    db.SaveChanges();

                    Console.WriteLine("Employee assigned to project successfully.");
                }
                else
                {
                    Console.WriteLine("Employee or Project not found.");
                }
                Console.ReadKey();
            }
        }

        public static void AssignEmployeeToDepartment()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Department ID to assign: ");
                int deptId = int.Parse(Console.ReadLine());

                var employee = db.Employees.Find(empId);
                var department = db.Departments.Find(deptId);

                if (employee == null)
                {
                    Console.WriteLine("Employee not found.");
                    return;
                }

                if (department == null)
                {
                    Console.WriteLine("Department not found.");
                    return;
                }

                employee.DepartmentId = deptId;
                db.SaveChanges();

                Console.WriteLine("Employee assigned to department successfully!");
                Console.ReadKey();
            }
        }

        public static void RemoveEmployeeFromProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Project ID: ");
                int projId = int.Parse(Console.ReadLine());

                var emp = db.EmployeeProjects
                    .FirstOrDefault(ep => ep.EmployeeId == empId && ep.ProjectId == projId);

                if (emp != null)
                {
                    db.EmployeeProjects.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee removed from project.");
                }
                else
                {
                    Console.WriteLine("This employee is not assigned to the specified project.");
                }
                Console.ReadKey();
            }
        }

        public static void DisplayDepartments()
        {
            using (var db = new CompanyDbContext())
            {
                var departments = db.Departments
                                    .Include(d => d.Employees)
                                    .ToList();

                foreach (var dept in departments)
                {
                    Console.WriteLine($"Department ID: {dept.DepartmentId}, Name: {dept.Name}");
                    Console.WriteLine("Employees:");

                    foreach (var emp in dept.Employees)
                    {
                        Console.WriteLine($"   - {emp.FirstName} {emp.LastName} (ID: {emp.EmployeeId})");
                    }

                    Console.WriteLine("═══════════════════════════════════════════════════════");
                }
                Console.ReadKey();
            }
        }

        public static void DisplayEmployees()
        {
            using (var db = new CompanyDbContext())
            {
                var employees = db.Employees
                                  .Include(e => e.Department)
                                  .Include(e => e.EmployeeProjects)
                                  .ThenInclude(ep => ep.Project)
                                  .ToList();

                foreach (var emp in employees)
                {
                    Console.WriteLine($"Employee ID: {emp.EmployeeId}, Name: {emp.FirstName} {emp.LastName}");
                    Console.WriteLine($"Department: {(emp.Department != null ? emp.Department.Name : "None")}");

                    Console.WriteLine("Projects:");
                    foreach (var proj in emp.EmployeeProjects)
                    {
                        Console.WriteLine($"   - {proj.Project.Name}");
                    }

                    Console.WriteLine("═══════════════════════════════════════════════════════");
                }
                Console.ReadKey();
            }
        }

        public static void DisplayProjects()
        {
            using (var db = new CompanyDbContext())
            {
                var projects = db.Projects
                                 .Include(p => p.EmployeeProjects)
                                 .ThenInclude(ep => ep.Employee)
                                 .ToList();

                foreach (var proj in projects)
                {
                    Console.WriteLine($"Project ID: {proj.ProjectId}, Name: {proj.Name}");
                    Console.WriteLine($"Duration: {proj.StartDate} to {proj.EndDate}");
                    Console.WriteLine("Assigned Employees:");

                    foreach (var emp in proj.EmployeeProjects)
                    {
                        Console.WriteLine($"   - {emp.Employee.FirstName} {emp.Employee.LastName} (ID: {emp.Employee.EmployeeId})");
                    }

                    Console.WriteLine("═══════════════════════════════════════════════════════");
                }
                Console.ReadKey();
            }
        }

        public static void DeleteDepartment()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Department ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var dept = db.Departments
                             .Include(d => d.Employees)
                             .FirstOrDefault(d => d.DepartmentId == id);

                if (dept != null)
                {
                    if (dept.Employees.Any())
                    {
                        Console.WriteLine("Can't delete department. It still has employees assigned.");
                    }
                    else
                    {
                        db.Departments.Remove(dept);
                        db.SaveChanges();
                        Console.WriteLine("Department deleted successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Department not found.");
                }
            }
            Console.ReadKey();
        }

        public static void DeleteEmployee()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var emp = db.Employees
                    .Include(e => e.EmployeeProjects)
                    .FirstOrDefault(e => e.EmployeeId == id);

                if (emp != null)
                {
                    emp.EmployeeProjects.Clear();
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            Console.ReadKey();
        }

        public static void DeleteProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Project ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var proj = db.Projects
                             .Include(p => p.EmployeeProjects)
                             .FirstOrDefault(p => p.ProjectId == id);

                if (proj != null)
                {
                    proj.EmployeeProjects.Clear();
                    db.Projects.Remove(proj);
                    db.SaveChanges();
                    Console.WriteLine("Project deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Project not found.");
                }
            }
            Console.ReadKey();
        }

        public static void EditDepartmentData()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Department ID to edit: ");
                int deptId = int.Parse(Console.ReadLine());

                var department = db.Departments.FirstOrDefault(d => d.DepartmentId == deptId);
                if (department == null)
                {
                    Console.WriteLine("Department not found.");
                    return;
                }

                Console.WriteLine($"Current Name: {department.Name}");
                Console.Write("New Name : ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    department.Name = newName;
                    db.SaveChanges();
                    Console.WriteLine("Department updated successfully.");
                }
                else
                {
                    Console.WriteLine("No changes made.");
                }
            }
        }

        public static void EditProjectData()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Project ID to edit: ");
                int projectId = int.Parse(Console.ReadLine());

                var project = db.Projects.FirstOrDefault(p => p.ProjectId == projectId);
                if (project == null)
                {
                    Console.WriteLine("Project not found.");
                    return;
                }

                Console.WriteLine($"Current Name: {project.Name}");
                Console.Write("New Name : ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                    project.Name = newName;

                Console.WriteLine($"Current Start Date: {project.StartDate:yyyy-MM-dd}");
                Console.Write("New Start Date (yyyy-MM-dd): ");
                string newStart = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newStart))
                    project.StartDate = DateTime.Parse(newStart);

                Console.WriteLine($"Current End Date: {project.EndDate?.ToString("yyyy-MM-dd") ?? "N/A"}");
                Console.Write("New End Date (yyyy-MM-dd): ");
                string newEnd = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newEnd))
                    project.EndDate = DateTime.Parse(newEnd);

                db.SaveChanges();
                Console.WriteLine("Project updated successfully.");
            }
        }

        public static void EditEmployee()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID to edit: ");
                int id = int.Parse(Console.ReadLine());

                var emp = db.Employees.FirstOrDefault(e => e.EmployeeId == id);

                if (emp != null)
                {
                    Console.WriteLine($"Current First Name: {emp.FirstName}");
                    Console.Write("New First Name : ");
                    string newFirstName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newFirstName))
                        emp.FirstName = newFirstName;

                    Console.WriteLine($"Current Last Name: {emp.LastName}");
                    Console.Write("New Last Name : ");
                    string newLastName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newLastName))
                        emp.LastName = newLastName;

                    db.SaveChanges();
                    Console.WriteLine("Employee name updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
    }
}