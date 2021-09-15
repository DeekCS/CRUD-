using System;
using System.Data.SqlClient;

namespace FinalProject
{
    class Student
    {
        public SqlConnection Con;
        public string Path;

        public Student()
        {
            Path = @"Data Source=DESKTOP-J6T4HOT\SQLEXPRESS;Initial Catalog=College;Integrated Security=True;Pooling=False";
        }

        public bool InsertStudent(student std)
        {
           
            try
            {

                Con = new SqlConnection(Path);
                Con.Open();
                Console.WriteLine("Database Connected Successfully");
                
                Console.WriteLine("Please Enter Student First Name");
                std.studentFirstName = Console.ReadLine();

                Console.WriteLine("Please Enter Student Last Name");
                std.studentLastName = Console.ReadLine();


                Console.WriteLine("Enter Student Gender: ");
                std.Gender = Console.ReadLine();
                string lower = std.Gender.ToLower();

                Console.WriteLine("Enter Student GPA");
                std.gpa = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Student Email:");
                std.studentEmail = Console.ReadLine();

                Console.WriteLine("Please Enter Student Password");
                std.studentPassword = Console.ReadLine();

                

                Console.WriteLine("Please Enter Admin ID:");
                std.adminId= Convert.ToInt32(Console.ReadLine());

                string query =
                    $"Insert into student(studentFirstName,studentLastName,Gender,gpa, studentEmail,studentPassword,adminId) values ('{std.studentFirstName}','{std.studentLastName}',' {lower}','{std.gpa} ',' {std.studentEmail}',' {std.studentPassword}  ','{std.adminId}')";


                SqlCommand ins = new SqlCommand(query, Con);
                ins.ExecuteNonQuery();
                Console.WriteLine("Student Details inserted successfully :D ");

                Con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
        public bool UpdateStudent(student std)
        {
            string query;
            try
            {
                Con = new SqlConnection(Path);
                Con.Open();
                Console.WriteLine("Enter Student First Name, to update");
                std.studentFirstName = Console.ReadLine();
                Console.WriteLine("Select Student id you want to update his name");
                std.studentId= Convert.ToInt32(Console.ReadLine());
                query =
                    $"Update student SET studentFirstName= '{std.studentFirstName}'where studentId ='{std.studentId}';";
                SqlCommand ins = new SqlCommand(query, Con);
                Console.WriteLine();
                Console.WriteLine("Student Name Updated Successfully :D ");
                ins.ExecuteNonQuery();
                Con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public void DisplayStudent()
        {
            using (collegeDataContext dataContext = new collegeDataContext())
            {
                Console.WriteLine("All Student Details : \n\n");

                foreach (student std in dataContext.students)
                {
                    Console.WriteLine(
                        $"StudentID: {std.studentId} \n StudentFirstName: {std.studentFirstName} \n StudentLastName: {std.studentLastName} \n StudentGender: {std.Gender} \n StudentEmail {std.studentEmail} \n StudentGPA: {std.gpa} \n Admin Student ID {std.adminId}");
                }
            }
        }

        public bool DeleteStudent(student std)
        {
            try
            {
                Con = new SqlConnection(Path);
                Con.Open();
                Console.WriteLine("Enter Id Student to delete");
                std.studentId= Convert.ToInt32(Console.ReadLine());
                string query = $"delete from student where studentId= '{std.studentId}'";
                SqlCommand ins = new SqlCommand(query, Con);
                Con = new SqlConnection(Path);
                Console.WriteLine();
                ins.ExecuteNonQuery();

                Console.WriteLine("Selected Student Deleted Successfully");
                Con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public void ManageStudent()
        {
            Console.WriteLine("Which your choice you need to do?");
            Console.WriteLine("1-Add Student.\n 2-Edit Student.\n 3-Remove Student.\n 4-Display All Students. \n 5-Search Student By First Name\n 6-Student Statics");

            var choice = Convert.ToInt32(Console.ReadLine());
            Student std = new Student();
            switch (choice)
            {
                case 1:
                {
                  
                    std.InsertStudent(new student());
                    break;
                }
                case 2:
                {
                   
                    std.UpdateStudent(new student());
                    break;
                }
                case 3:
                {
                    std.DeleteStudent(new student());
                    break;
                }
                case 4:
                {
                    std.DisplayStudent();
                    break;
                }
                case 5:
                {
                    std.StudentSearchByName(new student());
                    break;
                }
                case 6:
                {
                    std.StudentStatics();
                    break;
                }
                default:
                    Console.WriteLine($"Please Select Number from the Menu between 1-6 :) ");
                    break;
            }
           

        }

        public void StudentStatics()
        {
            try
            {
                using (collegeDataContext dataContext = new collegeDataContext())
                {
                    int maleCount = 0, femaleCount = 0;
                    Console.WriteLine("All Student Details : \n\n");

                    foreach (student stu in dataContext.students)
                    {

                        if (stu.Gender == "f" || stu.Gender == "female")
                        {
                            femaleCount++;
                            Console.WriteLine(
                                $"StudentID: {stu.studentId} \n StudentFirstName: {stu.studentFirstName} \n StudentLastName: {stu.studentLastName} \n StudentGender: {stu.Gender} \n StudentEmail {stu.studentEmail} \n StudentGPA: {stu.gpa} \n Admin Student ID {stu.adminId}");
                        }
                        if (stu.Gender == "m" || stu.Gender == "male")
                        {
                            maleCount++;
                            Console.WriteLine(
                                $"StudentID: {stu.studentId} \n StudentFirstName: {stu.studentFirstName} \n StudentLastName: {stu.studentLastName} \n StudentGender: {stu.Gender} \n StudentEmail {stu.studentEmail} \n StudentGPA: {stu.gpa} \n Admin Student ID {stu.adminId}");
                        }
                        
                    }
                    Console.WriteLine($"All Student Count : {(femaleCount+maleCount)}");
                    Console.WriteLine($"Student Female Count {femaleCount}");
                    Console.WriteLine($"Student Male Count {maleCount}");

                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
           
        }

        public bool StudentSearchByName(student std)
        {
            try
            {
                using (collegeDataContext dataContext = new collegeDataContext())
                {
                    Console.WriteLine("Enter Student Name to search : \n\n");
                   string name = Console.ReadLine();

                    foreach (student stu in dataContext.students)
                    {
                        if (stu.studentFirstName == name)
                        {
                            Console.WriteLine(
                                $"StudentID: {stu.studentId} \n StudentFirstName: {stu.studentFirstName} \n StudentLastName: {stu.studentLastName} \n StudentGender: {stu.Gender} \n StudentEmail {stu.studentEmail} \n StudentGPA: {stu.gpa} \n Admin Student ID {stu.adminId}");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return false;
        }



    }
}
