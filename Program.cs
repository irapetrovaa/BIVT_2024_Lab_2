﻿using System;
using System.Data;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();

        // int i, s;
        //for (i = 2; i < 35; i = i + 3)
        //    {
        //      s = s + i;
        //    }
        // Console.WriteLine("s = {0}", s);

        //program.Task_1_2();
        //program.Task_1_3();
        //    program.Task_1_4(0.9);
        // program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        // program.Task_1_7();
        //program.Task_1_8();
        //  program.Task_1_9();
        // program.Task_1_10();
        //  {
        //  double answer = 0, n = 1, a;
        //    double answer = 0, n = 1, a;
        //    Console.ReadLine(x);

        //   answer = 1;
        //  for (int i = 1; i <= 10; i++)
        //   {
        //    n = x * n;
        //   answer = answer + 1 / n;
        //  }

        //program.Task_1_11();
        //program.Task_1_12();
       // program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
         int answer = 0;

        int i=0;
        for (i = 2; i <= 35; i = i + 3) 
        {
            answer = answer + i;
        }
        Console.WriteLine("answer  = {0}", answer);

       return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        {
            for(int i=1; i <10;  i++)
            {

            answer = answer + 1.0 / i;
            }
            Console.WriteLine("answer  = {0}", answer);
        }

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(int i=2; i <112; i=i + 2) 
        {
            answer += (i) / (i++);
        }
        Console.WriteLine("answer  = {0}", answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        answer = Math.Cos(x);
       
        for (int n = 1; n<9; n++)
        {
            answer = answer + Math.Cos(n * x)/a ;
          
            a = a * x;
        } 
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double s = 0;
        // code here
        for (int i = 0; i < 9; i++)
        {
            
            answer= answer +(p+i*h)*(p+i*h);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        x = -4;

        for (int i = 0; i< 17; i++ )
        {
            
            answer=0.5*x*x -7*x;
            
            Console.WriteLine("x = {0:f2}\answer = {1:f2}", x, answer);
            x = x + 0.5;
        }
        // end
        // можно не писать шаг

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i< 6; i++)
        {
            answer = answer*i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        answer = 1;
        int y = 1;
        // code here;
        for( int i= 1; i<=5; i++)
        {
              y =y*(i+1);
            answer = answer + y;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double n1 = -1;
        double n2 = 5;
        double y = 1;
        double i = 1;
        // code here;
         for(; i < 6; i++); 
        {
            n1 = (-1) * n1;
            n2 = n2 * n2;
            y = y * (i + 1);
            answer= answer + n1*n2 /y;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;
        answer = 1;
        // code here
        for(int i= 1; i <= 7; i++)
        {
            answer = answer * 3;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
     
        for( int i=1; i <= 6; i++ )
        {
            Console.WriteLine(i);
        }
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(5);
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        
        double answer = 0, n = 1;
        answer = 1;
        for(int i=1; i <= 10; i++)
        {
            n = x * n;
            answer = answer + 1/n;
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // code here

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
       
        double answer = 0;
        if (x <= -1)
        {
            answer = 1;
            Console.WriteLine(answer);
        }
        else
            if (x <= 1 && x > -1)
        {
            answer = -x;
            Console.WriteLine(answer);
        }
        else if (x > 1)
        {
            answer = -1;
            // code here
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}