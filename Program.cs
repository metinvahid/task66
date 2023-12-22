using System.ComponentModel.Design.Serialization;

namespace _13dekabrtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstMethod();
            SecondMethod();
            ThirdMethod();
            FourthMethod();
            FifthMethod();
            SixthMethod();
            SeventhMeth();
            EighthMeth();
            NinthMeth();
            TenthMeth();
            EleventhMeth();
            Task12();
            Task13();
            Task14();
            Task16();
            {
                Console.WriteLine("Metn daxil edin");
                string text = Console.ReadLine();

                string newText = "";
                for (int i = 0; i < text.Length; i++)
                {
                    char currentChar = text[i];
                    if (i % 2 == 0)
                    {
                        //Console.Write(char.ToUpper(currentChar));
                        newText += Char.ToUpper(text[i]);


                    }
                    else
                    {

                        //Console.Write(char.ToLower(currentChar));
                        newText += Char.ToLower(text[i]);
                    }

                }

            }
            Task14();





        }

        static void FirstMethod()
        {
        l1:
            Console.WriteLine("Daxilinde a ve ya b simvollarindan ibaret bir metn daxil edin:");
            string text = Console.ReadLine();
            char aSimvolu = 'a';
            char bSimvolu = 'b';
            int aamount = 0;
            int bamount = 0;

            foreach (char a in text)
            {
                if (a == 'a')
                {
                    aamount++;
                }
            }
            foreach (char b in text)
            {
                if ((b == 'b'))
                {
                    bamount++;
                }
            }
            if (aamount == 0)
            {
                Console.WriteLine(" a simvolunun sayi 0-a beraberdir");
                goto l1;
            }
            if ((bamount == 0))
            {
                Console.WriteLine("b simvolunun sayi 0-a beraberdir");
                goto l1;
            }
            Console.WriteLine($"Daxil edilen melumatdaki a simvolunun sayi {aamount},b simvolunun sayi ise {bamount}-dir");
            int ratio = aamount / bamount;
            Console.WriteLine($"simvollarin saylari arasindaki nisbet {ratio}-dir");
            Console.WriteLine(" ");
















        }

        static void SecondMethod()
        {
            Console.WriteLine("Metn daxil edin");
        l2:
            string text = Console.ReadLine();
            char aSimvolu = 'a';
            //for (int i = 1; i < text.Length; i += 2) cutler ucun
            for (int i = 0; i < text.Length; i += 2)
            {
                if (text[i] != aSimvolu)
                {
                    Console.WriteLine("Tek yerde duran  simvollarin hamsi a-deyil");
                    goto l2;
                }
            }
            Console.WriteLine("Tek yerde duranlarin hamsi a simvoludur ");



        }


        static void ThirdMethod()
        {
            Console.WriteLine("Metn daxil edin");
        l3:
            string text = Console.ReadLine();
            //Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.
            char bSimvolu = 'b';
            int bamount = 0;
            for (int i = 0; i < text.Length; i += 2)
            {
                if (text[i] == bSimvolu)
                {
                    bamount++;
                }
            }
            Console.WriteLine($"Tek yerde duran b simvollarinin sayi:{bamount}-dir");
            Console.WriteLine(" ");





        }

        static void FourthMethod()
        {
            Console.WriteLine("Metn daxil edin");
            string text = Console.ReadLine();
            char aSimvolu = 'a';
            int a = text.IndexOf(aSimvolu);
            if ((a + 1) % 2 == 0)
            {
                Console.WriteLine("A simvolu cut yerde yerlesir");
            }
            else
            {
                Console.WriteLine("A simvolu tek yerde yerlesir");

            }
            Console.WriteLine(" ");

        }

        static void FifthMethod()
        {
            Console.WriteLine("Daxilinde a,b,c  simvollari olan bir metn daxil edin:");
        l5:
            // Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?
            string text = Console.ReadLine();
            int a = text.IndexOf('a');
            int b = text.IndexOf('b');
            int c = text.IndexOf('c');

            if (a == -1 || b == -1 || c == -1)
            {
                Console.WriteLine("Simvollardan hansisa yoxdur:");
                goto l5;
            }
            else
            {
                if (a < c && a < b)
                {
                    Console.WriteLine("Ilk gelen simvol a-dir");
                }
                else if (b < a && b < c)
                {
                    Console.WriteLine("Ilk gelen simvol b-dir");
                }
                else if (c < a && c < b)
                {
                    Console.WriteLine("Ilk gelen simvol c-dir");
                }
            }
            Console.WriteLine(" ");


        }

        static void SixthMethod()
        {
            //Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            string text = Console.ReadLine();
            int a1 = text.IndexOf('a');
            int ason = text.LastIndexOf("a");

            if (a1 == ason)
            {
                Console.WriteLine("a simvolunun sol ve sag terefden indexleri eynidir");
            }
            else
            {
                Console.WriteLine("a simvolunun sol ve sag terefden indexleri eyni deyil");


            }

            Console.WriteLine(" ");









        }

        static void SeventhMeth()
        {
            Console.WriteLine("Daxilinde a,b,c simvollari olan bir metn daxil edin:");
        l8:
            string text = Console.ReadLine();

            int a = text.IndexOf('a');
            int b = text.IndexOf('b');
            int c = text.IndexOf('c');

            if (a == -1 || b == -1 || c == -1)
            {
                Console.WriteLine("Simvollardan hansisa yoxdur!");
                goto l8;
            }
            else
            {
                if (a < b && b < c)
                {
                    Console.WriteLine("a simvolu b simvolundan qabaq ve b simvolu ise c simvolundan qabaq gelir ");
                }
                else
                {
                    Console.WriteLine("A simvolu b simvolundan qabaq b simvolu ise c simvolundan qabaq gelmelidir!");
                    goto l8;
                }
            }
            Console.WriteLine(" ");

        }

        static void EighthMeth()
        {
            Console.WriteLine("Metn daxil edin ");
            string text = Console.ReadLine();
            int a = text.IndexOf('a');
            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine(text[a + 1]);
            }
            Console.WriteLine(" ");

        }

        static void NinthMeth() //*
        {
            Console.WriteLine("Metn daxil edin");
        l9:
            string text = Console.ReadLine();
            int a = text.Length;
            char a1 = text[a - 1];
            char a2 = text[a - 2];
            char a3 = text[a - 3];

            char b1 = text[0];
            char b2 = text[1];
            char b3 = text[2];

            if (a1 == b1 && a2 == b2 && a3 == b3)
            {
                Console.WriteLine("Daxil edilmis metndeki ilk 3 simvol son 3 simvolun ters formasi ile eynidir!");

            }

            else
            {
                Console.WriteLine("Eyni deil");
                goto l9;
            }
        }
        static void TenthMeth() //*
        {
            string text = Console.ReadLine();
            string result = "";
            foreach (char c in text)
            {

                if (char.IsLetter(c))
                {
                    result += c;
                }
            }

            Console.WriteLine(result);
            Console.WriteLine(" ");
        }

        static void EleventhMeth()
        {
            Console.WriteLine("Metn daxil edin:");
            string text = Console.ReadLine();

            string change = "";
            foreach (char c in text)
            {
                if (c == 'a')
                {
                    change += 'b';
                }
                if (c == 'b')
                {
                    change += 'a';
                }
                change += c;
            }
            Console.WriteLine($"evezlenmis string:{change}");
        }

        static void Task12()
        {
        //12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. 
        l1:
            Console.Write("Metn daxil edin:");
            string text = Console.ReadLine();

            Console.WriteLine(text);
            int firstAIndex = text.IndexOf('a');


            if (firstAIndex != -1)
            {

                int lastAIndex = text.LastIndexOf('a');


                if (firstAIndex == lastAIndex)
                    Console.WriteLine(text); ;


                string middleSection = text.Substring(firstAIndex + 1, lastAIndex - (firstAIndex + 1));
                string modifiedStr = text.Substring(0, firstAIndex + 1) + middleSection.Replace("a", "") + text.Substring(lastAIndex);


                Console.WriteLine(modifiedStr); ;
            }

            else
            {
                Console.WriteLine("Daxil etdiyiniz metnde a simvolu yoxdur:");
                goto l1;
            }


        }

        static void Task13()
        {
            Console.WriteLine("Metn daxil edin");
            string text = Console.ReadLine();

            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (i % 2 == 0)
                {
                    //Console.Write(char.ToUpper(currentChar));
                    newText += Char.ToUpper(text[i]);


                }
                else
                {

                    //Console.Write(char.ToLower(currentChar));
                    newText += Char.ToLower(text[i]);
                }

            }

        }

        static void Task14()
        {


            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et. 


            string text = Console.ReadLine();

            for (int i = 0; i < text.Length - 1; i++)
            {
                char x = text[i + 1];

                if (char.IsLetter(x))
                {




                    if (i % 2 == 0)
                    {

                        text = text.Remove(i, 1);
                        text = text.Insert(i, Char.ToUpper(x).ToString());


                    }

                }

            }

            Console.WriteLine(text);

        }
         

         static void Task16()
            {
                for (int a = 0; a <= 10; a++)
                {
                    for (int b = 0; b <= 10; b++)
                    {
                        Console.WriteLine("{0}x{1}", a, b, a * b);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();


            }
        }

    }

        
    

