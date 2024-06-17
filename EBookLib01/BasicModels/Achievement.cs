using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBookLib01.BasicModels;

namespace EBookLib01.BasicModels
{
  
    public class Achievement
    {
        public int Id { get; set; }
        public string AchievementName { get; set; }
        public string Description { get; set; } 

        public virtual List<UserAchievement> UserAchievements { get; set; }
    }
}
