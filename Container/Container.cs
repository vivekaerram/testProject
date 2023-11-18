using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _bindings;

        public Container()
        {
            _bindings = new Dictionary<Type, Type>();
        }

        public void Bind(Type interfaceType, Type implementationType)
        {
            if (!interfaceType.IsAssignableFrom(implementationType))
            {
                throw new ArgumentException($"Type {implementationType.Name} must implement {interfaceType.Name}.");
            }

            _bindings[interfaceType] = implementationType;
        }

        public T Get<T>()
        {
            Type serviceType = typeof(T);

            if (!_bindings.TryGetValue(serviceType, out Type implementationType))
            {
                throw new InvalidOperationException($"No binding found for type {serviceType.Name}.");
            }

            return (T)Activator.CreateInstance(implementationType);
        }
    }
}
