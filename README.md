![GitHub repo size](https://img.shields.io/github/repo-size/kvrvgixzis/bus-depot)
# Курсовая работа РГППУ Парфенов Н.А. ООП 2020г.
> Вариант 6: Автобусный парк
> Требуется разработать программную систему, предназначенную для диспетчера
> автобусного парка. 

**Использовано:**
- C# using Visual Studio
- MongoDB using NoSQLBooster

## ~~TODO~~

- [x] Установка и настройка MongoDB на Windows 10
- [x] Создание двух пользователей с разными правами
- [x] Создание класса C# для взаимодейтсвия с базой данных
- [x] Создание моделей коллекций MongoDB в C#
- [x] Реализовать логин
- [x] Создать форму главной страницы
- [x] Реализовать отображение коллекций на главной странице
- [x] Реализовать удаление выделенной записи по кнопке
- [x] Реализовать добавление нового маршрута
- [x] Реализовать добавление нового автобуса
- [x] Реализовать добавление нового водителя
- [x] Реализовать редактирование маршрута
- [x] Реализовать редактирование автобуса
- [x] Реализовать редактирование водителя
- [x] Отображение сводной информации
- [x] Сделать .gitignore
- [x] Выгрузить базу на удаленный сервер


## Подключение к базе данных

### Кнопка логина

```csharp
    private void loginBtn_Click(object sender, EventArgs e)
    {
        string login = loginInput.Text;
        string pwd = pwdInput.Text;
        MongoTools database = Program.Login(login, pwd);
        if (MongoTools.isConnect)
        {
            if (login == "admin") {
                MongoTools.isAdmin = true;
            }
            MainForm mainForm = new MainForm(database);
            mainForm.Show();
            this.Hide();
        }
        else
        {
            loginBtn.ForeColor = Color.FromName("red");
            loginBtn.Text = "Неверный логин или пароль. Попробуйте снова!";
        }
    }
```

### Подключение

```csharp
    static public MongoTools Login(string login, string pwd)
    {
        var connectionString = $"mongodb://{login}:{pwd}@94.230.138.242:49563/?authSource=bus_depot";
        const string databaseName = "bus_depot";
        MongoTools database = new MongoTools(connectionString, databaseName);
        return database;
    }
```

### Проверка логина

```csharp
    public MongoTools(string connectionString, string databaseName)
    {
        //Create new database connection
        var client = new MongoClient(connectionString);
        db = client.GetDatabase(databaseName);
        try {
            isConnect = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
        } catch {
            isConnect = false;
        }
    }
```

## Модели базы данных MongoDB | MongoDB Models:
### **Водитель** *Driver*

| Id | Last Name | Name | Patronymic | Grade | Experience | Salary | Bus Id | Route Id | Schedule |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `ObjectId` | `string` | `string` | `string` | `int` | `int` | `float` | `ObjectId` | `ObjectId` | `List<string>` |
| 5eac42... | Парфенов | Андриан | Геннадьевич | 1 | 5 | 30000 | 5eac42... | 5eac42... | "Пн", "Вт", "Чт", "Пт" |


```csharp
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
```
### **Маршрут** *Route*

| Id | Number | Start Point | End Point | Start Time | End Time | Interval | Lenght |
| --- | --- | --- | --- | --- | --- | --- | --- |
| `ObjectId` | `int` | `string` | `string` | `string` | `string` | `int` | `int` |
| 5ea47... | 25 | Технопарк | ТЦ МЕГА | 06:00 | 20:00 | 25 | 840 |

```csharp
    public partial class Route
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Number { get; set; }
        public string StPoint { get; set; }
        public string EndPoint { get; set; }
        public string StTime { get; set; }
        public string EndTime { get; set; }
        public int Interval { get; set; }
        public int Length { get; set; }
        public Route()
        {
            Id = ObjectId.GenerateNewId();
        }
    }
```
### **Автобус** *Bus*

| Id | Number | Type | Capacity | Is Working |
| --- | --- | --- | --- | --- |
| `ObjectId` | `string` | `string` | `int` | `bool` |
| 5e9f0a... | a001aa | Автолайн | 13 | true |

```csharp
    public partial class Bus
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public int Сapacity { get; set; }
        public bool IsWorking { get; set; }
        public Bus()
        {
            Id = ObjectId.GenerateNewId();
        }
    }
```

## Приложение | Application:

### Роли:
- **Диспетчер:**
    login:pwd: (reader:reader)
    права доступа: read-only
- **Администратор:**
    login:pwd: (admin:admin)
    права доступа: read-write
    
### Интерфейс:
- Логин:

![login_screen](images/login_screen.jpg)
![wrong_login_screen](images/wrong_login_screen.jpg)
- Главный экран:

![main_screen](images/main_screen.jpg)
- Добавление:

![add_route_screen](images/add_route_screen.jpg)
![add_bus_screen](images/add_bus_screen.jpg)
![add_driver_screen](images/add_driver_screen.jpg)

### Функции:
**Корректировка коллекций:**
- Добавление документов в коллекцию MongoDB:
```csharp
    public void InsertDocument<T>(string collectionName, T document)
        {
            var collection = db.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
```
- Удаление документов из коллекции MongoDB:
```csharp
    public void DeleteDocument<T>(string collectionName, ObjectId id)
        {
            var collection = db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
```
**Чтение данных из коллекций:**
- Получить все документы коллекции MongoDB:
```csharp
    public List<T> LoadAllDocuments<T>(string collectionName)
        {
            var collection = db.GetCollection<T>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }
```
- Получить документ из коллекции MongoDB по ObjectId:
```csharp
    public T LoadDocumentById<T>(string collectionName, ObjectId id)
        {
            var collection = db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }
```
