using System;
using System.Collections.Generic;
using System.Collections.Specialized;
// ReSharper disable PossibleMistakenCallToGetType.2

namespace UniAgile.Testing
{
    public static class CollectionDataGeneration
    {
        public static Dictionary<string, TEnum> FeatureFlag<TEnum>(TEnum value)
            where TEnum : Enum
        {
            return new Dictionary<string, TEnum>()
            {
                {typeof(TEnum).GetType().ToString(), value}
            };
        }

        public static Dictionary<string, INotifyCollectionChanged> EmptyListenables()
        {
            return new Dictionary<string, INotifyCollectionChanged>();
        }
        
        public static Dictionary<string, INotifyCollectionChanged> Listenables(string key, INotifyCollectionChanged collectionChanged)
        {
            return new Dictionary<string, INotifyCollectionChanged>()
            {
                {
                    key, collectionChanged
                }
            };
        }
    }
}