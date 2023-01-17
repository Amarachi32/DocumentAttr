using Document.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.Attributes
{
    [AttributeUsage(AttributeTargets.All | AttributeTargets.Enum)]
    public class DocumentAttribute : Attribute
    {
        //private object? input;
        
        private readonly object? output;
        private string _cohort;
        private string _firstname;
        private string _lastname;
        public string Description { get; set; }
        public string Cohort { get; set; }

        public Scream Scream { get; set; }
        //public object? Input { get; private set; }
        public object? Output { get; private set; }
        public string Fullname { get {return $"firstname: { _firstname}, lastname: {_lastname}";}
            set { Fullname = value; } }
        public int Age { get; set; }

        public DocumentAttribute( string description = "A software engineering training program", string cohort = "3.0", string fullname = "Emeka Eze", int age = 1, Scream scream = Scream.GodAbeg)
        {
            Description = description;
            Cohort = cohort;
            Fullname = fullname;
            //Fullname = $"firstname: {_firstname}, lastname: {_lastname}";
            Age = age;
            //Output = output;
        }

/*        public DocumentAttribute(string Description)
        {
            this.Description = Description;
        }*/
    }
}
