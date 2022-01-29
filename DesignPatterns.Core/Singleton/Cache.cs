using System;
using System.Collections.Concurrent;

namespace DesignPatterns.Core.Singleton;

internal class Cache
{
    private static int instanceCount = 0;

    private static object cacheLock = new object();

    private Cache() 
    {
        
    }

    public static IMessage? Message { get; set; } = null;

    private static Cache? instance = null;
    public static Cache Instance
    {
        get
        {
            lock (cacheLock)
            {
                if (instance == null)
                {
                    Message?.Write($"New cache object is creating ({instanceCount++})...");
                    instance = new Cache();
                }
            }
            return instance;
        }
    }
}
