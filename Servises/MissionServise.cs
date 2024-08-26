using MossadAgentsMVC.Enums;
using MossadAgentsMVC.Models;

namespace MossadAgentsMVC.Servises
{
    public class MissionServise
    {
        public int GetNumOfMissions(Mission[] missions )
        {
            return missions.Length;
        }

        public int GetNumOfActiveMissions(Mission[] missions)
        {
            int count = 0;
            foreach (var mission in missions)
            {
                if (mission.Status == MissionStatus.AssignmentToTask)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
