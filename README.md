![GitHub last commit](https://img.shields.io/github/last-commit/MindTrader/GuessMelody?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/MindTrader/GuessMelody?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/MindTrader/GuessMelody?style=for-the-badge)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/MindTrader/GuessMelody?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/MindTrader/GuessMelody?style=for-the-badge)

# GuessMelody
Данное приложение представляет собой интерактивную игру "Угадай мелодию" для двоих человек. Цель - набрать наибольшее количество очков к концу игры. Очки начисляются игрокам за верно угаданную композицию. С помощью настроек приложения можно разнообразить игровой процесс включением/выключение различных встроенных механик игры.

Целевая платформа - .Net Framework 4.6.1

Приложение имеет графический пользовательский интерфейс, реализованный с использованием Windows Forms

## Описание работы приложения
При первом запуске приложения на экране появится окно с инструкцией, где игроки могут ознакомиться со всеми правилами и возможностями игры. 

<p align="center"><img src="ScreenShots/faq.jpg" alt="FAQ" title="FAQ"/></p>

После закрытия инструкции на экране появится главное окно приложения. Там пользователь при необходимости может ещё раз ознакомиться с инструкцией, открыть настройки игры, запустить игру.

<p align="center"><img src="ScreenShots/main.jpg" alt="Главное окно" title="Главное окно"/></p>

При первом запуске приложения пользователю необходимо будет запустить настройки, где ему будет необходимо указать папку с музыкой для дальнейшей игры, а также настроить игру максимально удобно для себя и своего соперника

<p align="center"><img src="ScreenShots/settings.jpg" alt="Настройки" title="Настройки"/></p>

После нажатия кнопки "Сохранить" все настройки сохраняются в реестр - вам не нужно будет каждый раз настраивать приложение заново.

Если при первом запуске пользователь не настроил папку для музыки, а вместо этого решил сразу запустить игру, то он получит ошибку. Игра не запустится, пока пользователь не выберет музыку.

<p align="center"><img src="ScreenShots/startErr.jpg" alt="Ошибка запуска игры" title="Ошибка запуска игры"/></p>

Когда пользователь всё-таки настроит игру согласно инструкции и запустит её, то на экране появится новое окно, где будут отображаться имена игроков (их можно также изменить в настройках), количество очков рядом с их именами, индикатор доступности ответа (на картинке ниже горит зелёным цветом) - не допускает возможности ответа одного игрока более 1 раза подряд при неверном ответе (для удобства игроков реализовано светофором, при невозможности ответа загорается красным), также кнопки "+" и "-" около количества очков каждого игрока для их ручного изменения, ниже указано время в секундах до конца ответа по текущей мелодии, ещё ниже - индикатор длительности игры - изображает время до конца игры. Также ниже можно увидеть кнопки с возможность приостановить игру, продолжить и включить следующую композицию, если ни один из игроков не может угадать текущую

<p align="center"><img src="ScreenShots/game.jpg" alt="Игра" title="Игра"/></p>

В процессе игры, если какой-то игрок хочет ответить, то ему следует нажать на настроенную для себя горячую клавишу ответа, тогда появляется окно для ответа с таймером, чтобы игрок особо не затягивал. Также возле имени отвечающего игрока загорится красный свет. После того, как он ответил, ему можно проверить, нажав на "Space" (пробел), чтобы показать верный ответ

<p align="center"><img src="ScreenShots/showAns.jpg" alt="Показать ответ" title="Показать ответ"/></p>

И далее необходимо выбрать верно ли ответил игрок или нет. Если игрок ответил верно, то ему будут автоматически начислены очки за верный ответ, иначе, в зависимости от настроек игры, игроку может ничего не начислиться или у него могут сгореть очки за неверный ответ. Данная возможность игры позволяет играть в неё двум игрокам без судьи. Однако, в игру можно подключить третьего человека, который рассудит игроков при их ответе и сам будет начислять игрокам очки.

После того, как игроки прослушают все выбранные в настройках композиции, на экран выведется сообщение об этом

<p align="center"><img src="ScreenShots/complete.jpg" alt="Песни закончились" title="Песни закончились"/></p>

Все правила игры подробно описаны в настройках. Если здесь что-то не указано, то вы можете ознакомиться с ними там.

## Установка приложения
Чтобы установить приложение - запустите установочный файл "OtherFiles/ForInstallation/setup.exe" и дождитесь окончания установки. После этого на рабочем столе появится ярлык для запуска приложения.