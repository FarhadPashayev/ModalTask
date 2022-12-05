namespace FirstProject;
using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.Unicode;
        // Azərbaycan şirifti daxil etmək Üçün istifadə
        // etdim Başqa sinifdə olduğu üçün yuxarda həmin sinifidə çağırdım
        Console.WriteLine("Xoş gəlmisiniz bir kalkulyator təsəvvür edin sadəcə toplayır tanış olmağ üçün enter basmağ kifayətdir");
            var userInput = Console.ReadKey();
        
            
           if (userInput.Key == ConsoleKey.Enter) {
            Console.Write("1-ci Rəqəmi daxil edin:");
            }
           
        // Console.Write nan yazdım ,çünkü consolda keyboardnan daxil edəndə
        // tələb elədiyim mətnin qarşısında yazmağ mümükün olsun
            int a = Convert.ToInt32(Console.ReadLine());
        // burda keyboard dan daxil etdiyimiz karakteri çevir int32 e  
            Console.Write("2-ci ədədi daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());
            int Sum = a + c;
        Console.WriteLine(a + " +  " + c + " = " + Sum );
        }
    }
