using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {



        String connectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=Sample;Integrated Security=True";

        //
        // GET: /Employee/
        public ActionResult Index()
        {

            DataTable dtblProduct = new DataTable();

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from tblEmployee", sqlcon);
                sqlDa.Fill(dtblProduct);


            }
            return View(dtblProduct);
        }
    }
}



