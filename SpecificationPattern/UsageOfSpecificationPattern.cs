using System.Collections.Generic;
using System.Linq;

namespace SpecificationPattern
{
    public class UsageOfSpecificationPattern
    {
        public static void Run()
        {
            var users = new List<User>()
            {
                new User() { Name = "Ali", Age = 18, Gender = "Male"},
                new User() { Name = "Hasan", Age = 20, Gender = "Male"},
                new User() { Name = "Merve", Age = 22, Gender = "Female"}
            };

            var maleExpSpec = new ExpressionSpecification<User>(x => x.Gender == "Male");
            var maleUsers = users.Where(maleExpSpec.IsSatisfiedBy);

            var ageGreatherThan19ExpSpec = new ExpressionSpecification<User>(x => x.Age > 19);
            var ageGreatherThan19Users = users.Where(ageGreatherThan19ExpSpec.IsSatisfiedBy);

            var complexSpec = maleExpSpec.And(ageGreatherThan19ExpSpec);
            var filteredUsers = users.Where(complexSpec.IsSatisfiedBy);
        }
    }
}