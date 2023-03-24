internal class Program
{
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
        SimpleDataBase <float> data = new SimpleDataBase<float>();
        data.AddNewData(13.0f);
        data.AddNewData(02.0f);
        data.AddNewData(21.0f);
        data.PrintAllData();
    }
}