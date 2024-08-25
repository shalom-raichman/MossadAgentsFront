﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MossadAgentsMVC.Models;
using System.Text.Json;

namespace MossadAgentsMVC.Controllers
{
    public class MissionController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();


        // GET: MissionController
        public async Task<ActionResult> Missions()
        {
            var missions = await _httpClient.GetFromJsonAsync("http://localhost:5217/api/Missiion", typeof(Mission[]));
            //Mission[] missions = JsonSerializer.Deserialize<Mission[]>(missionJson);
            return View(missions);
        }

        // GET: MissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MissionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MissionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MissionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
