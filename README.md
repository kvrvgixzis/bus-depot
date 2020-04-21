# Курсовая работа РГППУ Парфенов Н.А. ООП 2020г.
> Вариант 6: Автобусный парк
> Требуется разработать программную систему, предназначенную для диспетчера
> автобусного парка. 

**Использовано:**
- C# using Visual Studio
- MongoDB using NoSQLBooster

## Модели базы данных MongoDB:

```csharp
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

    public partial class Route
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Number { get; set; }
        public string StPoint { get; set; }
        public string EndPoint { get; set; }
        public DateTime StTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Interval { get; set; }
        public int Length { get; set; }
        public Route()
        {
            Id = ObjectId.GenerateNewId();
        }
    }

    public partial class Bus
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public int Сapacity { get; set; }
        public ObjectId DriverId { get; set; }
        public bool IsWorking { get; set; }
        public Bus()
        {
            Id = ObjectId.GenerateNewId();
        }
    }


}
```

## Приложение

### Роли
- Диспетчер (reader:reader)
- Директор (admin:admin)

### Функции:
- Корректировка таблиц
- Добавление новых записей в таблицы
- Вывод списков по таблицам

**Информация к отображению:**

- Список водителей, работающих на определенном маршруте с указанием графика их работы.
- Какие автобусы обслуживают данный маршрут.
- Протяженность маршрутов и их минимальная, и максимальная протяженность.
- На каком маршруте работает водитель с максимальным стажем.
- Какова общая протяженность маршрутов, обслуживаемых автопарком.
- Какие водители не вышли на линию по причине неисправности автобуса. 

**Директор:**
- добавить водителя,
- добавить автобус,
- удалить водителя,
- удалить автобус.
