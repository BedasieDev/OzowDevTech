﻿using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using Unity;

namespace OzowDevAssessment
{
    public class UnityResolver
    {
        private IUnityContainer container;

        public T Resolve<T>() where T : class
        {
            var resolvedObject = default(T);

            if (container == null)
            {
                container = LoadConfiguration();
            }

            try
            {
                resolvedObject = container.Resolve<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unity Resolver Error:\n{ex}");
            }

            return resolvedObject;
        }

        private IUnityContainer LoadConfiguration()
        {
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            IUnityContainer container = new UnityContainer();
            section.Configure(container);

            return container;
        }
    }
}