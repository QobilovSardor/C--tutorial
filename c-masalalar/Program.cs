using System;
class Program
{
  static void Main(string[] args)
  {
    // varialbes, int, const, double
    // data type, string, number ....
    // ================1-masala================
    /*
      int a, p;

      // kvadratning tomonini so'rash
      Console.Write("Kvadratning tomonini kiriting: ");
      // qabul qilingan javobni number tipiga o'girish bo'limi
      a = Convert.ToInt32(Console.ReadLine());
      // p o'zgaruvchisida masalani javobini saqlayapmiz.
      p = 4 * a;
      // javobni console ga chiqorayapmiz
      Console.WriteLine("Primetr javobi: " + p);
    */
    // ================2-masala================
    /*
      int a, s;
      Console.Write("Kvadratning tomonini kiriting: ");
      a = Convert.ToInt32(Console.ReadLine());
      s = a * a; // kvadratga ko'tarish
      Console.WriteLine("Kvadratning yuasi: " + s);
    */

    // ================3-masala================
    /*
      int a, b, s, p;
      // a sonini olish
      Console.Write("A soni kiriting: ");
      a = Convert.ToInt32(Console.ReadLine());

      // b sonini olish
      Console.Write("B soni kiriting: ");
      b = Convert.ToInt32(Console.ReadLine());

      // yuzani aniqlash
      s = a * b;
      Console.WriteLine("To'rtburchaking yuzasi: " + s);

      // premetirni aniqlash
      p = 2 * (a + b);
      Console.WriteLine("Premetir javobi: " + p);
    */

    // ================4-masala================
    /*
      double d, l;
      double p = 3.14;
      Console.Write("D soni kiriting: ");
      d = Convert.ToDouble(Console.ReadLine());
      l = p * d;
      Console.WriteLine("Diametrning uzunligi: " + l);
    */
  }
}
