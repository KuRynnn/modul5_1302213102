internal class Program
{
    class penjumlahan
    {
        public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic penjumlahan = (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
            Console.WriteLine("Hasil Penjumlahan : " + penjumlahan);
        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData= new List<T>();
            inputDates= new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            DateTime waktu = DateTime.Now;
            inputDates.Add(waktu);
        }
        public void PrintAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + "  berisi: " + storedData[i] + ", yang disimpan pada waktu UTC " + inputDates[i]);
            }
        }
    }
    private static void Main(string[] args)
    {

        penjumlahan jumlah = new penjumlahan();
        jumlah.JumlahTigaAngka<float>(13, 02, 21);

        SimpleDataBase <float> data = new SimpleDataBase<float>();
        data.AddNewData(13.0f);
        data.AddNewData(02.0f);
        data.AddNewData(21.0f);
        data.PrintAllData();
    }
}