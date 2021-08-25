using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            //string name;//определение типа переменных
            byte his1, rus1, mat1, height1, age1;
            string name,name2,name3;
            //int name1;
            Console.WriteLine("Пользователь 1");
          
            while (true)
            {
                Console.WriteLine("\nВведите имя:");
                name = Console.ReadLine();
                string name_= @"^[a-zA-Zа-яА-Я]"; //[a-zA-Zа-яА-Я] шаблон регулярное выражение, сотоящее только из латинских и кириллических символов
                Match m = Regex.Match(name, name_);// Метод возвращает первую подстроку, которая соответствует шаблону регулярного выражения во входной строке
                if (!m.Success) //цикл, который при введении иных символов кроме букв возвращает к вводу имени
                {
                    Console.WriteLine("Имя должно содержать только буквы ", m.Value, m.Index);
                    m = m.NextMatch();
                }
                else { break; } //при успешном вводе выходит из цикла с введенным именем
                
            }
            
            while (true)
            {
                Console.WriteLine("Введите возраст");
                //age = Console.ReadLine();
                if (byte.TryParse(Console.ReadLine(), out age1)) /*преобразование типа 
                                                            статическим методом TryParse*/
                   
                    if (age1 > 100 | age1 < 18)  //условие вводимых данных, при которых цикл выполнится
                    {
                        Console.WriteLine("Ошибка! ВВедите достоверные данные");
                    }
                    else { break; }//завершение выполнения тела цикла 
                Console.WriteLine("Ошибка! ВВедите достоверные");
            }
            
            while (true)
            {
                Console.WriteLine("Введите рост");
                //height = Console.ReadLine();
                
                if (byte.TryParse(Console.ReadLine(), out height1))
                    if (height1 > 250)
                    {
                        Console.WriteLine("Ошибка! Рост не может быть выше 250 см");
                    }
                    else
                    { break; }
                Console.WriteLine("Ошибка! Введите правильные данные");
            }

            while (true) //цикл после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по истории");
                //his = Console.ReadLine();
                if (byte.TryParse(Console.ReadLine(), out his1))

                    if (his1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else
                    { break; }
            }

            while (true) //цикл, после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по математике");
                //mat = Console.ReadLine();
                if (byte.TryParse(Console.ReadLine(), out mat1))
                    if (mat1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }

            }

            while (true)//цикл после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по русскому");
                //rus = Console.ReadLine();
                if (byte.TryParse(Console.ReadLine(), out rus1))
                    if (rus1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }
            }
            Console.WindowWidth = 200;//ширина окна консоли
            double average = Convert.ToDouble(mat1 + rus1 + his1) / 3;//подсчет среднего балла
            double averageRound = Math.Round(average, 2);//округление до сотых
            string newPattern = "Имя: " + name + ". " + "Возраст: " + age1 + " года(лет). " + "Рост: " + height1 + " см. " + //обычный
                                "Балл по русскому: " + rus1 + " . " + "Балл по Истории: " + his1 + " . " +                   //вывод
                                "Балл по Математике: " + mat1 + " . " + "Средний балл: " + averageRound;                  //данных

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
            while (true)
            {
                Console.WriteLine("\nВведите имя:");
                name2 = Console.ReadLine();
                string name_ = @"^[a-zA-Zа-яА-Я]"; //[a-zA-Zа-яА-Я] шаблон регулярное выражение, сотоящее только из латинских и кириллических символов
                Match m = Regex.Match(name2, name_);// Метод возвращает первую подстроку, которая соответствует шаблону регулярного выражения во входной строке
                if (!m.Success) //цикл, который при введении иных символов кроме букв возвращает к вводу имени
                {
                    Console.WriteLine("Имя должно содержать только буквы ", m.Value, m.Index);
                    m = m.NextMatch();
                }
                else { break; } //при успешном вводе выходит из цикла с введенным именем

            }
            while (true)
            {
                Console.WriteLine("Введите возраст");
                if (byte.TryParse(Console.ReadLine(), out age1)) /*преобразование типа 
                                                            статическим методом TryParse*/
                    //else if (age1 > 100 | age1 < 18)
                    //{ Console.WriteLine("Введите правильный возраст"); }
                    if (age1 > 100 | age1 < 18)  //условие вводимых данных, при которых цикл выполнится
                    {
                        Console.WriteLine("Ошибка! ВВедите достоверные данные");
                    }
                    else { break; }//завершение выполнения тела цикла 
                Console.WriteLine("Ошибка! ВВедите достоверные");
            }

            while (true)
            {
                Console.WriteLine("Введите рост");
                if (byte.TryParse(Console.ReadLine(), out height1))
                    if (height1 > 250)
                    {
                        Console.WriteLine("Ошибка! Рост не может быть выше 250 см");
                    }
                    else
                    { break; }
                Console.WriteLine("Ошибка! Введите правильные данные");
            }

            while (true) //цикл после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по истории");
                if (byte.TryParse(Console.ReadLine(), out his1))

                    if (his1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else
                    { break; }
            }

            while (true) //цикл, после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по математике");
                if (byte.TryParse(Console.ReadLine(), out mat1))
                    if (mat1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }

            }

            while (true)//цикл после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по русскому");
                if (byte.TryParse(Console.ReadLine(), out rus1))
                    if (rus1 > 100)
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
            Console.Write(newPattern2, name2, age1, height1, rus1, his1, mat1,averageRound);
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region user3
            //данные для третьего пользователя
            Console.WriteLine("Пользователь 3");
            while (true)
            {
                Console.WriteLine("\nВведите имя:");
                name3 = Console.ReadLine();
                string name_ = @"^[a-zA-Zа-яА-Я]"; //[a-zA-Zа-яА-Я] шаблон регулярное выражение, сотоящее только из латинских и кириллических символов
                Match m = Regex.Match(name3, name_);// Метод возвращает первую подстроку, которая соответствует шаблону регулярного выражения во входной строке
                if (!m.Success) //цикл, который при введении иных символов кроме букв возвращает к вводу имени
                {
                    Console.WriteLine("Имя должно содержать только буквы ", m.Value, m.Index);
                    m = m.NextMatch();
                }
                else { break; } //при успешном вводе выходит из цикла с введенным именем

            }
            while (true)
            {
                Console.WriteLine("Введите возраст");
                if (byte.TryParse(Console.ReadLine(), out age1)) /*преобразование типа 
                                                            статическим методом TryParse*/
                    //else if (age1 > 100 | age1 < 18)
                    //{ Console.WriteLine("Введите правильный возраст"); }
                    if (age1 > 100 | age1 < 18)  //условие вводимых данных, при которых цикл выполнится
                    {
                        Console.WriteLine("Ошибка! ВВедите достоверные данные");
                    }
                    else { break; }//завершение выполнения тела цикла 
                Console.WriteLine("Ошибка! ВВедите достоверные");
            }

            while (true)
            {
                Console.WriteLine("Введите рост");
                if (byte.TryParse(Console.ReadLine(), out height1))
                    if (height1 > 250)
                    {
                        Console.WriteLine("Ошибка! Рост не может быть выше 250 см");
                    }
                    else
                    { break; }
                Console.WriteLine("Ошибка! Введите правильные данные");
            }

            while (true) //цикл после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по истории");
                if (byte.TryParse(Console.ReadLine(), out his1))

                    if (his1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else
                    { break; }
            }

            while (true) //цикл, после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по математике");
                if (byte.TryParse(Console.ReadLine(), out mat1))
                    if (mat1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }
            }

            while (true)//цикл после выполнения которого получим корректные данные
            {
                Console.WriteLine("Балл по русскому");
                if (byte.TryParse(Console.ReadLine(), out rus1))
                    if (rus1 > 100)
                    {
                        Console.WriteLine("\nБольше 100 баллов быть не может! Проверьте данные!");
                    }
                    else { break; }
            }

            //вывод текста с применением интерполяции
            string user3 = $"Имя: {name3}. Возраст: {age1} лет. Рост: {height1} см. Балл по истории: {his1}." +
                             $"Балл по математике: {mat1}. Балл по русскому: {rus1}.  Средний балл: {averageRound} ";
            
            int centerX3 = (Console.WindowWidth / 2) - (user3.Length / 2);
            int centerY3 = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX3, centerY3);
            Console.WriteLine(user3);
            Console.ReadKey();
            #endregion
            


        }
    }
}