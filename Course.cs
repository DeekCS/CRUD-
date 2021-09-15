using System;
using System.Data.SqlClient;
using System.IO;

namespace FinalProject
{
    class Courses
    {
        public SqlConnection con;

        public string path =
            @"Data Source=DESKTOP-J6T4HOT\SQLEXPRESS;Initial Catalog=College;Integrated Security=True;Pooling=False";

        public bool insertCourse(Course cor)
        {
            try
            {
                con = new SqlConnection(path);
                con.Open();
                Console.WriteLine("Database Connected Successfully");

                Console.WriteLine("Enter Student ID to add him to the Course:");
                cor.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name:");
                cor.courseName = Console.ReadLine();

                Console.WriteLine("Enter Course Language:");
                cor.courseLanguage = Console.ReadLine();

                Console.WriteLine("Enter Course Location:");
                cor.courseLocation = Console.ReadLine();

                Console.WriteLine("Enter Admin ID of the Course:");
                cor.adminId = Convert.ToInt32(Console.ReadLine());

                string query =
                    $"Insert into Courses(studentId,courseLocation,courseLanguage,adminId,courseName) values ('{cor.studentId}','{cor.courseLocation}',' {cor.courseLanguage}','{cor.adminId} ',' {cor.courseName}')";


                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                Console.WriteLine("Courses Details inserted successfully :D ");

                con.Close();


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool UpdateCourse(Course cor)
        {
            string query;
            try
            {
                con = new SqlConnection(path);
                con.Open();
                Console.WriteLine("Enter Course Name, to update: ");
                //cor.courseName= Console.ReadLine();
                cor.courseName = Console.ReadLine();
                Console.WriteLine("Select Course id you want to update: ");
                cor.courseId = Convert.ToInt32(Console.ReadLine());
                query =
                    $"Update Courses SET courseName= '{cor.courseName}'where courseId ='{cor.courseId}';";
                SqlCommand ins = new SqlCommand(query, con);
                Console.WriteLine();
                Console.WriteLine("Course Name Updated Successfully :D ");
                ins.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public void DisplayCourses()
        {
            using (collegeDataContext dataContext = new collegeDataContext())
            {
                Console.WriteLine("All Courses Details : \n\n");

                foreach (Course cor in dataContext.Courses)
                {
                    Console.WriteLine(
                        $"CourseID: {cor.courseId} \n CourseName: {cor.courseName} \nstudentId :{cor.studentId}\n CourseLanguage: {cor.courseLanguage} \n CourseLocation: {cor.courseLocation} \n ID Admin Of the Course: {cor.adminId} ");
                    Console.WriteLine("=============================");
                }
            }
        }

        public bool DeleteCourse(Course cor)
        {
            try
            {
                con = new SqlConnection(path);
                con.Open();
                Console.WriteLine("Enter Course ID to delete");
                cor.courseId = Convert.ToInt32(Console.ReadLine());
                string query = $"delete from Courses where courseId= '{cor.courseId}";
                SqlCommand ins = new SqlCommand(query, con);
                Console.WriteLine();
                ins.ExecuteNonQuery();
                Console.WriteLine("Selected Course Deleted Successfully");
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public void PrintCourseToFile()
        {
            string fileName = @"C:\Users\DEV\Desktop\CourseFile\courseFile";
            try
            {
                using (StreamWriter streamWriter =File.AppendText(fileName))
                {

                    using (collegeDataContext dataContext = new collegeDataContext())
                    {
                        foreach (Course cor in dataContext.Courses)
                        {
                            streamWriter.WriteLine("======= Course Details =======");
                            streamWriter.WriteLine($"CourseID: {cor.courseId} \n CourseName:         {cor.courseName} \nstudentId :{cor.studentId}\n CourseLanguage: {cor.courseLanguage} \n CourseLocation: {cor.courseLocation} \n ID Admin Of the Course: {cor.adminId} ");
                            streamWriter.WriteLine("=============================");
                        }

                    }
               
                }

                Console.WriteLine("Inserted to File Successfully :D ");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void ManageCourses()
        {
            Console.WriteLine("Which your choice you need to do?");
            Console.WriteLine(" 1-Add Course.\n 2-Edit Course.\n 3-Remove Course.\n 4-Display All Courses.\n 5-Print Course to File.\n");

            var choice = Convert.ToInt32(Console.ReadLine());
            Courses cor = new Courses();
            switch (choice)
            {

                case 1:
                {

                    cor.insertCourse(new Course());
                    break;
                }
                case 2:
                {
                    cor.UpdateCourse(new Course());
                    break;
                }
                case 3:
                {
                    cor.DeleteCourse(new Course());
                    break;
                }
                case 4:
                {
                    cor.DisplayCourses();
                    break;
                }
                case 5:
                {
                    cor.PrintCourseToFile();
                    break;
                }
                default:
                    Console.WriteLine($"Please Select Number from the Menu between 1-5 :) ");
                    break;

            }


        }

    }
}
