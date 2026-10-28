using System;
string[] ruTranslate = { " ВВедите ваш выбор "," Юзернейм ", " Пароль ", " 1.Логин  \n 2.Регистрация "," Главное меню \n 1. Свободные номера. \n 2. Номер \n 3. Отменить бронь номера ", " Свободные номера: ", " Номер успешно забронирован "};
string[] enTranslate = { "Enter your choice"," Username ", " Password ", " 1.Login \n 2.Registration", "Main menu \n 1. Available rooms. \n 2. Room \n 3. Cancel room reservation", "Available rooms:", "Room successfully booked" };


void LoginRegistration()
{
    Console.WriteLine(ruTranslate[1]);
    Console.ReadLine();
    Console.WriteLine(enTranslate[1]);
    Console.ReadLine();
    /*
     * Забыл упомянуть это анонимный массив
     * При создании анонимного типа,
     * содержащего массив, этот массив необходимо неявно типизировать в инициализаторе объекта типа.
     * В следующем примере contacts представляет собой неявный типизированный массив анонимных типов,
     * каждый из которых содержит массив с именем PhoneNumbers.
     * Ключевое var слово не используется внутри инициализаторов объектов.
     * Ссылка на ресурс https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/arrays
     */
    var userLoginData = new[]
    {
        new
        {
            Name = "Kilo",
            password = "User1",
            room_rent = false,
            room_number = 10,
            User_number = new[] {"5684566211488", "4445532432430" }
        },
        new
        {   
            Name = "Mila",
            password = "User",
            room_rent = true,
            room_number = 9,
            User_number = new[] {"342432887324325"}
        },
        new
        {
            Name = "Fiae",
            password = "user22",
            room_rent = false,
            room_number = 11,
            User_number = new[] {"3244434234234342"}
        }
    };
    
    var newLoginUser = new[]
    {
        new
        {
        }
    };
    
    
}
    

void Language()
{
    
        Console.WriteLine(" Добро пожаловать в сервис бронирования / Welcome to the booking service ");
        Console.WriteLine(" Выберите язык. \n Choose a language. \n 1.Ru \n 1.En \n Введите номер/Enter а number: ");

        int userInput = Convert.ToInt32(Console.ReadLine());
        
        if (userInput == 1)
        {
            Console.WriteLine(ruTranslate[0],"\n",ruTranslate[1]);
            LoginRegistration();
        }
        else if (userInput == 2)
        {
            Console.WriteLine(enTranslate[0],"\n",enTranslate[1]);
        }
        else
        {
            Console.WriteLine("Введите правильные данные");
            LoginRegistration();
        }
}

Language();
