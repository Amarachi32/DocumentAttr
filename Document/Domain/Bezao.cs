using Document.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.Domain
{
    public class Bezao
    {
        // [Document("desciption =  this gets and sets bezao cohort") ]
        [Document]
        public string Cohort { get; set; }


        // [Document("3.0"), Input = "it initializes bezao with cohort", input = "it takes a cohort as a string"]
        [Document("3.0.1")]
        public Bezao(string cohort)
        {
            Cohort = cohort;
        }
    }
}
