using System;
using System.Collections.Generic;
using System.Text;

namespace BankHeist
{
    class TeamMember
    {
        private int _skillLevel;
        private double _courageFactor;
        public string Name { get; set; }
        public int SkillLevel {
            get
            {
                return _skillLevel;
            }
            set
            {
                if (value > 0)
                {
                    _skillLevel = value;
                }
            }
        }
        public double CourageFactor {
            get
            {
                return _courageFactor;
            }
            set
            {
                if (value >= 0.0 && value <= 2.0)
                {
                    _courageFactor = value;
                }
            }
        }

        public TeamMember(string name)
        {
            Name = name;
        }
    }
}
