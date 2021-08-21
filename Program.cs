using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2.7 Домашняя работа 
/// </summary>
namespace Homework_Theme_01
{
    /// <summary>
    /// Точка входа, название программы. Запрашиваются данные и выдаётся результат.
    /// </summary>
    public class homowork

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Записная книжка"); //название программы
                     
            #region user1
                Console.WriteLine("Пользователь 1");
                Console.WriteLine("\nВведите имя:");//ввод имени первого пользователя
                string name = Convert.ToString(Console.ReadLine());
                byte height,age,his, rus, mat; ; //определение типа переменных              
                while (true) //цикл, после выполнения которого получим корректные данные
                {
                    Console.WriteLine("Введите возраст");
                    age = byte.Parse(Console.ReadLine());   /*преобразование типа 
                                                            статическим методом Parse*/
                    if (age > 100 | age < 18) //условие вводимых данных, при которых цикл выполнится
                    {
                        Console.WriteLine("Ошибка! ВВедите достоверные данные");
                    }
                    else {break;}//завершение выполнения тела цикла 
                }

                Console.WriteLine("Введите рост");
                height = byte.Parse(Console.ReadLine());
                            
                while (true) //цикл после выполнения которого получим корректные данные
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

                while (true) //цикл, после выполнения которого получим корректные данные
            {
                    Console.WriteLine("Балл по математике");
                    mat = byte.Parse(Console.ReadLine());
                    if (mat > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }

                }

                while(true)//цикл после выполнения которого получим корректные данные
            {
                    Console.WriteLine("Балл по русскому");
                    rus = byte.Parse(Console.ReadLine());
                    if (rus > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }
                }
                Console.WindowWidth = 200;//ширина окна консоли
                double average = Convert.ToDouble(mat + rus + his) / 3;//подсчет среднего балла
                double averageRound = Math.Round(average, 2);//округление до сотых
                string newPattern = "Имя: "+ name + ". " + "Возраст: " + age + " года(лет). "+ "Рост: " + height +" см. " + //обычный
                                    "Балл по русскому: " + rus + " . "+ "Балл по Истории: " + his +" . "+                   //вывод
                                    "Балл по Математике: " + mat + " . "+ "Средний балл: " + averageRound;                  //данных
               
            //определения полождения выводимого текста по центру консоли
                int centerX = (Console.WindowWidth / 2) - (newPattern.Length / 2); //(ширина окна консоли поделенная на два)-(длина выводимой строки / 2)
                int centerY = (Console.WindowHeight / 2) - 1; //(высота окна консоли / 2) - 1
                Console.SetCursorPosition(centerX, centerY); //координата вывода 
                Console.WriteLine(newPattern);//вывод вводимых данных
                Console.ReadKey();// переход к следующей части программы нажатием клавиши
                Console.Clear();//очистка консоли
            #endregion

            //данные для второго пользователя
            #region user2
            Console.WriteLine("Пользователь 2");
            Console.WriteLine("\nВведите имя:");
            string name2 = Convert.ToString(Console.ReadLine());
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
            //вывод данных осуществляется форматированным выводом
            
            string newPattern2 = "Имя: {0} Возраст: {1}лет. Рост: {2}см. Балл по русскому: {3}. " +
                                 "Балл по Истории: {4}. Балл по Математике: {5}. Средний балл: {6}.";
            
            int centerX2 = (Console.WindowWidth / 2) - (newPattern2.Length / 2);
            int centerY2 = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX2, centerY2);
            Console.Write(newPattern2, name2, age, height, rus, his, mat,averageRound);
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region user3
            //данные для третьего пользователя
            Console.WriteLine("Пользователь 3");
            Console.WriteLine("\nВведите имя:");
            string name3 = Convert.ToString(Console.ReadLine());
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
           
            //вывод текста с применением интерполяции
            string user3 = $"Имя: {name}. Возраст: {age} лет. Рост: {height} см. Балл по истории: {his}." +
                             $"Балл по математике: {mat}. Балл по русскому: {rus}.  Средний балл: {averageRound} ";
            
            int centerX3 = (Console.WindowWidth / 2) - (user3.Length / 2);
            int centerY3 = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX3, centerY3);
            Console.WriteLine(user3);
            Console.ReadKey();
            #endregion

        }
    }
}