﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
        public Monster(int id, string name, int currentHitPoints, int maximumHitPoints, int maxDamage, int rewardExp, int rewardGold) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExp;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}