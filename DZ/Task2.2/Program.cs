// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Х coordinate");
int c1 = int.Parse(Console.ReadLine());
Console.WriteLine("Y coordinate");
int c2 = int.Parse(Console.ReadLine());


    
    
        if ( c1 ==0 || c2 == 0)
        {
            Console.WriteLine("одна из координат равна 0");
        }
        else
        {
            if ( c1 > 0 && c2 > 0 )
            {
                Console.WriteLine($"точка( {c1} {c2} ) находиться в первой четверти");
            }
            else
            {
                if ( c1 < 0 && c2 > 0)
                {
                    Console.WriteLine($"точка( {c1} {c2} ) находиться во второй четверти");
                }
                else
                {
                    if ( c1 < 0 && c2 < 0)
                    {
                        Console.WriteLine($"точка( {c1} {c2} ) находиться в третьей четверти");
                    }
                    else
                    {
                        Console.WriteLine($"точка( {c1} {c2} ) находиться в четвертой четверти");
                    }
                }

            }

        }
    

    