using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    internal class Course
    {
        private List<Group> _groups = new List<Group>();

        public List<Group> Groups { get { return _groups; } }

        public void Add(Group group)
        {
            if (group.AvgPoint >= 70)
            {
                _groups.Add(group);
            }
        }
    }
}
