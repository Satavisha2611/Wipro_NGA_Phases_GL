namespace DemoRazor.Model
{
    public class EmployeeData
    {
        public int id {  get; set; }    
        public string name { get; set; }
        public int age { get; set; }

        public EmployeeData(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


    }
}
