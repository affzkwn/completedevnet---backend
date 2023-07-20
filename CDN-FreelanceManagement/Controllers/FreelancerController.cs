using CDN_FreelanceManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace CDN_FreelanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public FreelancerController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                            select * from dbo.FreelanceUser";
            DataTable dt = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("cdnappDBCon");
            SqlDataReader myReader;
            using(SqlConnection myConn = new SqlConnection(sqlDataSource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }

            return new JsonResult(dt);
        }

        [HttpPost]
        public JsonResult Post(Freelancer Flancer)
        {
            string query = @"
                            insert into dbo.FreelanceUser
                            (username,email,phone,skillsets,hobby)  
                            values (@username,@email,@phone,@skillsets,@hobby)";

            DataTable dt = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("cdnappDBCon");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDataSource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myCommand.Parameters.AddWithValue("@username", Flancer.username);
                    myCommand.Parameters.AddWithValue("@email", Flancer.email);
                    myCommand.Parameters.AddWithValue("@phone", Flancer.phone);
                    myCommand.Parameters.AddWithValue("@skillsets", Flancer.skillsets);
                    myCommand.Parameters.AddWithValue("@hobby", Flancer.hobby);
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }

            return new JsonResult("Create Successfully");
        }

        [HttpPut]
        public JsonResult Put(Freelancer Flancer)
        {
            string query = @"
                            update dbo.FreelanceUser
                            set username = @username,
                                email = @email,
                                phone = @phone,
                                skillsets = @skillsets,
                                hobby = @hobby
                            where usernameId = @usernameId
                            ";

            DataTable dt = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("cdnappDBCon");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDataSource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myCommand.Parameters.AddWithValue("@usernameId", Flancer.usernameId);
                    myCommand.Parameters.AddWithValue("@username", Flancer.username);
                    myCommand.Parameters.AddWithValue("@email", Flancer.email);
                    myCommand.Parameters.AddWithValue("@phone", Flancer.phone);
                    myCommand.Parameters.AddWithValue("@skillsets", Flancer.skillsets);
                    myCommand.Parameters.AddWithValue("@hobby", Flancer.hobby);
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }

            return new JsonResult("Update Successfully");
        }

        [HttpDelete("{usernameId}")]
        public JsonResult Delete(int usernameId)
        {
            string query = @"
                            delete from dbo.FreelanceUser
                            where usernameId = @usernameId
                            ";

            DataTable dt = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("cdnappDBCon");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDataSource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myCommand.Parameters.AddWithValue("@usernameId", usernameId);
                   
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }

            return new JsonResult("Delete Successfully");
        }

    }

}
