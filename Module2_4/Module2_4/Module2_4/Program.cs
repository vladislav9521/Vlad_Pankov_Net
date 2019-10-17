using System;

namespace Module2_4
{
    class Program
    {

        //4)	Программа для подсчета периметра и площади фигур(треугольник, четырехугольник, круг).
        //Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр.
        //    Задаётся все необходимые значения, а на основе полученных результатов, программа должна 
        //    подсчитать, какими могли бы быть периметры или площади остальных фигур.

        static void Main(string[] args)
        {

            string selectFig, selectOper;
            double sideATr, perimTr, sqTr;
            double R, perimCircle, sqCircle;
            double sideARec, perimRec,sqRec;

            ChooseFigure:

            Console.WriteLine("Выберите фигуру:\n1. Равносторонний треугольник;\n2. Правильный четырехугольник;\n3. Круг.");
            selectFig = Console.ReadLine();

            switch(selectFig)
            {
                case "1":
                    {
                        Console.Write("Введите сторону A:");
                        sideATr = double.Parse(Console.ReadLine());
                      
                        ChooseOperTr:

                        Console.WriteLine("1. Расчет периметра;\n2. Расчет площади");
                        selectOper = Console.ReadLine();
                                               

                        switch (selectOper)
                        {
                            case "1":
                                {
                                    perimTr = sideATr * 3;
                                    R = perimTr / (2 * Math.PI);
                                    sqCircle = Math.PI * Math.Pow(R, 2);
                                    sideARec = perimTr / 4;
                                    sqRec = Math.Pow(sideARec,2);
                                    Console.WriteLine($"Периметр треугольника = {perimTr:0.00}");
                                    Console.WriteLine($"Возмжный радиус окружности = {R:0.00}, а площадь такой окружности = {sqCircle:0.00}");
                                    Console.WriteLine($"Предположительно, сторона квадрата = {sideARec:0.00}, а его площадь = {sqRec:0.00}");
                                    break;
                                }
                            case "2":
                                {
                                    sqTr = Math.Pow(sideATr, 2) * Math.Sqrt(3) / 4;
                                    R = Math.Sqrt(sqTr / Math.PI);
                                    perimCircle = 2 * Math.PI * R;
                                    sideARec = Math.Sqrt(sqTr);
                                    perimRec = sideARec * 4;
                                    Console.WriteLine($"Площадь треугольника = {sqTr:0.00}");
                                    Console.WriteLine($"Возмжный радиус окружности = {R:0.00}, а длина такой окружности = {perimCircle:0.00}");
                                    Console.WriteLine($"Предположительно, сторона квадрата = {sideARec:0.00}, а его периметр = {perimRec:0.00}");
                                    break;
                                }
                            default:
                                Console.WriteLine("Некорректный ввод!!!");
                                goto ChooseOperTr;
                        }
                        break;
                    }                         
                    
                case "2":
                    {
                        Console.Write("Введите сторону A:");
                        sideARec = double.Parse(Console.ReadLine());
                       
                        ChooseOperRect:

                        Console.WriteLine("1. Расчет периметра;\n2. Расчет площади");
                        selectOper = Console.ReadLine();
                                    
                        switch (selectOper)
                        {
                            case "1":
                                {
                                    perimRec = sideARec * 4;
                                    R = perimRec / (2 * Math.PI);
                                    sqCircle = Math.PI * Math.Pow(R, 2);
                                    sideATr = perimRec / 3;
                                    sqTr = Math.Pow(sideATr, 2) * Math.Sqrt(3) / 4;
                                    Console.WriteLine($"Периметр прямоугольника = {perimRec:0.00}");
                                    Console.WriteLine($"Возмжный радиус окружности = {R:0.00}, а площадь такой окружности = {sqCircle:0.00}");
                                    Console.WriteLine($"Предположительно, сторона равностороннего треугольника = {sideATr:0.00}, а его площадь = {sqTr:0.00}");
                                    break;
                                }
                            case "2":
                                {
                                    sqRec =sideARec*2;
                                    R = Math.Sqrt(sqRec / Math.PI);
                                    perimCircle = 2 * Math.PI * R;
                                    sideATr = Math.Sqrt(sqRec*4/Math.Sqrt(3));
                                    perimTr = sideATr * 3;
                                    Console.WriteLine($"Площадь прямоугольника = {sqRec:0.00}");
                                    Console.WriteLine($"Возмжный радиус окружности = {R:0.00}, а длина такой окружности = {perimCircle:0.00}");
                                    Console.WriteLine($"Предположительно, сторона равностороннего треугольника = {sideATr:0.00}, а его периметр = {perimTr:0.00}");
                                    break;
                                }
                            default:
                                Console.WriteLine("Повторите попытку выбора!");
                                goto ChooseOperRect;
                        }
                        break;
                    }

                case "3":
                    {
                        Console.Write("Введите радиус огружности R:");
                        R = double.Parse(Console.ReadLine());

                        ChooseOperCircle:

                        Console.WriteLine("1. Расчет периметра;\n2. Расчет площади");
                        selectOper = Console.ReadLine();
                       
                        switch (selectOper)
                        {
                            case "1":
                                {

                                    perimCircle = 2 * Math.PI * R;
                                    sideARec = perimCircle / 4;
                                    sqRec = Math.Pow(sideARec, 2);
                                    sideATr = perimCircle / 3;
                                    sqTr = Math.Pow(sideATr, 2) * Math.Sqrt(3) / 4;
                                    Console.WriteLine($"Длина окружности = {perimCircle:0.00}");
                                    Console.WriteLine($"Предположительно, сторона квадрата = {sideARec:0.00}, а его площадь = {sqRec:0.00}");
                                    Console.WriteLine($"Предположительно, сторона равностороннего треугольника = {sideATr:0.00}, а его площадь = {sqTr:0.00}");
                                    break;
                                }
                            case "2":
                                {
                                    sqCircle = Math.PI * Math.Pow(R, 2);
                                    sideARec = Math.Sqrt(sqCircle);
                                    perimRec = sideARec * 4;
                                    sideATr = Math.Sqrt(sqCircle * 4 / Math.Sqrt(3));
                                    perimTr = sideATr * 3;
                                    Console.WriteLine($"Площадь круга = {sqCircle:0.00}");
                                    Console.WriteLine($"Предположительно, сторона квадрата = {sideARec:0.00}, а его периметр = {perimRec:0.00}");
                                    Console.WriteLine($"Предположительно, сторона равностороннего треугольника = {sideATr:0.00}, а его периметр = {perimTr:0.00}");
                                    break;
                                }
                            default:
                                Console.WriteLine("Повторите попытку выбора!");
                                goto ChooseOperCircle;
                        }
                        break;
                    }

                default:
                    Console.WriteLine("Такой фигуры нет!");
                    goto ChooseFigure;

            }

            Console.ReadLine();
        }
    }
}
