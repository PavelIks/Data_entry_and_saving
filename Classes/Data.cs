namespace SaveTXTFileDate.Classes
{
    class Data
    {
        public string first_Name;
        public string middle_Name;
        public string last_Name;
        public int age;

        public Data(string new_first_name, string new_middle_name, string new_last_name, int new_age)
        {
            first_Name = new_first_name;
            middle_Name = new_middle_name;
            last_Name = new_last_name;
            age = new_age;
        }
    }
}