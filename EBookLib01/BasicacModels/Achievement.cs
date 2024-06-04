using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicacModels
{
    [Serializable]
    public class Achievement
    {
        public int Id { get; set; }
        public string AchievementName { get; set; }
        public string Description { get; set; } 

        public virtual List<UserAchievement> UserAchievements { get; set; }
    }
}
