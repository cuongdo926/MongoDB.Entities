﻿using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDB.Entities
{
    /// <summary>
    /// Indicates that this property should be ignored when this class is persisted to MongoDB.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreAttribute : BsonIgnoreAttribute { }   
}