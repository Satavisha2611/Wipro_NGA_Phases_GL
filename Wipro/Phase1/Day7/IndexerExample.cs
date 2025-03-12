using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class IndexerExample
    {
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string job { get; set; }

        public Employee(int id, string name, string job)
        {
            this.Id = id;
            this.Name = name;
            this.job = job;
        }

        public Object this[string name]
        {
            get
            {
                if (name.ToUpper ()== "NAME")
                    return Name;
                else if (name.ToUpper() == "JOB")
                    return job;
                else
                    return null;
            }
            set
            {

                if (name.ToUpper() == "NAME")
                     Name=value.ToString();
                else if (name.ToUpper() == "JOB")
                     job= value.ToString();
            }
        }

        public Object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return job;
                else
                    return null;
            }
            set
            {

                if (index == 0)
                   Id = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    job = value.ToString();
            }
        }
    }
}
