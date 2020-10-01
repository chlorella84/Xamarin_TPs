using System;
using System.Collections.Generic;
using System.Text;
using TP6.Models;

namespace TP6.Services
{
    interface ITwitterService
    {
        bool Authenticate(string login, string password);

        List<Tweet> GetTweets();
    }
}
