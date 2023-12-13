using System.Numerics;
using System.Runtime.ConstrainedExecution;

class Task4
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task04();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
        Task15();
    }
    //1) verilmiş 4 reqemli ededin reqemlerinin cemini tap
    static void Task1()

    {

    l1:
        Console.WriteLine("1. 4 reqemli eded daxil edin:");

        string Input = Console.ReadLine();
        int cavab = 0;

        if (int.TryParse(Input, out int eded))
        {

            if (eded <= 999 || eded >= 10000)
            {
                goto l1;
            }

            while (eded > 0)
            {
                int a = eded % 10;
                cavab += a;

                eded /= 10;

            }

            Console.WriteLine("Cavab: " + cavab);
        }
    }

    //2) verilmiş 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3
    static void Task2()


    {
    l1:
        Console.WriteLine("2. 6 reqemli eded daxil edin: ");

        var input = Console.ReadLine();
        int cavab = 0;

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 1000000 || eded <= 99999)
            {
                goto l1;
            }

            eded /= 1000;

            while (eded > 0)
            {
                int a = eded % 10;
                cavab += a;

                eded /= 10;

            }

            Console.WriteLine("Cavab: " + cavab);
        }

    }

    //3) verilmiş 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
    static void Task3()


    {
    l1:
        Console.WriteLine("3. 9 reqemli eded daxil edin: ");

        string input = Console.ReadLine();
        int cavab = 0;

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 1000000000 || eded <= 99999999)
            {
                goto l1;
            }

            eded %= 1000000;
            eded /= 1000;

            while (eded > 0)
            {
                int a = eded % 10;
                cavab += a;

                eded /= 10;
            }

            Console.WriteLine("Cavab: " + cavab);

        }


    }

    //4) verilmiş 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
    static void Task04()

    {
    l1:
        Console.WriteLine("4. 5 reqemli eded daxil edin");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 100000 || eded <= 9999)
            {
                goto l1;
            }

            int ilkReqem = eded / 10000;
            int sonReqem = eded % 10;
            int cem = ilkReqem + sonReqem;
            int cavab = cem * cem;

            Console.WriteLine("Cavab:" + cavab);

        }
    }

    //5) verilmiş 6 reqemli ededin 1 ci reqemini hemin ededin axirina at
    static void Task5()
    {
    l1:
        Console.WriteLine("5. 6 reqemli eded daxil edin");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 1000000 || eded <= 99999)
            {
                goto l1;
            }

            int ilkReqem = eded / 100000;
            int a = eded % 100000;

            int cavab = a * 10 + ilkReqem;

            Console.WriteLine("Cavab: " + cavab);
        }
    }

    //6) verilmiş 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
    static void Task6()
    {
    l1:
        Console.WriteLine("6. 8 reqemli eded daxil edin: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 100000000 || eded <= 9999999)
            {
                goto l1;
            }

        }

        int cavab = (eded / 10) % 1000000;

        Console.WriteLine("Cavab: " + cavab);

    }

    //7) verilmiş 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
    static void Task7()
    {
    l1:
        Console.WriteLine("7. 4 reqemli eded daxil edin: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 10000 || eded <= 999)
            {
                goto l1;
            }

            int cavab = 0;

            while (eded > 0)
            {

                cavab += (eded % 10);
                cavab *= 10;

                eded /= 10;

            }

            cavab += 800008;

            Console.WriteLine("cavab: " + cavab);

        }
    }

    //8) verilmiş ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap
    static void Task8()
    {
    l1:
        Console.WriteLine("8. Eded daxil edin");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded <= 99)
            {
                goto l1;
            }

            int sondanUc = (eded / 100) % 10;
            int sonuncu = eded % 10;
            int cavab = sondanUc + sonuncu;

            Console.WriteLine("cavab: " + cavab);

        }
    }

    //9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
    static void Task9()
    {
    l1:
        Console.WriteLine("9. 9 reqemli eded daxil edin");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 1000000000 || eded <= 99999999)
            {
                goto l1;
            }

            int c = 0;
            int yer = 1;

            while (eded > 0)
            {
                int a = eded % 10;

                if (yer % 2 != 0)
                {
                    c = c * 10 + a;
                }

                eded /= 10;
                yer++;


            }

            int cavab = 0;

            while (c > 0)
            {
                int digit = c % 10;
                cavab = cavab * 10 + digit;
                c /= 10;
            }

            Console.WriteLine("cavab " + cavab);
        }
    }

    /* 10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
     sonra cut yerde dayanlarinda bir eded duzlet,
     sonra onlari topla */
    static void Task10()
    {
    l1:
        Console.WriteLine("10. 9 reqemli eded daxil edin");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int eded))
        {
            if (eded >= 1000000000 || eded <= 99999999)
            {
                goto l1;
            }

            int c = 0;
            int d = 0;
            int yer = 1;

            while (eded > 0)
            {
                int a = eded % 10;

                if (yer % 2 != 0)
                {
                    c = c * 10 + a;
                }

                else
                {
                    d = d * 10 + a;
                }

                eded /= 10;
                yer++;
            }

            int tekYer = 0;
            while (c > 0)
            {
                int digit = c % 10;
                tekYer = tekYer * 10 + digit;
                c /= 10;
            }

            int cutYer = 0;
            while (d > 0)
            {
                int digit = d % 10;
                cutYer = cutYer * 10 + digit;
                d /= 10;
            }

            int cavab = tekYer + cutYer;
            Console.WriteLine("cavab: " + cavab);
        }
    }

   /* 11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
    Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
    Sonra cavabin ozunden onun 18% ni cix; */
   static void Task11()
    {
        Console.WriteLine("11. 8 reqemli eded daxil edin");

        string input = Console.ReadLine();

        if(int.TryParse(input, out int eded))
        {
            int cavab = 0;

            while(eded>0)
            {
                cavab += (eded % 100);
                eded = eded / 100;
            }

            cavab = cavab * 100 + 99;

            double cavabDouble = Convert.ToDouble(cavab);

            cavabDouble = cavab - (cavab*0.18);

            Console.WriteLine("cavab: " + cavabDouble);

        }
    }

    /*12) 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne
    II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.*/
    static void Task12()
    {
    l1:
        Console.WriteLine("12. 1inci 5 reqemli ededi daxil edin");
        string input1 = Console.ReadLine();

        int eded1Cem = 0;
        if (int.TryParse(input1, out int eded1))
        {
            while (eded1 > 0)
            {
                eded1Cem += eded1 % 10;
                eded1 /= 10;
            }
        }

        else
        {
            goto l1;
        }

    l2:
        Console.WriteLine("    2inci 5 reqemli ededi daxil edin");
        string input2 = Console.ReadLine();

        int eded2Hasil = 1;
        if(int.TryParse(input2, out int eded2))
        {
            while(eded2>0)
            {
                eded2Hasil *= eded2 % 10;
                eded2 /= 10;

            }
        }

        else
        {
            goto l2;
        }

        int a = eded1Cem % 10;
        int cavab = (eded2Hasil*10) + a;

        Console.WriteLine("cavab: " + cavab);
    }

    /*13) 3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.*/
    static void Task13()
    {
        Console.WriteLine("13. 1inci 5 reqemli ededi daxil edin: ");
        string input1 = Console.ReadLine();

        int eded1Ilk = 0;
        int eded1Son = 0;

        if(int.TryParse(input1, out int eded1))
        {
            eded1Ilk = (eded1 / 10000) * 10;
            eded1Son = eded1 % 10;
            eded1Ilk += eded1Son;
        }

        Console.WriteLine("    2inci 5 reqemli ededi daxil edin: ");
        string input2 = Console.ReadLine();

        int eded2Ilk = 0;
        int eded2Son = 0;

        if (int.TryParse(input2, out int eded2))
        {
            eded2Ilk = (eded2 / 10000) * 10;
            eded2Son = eded2 % 10;
            eded2Ilk += eded2Son;
        }

        Console.WriteLine("    3inci 5 reqemli ededi daxil edin: ");
        string input3 = Console.ReadLine();

        int eded3Ilk = 0;
        int eded3Son = 0;

        if (int.TryParse(input3, out int eded3))
        {
            eded3Ilk = (eded3 / 10000) * 10;
            eded3Son = eded3 % 10;
            eded3Ilk += eded3Son;
        }

        int cem = eded1Ilk + eded2Ilk + eded3Ilk;

        double cemDouble = (int)Convert.ToDouble(cem);

        cemDouble *= 0.5;

        double cavab = cem + cemDouble;

        Console.WriteLine("cavab: " + cavab);

    }

    /* 14) 4 dene eded daxil et.Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
     6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
     Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
     Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
     Neticenin 60 % tap.Cavabin axirina 60 artir.
     Neticeden 18% cix. */
    static void Task14()
    {
    l1:
        Console.WriteLine("14. 1inci 6 reqemli ededi daxil edin: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("    2inci 6 reqemli ededi daxil edin: ");
        string input2 = Console.ReadLine();

        Console.WriteLine("    3inci 6 reqemli ededi daxil edin: ");
        string input3 = Console.ReadLine();

        Console.WriteLine("    1inci 7 reqemli ededi daxil edin: ");
        string input4 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2) && int.TryParse(input3, out int num3) && int.TryParse(input4, out int num4))
        {
            if (num1 < 100000 || num1 > 999999 || num2 < 100000 || num2 > 999999 || num3 < 100000 || num3 > 999999 || num4 < 1000000 || num4 > 9999999)
            {
                goto l1;
            }

            int Ilk3ReqeminCemi = num1 / 1000 % 10 + num2 / 1000 % 10 + num3 / 1000 % 10;
            int cem = Ilk3ReqeminCemi + num4 % 10000;
            int Ilk3ReqeminVurulmasi = (num4 / 1000000) * (num4 / 100000 % 10) * (num4 / 10000 % 10);
            int result = (int)(Ilk3ReqeminVurulmasi * 0.6) + 60;

            cem -= (int)(cem * 0.18);

            int cavab = cem - result;

            Console.WriteLine("Result: " + cavab);
        }
    }

    /*15)* 5 dene eded daxil et.Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
 Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
 Cavabdan 7 reqemli ededin son 5 reqemini cix.
 Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
 Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
 Cavabin axirina 11 artir.
 Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
 Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/
static void Task15()
    {
        {
            
            Console.WriteLine("    1inci 3reqemli eded: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("    2inci 3reqemli eded: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("    1inci 6reqemli eded: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("    2inci 6reqemli eded: ");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("    1inci 7reqemli eded: ");
            int num5 = int.Parse(Console.ReadLine());

            int UcReqemliEdedlerinCemi = num1 + num2;
            int Son2ReqeminKvadrati = (UcReqemliEdedlerinCemi % 100) * (UcReqemliEdedlerinCemi % 100);
            int UcReqemliEdedler = int.Parse(num1.ToString() + num2.ToString() + num1.ToString());

            int sum = UcReqemliEdedlerinCemi + UcReqemliEdedler;
            int YeddiReqemliEdedinSon5Reqemi = num5 % 100000;
            int AltiReqemliEdedinSon5Reqemi = (num3 % 1000) + (num4 % 1000);

            int YeddiReqemliEdedinTersi = int.Parse(new string(num5.ToString().Reverse().ToArray()));

            sum += 11;

            sum -= YeddiReqemliEdedinSon5Reqemi;

            sum += AltiReqemliEdedinSon5Reqemi;

            sum += YeddiReqemliEdedinTersi;

            int TekYerdekiReqemler = (num5 / 1000000 % 10) + (num5 / 100000 % 10) + (num5 / 1000 % 10) + (num5 / 10 % 10);
            sum -= TekYerdekiReqemler;

            int AxirdanIkinciReqem = sum / 10 % 10;
            int SonuncuReqem = sum % 10;
            sum = sum / 100 * 100 + AxirdanIkinciReqem * 1000 + 88 * 10 + SonuncuReqem;

            Console.WriteLine("cavab: " + sum);
        }


    }


}






