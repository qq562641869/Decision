﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using StructureMap;

namespace Decision.Web.Infrastructure.IocConfig
{
    public class StructureMapSignalRDependencyResolver : DefaultDependencyResolver
    {

        private readonly IContainer _container;
        public StructureMapSignalRDependencyResolver(IContainer container)
        {
            _container = container;
        }

        public override object GetService(Type serviceType)
        {
            if (serviceType == null)
                return null;

            var service = base.GetService(serviceType);
            if (service != null) return service;


            return !serviceType.IsAbstract && !serviceType.IsInterface && serviceType.IsClass
                ? _container.GetInstance(serviceType)
                : _container.TryGetInstance(serviceType);
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances(serviceType).Cast<object>().Concat(base.GetServices(serviceType));
        }
    }
}