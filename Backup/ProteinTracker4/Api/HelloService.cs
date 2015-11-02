﻿using ServiceStack;
using ServiceStack.Configuration;
using ServiceStack.Web;
using ServiceStack.Host;

namespace ProteinTracker4.Api
{
    public class HelloService : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }

    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}