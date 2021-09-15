using System;
using System.Data.SqlClient;
using System.IO;

namespace FinalProject
{
    class Score
    {

        public SqlConnection Con;
        public string Path;

        public Score()
        {
            Path = $"Data Source=DESKTOP-J6T4HOT\\SQLEXPRESS;Initial Catalog=College;Integrated Security=True;Pooling=False";
        }

        public bool InsertScore(score sco)
        {
            try
            {
                Con = new SqlConnection(Path);
                Con.Open();
                Console.WriteLine("Database Connected Successfully");

                Console.WriteLine("Enter Student ID to Add his Score:");
                sco.studentId= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Course ID of the Score: ");
                sco.courseId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Score Value: ");
                sco.studentScore = Double.Parse(Console.ReadLine());

                string query =
                    $"Insert into score(studentScore,courseId,studentId) values ('{ sco.studentScore}','{ sco.courseId }',' { sco.studentId}')";
                SqlCommand ins = new SqlCommand(query, Con);
                ins.ExecuteNonQuery();
                Console.WriteLine("Score Details inserted successfully :D ");

                Con.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public bool UpdateScore(score sco)
        {
            string query;
            try
            {
                Con = new SqlConnection(Path);
                Con.Open();
                Console.WriteLine("Enter Score Value To Update: ");
                //cor.courseName= Console.ReadLine();
                sco.studentScore = Double.Parse(Console.ReadLine());
                Console.WriteLine("Select Student Id you want to update his score: ");
                sco.studentId= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select Course Id you want to update student score in : ");
                sco.courseId= Convert.ToInt32(Console.ReadLine());


                query =
                    $"Update Score SET studentScore= '{sco.studentScore}'where courseId ='{sco.courseId}'AND studentId= '{sco.studentId}' ;";
                SqlCommand ins = new SqlCommand(query, Con);
                Console.WriteLine();
                Console.WriteLine($"Score Value of Updated Successfully :D ");
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
        public bool DeleteScore(score sco)
        {
            try
            {
                Con = new SqlConnection(Path);
                Con.Open();
                Console.WriteLine("Select Student Id you want to Delete his score:");
                sco.courseId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select Course Id you want to delete student score from : ");

                string query = $"delete from Score where courseId= '{sco.courseId}' AND studentId =  {sco.studentId}";
                SqlCommand ins = new SqlCommand(query, Con);
                Console.WriteLine();
                ins.ExecuteNonQuery();
                Console.WriteLine("Selected Score Deleted Successfully");
                Con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public void DisplayScore()
        {
            using (collegeDataContext dataContext = new collegeDataContext())
            {
                Console.WriteLine("All Score Details : ");
                Console.WriteLine("=============================");
                foreach (score sco in dataContext.scores)
                {
                    
                    Console.WriteLine(
                        $"ScoreID: {sco.scoreId} \n StudentScore: {sco.studentScore} \nCourseID:{sco.courseId}\n StudentID: {sco.studentId}");
                    Console.WriteLine("=============================");
                }
            }
        }

        public void PrintScoreToFile()
        {
            string fileName = @"C:\Users\DEV\Desktop\CourseFile\scoreFile.txt";
            try
            {
                using (StreamWriter streamWriter = File.AppendText(fileName))
                {

                    using (collegeDataContext dataContext = new collegeDataContext())
                    {
                        foreach (score sco in dataContext.scores)
                        {
                            streamWriter.WriteLine("======= Score List =======");
                            streamWriter.WriteLine($"ScoreID=> {sco.scoreId}\n StudentScore=> {sco.studentScore}\nCourseID=> {sco.courseId}\n StudentID=> {sco.studentId}");
                           
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

       

        public void ManageScore()
        {
            Console.WriteLine("Which your choice you need to do?");
            Console.WriteLine(" 1-Add Score.\n 2-Edit Score.\n 3-Remove Score.\n 4-Display All Scores.\n 5-Print Score to File.\n 6-Display Average");

            var choice = Convert.ToInt32(Console.ReadLine());
            Score sc = new Score();
            switch (choice)
            {

                case 1:
                {

                    sc.InsertScore(new score());
                    break;
                }
                case 2:
                {
                    sc.UpdateScore(new score());
                    break;
                }
                case 3:
                {
                    sc.DeleteScore(new score());
                    break;
                }
                case 4:
                {
                    sc.DisplayScore();
                    break;
                }
                case 5:
                {
                    sc.PrintScoreToFile();
                    break;
                }
                case 6:
                {
                    sc.DisplayAverage();
                    break;
                }
                default:
                    Console.WriteLine($"Please Select Number from the Menu between 1-6 :) ");
                    break;

            }



        }
        public void DisplayAverage()
        {
            Console.WriteLine("Enter Course ID to calculate the Average : ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            double avg = 0;
            double summation = 0;
            int count = 0;

            using (collegeDataContext dataContext = new collegeDataContext())
            {
                foreach (score sco in dataContext.scores)
                {
                    if (courseId == sco.courseId)
                    {
                        if (sco.studentScore != null) summation += (double) sco.studentScore;
                        count++;
                    }

                }
                avg = summation / count;
                Console.WriteLine($"The Average of CourseID {courseId} = {avg} ");
            }

        }

    }

}
