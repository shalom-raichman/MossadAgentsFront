using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MossadAgentsMVC.Models;
using MossadAgentsMVC.Servises;
using MossadAgentsMVC.ViewModeles;
using System.Net.Http;

namespace MossadAgentsMVC.Controllers
{
    public class DeshboardController : Controller
    {

        private HttpClient _httpClient = new HttpClient();
        private readonly AgentsServise _agentsServise;
        private readonly TargetServise _targetServise;
        private readonly MissionServise _missionServise;


        public DeshboardController(AgentsServise agentsServise, TargetServise targetServise, MissionServise missionServise)
        {
            _agentsServise = agentsServise;
            _targetServise = targetServise;
            _missionServise = missionServise;
        }

        // GET: DeshboardController1
        public async Task<ActionResult> DeshboardView()
        {
            var agents = await _httpClient.GetFromJsonAsync("http://localhost:5217/Agents", typeof(Agent[]));
            var targets = await _httpClient.GetFromJsonAsync("http://localhost:5217/Targets", typeof(Target[]));
            var Missions = await _httpClient.GetFromJsonAsync("http://localhost:5217/Missions", typeof(Mission[]));

            
            //Deshboard.NumOfAgents = _agentsServise.GetNumOfAgents(agents);

            return View();
        }

        // GET: DeshboardController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeshboardController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeshboardController1/Create
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

        // GET: DeshboardController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeshboardController1/Edit/5
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

        // GET: DeshboardController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeshboardController1/Delete/5
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
