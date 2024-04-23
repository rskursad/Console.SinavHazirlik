namespace hamzasinav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boy, no, fark =0, enKucukFark = int.MaxValue,  tutNo = 0;
            string tutucu = " ";
            while (true)
            {
                Console.WriteLine("öğrenci no giriniz");
                no = int.Parse(Console.ReadLine());
                Console.WriteLine("boyunuzu giriniz");
                boy = int.Parse(Console.ReadLine());

                fark = Math.Abs(150 - boy);
                if (fark<enKucukFark)
                {
                    enKucukFark=fark;
                    tutucu = "150cm' ye en yakın öğrencinin boyu: " + boy+" Öğrencinin numarası: "+no;
                }
                if (no<0)
                {
                    break;
                }    
            }
            Console.WriteLine(tutucu);
        }
    }
}
