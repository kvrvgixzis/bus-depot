using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace bus_depot
{
    public partial class Driver
    {
        /*
         * id,
         * ФИО,
         * класс,
         * стаж,
         * оклад (вычисляемое),
         * автобус (id),
         * маршрут (id),
         * график (список дней недели).
         */
        [BsonId]
        public ObjectId Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Grade { get; set; }
        public int Experience { get; set; }
        public float Salary { get; set; }
        public ObjectId BusId { get; set; }
        public ObjectId RouteId { get; set; }
        public List<string> Schedule { get; set; }
        public Driver()
        {
            Id = ObjectId.GenerateNewId();
            Schedule = new List<string>();
        }
    }

    
}
