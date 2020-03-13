﻿# Clicker application

Simple project that is a cross-platform application created with React and Ionic platform.

**Authors:**  
Siamion Piatrenka  
Aliaksei Tsymbalist  
Yauheni Lazakovich

При загрузке приложения пользователю доступны регистрация или вход в систему для уже существующих пользователей. 

После входа в систему пользователю предлагается три режима игры на выбор:  
**Single player**  
**Multiplayer**  
**Blitz**  

Single player  
Игрок имеет возможность кликать на изображение яблока, зарабатывая очки за каждый клик. Заработанные очки можно менять на “бустеры” - автоматически кликающие боты. В ходе игры цена на бустеры вырастает. Пользователю доступна кнопка просмотра таблицы рекордов в данном режиме. 

Multiplayer  
Игроку предоставляется выбрать количество участников (2-5) для игры. Каждому игроку будет дана минута, чтобы он накликал максимально возможное количество очков. Когда последний игрок закончит раунд, выводится таблица результатов

Blitz  
В данном режиме в течение минуты на экране с интервалом 2 секунды одновременно появляются изображение помидора и изображение яблока в произвольном месте, и пользователю необходимо нажимать на яблоко, чтобы изображения появились снова и чтобы заработать очки. При нажатии на помидор игра заканчивается преждевременно. После игры на экран выводится таблица с лучшими результатами данного пользователя. После каждых 10 нажатий интервал смены положения изображений уменьшается.
В приложении используется база данных для хранения достижений каждого пользователя, а также для его персональных данных.

Используемые технологии:  
.NET Framework  
JavaScript  

Как запустить:  
* Скачайте .NET Framework 2.2 на ваш компьютер по ссылке:
https://dotnet.microsoft.com/download/dotnet-core/2.2  
* Откройте Windows PowerShell
* Перейдите в папку проекта, в папку PC.
* Bведите dotnet run

Теперь приложение запущено и доступно по адресу **localhost:5000**

При регистрации пользователя использовать в пароле заглавные и прописные
 латинские буквы, цифры, специальные символы.

