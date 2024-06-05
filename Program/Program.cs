using System;

public class Points
{
    private int x;
    private int y;

    // a-Noktanın koordinatlarını atamak.
    public void SetCoordinates(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // b-Noktanın koordinatlarını yazdırmak.
    public void PrintCoordinates()
    {
        Console.WriteLine($"Noktanın koordinatları: ({x}, {y})");
    }

    // c-Noktanın x koordinatını geri döndürmek.
    public int GetX()
    {
        return x;
    }

    // d-Noktanın y koordinatını geri döndürmek.
    public int GetY()
    {
        return y;
    }
}

public class Program
{
    public static void Main()
    {
        // Points sınıfından bir nesne oluşturma
        Points point = new Points();

        // Noktanın koordinatlarını atama
        point.SetCoordinates(3, 4);

        // Noktanın koordinatlarını yazdırma
        point.PrintCoordinates();

        // Noktanın x koordinatını geri döndürme ve yazdırma
        int x = point.GetX();
        Console.WriteLine($"Noktanın x koordinatı: {x}");

        // Noktanın y koordinatını geri döndürme ve yazdırma
        int y = point.GetY();
        Console.WriteLine($"Noktanın y koordinatı: {y}");
        Console.ReadLine();
    }
}
