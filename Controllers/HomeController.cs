using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HappyLife.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HappyLife.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            if (role =="user") {

                return RedirectToAction("Index2");
            
            }

            return View(await db.Users.ToListAsync());
        }
        [Authorize(Roles = "user")]
        public async Task<IActionResult> Index2()
        {
            return View(await db.Users.ToListAsync());
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Help()
        {   var q = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);
            int q1 = q.UserId;
            return View(await db.Accesemps.Where(p => p.Other == q1  ).ToListAsync());
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Acces()
        {

            return View(await db.Users.ToListAsync());
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Alluser()
        {

            return View(await db.Users.ToListAsync());
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult Permission()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Permission(Record record)
        {
            var user1 = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);

            TimeSpan ts = new TimeSpan(18, 00, 00);
            var a = record.Start.Date + ts;
            record = new Record
            {
                Description = record.Description,
                InWork = true,
                Start = record.Start,
                End = a ,
                UserId = user1.UserId

            };
            db.Records.Add(record);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        [Authorize(Roles = "admin, user")]

        public async Task<IActionResult> Privacy()
        {
            var user1 = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);

            return View(await db.Records.Where(p => p.UserId == user1.UserId ).ToListAsync());
        }
        [Authorize(Roles = "admin, user")]

        public async Task<IActionResult> See(int? id)
        {
           

            return View(await db.Records.Where(p => p.UserId == id).ToListAsync());
        }
        [Authorize(Roles = "admin, user")]

        [HttpPost]
        public async Task<IActionResult> Privacy(Record record)
        {
            var user1 = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);

            record = new Record {
                Description = "Manually",
                InWork = false,
                Start = DateTime.Now,
                End = DateTime.MinValue ,
                UserId = user1.UserId

            };

            db.Records.Add(record);
            await db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var record =  db.Records.FirstOrDefault(p => p.RecordId == id);

            Record record1 = new Record
            {
                Description = record.Description ,
                InWork = true ,
                Start = record.Start , 
                End = DateTime.Now ,
                UserId = record.UserId
               

            };
            db.Records.Remove(record);
            db.Records.Add(record1);

            await db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Give(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var user1 = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);

            Accesemp accesemp = new Accesemp
            {
               Other = (int)id , 
               Email = User.Identity.Name
               ,
               UserId = user1.UserId


            };
            
            db.Accesemps.Add(accesemp);

            await db.SaveChangesAsync();
            return RedirectToAction("Help");
        }
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Getofwork(int? id)
        {
            var user1 = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);

            if (id == null) return RedirectToAction("Index");
            TimeSpan ts = new TimeSpan(09, 00, 00);
            var a = DateTime.Now.Date + ts;
            TimeSpan ts2 = new TimeSpan(18, 00, 00);
            var b = DateTime.Now.Date + ts2;
            Record record1 = new Record
            {   
                Description = "Permission with other employee",
                InWork = true,
                Start = a,
                End = b,
                UserId = user1.UserId


            };
           
            db.Records.Add(record1);



            await db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }


    }
}
