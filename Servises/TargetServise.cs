using MossadAgentsMVC.Enums;
using MossadAgentsMVC.Models;

namespace MossadAgentsMVC.Servises
{
    public class TargetServise
    {
        public int GetNumOfTargets(Target[] targets)
        {
            return targets.Length;
        }

        public int GetNumOfDeadtargets(Target[] targets)
        {
            int count = 0;
            foreach (var target in targets)
            {
                if(target.Status == TargetStatus.Dead)
                {
                    count ++;
                }
            }
                return count;
        }
    }
}
