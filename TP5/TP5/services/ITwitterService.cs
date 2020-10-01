using System;
using System.Collections.Generic;
using System.Text;
using TP5.models;

namespace TP5.services
{
    public interface ITwitterService
    {
        bool authenticate(String key, String secret);
        List<Tweet> getTweets();
    }
}
