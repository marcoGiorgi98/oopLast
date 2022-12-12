using System;
using System.Collections.Generic;

namespace Collections
{
    public class SocialNetworkUser<TUser> : User, ISocialNetworkUser<TUser>
        where TUser : IUser
    {
        private readonly IDictionary<string, ISet<TUser>> _followedUsers = new Dictionary<string, ISet<TUser>>();
        public SocialNetworkUser(string fullName, string username, uint? age) : base(fullName, username, age)
        {
        
        }


        public bool AddFollowedUser(string group, TUser user)
        {
            if(_followedUsers.ContainsKey(group)){
                var set = _followedUsers[group];
                return set.Add(user);
            }
            else{
                var set =new HashSet<TUser>();
                set.Add(user);
                _followedUsers[group]=set;
                return true;
            }
        }

        public IList<TUser> FollowedUsers
        {
            
            get
            {
                var set =new HashSet<TUser>();
              
                foreach(var grop in _followedUsers.Values ){
                    foreach (var us in grop)
                    {
                        set.Add(us);
                    }
                }
                return (IList<TUser>)set;     //oppure creo una lista
            }
        }

        public ICollection<TUser> GetFollowedUsersInGroup(string group)
        {
            if(_followedUsers.ContainsKey(group)){
                return new HashSet<TUser>(_followedUsers[group]);
                
            }
            else{
                var GropFollow2 =_followedUsers[group];
                return GropFollow2;
            }
             
             

        }
    }
}
