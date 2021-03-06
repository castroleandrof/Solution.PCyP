﻿using Domain.PCyP.Biz;
using Domain.PCyP.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PCyP.WebSite.Controllers
{
    public class CategoryController : Controller
    {

        // GET: Category
        public ActionResult Index()
        {
            var lista = CategoryBusiness.GetCategoryList();

            return View(lista);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category model)
        {
            try
            {
                // TODO: Add insert logic here
                CategoryBusiness.Add(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var lista = CategoryBusiness.GetCategoryList();
            Category category =  lista.Find(x => x.Id == id);

            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, string name) 
        {
            try
            {
                // TODO: Add update logic here
                var lista = CategoryBusiness.GetCategoryList();
                Category category = lista.Find(x => x.Id == id);
                category.name = name;
                category.ChangedOn = DateTime.Now;


                return RedirectToAction("Index");
            
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var lista = CategoryBusiness.GetCategoryList();
            Category category = lista.Find(x => x.Id == id);

            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var lista = CategoryBusiness.GetCategoryList();
                Category category = lista.Find(x => x.Id == id);
                lista.Remove(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
