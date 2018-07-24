# Visual Editor Core

## Полезные команды для разработки:

### Unix

* `dotnet run` - пуск!
* `dotnet watch run` - пуск с автоматическим перезапуском.
* `dotnet add package <пакет>` - добавить пакет в список зависимостей.
  Если пакет - это не библиотека для проекта, а набор инструментов для dotnet, то нужно перенести `PackageReference` вниз в группу `DotNetCliToolReference` и исправить тег.
* `dotnet restore` - установить все зависимости.
* `dotnet ef migrations add <название>` - сгенерировать миграцию БД.
* `dotnet ef database update` - применить все миграции.
* `dotnet aspnet-codegenerator controller -name <название контроллера> -namespace CoreEditor.Controllers -outDir Controllers -async -m <используемая модель> -dc CoreEditorContext -udl` - сгенерировать CRUD-контроллер.
* `setx ASPNETCORE_ENVIRONMENT "<имя среды>"` - изменение переменной среды: Development/Production

## Порядок создания миграций:

* Написать модель
* В CoreEditorContext.cs добавить строку `public DbSet<Название модели> Название модели во множественном числе { get; set; }`
* Выполнить команду `dotnet ef migrations add <Название миграции>`
* Проверить сгенерированные файлы в папке `Migrations`
* Выполнить команду `dotnet ef database update`

### Отмена миграций

Для отмены последней примененной миграции необходимо выполнить команду `dotnet ef database update <Название предпоследней миграции>` и удалить файлы в папке `Migrations` связанные с последней миграцией.
