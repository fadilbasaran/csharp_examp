

       

        byte b = 5;//1 byte
        sbyte c = 5;//1 byte

        short s = 5;//2 byte
        ushort us = 5;//2 byte


        short i16 = 2;//2 byte
        int i = 2;//4 byte
        int i32 = 2;//4 byte
        long i64 = 2;//8 byte

        uint ui = 2;//4 byte
        long l = 4;// 8 byte
        ulong ul = 22;// 8 byte


        //Reel Sayılar

        float f = 5.09f;// 4 byte
        double d = 5;// 8 byte
        decimal dec = 3.33m;// 16 byte

        char ch='s'; //2 byte
        string str ="Alice";// Sınırsız

        bool b0= false;//
        bool b1 = true;
        Console.WriteLine("Hello, World!");
        DateTime date = DateTime.Now;

        Console.WriteLine(date);


        object o1="x";//HEr veri aktarılabilir
        object o2='c';
        object o3=4;
        object  o4=4.5m;
        

        //string ifaddeler

        string str1=string.Empty;

        str1="Ali";

        Console.WriteLine(str1);

        bool bool1=20>2;


        string str20="20";

        int int20=20;
        string yeniDeger=str20+ int20.ToString();
        Console.WriteLine(yeniDeger);
        int int21=int20+ Convert.ToInt32(str20);

        Console.WriteLine(int21);//Çıktı 40

        int int22= int20+int.Parse(str20);//Çıktı 40

        string datetime=DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime1=DateTime.Now.ToString("HH:mm");
        Console.WriteLine(datetime1);


