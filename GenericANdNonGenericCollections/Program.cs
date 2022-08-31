using System;
using System.Collections;//ArrayList,Hashtable
using System.Collections.Generic;//List,

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



            Console.ReadKey();

            //-------------------------------------------------------------------------------------------Lists

            //-------------------------------------------------------------------------------------------HashTables
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

        }

        // key - value -> they can be a different type
        class Student
        {
            //constructor
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }


        }

    }
}
