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

        // GET: DeshboardController
        // תצוגה כללית
        public async Task<ActionResult> OverallView()
        {
            var agents = await _httpClient.GetFromJsonAsync<Agent[]>("http://localhost:5217/Agents");
            var targets = await _httpClient.GetFromJsonAsync<Target[]>("http://localhost:5217/Targets");
            var missions = await _httpClient.GetFromJsonAsync<Mission[]>("http://localhost:5217/Mission");

            Deshboard deshboard = new Deshboard();
            deshboard.NumOfAgents = _agentsServise.GetNumOfAgents(agents);
            deshboard.NumOfActiveAgents = _agentsServise.NumOfActiveAgents(agents);
            deshboard.NumOfTargets = _targetServise.GetNumOfTargets(targets);
            deshboard.NumOfDeadTargets = _targetServise.GetNumOfDeadtargets(targets);
            deshboard.NumOfMissions = _missionServise.GetNumOfMissions(missions);
            deshboard.NumOfActiveMissions = _missionServise.GetNumOfActiveMissions(missions);
            deshboard.NumOfPrroposeMissions = _missionServise.GetnumOfProposeMissions(missions);


            return View(deshboard);
        }
        
        // GET: DeshboardController
        // agents status
        public async Task<ActionResult> AgentsView()
        {
            var agents = await _httpClient.GetFromJsonAsync<Agent[]>("http://localhost:5217/Agents");



            return View(agents);
        }
        
        // GET: DeshboardController
        // targets status
        public async Task<ActionResult> TargetsView()
        {
            var targets = await _httpClient.GetFromJsonAsync<Target[]>("http://localhost:5217/Targets");



            return View(targets);
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
