interface Ix
{
    void F0(int k);
    void F1(int k, out int i);
}
interface Iy
{
    void F0(int k);
    void F1(int k);
}

class Class1 : Ix, Iy
{
    int w;
    void Ix.F0(int k)
    {
        w = k * w * w;
    }
    public void IxF0(int k)
    {
        w = k * w * w;
    }
    void Ix.F1(int k, out int i)
    {
        i = 2 * w - k;
    }
    public void IxF1(int k, out int i)
    {
        i = 2 * w - k;
    }
    void Iy.F0(int k)
    {
        w = Math.Abs(w) - k;
    }
    public void IyF0(int k)
    {
        w = Math.Abs(w) - k;
    }
    void Iy.F1(int k)
    {
        Console.WriteLine("F1 from Iy: " + (2 * w - k));
    }

    public void IyF1(int k)
    {
        Console.WriteLine("F1 from Iy: " + (2 * w - k));
    }

    public void SetW(int value)
    {
        w = value;
    }
    public void PrintW()
    {
        Console.WriteLine("W value: " + w);
    }
}

class Class2 : Ix, Iy
{
    int w;
    public void SetW(int value)
    {
        w = value;
    }
    public void PrintW()
    {
        Console.WriteLine("W value: " + w);
    }
    public void F0(int k)
    {
        w = k * w * w;
    }
    public void F1(int k, out int i)
    {
        i = 2 * w - k;
    }
    void Iy.F1(int k)
    {
        Console.WriteLine("F1 from Iy: " + (2 * w - k));
    }
}
class Program
{
    public static void Main()
    {
        char[] a = {'a', 'b', 'c', 'r', 'c', 'a', 'a','b'};
        char k = 'a';
        for(int i = 0; i < 8; ++i)
        {
            if (a[i] > k)
            {
                k = a[i];
                Console
            }
        }
    }
}
