using System;

class Program
{
    static void Main()
    {
        int rakam = Int32.Parse(Console.ReadLine());
        double vazn = Double.Parse(Console.ReadLine());

        double resultkg = 0;
        

       
    
        

        switch (rakam)
        {
            case 1: 
                resultkg = vazn;
                break;
            case 2: 
                resultkg = vazn* 0.000001;
                break;
            case 3: // Грамм
                resultkg = vazn * 0.001;
                break;
            case 4: // Тонна
                resultkg = vazn * 1000;
                break;
            case 5: // Центнер
               resultkg = vazn* 100;
                break;
            default:
                Console.WriteLine("incorrect num");
                return;
        }

        Console.WriteLine(resultkg+" kg");
    }
}