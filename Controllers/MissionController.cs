using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MossadAgentsMVC.Models;
using Newtonsoft.Json;
using System.Text;
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

        // PUT: MissionController/{id}/status
        public async Task<ActionResult> SetMission(int id)
        {

            var data = new
            {
                Name = "John Doe",
                Age = 30
            };

            // Serialize the data object to a JSON string
            var jsonData = JsonConvert.SerializeObject(data);

            // Create a StringContent object to send as the request body, with the appropriate content type (here, JSON)
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"http://localhost:5217/api/Missiion/{id}/status", content);

            return RedirectToAction("Missions");
        }

        // GET: MissionController/Details/5
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            var mission = await _httpClient.GetFromJsonAsync($"http://localhost:5217/api/Missiion/{id}", typeof(Mission));
            return View(mission);
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
