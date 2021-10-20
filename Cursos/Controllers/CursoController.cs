using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dados.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace Curso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        

        public string cursoName { get; set; }
        public string cursoDescricao { get; set; }
        public string cursoFoto { get; set; }
        public string cursoProfessor { get; set; }
        public string cursoId { get; set; }

        public CursoController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                            select * from
                            dbo.cursos
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CursosAppCon");

            SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand=new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(CursoController cur)
        {
            string query = @"
                            insert into dbo.cursos
                            (cursoName, cursoDescricao, cursoFoto, cursoProfessor)
                     values (@cursoName, @cursoDescricao, @cursoFoto, @cursoProfessor)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CursosAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@cursoName", cur.cursoName);
                    myCommand.Parameters.AddWithValue("@cursoDescricao", cur.cursoDescricao);
                    myCommand.Parameters.AddWithValue("@cursoFoto", cur.cursoFoto);
                    myCommand.Parameters.AddWithValue("@cursoProfessor", cur.cursoProfessor);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Curso incluido com sucesso!!");
        }

        [HttpPut]
        public JsonResult Put(CursoController cur)
        {
            
            string query = @"
                            update dbo.cursos
                            set cursoName = @cursoName,
                             cursoDescricao = @cursoDescricao,
                             cursoFoto = @cursoFoto
                            where cursoId = @cursoId
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CursosAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@cursoId", cur.cursoId);
                    myCommand.Parameters.AddWithValue("@cursoName", cur.cursoName);
                    myCommand.Parameters.AddWithValue("@cursoDescricao", cur.cursoDescricao);
                    myCommand.Parameters.AddWithValue("@cursoFoto", cur.cursoFoto);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Curso alterado com sucesso!!");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                            delete from dbo.cursos
                            where CursoId = @CursoId
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CursosAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@CursoId", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Curso deletado com sucesso!!");
        }

        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Fotos/" + filename;

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(filename);
            }
            catch (Exception)
            {

                return new JsonResult("anonymous.png");
            }
        }

    }
}

    
    

