Лабораторна робота 
з дисципліни "Технологія розробки Web-додатків"
Виконав: Війтенко Артем КВ-01мп

Загальне завдання: розробити функції обміну даними між користувачами Web-додатка, а також адміністрування користувачами у реальному часі.
Інструменти розробки: C#, ASP.NET Core 
Web-додаток має реалізовувати наступні функції:

реєстрація користувача (поля:  email, дата народження, пароль та повторний ввод пароля )
вхід до сайту (поля: email, пароль)
профіль користувача (поля у табличному вигляді)
про додаток (емблема додатку, короткий опис додатка)
робочі функції додатка (розробляється самостійно студентом відповідно до обраної тематики)


Регістрація здійснюється при переході на https://localhost:*****/Account/Register (коли додаток запущено) 

Вхід до профіля сдійснюється при переході на https://localhost:*****/account/login (коли додаток запущено) 

Якщо введені вхідні дані для адміністратора (login - admin; password - superpassword) то при переході до https://localhost:*****/admin 
можна побачиити можливості редагування сторінок та додавання "Послуг"
