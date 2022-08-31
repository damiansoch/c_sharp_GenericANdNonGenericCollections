using System;
using System.Collections;//ArrayList,Hashtable
using System.Collections.Generic;//List,Dictionary
using System.Linq;//ElementAt

namespace GenericANdNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------ArrayLists

            ArrayList myArrayList = new ArrayList(); // we can define the amount of objects (100)
            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(13.37);
            myArrayList.Add(128);
            myArrayList.Add(128);
            myArrayList.Add(25.4);
            myArrayList.Add("Google");
            myArrayList.Add(13.24);

            //removing element with specific value(first)
            myArrayList.Remove(128);
            //removing specific index
            myArrayList.RemoveAt(2);

            int count = myArrayList.Count;
            Console.WriteLine(count);


            double sum = 0;
            foreach (object obj in myArrayList)
            {


                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);

                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine("\n" + sum);


            //-------------------------------------------------------------------------------------------Lists

            //-------------------------------------------------------------------------------------------HashTables (any type key, any type value)
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new(1, "Maria", 98);
            Student stud2 = new(2, "John", 88);
            Student stud3 = new(3, "Ed", 60);
            Student stud4 = new(4, "Anna", 99);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            //storing a specific entry
            Student storedStudent1 = (Student)studentsTable[stud1.Id];//we need to cast it to type student

            //retrieving as specific entry with known Id
            Console.WriteLine("1) Id:{0}, name = {1}, GPA= {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            Console.WriteLine("\n");
            //printing all entries from the hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value; //we need to cast it to type student
                Console.WriteLine("2) id:{0}, name:{1}, GPA: {2}", temp.Id, temp.Name, temp.GPA);
            }

            Console.WriteLine("\n");
            //simplifying the above
            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine("2) id:{0}, name:{1}, GPA: {2}", student.Id, student.Name, student.GPA);
            }

            //-------------------------------------------------------------------------------------------Dictionaries generic type of hashtable (specified type key - specified type value)
            Dictionary<int, string> myDictionary = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" } };

            Employee[] employees = {
            new Employee("sales assistant", "John", 24, 14.32f),
            new Employee("secretary", "Amy", 45, 11.90f),
            new Employee("CEO", "Ben", 36, 18f),
            new Employee("manager", "James", 40, 14.44f),
            new Employee("cleaner", "Olga", 58, 12.32f),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
                Console.WriteLine("person {0} added", emp.Name);
            }

            //------------------------------------------------------------search base on value
            string search = "CEO";
            if (employeesDirectory.ContainsKey(search))
            //we can use TryGetValue() - works the same as TryParse()
            {
                Employee empl = employeesDirectory[search];
                Console.WriteLine(empl.Name);
            }
            else
            {
                Console.WriteLine("{0} wasn't found!", search);
            }

            Console.WriteLine("\n");

            //-------------------------------------------------------------adding and removing from dictionary
            //updating
            string keyToUpdate = "CEO";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Bogdan", 26, 11);
            }
            else
            {
                Console.WriteLine("{0} not found", keyToUpdate);
            }
            //removing
            string keyToRemove = "cleaner";
            if (employeesDirectory.Remove(keyToRemove))//we can do it like this because it returns a bool
            {
                Console.WriteLine("item removed");
            }
            else
            {
                Console.WriteLine("{0} not found", keyToRemove);
            }
            //add
            employeesDirectory.Add(, new Employee("cleaner", "Bogumila", 78, 5));

            //-------------------------------------------------------------search based on index
            //internally the key will always be a number(index) so we can do:
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i); //returns key-value pair at index i
                Console.WriteLine("Key {0}", keyValuePair.Key); // writing index
                //writing value
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine("name: {0},role: {1},age: {2}, rate: {3}, salary: {4}, is @ index:{5}", employeeValue.Name, employeeValue.Age, employeeValue.Role, employeeValue.Rate, employeeValue.Salary, i);
            }

        }





    }
}
