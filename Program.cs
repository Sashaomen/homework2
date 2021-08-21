using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Theme_01
{
    public class homowork

    {
        public static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;
            Console.WindowWidth = 200;
            Console.WriteLine("Записная книжка");
            
            //for (int i = 0; i<3; i++)
            
                Console.WriteLine($"Пользователь 1");
                //string name;
                Console.WriteLine("\nВведите имя:");
                string name = Convert.ToString(Console.ReadLine());
                byte age;                
                while (true)
                {
                    Console.WriteLine("Введите возраст");
                    age = byte.Parse(Console.ReadLine());

                    if (age > 100 | age < 18)
                    {
                        Console.WriteLine("Ошибка! ВВедите достоверные данные");
                    }
                    else {break;}
                }
                //Console.WriteLine("Ошибка! ВВедите достоверные данные");
                byte height;
                Console.WriteLine("Введите рост");
                height = byte.Parse(Console.ReadLine());
                byte his, rus, mat;
                while (true)
                {
                    Console.WriteLine("Балл по истории");
                    his = byte.Parse(Console.ReadLine());
                    if (his > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else 
                    { break; }
                }

                while (true)
                {
                    Console.WriteLine("Балл по математике");
                    mat = byte.Parse(Console.ReadLine());
                    if (mat > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }

                }

                while(true)
                {
                    Console.WriteLine("Балл по русскому");
                    rus = byte.Parse(Console.ReadLine());
                    if (rus > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }
                }
               Console.WindowWidth = 200;//ширина консоли
                
                string newPattern = "Имя: {0} Возраст: {1}лет. Рост: {2}см. Балл по русскому: {3}. Балл по Истории: {4}. Балл по Математике: {5}. Средний балл: {6}";
                int centerX = (Console.WindowWidth / 2) - (newPattern.Length / 2);
                int centerY = (Console.WindowHeight / 2) - 1;
                Console.SetCursorPosition(centerX, centerY);
                double average = Convert.ToDouble(mat + rus + his) / 3;
                double averageRound = Math.Round(average, 2);
                Console.WriteLine(newPattern, name, age, height, rus, his, mat, averageRound);
               // Console.WriteLine("Средний балл=" + (mat + rus + his) / 3);
                Console.ReadKey();
                Console.Clear();

            #region user2
            Console.WriteLine($"\nПользователь 2");
            //string name;
            Console.WriteLine("\nВведите имя:");
            string name2 = Convert.ToString(Console.ReadLine());
            //byte age;
            while (true)
            {
                Console.WriteLine("Введите возраст");
                age = byte.Parse(Console.ReadLine());

                if (age > 100 | age < 18)
                {
                    Console.WriteLine("Ошибка! ВВедите достоверные данные");
                }
                else { break; }
            }
          
            Console.WriteLine("Введите рост");
            height = byte.Parse(Console.ReadLine());
            
            while (true)
            {
                Console.WriteLine("Балл по истории");
                his = byte.Parse(Console.ReadLine());
                if (his > 100)
                {
                    Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                }
                else
                { break; }
            }

            while (true)
            {
                Console.WriteLine("Балл по математике");
                mat = byte.Parse(Console.ReadLine());
                if (mat > 100)
                {
                    Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                }
                else { break; }

            }

            while (true)
            {
                Console.WriteLine("Балл по русскому");
                rus = byte.Parse(Console.ReadLine());
                if (rus > 100)
                {
                    Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                }
                else { break; }
            }
            Console.WindowWidth = 200;//ширина консоли

            string newPattern2 = "Имя: {0} Возраст: {1}лет. Рост: {2}см. Балл по русскому: {3}. Балл по Истории: {4}. Балл по Математике: {5}. Средний балл: {6}.";
            int centerX2 = (Console.WindowWidth / 2) - (newPattern2.Length / 2);
            int centerY2 = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX2, centerY2);
            Console.Write(newPattern2, name2, age, height, rus, his, mat,averageRound);
            Console.ReadKey();
            #endregion
            Console.Clear();

            #region user3

            Console.WriteLine($"\nПользователь 3");
            //string name;
            Console.WriteLine("\nВведите имя:");
            string name3 = Convert.ToString(Console.ReadLine());
            //byte age;
            while (true)
            {
                Console.WriteLine("Введите возраст");
                age = byte.Parse(Console.ReadLine());

                if (age > 100 | age < 18)
                {
                    Console.WriteLine("Ошибка! ВВедите достоверные данные");
                }
                else { break; }
            }

            Console.WriteLine("Введите рост");
            height = byte.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Балл по истории");
                his = byte.Parse(Console.ReadLine());
                if (his > 100)
                {
                    Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                }
                else
                { break; }
            }

            while (true)
            {
                Console.WriteLine("Балл по математике");
                mat = byte.Parse(Console.ReadLine());
                if (mat > 100)
                {
                    Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                }
                else { break; }

            }

            while (true)
            {
                Console.WriteLine("Балл по русскому");
                rus = byte.Parse(Console.ReadLine());
                if (rus > 100)
                {
                    Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                }
                else { break; }
            }
            
            Console.WindowWidth = 200;//ширина консоли

            string newPattern3 = "Имя: {0} Возраст: {1}лет. Рост: {2}см. Балл по русскому: {3}. Балл по Истории: {4}. Балл по Математике: {5}. Средний балл: {6}.";
            int centerX3 = (Console.WindowWidth / 2) - (newPattern3.Length / 2);
            int centerY3 = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX3, centerY3);
            Console.WriteLine(newPattern3, name3, age, height, rus, his, mat,averageRound);
            Console.WriteLine("Средний балл=" + (mat + rus + his) / 3);
            Console.ReadKey();

            #endregion
            //string users = Convert.ToString(newPattern);
            // int tabs = Console.WindowWidth - newPattern.Length; //длина отступа
            // newPattern = newPattern.PadLeft(newPattern.Length + tabs, '\0'); //правое выравнивание
            // string users = Convert.ToString(Console.WriteLine(newPattern,age);
            //var width = Console.WindowWidth;
            //var padding = width / 2 + newPattern.Length / 2;

            //  Console.WriteLine("{0," + padding + "}", newPattern,name,age,height,rus,his,mat);
            //Console.WriteLine(newPattern);
            // Console.WriteLine(users, name, age, height, rus, his, mat);


            #region other
            //string user = ($"Пользователь {i + 1}" +
            //     $"\nИмя: {name} " +
            //     $"\nВозраст: {age} \nРост: {height} \nБалл по истории: {his} " +
            //     $"\nБалл по математике: {mat} \nБалл по русскому: {rus}");
            //string user1 = $"Пользователь: {name}";
            //string age1 = $"Возраст: {age}";
            //string height1 = $"Рост {height}";
            //string his1 = $"Балл по истории: {his}";
            //string mat1 = $"Балл по математике: {mat}";
            //string rus1 = $"Балл по Русскому: {rus}";

            //var user2 =(newPattern,
            //     user1,
            //     age1,
            //     height1,
            //     his1,
            //     mat1,
            //     rus1);

            //var width = Console.WindowWidth;
            //var padding = width / 2 + newPattern.Length / 2;
            // Console.WriteLine("{0," + padding + "}", newPattern);


            ///
            //int centerX = (Console.WindowWidth / 2) - (newPattern.Length / 2);
            //int centerY = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(centerX, centerY);

            //// Console.WriteLine(user1);

            //int centerXage = (Console.WindowWidth / 2) - (age1.Length / 2);
            //int centerYage = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(centerXage, centerYage);
            ////  Console.WriteLine(age1);

            //int centerXheight = (Console.WindowWidth / 2) - (height1.Length / 2);
            //int centerYheight = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(centerXheight, centerYheight);
            ////  Console.WriteLine(height1);

            //int centerXhis = (Console.WindowWidth / 2) - (his1.Length / 2);
            //int centerYhis = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(centerXhis, centerYhis);
            ////  Console.WriteLine(his1);

            //int centerXmat = (Console.WindowWidth / 2) - (mat1.Length / 2);
            //int centerYmat = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(centerXmat, centerYmat);
            ////   Console.WriteLine(mat1);

            //int centerXrus = (Console.WindowWidth / 2) - (rus1.Length / 2);
            //int centerYrus = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(centerXrus, centerYrus);
            ////Console.WriteLine(rus1);

            /////     Console.Write($"{user1}" + $"\n{age1}" + $"\n{height1}" + $"\n{his1}" + $"\n{mat1}" + $"\n{rus1}");

            ////Console.Write(user1 + "\n" + age1 + "\n" + height1 + "\n" + rus1 + "\n" + mat1 + "\n" + his1);

            #endregion

            ////var width = Console.WindowWidth;
            ////var padding = width / 2 + user.Length / 2;
            ////Console.WriteLine("{0," + padding + "}", user);

            //Console.WriteLine(user1);
            //Console.WriteLine(age1);
            //Console.WriteLine(height1);
            //Console.WriteLine(rus1);
            //Console.WriteLine(mat1);
            //Console.WriteLine(his1);



            //int tabs = Console.WindowWidth-user.Length;
            ////user = user.PadRight(user.Length + tabs, '\0');
            ////Console.WriteLine(user);
            //user = user.PadLeft(user.Length + tabs, '\0');
            // Console.WriteLine(user);
            /*Console.WriteLine($"\nПользователь {i + 1} \nВаши данные: \nИмя: {name} " +
                 $"\nВозраст: {age} \nРост: {height} \nБалл по истории: {his} " +
                 $"\nБалл по математике: {mat} \nБалл по русскому: {rus}");*/
            // Console.SetOut(TextWrite newOut);




        }
    }
}