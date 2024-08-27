using _1newProject;
using _1newProject.Data;
using _1newProject.Models;

internal class Program
{
    public static void Main(string[] args)
    {

        UserModel.Request userModelRequest = new UserModel.Request();
        userModelRequest.TCNumber = "123";

        //Gerekli Newlemeri Yaptım
        TCNumberControl tCNumberControl = new TCNumberControl();

        //Kullanıcıdan TCKimlik istedim ve compare methodunu çalıştırdım
        Console.WriteLine("Lütfen TC kimlik Giriniz");
        string TcNumber = Convert.ToString(Console.ReadLine());
        tCNumberControl.Compare(TcNumber, userModelRequest);

        //int number = 10;

        //// 'ptr' adında bir işaretçi tanımlıyoruz ve 'number' değişkeninin adresini işaret ediyoruz.
        //int* ptr = &number;

        //// 'ptr' işaretçisinin gösterdiği adresin değerini ekrana yazdırıyoruz.
        //Console.WriteLine("number değeri: " + *ptr); // Çıktı: number değeri: 10

        //// 'ptr' işaretçisinin değerini değiştiriyoruz.
        //*ptr = 20;

        //// 'number' değişkeninin güncellenmiş değerini ekrana yazdırıyoruz.
        //Console.WriteLine("Güncellenmiş number değeri: " + number); // Çıktı: Güncellenmiş number değeri: 20


        //int a = 10;
        //int b = a;
        //Console.WriteLine("number değeri: " + b);
        //b = 20;
        //Console.WriteLine("Güncellenmiş number değeri: " + a);

    }
}