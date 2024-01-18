# ShoeStore
Это Web-API импромизироавнного магазина обуви. В качестве плтформы для разработки использовалась ASP.NET Core, а все данные хранятся в базе данных под управлением СУБД PostrgeSQL.
### Использованные технологии и библиотеки
.NET 8.0, ASP.NET Core 8.0, EFCore 8.0, MediatR 12.2.0 , FluentValidation 11.9.0, AutoMapper 12.0.1, Docker, Docker Compose
## Запуск
1. Клонировать текущий репозиторий
2. Перейти в папку с проектом
3. Выполнить команду ниже:
```
    docker compose up
```
Чтобы зайти в Swagger UI можно перейти по адресу:
```
http://localhost:5000/swagger
```
## Описание эндпоинтов
Все эндпоинты описаны в документации Swagger UI, доступной по адресу http://localhost:5000/swagger

![image](https://github.com/XeeRooX/ShoeStore/assets/91987012/93cff13b-64b9-4707-b884-db401f8fd3ff)

Здесь же их можно протестировать.

![image](https://github.com/XeeRooX/ShoeStore/assets/91987012/c9323f7f-df87-419f-a6b3-18baca471484)
## Конфигурация
Вся основная конфигурация хранится в переменных окружения, которые можно назначить в файле docker-compose.yml в блоке environment. Все переменные, описанные в этом блоке, стандартные кроме нескольких:
- ConnectionStrings__DefaultConnection - хранит в себе значение строки подключения к базе данных
- GenerateDemoData - переменная типа bool, которая при значении true создает демо данные в БД. По умолчанию true.
