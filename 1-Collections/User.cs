using System;

namespace Collections
{
    public class User : IUser
    {
        public User(string fullName, string username, uint? age)
        {
           
            Age = age;
            Username =username ??
                       throw new ArgumentNullException($"The {nameof(username)} argument cannot be null");
            FullName=fullName;
        }
        
        public uint? Age { get; }
        
        public string FullName { get; }
        
        public string Username { get; }

        public bool IsAgeDefined => throw new NotImplementedException("TODO check whether age is non-null or not");

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }


        // TODO implement missing methods (try to autonomously figure out which are the necessary methods)
    }
}
