// Написать программу которая при задании четверти "координатных осей" выводит возможные координаты x;y


Console.WriteLine ("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());

if (x==1)
{
    Console.WriteLine ("Возможные координаты: Х>0; Y>0");
}

if (x==2)
{
    Console.WriteLine ("Возможные координаты: Х<0; Y>0");
}

if (x==3)
{
    Console.WriteLine ("Возможные координаты: Х<0; Y<0");
}

if (x==4)
{
    Console.WriteLine ("Возможные координаты: Х>0; Y<0");
}
if (x>4||x<1)
{
    Console.WriteLine ("ОШИБКА ПРОГРАММЫ: возмодный диапазон ввода от 1 до 4, повторите ВВОД");
}
