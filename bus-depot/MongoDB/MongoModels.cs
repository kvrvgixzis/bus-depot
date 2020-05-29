using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace bus_depot {
    public partial class Driver {
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
        public Driver() {
            Id = ObjectId.GenerateNewId();
            Schedule = new List<string>();
        }
    }

    public partial class Route {
        /*
         * id,
         * номер,
         * начальный пункт,
         * конечный пункт,
         * начало движения,
         * конец движения,
         * интервал движения,
         * протяженность (минуты).
         */
        [BsonId]
        public ObjectId Id { get; set; }
        public int Number { get; set; }
        public string StPoint { get; set; }
        public string EndPoint { get; set; }
        public string StTime { get; set; }
        public string EndTime { get; set; }
        public int Interval { get; set; }
        public int Length { get; set; }
        public Route() {
            Id = ObjectId.GenerateNewId();
        }
    }

    public partial class Bus {
        /*
         * id,
         * номер,
         * тип,
         * вместимость,
         * водитель (ключ),
         * исправность.
         */
        [BsonId]
        public ObjectId Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public int Сapacity { get; set; }
        public bool IsWorking { get; set; }
        public Bus() {
            Id = ObjectId.GenerateNewId();
        }
    }


}
