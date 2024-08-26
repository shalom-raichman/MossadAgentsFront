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

        public int GetnumOfProposeMissions(Mission[] missions) 
        {
            int count = 0;
            foreach (var mission in missions)
            {
                if(mission.Status == MissionStatus.Proposal)
                {
                    count++;
                }
            }
            return count;
        }
        
        public List<Mission> GetProposeMissions(Mission[] missions) 
        {
            List<Mission> list = new List<Mission>();
            foreach (var mission in missions)
            {
                if(mission.Status == MissionStatus.Proposal)
                {
                    list.Add(mission);
                }
            }
            return list;
        }
    }
}
