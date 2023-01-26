using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace FreeCourseServices.Catalog.Model
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        [BsonIgnore] //MongoDB'deki collectionlara satır olarak yansıtırken bunu gözardı et
        public Category Category { get; set; }

    }
}
