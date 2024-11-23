namespace TaskOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test1
            //User user1 = new User("a", "a@amail.com", "Password1");
            //User user2 = new User("b", "b@bmail.com", "Password2");
            //User user3 = new User("c", "c@cmail.com", "Password3");
            //User user4 = new User("d", "d@dmail.com", "Password4");
            //User user5 = new User("e", "e@email.com", "Password5");
            //User user6 = new User("f", "f@fmail.com", "Password6");


            //user1.ShowInfo();
            //user2.ShowInfo();
            //user3.ShowInfo();
            //user4.ShowInfo();
            //user5.ShowInfo();
            //user6.ShowInfo();

            //Student student1 = new Student("a", 20);
            //Student student2 = new Student("b", 35);
            //Student student3 = new Student("c", 56);
            //Student student4 = new Student("d", 92);
            //Student student5 = new Student("e", 123);

            //student1.StudentInfo();
            //student2.StudentInfo();
            //student3.StudentInfo();
            //student4.StudentInfo();
            //student5.StudentInfo();

            //Group group = new Group("PB503", 5);

            //Console.WriteLine(group.CheckGroupNo());

            //group.AddStudent(student1);
            //group.AddStudent(student2);
            //group.AddStudent(student3);
            //group.AddStudent(student4);
            //group.AddStudent(student5);
            //group.ShowAllStudents();
            #endregion
            #region Test2
            //Console.WriteLine("Enter your full name: ");
            //string fullname = Console.ReadLine();

            //Console.WriteLine("Enter your email: ");
            //string email = Console.ReadLine();

            //Console.WriteLine("Enter your password: ");
            //string password = Console.ReadLine();

            //User user = new User(fullname, email, password);

            //if (!user.PasswordChecker(password))
            //{
            //    Console.WriteLine("Error!");
            //}
            //else
            //{
            //    Console.WriteLine("User created.");
            //}

            //int input;
            //do
            //{
            //    Console.WriteLine("Choose an operation: ");
            //    Console.WriteLine("1. Show info");
            //    Console.WriteLine("2. Create new group");
            //    Console.WriteLine("0. Exit");

            //    input = int.Parse(Console.ReadLine());
            //    switch (input)
            //    {
            //        case 1:

            //    }
            //}
            //while (input != 0);
            #endregion


            Console.WriteLine("Create a User");
            Console.WriteLine("Fullname: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email= Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            User user = new(fullname,email,password);

            int menu;
            Group group = null;
            do
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Create new group");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                

                    case 2:
                        Console.Write("GroupNo: ");
                        string groupNo = Console.ReadLine();
                        Console.Write("StudentLimit: ");
                        int studentLimit = int.Parse(Console.ReadLine());

                        group = new Group(groupNo, studentLimit);

                        if (!group.CheckGroupNo())
                        {
                            Console.WriteLine("Invalid group number format.");
                            group = null;
                        }
                        else
                        {
                            Console.WriteLine($"Group {group.GroupNo} created successfully.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }
                if (group != null)
                {
                    int groupMenu;
                    do
                    {
                        Console.WriteLine("\nGroup Menu:");
                        Console.WriteLine("1. Show all students");
                        Console.WriteLine("2. Get student by id");
                        Console.WriteLine("3. Add student");
                        Console.WriteLine("0. Back to main menu");
                        Console.Write("Select an option: ");
                        groupMenu = int.Parse(Console.ReadLine());

                        switch (groupMenu)
                        {
                            case 1:
                                Console.WriteLine("\nList of Students: ");
                                group.ShowAllStudents();
                                break;

                            case 2:
                                Console.WriteLine("Enter Student Id: ");
                                int id = int.Parse(Console.ReadLine());
                                Student student = group.GetStudent(id);

                                if (student != null)
                                {
                                    student.StudentInfo();
                                }
                                else
                                {
                                    Console.WriteLine("Student not found");
                                }
                                break;

                            case 3:
                                Console.Write("Fullname: ");
                                string studentName = Console.ReadLine();
                                Console.Write("Email: ");
                                string studentEmail = Console.ReadLine();
                                Console.Write("Password: ");
                                string studentPassword = Console.ReadLine();
                                Console.Write("Point: ");
                                double point = double.Parse(Console.ReadLine());

                                Student newStudent = new(studentName, studentEmail, studentPassword, point);

                                if (!group.AddStudent(newStudent))
                                {
                                    Console.WriteLine("Group is full. Cannot add more students.");
                                }
                                else
                                {
                                    Console.WriteLine($"Student {newStudent.Fullname} added successfully.");
                                }
                                break;
                            case 0:
                                Console.WriteLine("Returning to main menu...");
                                break;

                            default:
                                Console.WriteLine("Invalid option. Try again.");
                                break;
                        }

                    } while (groupMenu != 0);
                } 
            } while (menu != 0);
        }

    }
}
