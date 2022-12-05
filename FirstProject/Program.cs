namespace FirstProject;
using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.Unicode;
        // Azərbaycan şirifti daxil etmək Üçün istifadə
        // etdim Başqa sinifdə olduğu üçün yuxarda həmin sinifidə çağırdım 
            Console.Write("Bölünən ədədi daxil edin:");
        // Console.Write nan yazdım ,çünkü consolda keyboardnan daxil edəndə
        // tələb elədiyim mətnin qarşısında yazmağ mümükün olsun
            int a = Convert.ToInt32(Console.ReadLine());
        // burda keyboard dan daxil etdiyimiz karakteri çevir int32 e  
            Console.Write("Bölən ədədi daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());
            int Qaliq = a % c;
        Console.WriteLine(a + " /  " + c + " = " + Qaliq );
        }
    }
