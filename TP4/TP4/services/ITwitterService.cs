using System;
using System.Collections.Generic;
using System.Text;
using TP4.models;

namespace TP4.services
{
    public interface ITwitterService
    {
        bool authenticate(String key, String secret);
        List<Tweet> getTweets();
    }
}
