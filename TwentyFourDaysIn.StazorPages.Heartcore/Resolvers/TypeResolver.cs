using System;
using StazorPages.Heartcore.Resolvers;
using StazorPages.Models;
using TwentyFourDaysIn.StazorPages.Heartcore.Models;
using Umbraco.Headless.Client.Net.Delivery.Models;

namespace TwentyFourDaysIn.StazorPages.Heartcore.Resolvers
{
    public class TypeResolver : ITypeResolver
    {
        public IRetrievedContent GetTypedContent(Content content)
        {
            return content.ContentTypeAlias switch
            {
                Cafe.ContentTypeAlias => Cafe.MapToType(content),
                // truncated for brevity
                _ => throw new TypeLoadException($"Unknown type {content.ContentTypeAlias} encountered.")
            };
        }
    }
}