using MossadAgentsMVC.Enums;
using MossadAgentsMVC.Models;

namespace MossadAgentsMVC.Servises
{
    public class AgentsServise
    {
        public int GetNumOfAgents(Agent[] agents)
        {
            return agents.Length;
        }

        public int NumOfActiveAgents(Agent[] agents)
        {
            int count = 0;
            foreach (var agent in agents)
            {
                if (agent.Status == AgentStatus.OnMission)
                {
                    count++;
                }
            }
            return count;
        }

        
    }
}
