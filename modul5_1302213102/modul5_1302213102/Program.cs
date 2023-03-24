internal class Program
{
    class penjumlahan
    {
        public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic penjumlahan = (dynamic)angka1 + (dynamic)angka2+ (dynamic)angka3;
            Console.WriteLine("Hasil Penjumlahan : " + penjumlahan);
        }
    }
    private static void Main(string[] args)
    {
        penjumlahan jumlah = new penjumlahan();
        jumlah.JumlahTigaAngka<float>(13, 02, 21);
    }
}