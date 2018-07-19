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
