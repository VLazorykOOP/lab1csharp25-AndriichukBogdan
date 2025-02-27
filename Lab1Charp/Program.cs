public class Program
{
    public static void Main(string[] args)
    {
        void task1(){
            System.Console.Write("Введіть Периметр:");
            int a = Convert.ToInt16(System.Console.ReadLine());
            double square = (a/4)*(a/4);
            System.Console.WriteLine(square);
        }
        void task2(){
            System.Console.Write("Введіть а:");
            double first =Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Введіть b:");
            double second =Convert.ToDouble(System.Console.ReadLine());
            if(first > second){
                System.Console.Write("First number is max");
            }
            else{
                System.Console.Write("Second number is max");
            }
        }
        void task3(){

            while (1 == 1){
            System.Console.Write("Введіть x:");
            double x = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Введіть y:");
            double y = Convert.ToDouble(System.Console.ReadLine());

            if(((x*x + y*y) < 12*12) && (y<x)) System.Console.WriteLine("Так!");
            else if(((x*x + y*y) == 12*12 && (y<x)) || (x == y)) System.Console.WriteLine("На межі!");
            else System.Console.WriteLine("Ні!");
            }

        }
        void task4(){
            System.Console.Write("Введіть місяць:");
            int month = Convert.ToInt16(System.Console.ReadLine());
            System.Console.WriteLine("Місяців до кінця року:" + (12 - month));
        }
        void task5(){
            int addTwoNumbers(int a,int b) {return a + b;}
            System.Console.Write("Введіть x:");
            int x = Convert.ToInt16(System.Console.ReadLine());
            System.Console.Write("Введіть y:");
            int y = Convert.ToInt16(System.Console.ReadLine());

            System.Console.WriteLine(x +"+"+y+"="+addTwoNumbers(x,y));
        }
        void task6(){
            System.Console.Write("Введіть а:");
            double a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Введіть b:");
            double b = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Результат:"+ (a+((a+b-1)/(a*a+1))-a*b));

        }
        void choose_task(){
            System.Console.Write("1.Площа з периметра\n2.Максимум серед двох\n3.Чи належить фігурі\n4.Скільки місяців до кінця\n5.Додати 2 числа\n6.Вирішити приклад\n");
            int answer = Convert.ToInt16(System.Console.ReadLine());

            switch (answer){
                case 1:{
                    task1();
                    System.Console.Write("\n\n\n\n\n\n\n");
                    choose_task();
                    break;
                }
                case 2:{
                    task2();
                    System.Console.Write("\n\n\n\n\n\n\n");
                    choose_task();
                    break;
                }
                case 3:{
                    task3();
                    System.Console.Write("\n\n\n\n\n\n\n");
                    choose_task();
                    break;
                    }
                case 4:{
                    task4();
                    System.Console.Write("\n\n\n\n\n\n\n");
                    choose_task();
                    break;
                    }
                case 5:{
                    task5();
                    System.Console.Write("\n\n\n\n\n\n\n");
                    choose_task();
                    break;
                    }
                case 6:{
                    task6();
                    System.Console.Write("\n\n\n\n\n\n\n");
                    choose_task();
                    break;
                }
                default:{
                    choose_task();
                    break;
                }

            }
        }
        choose_task();
    }
}