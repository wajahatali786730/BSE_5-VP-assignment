using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;



namespace VpAssignment_
{
    class Profile
    {
        public int stdId { get; set; }
        public string stdName { get; set; }
        public int stdSemester { get; set; }
        public double stdCgpa { get; set; }
        public string stdDepartment { get; set; }
        public string stdUniversity { get; set; }
        public Char stdAttendance { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\A\source\repos\VpAssignment!\std.bin";
            string path2 = @"C:\Users\A\source\repos\VpAssignment!\std1.bin";
            int size = 0;
            int temp;
            int temp1 = 0;
            Profile[] obj1 = new Profile[size];
            Profile[] obj2 = new Profile[size];
            int ch, ch1;
            char t = 'y';
            while (t == 'y')
            {
                // Console.WriteLine("_____________________________________");
                // Console.WriteLine("--------------------------------------");
                //Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tVisual programming Assignment");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tCode written by wajahat Ali");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tEnrollment # 01-131172-031");

                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tSubmitted to Sir Naeem");
                Console.WriteLine("________________________________________________________________________________________________________________________\n");
                // Console.WriteLine("------------------------------------------ ");

                Console.WriteLine("select one of the the following option: \n");
                Console.WriteLine("\t\t\t\t\tpress 1 for creating student profile:");
                Console.WriteLine("\t\t\t\t\tpress 2 for search student :         ");
                Console.WriteLine("\t\t\t\t\tpress 3 for Delete student record");
                Console.WriteLine("\t\t\t\t\tpress 4 for List Top 3 student of the class:");
                Console.WriteLine("\t\t\t\t\tpress 5 for Mark attendance:");
                Console.WriteLine("\t\t\t\t\tpress 6 view attendance:");
                Console.WriteLine("\t\t\t\t\tpress 7 for Exit:");

                Console.Write("select one of the above option:");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tVisual programming Assignment");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tCode written by wajahat Ali");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tEnrollment # 01-131172-031");

                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tSubmitted to Sir Naeem");
                        Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
                        Console.Write("enter the number of student profile You want to create:");
                        size = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\n");
                        obj1 = new Profile[size];
                        obj2 = new Profile[size];

                        for (int i = 0; i < size; i++)
                        {
                            Console.Write("Enter student id :");
                            temp = Convert.ToInt32(Console.ReadLine());
                            for (int j = 0; j < i; j++)
                            {
                                if (obj1[j].stdId == temp)
                                {
                                    temp1 = 1;
                                    break;
                                }
                            }
                            if (temp1 == 0)
                            {
                                obj1[i] = new Profile();
                                obj1[i].stdId = temp;
                                Console.Write("Enter the stduent name :");
                                obj1[i].stdName = Convert.ToString(Console.ReadLine());
                                Console.Write("Enter the student Semester :");
                                obj1[i].stdSemester = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the student CGPA:");
                                obj1[i].stdCgpa = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter the department name :");
                                obj1[i].stdDepartment = Convert.ToString(Console.ReadLine());
                                Console.Write("Enter the Univeristy name :");
                                obj1[i].stdUniversity = Convert.ToString(Console.ReadLine());
                                if (File.Exists(path1))
                                {
                                    using (BinaryWriter writer = new BinaryWriter(File.Open(path1, FileMode.Append)))
                                    {



                                        writer.Write(obj1[i].stdId);
                                        writer.Write(obj1[i].stdName);
                                        writer.Write(obj1[i].stdSemester);
                                        writer.Write(obj1[i].stdCgpa);
                                        writer.Write(obj1[i].stdDepartment);
                                        writer.Write(obj1[i].stdUniversity);
                                        writer.Flush();



                                    }
                                }
                                else
                                {
                                    using (BinaryWriter writer = new BinaryWriter(File.Open(path1, FileMode.Create)))
                                    {

                                        writer.Write(obj1[i].stdId);
                                        writer.Write(obj1[i].stdName);
                                        writer.Write(obj1[i].stdSemester);
                                        writer.Write(obj1[i].stdCgpa);
                                        writer.Write(obj1[i].stdDepartment);
                                        writer.Write(obj1[i].stdUniversity);
                                        writer.Flush();
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("The Data of the student is aready existed ,kindly renter your Data");
                                i--;
                                temp1 = 0;
                                continue;
                            }

                        }
                        break;


                    case 2:

                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tVisual programming Assignment");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tCode written by wajahat Ali");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tEnrollment # 01-131172-031");

                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tSubmitted to Sir Naeem");
                        Console.WriteLine("________________________________________________________________________________________________________________________\n");
                        Console.WriteLine("Select Menu:");
                        Console.WriteLine("\t\tpress 1 Search by Id");
                        Console.WriteLine("\t\tpress 2  Search by Name");
                        Console.WriteLine("\t\tpress 3 Total number of Student");
                        Console.WriteLine("\t\tpress 4 Back to main Menu");

                        Console.WriteLine("please select one of the above option");
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        int k = 0;
                        switch (ch1)
                        {
                            case 1:
                                int ID;
                                int x, sem;
                                Double cg;
                                string nam, dept, uni;
                                Console.Write("Enter ID Please  :  ");
                                ID = Convert.ToInt16(Console.ReadLine());
                                if (File.Exists(path1))
                                {
                                    using (BinaryReader reader = new BinaryReader(File.Open(path1, FileMode.Open)))
                                    {
                                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                                        {
                                            // It is importan

                                            x = reader.ReadInt32();
                                            nam = reader.ReadString();
                                            sem = reader.ReadInt32();
                                            cg = reader.ReadDouble();
                                            dept = reader.ReadString();
                                            uni = reader.ReadString();
                                            if (x == ID)
                                            {
                                                k = 1;
                                                Console.WriteLine(String.Format("{0,-10}  {1,20}  {2,12}   {3,13}  {4,23}  {5,25}", x, nam, sem, cg, dept, uni));
                                                break;
                                            }
                                        }
                                    }
                                }



                                if (k == 0)
                                {
                                    Console.WriteLine("NOT FOUND");
                                }
                                else
                                {
                                    k = 0;
                                }
                                try
                                {
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("OBJECT IS NOT DEFINED ", e);
                                }

                                break;


                            case 2:
                                string name;
                                Console.Write("Enter Name Please  :    ");
                                name = Console.ReadLine();


                                int x1, sem1;
                                Double cg1;
                                string nam1, dept1, uni1;

                                if (File.Exists(path1))
                                {
                                    using (BinaryReader reader = new BinaryReader(File.Open(path1, FileMode.Open)))
                                    {
                                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                                        {


                                            x1 = reader.ReadInt32();
                                            nam1 = reader.ReadString();
                                            sem1 = reader.ReadInt32();
                                            cg1 = reader.ReadDouble();
                                            dept1 = reader.ReadString();
                                            uni1 = reader.ReadString();
                                            if (nam1 == name)
                                            {
                                                k = 1;
                                                Console.WriteLine(String.Format("{0,-10}  {1,20}  {2,12}   {3,13}  {4,23}  {5,25}", x1, nam1, sem1, cg1, dept1, uni1));
                                                break;
                                            }
                                        }
                                    }
                                }



                                if (k == 0)
                                {
                                    Console.WriteLine("NOT FOUND");
                                }
                                else
                                {
                                    k = 0;
                                }

                                try
                                {
                                    if (k == 1)
                                    {

                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("OBJECT IS NOT DEFINED ", e);
                                }
                                break;





                            case 3:

                                Console.WriteLine(String.Format("{0,-10}  {1,20}  {2,12}  {3,13}  {4,23}  {5,25}", "ID", "NAME", "SEMESTER", "CGPA", "DEPARTMENT", "UNIVERISTY"));
                                Console.WriteLine("\n");
                                int temp5, semester2;
                                double CGPA2;
                                string name2, department2, university2;
                                if (File.Exists(path1))
                                {
                                    using (BinaryReader reader = new BinaryReader(File.Open(path1, FileMode.Open)))
                                    {
                                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                                        {
                                            temp5 = reader.ReadInt32();
                                            name2 = reader.ReadString();
                                            semester2 = reader.ReadInt32();
                                            CGPA2 = reader.ReadDouble();
                                            department2 = reader.ReadString();
                                            university2 = reader.ReadString();

                                            Console.WriteLine(String.Format("{0,-10}  {1,20}  {2,12}  {3,13}  {4,23}  {5,25}", temp5, name2, semester2, CGPA2, department2, university2));

                                        }
                                    }
                                }
                                break;

                            case 4:


                                break;
                        }

                        break;

                    case 3:

                        int id;
                        int h = 0;
                        int l = 0;
                        Console.Write("Enter ID Please  :    ");
                        id = Convert.ToInt16(Console.ReadLine());
                        int x3, sem3;
                        Double cg3;
                        string nam3, dept3, uni3;
                        if (File.Exists(path1))
                        {
                            using (BinaryReader reader = new BinaryReader(File.Open(path1, FileMode.Open)))
                            {
                                obj1 = new Profile[reader.BaseStream.Length];
                                while (reader.BaseStream.Position != reader.BaseStream.Length)
                                {
                                    // It is importan

                                    x3 = reader.ReadInt32();
                                    nam3 = reader.ReadString();
                                    sem3 = reader.ReadInt32();
                                    cg3 = reader.ReadDouble();
                                    dept3 = reader.ReadString();
                                    uni3 = reader.ReadString();
                                    if (x3 != id)
                                    {

                                        obj2[l] = new Profile();
                                        obj2[l].stdId = x3;
                                        obj2[l].stdName = nam3;
                                        obj2[l].stdSemester = sem3;
                                        obj2[l].stdCgpa = cg3;
                                        obj2[l].stdDepartment = dept3;
                                        obj2[l].stdUniversity = uni3;
                                        l++;
                                    }
                                    if (x3 == id)
                                    {
                                        h = 1;
                                    }
                                }
                            }
                        }

                        using (BinaryWriter writer = new BinaryWriter(File.Open(path1, FileMode.Create)))
                        {
                            for (int i = 0; i < l; i++)
                            {





                                writer.Write(obj2[i].stdId);
                                writer.Write(obj2[i].stdName);
                                writer.Write(obj2[i].stdSemester);
                                writer.Write(obj2[i].stdCgpa);
                                writer.Write(obj2[i].stdDepartment);
                                writer.Write(obj2[i].stdUniversity);
                                writer.Flush();
                            }
                            if (h == 1)
                            {
                                Console.WriteLine("                                            Deleted succesfully                     ");
                            }
                            else
                            {
                                Console.WriteLine("                                   NOT DELETED PLEASE ENTER VALID ID ");
                            }
                        }
                        break;

                    case 4:
                        Double a = 0, b = 0, c = 0;
                        int temp7, sem4;
                        Double cg4;
                        string nam4, dept4, uni4;

                        if (File.Exists(path1))
                        {
                            using (BinaryReader reader = new BinaryReader(File.Open(path1, FileMode.Open)))
                            {

                                while (reader.BaseStream.Position != reader.BaseStream.Length)
                                {
                                    // It is importan


                                    temp7 = reader.ReadInt32();
                                    nam4 = reader.ReadString();
                                    sem4 = reader.ReadInt32();
                                    cg4 = reader.ReadDouble();
                                    dept4 = reader.ReadString();
                                    uni4 = reader.ReadString();
                                    if (cg4 > a)
                                    {
                                        c = b;
                                        b = a;
                                        a = cg4;
                                    }
                                    else if (cg4 < a)
                                    {

                                        if (cg4 < b)
                                        {
                                            if (cg4 > c)
                                            {
                                                c = cg4;
                                            }
                                        }
                                        else
                                        {
                                            c = b;
                                            b = cg4;
                                        }
                                    }

                                }
                            }

                        }

                        Console.WriteLine("First Highest CGPA is = " + a);
                        Console.WriteLine("Second Highest CGPA is = " + b);
                        Console.WriteLine("Third Highest CGPA is = " + c);
                        break;

                    case 5:


                        char tom;
                        Console.WriteLine(String.Format("{0,-10}  {1,14} {2,27}", "ID", "NAME", "ATTENDANCE"));
                        int temp8, semesterX;
                        double cgpa7;
                        string namestd, deptstd, unistd;

                        if (File.Exists(path1))
                        {
                            using (BinaryReader reader = new BinaryReader(File.Open(path1, FileMode.Open)))
                            {
                                using (BinaryWriter writer = new BinaryWriter(File.Open(path2, FileMode.Create)))
                                {
                                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                                    {
                                        temp8 = reader.ReadInt32();
                                        namestd = reader.ReadString();
                                        semesterX = reader.ReadInt32();
                                        cgpa7 = reader.ReadDouble();
                                        deptstd = reader.ReadString();
                                        unistd = reader.ReadString();
                                        Console.Write(string.Format("{0,-18} {1,6}", temp8, namestd));
                                        Console.Write("\t\t\t");
                                        tom = Convert.ToChar(Console.ReadLine());
                                        if (tom == 'A' || tom == 'p')
                                        {
                                            if (File.Exists(path1))
                                            {
                                                writer.Write(temp8);
                                                writer.Write(namestd);
                                                writer.Write(tom);
                                                writer.Flush();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("YOu marked the attendance incorrectly, please mark it again");
                                            reader.BaseStream.Position -= 33;
                                        }
                                    }

                                }
                            }
                        }
                        break;


                    case 6:


                        Console.WriteLine(String.Format("{0,-10}  {1,20} {2,28}", "ID ", "NAME", "ATTENDANCE"));

                        int temp0;
                        char tom0;
                        string stdNameX;

                        if (File.Exists(path1))
                        {
                            using (BinaryReader reader = new BinaryReader(File.Open(path2, FileMode.Open)))
                            {
                                while (reader.BaseStream.Position != reader.BaseStream.Length)
                                {
                                    temp0 = reader.ReadInt32();
                                    stdNameX = reader.ReadString();
                                    tom0 = reader.ReadChar();

                                    Console.WriteLine(string.Format("{0,-10} {1,20} {2,24}", temp0, stdNameX, tom0));
                                }
                            }
                        }
                        break;

                    case 7:

                        Environment.Exit(0);

                        break;

                }
                Console.WriteLine("continu : Y/N ?");

                t = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            }
            Console.ReadKey();





















        }


    }
}

