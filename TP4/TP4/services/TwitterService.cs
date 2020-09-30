using System;
using System.Collections.Generic;
using System.Text;
using TP4.models;


namespace TP4.services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string username, string password)
        {
            if (username.Equals("Dominika") && password.Equals("blupblup"))
            {
                return true;
            }

            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet() { creationDate = "30 septembre 2020 13:48", identifier = "5456411564894", userIdentifier = "651561", userName = "name", userPseudo = "chlorella" });
            tweets.Add(new Tweet() { creationDate = "30 septembre 2020 13:48", identifier = "5456411564894", userIdentifier = "651561", userName = "name", userPseudo = "chlorella" });
            tweets.Add(new Tweet() { creationDate = "30 septembre 2020 13:48", identifier = "5456411564894", userIdentifier = "651561", userName = "name", userPseudo = "chlorella" });
            tweets.Add(new Tweet() { creationDate = "30 septembre 2020 13:48", identifier = "5456411564894", userIdentifier = "651561", userName = "name", userPseudo = "chlorella" });
            
            
            return tweets;
        }
    }
}
