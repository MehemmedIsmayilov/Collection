using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SocialMedia
    {
        private Dictionary<string, List<string>> friends;

        public SocialMedia()
        {
            friends = new Dictionary<string, List<string>>();
        }

        public Dictionary<string, List<string>> Friends
        {
            get { return friends; }
        }

        
        public void AddFriend(string username, string friendUsername)
        {
            if (!friends.ContainsKey(username))
            {
                friends[username] = new List<string>();
            }

            if (!friends[username].Contains(friendUsername))
            {
                friends[username].Add(friendUsername);
            }
        }

        
        public void RemoveFriend(string username, string friendUsername)
        {
            if (friends.ContainsKey(username))
            {
                friends[username].Remove(friendUsername);
            }
        }

        
        public List<string> GetAllFriendsByUsername(string username)
        {
            if (friends.ContainsKey(username))
            {
                return friends[username];
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
