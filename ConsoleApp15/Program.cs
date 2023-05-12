namespace ConsoleApp15
{
    internal class Program
    {
        // Pause til 14:04
        static void Main(string[] args)
        {
            /*
                 let terje1 = {
                    firstName: 'Terje',
                    birthYear: 1975,
                 }          
             */
            var terje1 = new Person();
            terje1.FirstName = "Terje";
            terje1.BirthYear = 1975;

            /*
                 let terje2 = {};
                 terje2.firstName = 'Terje';
                 terje2.birthYear= 1975;             
             */
            var terje2 = new Person
            {
                FirstName = "Terje",
                BirthYear = 1975
            };

            /*
              let model = {
                 person: {
                    firstName: 'Terje',
                    birthYear: 1975,
                 }
              };
             */
            var oldModel = new OldModel
            {
                Person = new Person
                {
                    FirstName = "Terje",
                    BirthYear = 1975
                }
            };

            /*
              let model = {
                 currentUser: 'terje',
                 people: [
                     {
                        firstName: 'Terje',
                        birthYear: 1975,
                     }
                 ]
              };
             */

            //Person[] people = null;
            //Console.WriteLine(people);

            //var model = new Model();
            //Console.WriteLine(model.People);
            var model = new Model
            {
                CurrentUser = "Terje",
                People = new Person[] {
                        new Person
                        {
                            FirstName = "Terje",
                            BirthYear = 1975
                        }
                    }
            };
        }
    }
}


/*
 metoder
 constructor
 innkapsling
 properties ({get;set;})


 */

