﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.SharedResources.ResourceItems
{
    public class DefaultResourceItemContentConverter : IResourceItemContentConverter, ITransientDependency
    {
        public virtual Task<string> GetConvertedContentAsync(string originalContent)
        {
            return Task.FromResult(originalContent);
        }
    }
}