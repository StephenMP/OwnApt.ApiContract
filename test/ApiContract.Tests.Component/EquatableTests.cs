using OwnApt.Common.Dto;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace ApiContract.Tests.Component
{
    public class EquatableTests
    {
        #region Public Methods

        [Fact]
        public void CanEquateModels()
        {
            var assemblyName = new AssemblyName(nameof(ApiContract));
            var classTypes = Assembly.Load(assemblyName).GetTypes().Where(t => t != typeof(Equatable) && typeof(Equatable).IsAssignableFrom(t));

            foreach (var type in classTypes)
            {
                var orig = Activator.CreateInstance(type);
                var copy = Activator.CreateInstance(type);
                Assert.Equal(orig, copy);
            }
        }

        #endregion Public Methods
    }
}
