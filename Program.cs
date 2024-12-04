using System;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskForm taskForm = new TaskForm();
            while (true)
            {
                Console.Clear(); // Очищаем консоль
                Console.WriteLine("Меню взаимодействия:");
                Console.WriteLine("1 - Вписать ФИО");
                Console.WriteLine("2 - Вписать марку автомобиля");
                Console.WriteLine("3 - Вписать email");
                Console.WriteLine("4 - Вывести введённые данные");
                Console.WriteLine("0 - Выход");
                Console.Write("Введите номер действия: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Введите Фамилию: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Введите Имя: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Введите Отчество: ");
                        string middleName = Console.ReadLine();
                        taskForm.LastName = lastName;
                        taskForm.FirstName = firstName;
                        taskForm.MiddleName = middleName;
                        Console.WriteLine("ФИО успешно сохранено!");
                        Pause();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Введите марку автомобиля: ");
                        string carName = Console.ReadLine();
                        taskForm.CarName = carName;
                        Console.WriteLine("Марка автомобиля успешно сохранена!");
                        Pause();
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Введите email: ");
                        string email = Console.ReadLine();
                        taskForm.Email = email;
                        Console.WriteLine("Email успешно сохранён!");
                        Pause();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Введённые данные:");
                        Console.WriteLine($"ФИО: {taskForm.LastName} {taskForm.FirstName} {taskForm.MiddleName}");
                        Console.WriteLine($"Марка автомобиля: {taskForm.CarName}");
                        Console.WriteLine($"Email: {taskForm.Email}");
                        Pause();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        Pause();
                        break;
                }
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }
    }
}
