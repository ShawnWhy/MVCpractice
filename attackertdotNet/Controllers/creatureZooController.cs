using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using attackertdotNet.Models;
using attackertdotNet.Models.ViewModels;
using System.Data;
using System.Data.SqlClient;
using DatalibraryMonster.Logic;


/*[HttpGet]
public ActionResult ViewScientists()
{
    ViewBag.Message = "List of Our Scientists";
    var data = ScientistProcess.LoadScientists();

    return View(data);

}*/

namespace attackertdotNet.Controllers
{
    public class creatureZooController : Controller
    {[HttpGet]
        // GET: creatureZoo
               public ActionResult Index()
        {
            /* var html = "<div class='monsterBody' style='border-radius: 31% 31% 25% 25%; height: 80%; width: 31%; background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='monsterEyerow'> <div class='eye'><div class='iris'></div></div><div class='eye'><div class='iris'></div></div><div class='eye'><div class='iris'></div></div><div class='eye'><div class='iris'></div></div><div class='eye'><div class='iris'></div></div><div class='eye'><div class='iris'></div></div></div><div class='monsterMouth'> <div class='topRow'> <div class='teeth'></div><div class='teeth'></div><div class='teeth'></div><div class='teeth'></div><div class='teeth'></div><div class='teeth'></div></div><div class='bottomRow'> <div class='teethB'></div><div class='teethB'></div><div class='teethB'></div><div class='teethB'></div><div class='teethB'></div><div class='teethB'></div></div></div><div class='tentacles'> <div class='tentacleRoot' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div><div class='tentacleRoot' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div><div class='tentacleRoot2' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div><div class='tentacleRoot2' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div></div><div class='tentaclesBack'> <div class='tentacleRoot' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div><div class='tentacleRoot' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div><div class='tentacleRoot' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div><div class='tentacleRoot' style='transform: translateY(0px); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(-10%, -30%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> <div class='tentaclePart' style='transform: translate(30%, 0%); background-image: radial-gradient(rgb(50, 125, 125) 30%, rgb(45, 25, 125));'> </div></div></div></div></div></div></div></div></div></div></div>";
            var monster = new monsterClass() { Name = "Dorothy", MonsterHTML = @html, IsDestroyed = false, };
            var monster2 = new monsterClass() { Name = "Dora", MonsterHTML = @html, IsDestroyed = false, };
            var monsters = new List<monsterClass>
            {@monster, @monster2


            };

            var viewModel = new MonstersAliveViewModel()
            {
                monsterClass = monsters
            };



            return View(viewModel);*/


            ViewBag.Message = "List of Our Scientists";
            var data = monsterProcess.loadMonsters();
       
            return View(data);
        }

        public ActionResult Edit2(int id)
        {

            return Content("id=" + id);
        }


        //Get all of the monsters 
        

            // GET: creatureZoo/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }

        // GET: creatureZoo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: creatureZoo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: creatureZoo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: creatureZoo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: creatureZoo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: creatureZoo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}


/*private static void OpenSqlConnection()
{
    string connectionString = GetConnectionString();

    using (SqlConnection connection = new SqlConnection())
    {
        connection.ConnectionString = connectionString;

        connection.Open();

        Console.WriteLine("State: {0}", connection.State);
        Console.WriteLine("ConnectionString: {0}",
            connection.ConnectionString);
    }
}

static private string GetConnectionString()
{
    // To avoid storing the connection string in your code,
    // you can retrieve it from a configuration file.
    return "Data Source=MSSQL1;Initial Catalog=AdventureWorks;"
        + "Integrated Security=true;";
}*/