using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaRelationShip
{
    class Students:List<Student>
    {
    }

    class Student
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public enumGenderTypes gender { get; set; }

        private Relations allRelations = new Relations();

        internal Relations AllRelations
        {
            get { return allRelations; }
            set { allRelations = value; }
        }

        public override string ToString()
        {
            return name + " " + lastname;
        }
    }
    enum enumGenderTypes
    {
        Male,Female
    }

    class Relations:List<Relation>
    { 
        
    }

    class Relation
    {
        public string studentInfo { get; set; }

        public override string ToString()
        {
            return studentInfo;
        }
    }
}
