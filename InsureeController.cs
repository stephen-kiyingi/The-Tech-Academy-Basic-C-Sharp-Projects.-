﻿//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using CarInsurance1.Models;

//namespace CarInsurance1.Controllers
//{
// public class InsureeController : Controller
// {
//private InsuranceEntities2 db = new InsuranceEntities2();

// GET: Insuree
//public ActionResult Index()
// {
//  return View(db.Insurees.ToList());
// }

// GET: Insuree/Details/5
//   public ActionResult Details(int? id)
// {
//     if (id == null)
//  {
//    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//}
//Insuree insuree = db.Insurees.Find(id);
//if (insuree == null)
//{
//  return HttpNotFound();
//}
//return View(insuree);
//}

// GET: Insuree/Create
//public ActionResult Create()
//{
//  return View();
//}

// POST: Insuree/Create
// To protect from overposting attacks, enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
//{
//  if (ModelState.IsValid)
//{
//  db.Insurees.Add(insuree);
// db.SaveChanges();
//return RedirectToAction("Index");
//}

//return View(insuree);
//}

// GET: Insuree/Edit/5
//public ActionResult Edit(int? id)
//{
//  if (id == null)
//{
//  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//}
//Insuree insuree = db.Insurees.Find(id);
//if (insuree == null)
//{
//   return HttpNotFound();
//}
//return View(insuree);
//}

// POST: Insuree/Edit/5
// To protect from overposting attacks, enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
//{
//  if (ModelState.IsValid)
//{
//  db.Entry(insuree).State = EntityState.Modified;
//db.SaveChanges();
//return RedirectToAction("Index");
//}
//return View(insuree);
//}

// GET: Insuree/Delete/5
//public ActionResult Delete(int? id)
//{
//  if (id == null)
//{
//  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//}
//Insuree insuree = db.Insurees.Find(id);
//if (insuree == null)
//{
//  return HttpNotFound();
//}
//return View(insuree);
//}

// POST: Insuree/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public ActionResult DeleteConfirmed(int id)
//{
//  Insuree insuree = db.Insurees.Find(id);
//db.Insurees.Remove(insuree);
//db.SaveChanges();
//return RedirectToAction("Index");
//}

//protected override void Dispose(bool disposing)
//{
//  if (disposing)
//{
//  db.Dispose();
//}
//base.Dispose(disposing);
//}
//}
//}

using System;
using System.Web.Mvc;
using CarInsurance1.Models;

string v = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,SpeedingTickets,DUI,CoverageType";

[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create([Bind(Include = v)] Insuree insuree)
{
    if (ModelState.IsValid)
    {
        // Base quote
        decimal quote = 50m;

        // Calculate age
        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

        // Age-based adjustments
        if (age <= 18)
        {
            quote += 100m;
        }
        else if (age >= 19 && age <= 25)
        {
            quote += 50m;
        }
        else
        {
            quote += 25m;
        }

        // Car year adjustments
        if (insuree.CarYear < 2000)
        {
            quote += 25m;
        }
        if (insuree.CarYear > 2015)
        {
            quote += 25m;
        }

        // Car make/model adjustments
        if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake.ToLower() == "porsche")
        {
            quote += 25m;
            if (!string.IsNullOrEmpty(insuree.CarModel) && insuree.CarModel.ToLower() == "911 carrera")
            {
                quote += 25m;
            }
        }

        // Speeding tickets
        quote += insuree.SpeedingTickets * 10m;

        // DUI adjustment
        if (insuree.DUI)
        {
            quote *= 1.25m;
        }

        // Full coverage adjustment
        if (insuree.CoverageType)
        {
            quote *= 1.50m;
        }

        // Set the final quote
        insuree.Quote = Math.Round(quote, 2);

        // Save to database
        db.Insurees.Add(insuree);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    return View(insuree);
}

ActionResult RedirectToAction(string v)
{
    throw new NotImplementedException();
}