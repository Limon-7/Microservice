﻿using Catalog.Domain.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Domain.Entities;

public class ProductType : AuditableEntity
{
    [BsonElement("Name")] public string Name { get; set; }
}