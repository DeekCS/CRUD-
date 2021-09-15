using System;
using System.Data.SqlClient;

namespace FinalProject
{
    class Admin
    {
        public SqlConnection con;

        public string path =
            @"Data Source=DESKTOP-J6T4HOT\SQLEXPRESS;Initial Catalog=College;Integrated Security=True;Pooling=False";

        public bool InsertAdmin(admin admin)
        {


            try
            {

                con = new SqlConnection(path);
                con.Open();
                Console.WriteLine("Database Connected Successfully");

                Console.WriteLine("Please Enter Admin First Name");
                admin.adminName = Console.ReadLine();

                Console.WriteLine("Please Enter Admin Email");
                admin.adminEmail = Console.ReadLine();

                Console.WriteLine("Please Enter Admin Password");
                admin.adminPassword = Console.ReadLine();

                Console.WriteLine("Please Enter Admin Phone Number :");
                admin.adminNumber = Convert.ToInt32(Console.ReadLine());

                string query =
                    $"Insert into Admin(adminName,adminEmail,adminPassword,adminNumber) values ('{admin.adminName}','{admin.adminEmail}','{admin.adminPassword}','{admin.adminNumber}')";


                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                Console.WriteLine("Admin Details inserted successfully :D ");

                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public bool UpdateAdmin(admin admin)
        {
            string query;
            try
            {
                con = new SqlConnection(path);
                con.Open();
                Console.WriteLine("Enter Admin Name, to update");
                admin.adminName = Console.ReadLine();
                Console.WriteLine("Select Admin id you want to update his name");
                admin.adminId = Convert.ToInt32(Console.ReadLine());
                query = "Update admin SET adminName= '" + admin.adminName + "'where adminId ='" + admin.adminId + "';";
                SqlCommand ins = new SqlCommand(query, con);
                Console.WriteLine();
                Console.WriteLine("Admin Name Updated");
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public void DisplayAdmin()
        {
            using (collegeDataContext dataContext = new collegeDataContext())
            {
                Console.WriteLine("All Admins Details : \n\n");

                foreach (admin ad in dataContext.admins)
                {
                    Console.WriteLine("AdminID    |\t AdminName |\t AdminEmail    | \t AdminPassowrd\n");
                    Console.WriteLine(ad.adminId + "      |\t " + ad.adminName + "     |\t " + ad.adminEmail +
                                      "    |\t " + ad.adminPassword);
                }
            }
        }

        public void DeleteAdmin(admin admin)
        {
            try
            {
                con = new SqlConnection(path);
                con.Open();
                Console.WriteLine("Enter Id admin to delete");
                //admin.adminName = Console.ReadLine();
                //Console.WriteLine("Select Admin id you want to update his name");
                admin.adminId = Convert.ToInt32(Console.ReadLine());
                string query = $"delete from admin where adminId= '{admin.adminId}";
                SqlCommand ins = new SqlCommand(query, con);
                Console.WriteLine();
                Console.WriteLine("Admin Name Updated");
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void ManageAdmin(admin admin)
        {
            Console.WriteLine("Which your choice you need to do?");
            Console.WriteLine("1- Add Admin.\n 2- Edit Admin.\n 3- Remove Admin.\n 4- Display All Admins.");

            var choice = Convert.ToInt32(Console.ReadLine());
            Admin adm = new Admin();
            switch (choice)
            {
                case 1:
                {

                    adm.InsertAdmin(new admin());
                    break;
                }
                case 2:
                {
                    adm.UpdateAdmin(new admin());
                    break;
                }
                case 3:
                {
                    adm.DeleteAdmin(new admin());
                    
                    break;
                }
                case 4:
                {
                    adm.DisplayAdmin();
                    break;
                }
            }

        }

        public void Menu()
        {
            Console.WriteLine("Which your choice you need to do?");
            Console.WriteLine(" [1] Admin Menu\n [2] Student Menu\n [3] Course Menu\n [4] Score Menu \n [5] Exit");


            var choice = Convert.ToInt32(Console.ReadLine());
            Student std = new Student();
            Admin adm = new Admin();
            Courses cor = new Courses();
            Score sc = new Score();
            switch (choice)
            {
                case 1:
                {

                    adm.ManageAdmin(new admin());
                    break;
                }
                case 2:
                {
                    std.ManageStudent();
                    break;
                }
                case 3:
                {
                    cor.ManageCourses();
                    break;
                }
                case 4:
                {
                    sc.ManageScore();
                    break;
                }
                case 5:
                {
                    Environment.Exit(0);
                    break;
                }
                default:
                    Console.WriteLine($"Please Select Number from the Menu between 1-5 :) ");
                    break;
            }

        }

        public void Login(admin admin)
        {
            con = new SqlConnection(path);
            string userName = "aseel";
            string Password = "aseel12345";

            Console.Write("Enter User Name: ");
            string user = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (user == userName && pass == Password)
            {
                Console.WriteLine();
                Console.WriteLine($"Welcome {userName}");
                Menu();
            }
            else
            {
                Console.WriteLine("Password OR Email is Wrong!");
            }


        }

        
    }
}

    

