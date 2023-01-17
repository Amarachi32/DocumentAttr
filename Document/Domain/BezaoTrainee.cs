using Document.Enum;
using Document.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.Domain
{
    [Document]
    internal class BezaoTrainee
    {
        //[Document(Description = "this sets and gets the trainee fullname")]
        [Document]
        public string Fullname { get; set; }

        // [Document(Description = "this sets and gets the trainee Age")]
        [Document]
        public string Age { get; set; }

        //[Document(Description = "this sets and gets the trainee Age")]
        //[Document(Description = "this initializes  the bezaoTrainee with a fullname"), Input = "it takes a fullname as string"]
        [Document("Amara Chuwkwu")]

        public BezaoTrainee(string fullname)
        {
            Fullname = fullname;
        }

        // [Document(Description = "this makes the trainee quiet when sth strange happens", Input = "it takes in something strange as an object")]
        [Document(Scream = Scream.GodAbeg)]

        internal void Code(object somethingStrange)
        {
            Console.WriteLine($"this makes the trainee code {Scream.HeyGod} when an idea comes up");
        }

        // [Document(Description = "this makes the trainee code when an idea comes up", Input = "it takes in something strange as an object"), Output = "it returns an object]
        [Document(Scream = Scream.Omo)]
        internal object code(object someIdea)
        {

            return "something strage";
        }
    }
}
