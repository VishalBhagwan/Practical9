using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Practical9.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }

        //Insert into Table
        public ActionResult DoInsert(string name, string clubName, int age, decimal fee)
        {
            try
            {
                SqlCommand myInsertCommand = new SqlCommand("Insert into Members (Name, ClubName, Age, Fee) Values ('" + name  + "', '" + clubName  + "', '" + age  + "', '" + fee  + "')", myConnection);

                myConnection.Open();
                int rowsAffected = myInsertCommand.ExecuteNonQuery();
                ViewBag.Message = "Success: " + rowsAffected + " rows added.";
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
            }
            finally
            {
                myConnection.Close();
            }
            return View("Index");
        }

        //Update Table
        public ActionResult Update()
        {
            return View();
        }

        public ActionResult DoUpdate(int id, string name, string clubName, int age, decimal fee)
        {
            try
            {
                //SqlCommand myUpdateCommand = new SqlCommand("Update Name Set Name='" + name + "' where ID=" + id, myConnection);
                SqlCommand myUpdateCommand = new SqlCommand("Update Members Set Name = '" + name + "', ClubName = '" + clubName + "', Age = " + age + ", Fee = " + fee + " where ID=" + id, myConnection);

                myConnection.Open();
                int rowsAffected = myUpdateCommand.ExecuteNonQuery();
                ViewBag.Message = "Success: " + rowsAffected + " rows updated.";
            }
            catch (Exception err)
            {
                ViewBag.Message = "Error: " + err.Message;
            }
            finally
            {
                myConnection.Close();
            }
            return View("Index");
        }

        //Delete row
        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult DoDelete(int id)
        {
            try
            {
                SqlCommand myDeleteCommand = new SqlCommand("Delete from Members where ID=" + id, myConnection);

                myConnection.Open();
                int rowsAffected = myDeleteCommand.ExecuteNonQuery();
                ViewBag.Message = "Success: " + rowsAffected + " rows deleted.";
            }
            catch (Exception err)
            {
                ViewBag.Message = "Error: " + err.Message;
            }
            finally
            {
                myConnection.Close();
            }
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}