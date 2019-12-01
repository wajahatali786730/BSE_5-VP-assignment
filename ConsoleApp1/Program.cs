using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class StudentProfile
    {
        public void getdata(string way, int id, string name, float cgpa, int semester, string dept, string university)
        {
            using (StreamWriter file = File.AppendText(way))
            {
                file.WriteLine(id);
                file.WriteLine(name);
                file.WriteLine(cgpa);
                file.WriteLine(semester);
                file.WriteLine(dept);
                file.WriteLine(university);
            }
        }
        public void searchbyid(string Path, int newid)
        {
            bool check = false;
            StreamReader find = new StreamReader(Path);
            string line = "";
            while ((line = find.ReadLine()) != null)
            {
                int temp;
                int.TryParse(line, out temp);
                if (int.TryParse(line, out temp))
                {
                    if (newid == temp)
                    {
                        check = true;
                        Console.WriteLine("ID: " + newid);
                        string name = find.ReadLine();
                        Console.WriteLine("NAME: " + name);
                        float cgpa = float.Parse(find.ReadLine());
                        Console.WriteLine("CGPA: " + cgpa);
                        int sem = int.Parse(find.ReadLine());
                        Console.WriteLine("SEMESTER: " + sem);
                        string dept = find.ReadLine();
                        Console.WriteLine("DEPARTMENT: " + dept);
                        string uni = find.ReadLine();
                        Console.WriteLine("UNIVERSITY: " + uni);
                        break;
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("Couldnot Find such ID");
            }
        }
        public void searchbyname(string Path, string name)
        {
            bool check = false;
            StreamReader find = new StreamReader(Path);
            string line = "";
            while ((line = find.ReadLine()) != null)
            {
                string id = line;
                if ((line = find.ReadLine()) == name)
                {
                    check = true;
                    Console.WriteLine("ID: " + id);
                    Console.WriteLine("NAME:" + name);
                    float cgpa = float.Parse(find.ReadLine());
                    Console.WriteLine("CGPA: " + cgpa);
                    int sem = int.Parse(find.ReadLine());
                    Console.WriteLine("SEMESTER:" + sem);
                    string dept = find.ReadLine();
                    Console.WriteLine("DEPARTMENT:" + dept);
                    string uni = find.ReadLine();
                    Console.WriteLine("UNIVERSTY:" + uni);
                    break;
                }

            }
            if (check == false)
            {
                Console.WriteLine("couldnot find such name in the file");
            }
        }
        public void searchbysem(string Path, string bysem)
        {
            bool check = false;
            StreamReader find = new StreamReader(Path);
            string line = "";
            string list = "";
            string match = "";
            while ((match = find.ReadLine()) != null && (list = find.ReadLine()) != null && (line = find.ReadLine()) != null)
            {
                string id = match;
                string name = list;
                string cgpa = line;
                if ((match = find.ReadLine()) == bysem || (list = find.ReadLine()) == bysem || (line = find.ReadLine()) == bysem)
                {
                    check = true;
                    Console.WriteLine("ID:" + id);
                    Console.WriteLine("NAME:" + name);
                    Console.WriteLine("CGPA:" + cgpa);
                    Console.WriteLine("SEMESTER:" + bysem);
                    string dept = find.ReadLine();
                    Console.WriteLine("DEPARTMENT:" + dept);
                    string uni = find.ReadLine();
                    Console.WriteLine("UNIVERSITY:" + uni);
                }
            }
            if (check == false)
            {
                Console.WriteLine("Couldnot Find such semester");
            }

        }
        public void markAttendance(string marked, string path, string semester)
        {
            bool check = false;
            StreamReader list = new StreamReader(path);
            string line = "";
            string find = "";
            string match = "";
            while ((line = list.ReadLine()) != null && (find = list.ReadLine()) != null && (match = list.ReadLine()) != null)
            {
                string id = line;
                string name = find;
                string cgpa = match;
                if ((line = list.ReadLine()) == semester)
                {
                    check = true;
                    list.ReadLine();
                    list.ReadLine();
                    Console.WriteLine(name);
                    string A = "ABSENT";
                    string P = "PRESENT";
                    Console.WriteLine("please press P/p for present and A/a for absent");
                    string ch;
                    ch = Console.ReadLine();
                    if (ch == "a" || ch == "A")
                    {
                        using (StreamWriter domatch = File.AppendText(marked))
                        {
                            domatch.WriteLine(name);
                            domatch.WriteLine(A);
                        }
                    }
                    else if (ch == "p" || ch == "P")
                    {
                        using (StreamWriter domatch = File.AppendText(marked))
                        {
                            domatch.WriteLine(name);
                            domatch.WriteLine(P);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("This semester doesnot exist in the file");
                }
            }
        }
        public void top3ofclass(string Key, string Path)
        {
            List<string> gpaList = new List<string>();
            using (StreamReader file = new StreamReader(Path))
            {
                string flag;
                while ((flag = file.ReadLine()) != null)
                {


                    if (Key == flag.Substring(0, 4))
                    {
                        gpaList.Add(flag.Substring(4));

                    }

                }
            }
            gpaList.Sort();
            gpaList.Reverse();

            Console.WriteLine("1: " + gpaList[0]);
            Console.WriteLine("2: " + gpaList[1]);
            Console.WriteLine("3: " + gpaList[2]);
        }
        public void deletion(int newid, string Way)
        {
            try
            {
                StreamReader find = new StreamReader(Way);
                string line;
                int increment = 0;
                while ((line = find.ReadLine()) != null)
                {
                    increment += 1;
                }
                find.Close();
                find = new StreamReader(Way);
                string[] occupy = new string[increment];
                for (int i = 0; i < increment; i++)
                {
                    occupy[i] = find.ReadLine();
                    if (occupy[i] == newid.ToString())
                    {
                        occupy[i] = null;
                        i--;
                        for (int j = 0; j < 5; j++)
                        {
                            line = find.ReadLine();
                        }
                    }
                }
                find.Close();
                using (StreamWriter nextfile = new StreamWriter(Way))
                {
                    for (int i = 0; i < occupy.Length; i += 1)
                    {
                        nextfile.WriteLine(occupy[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("FILE DOESNOT EXIST PLEASE MAKE A FILE FIRST");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                StudentProfile obj = new StudentProfile();
                string path;
                string filepath;
                int Id, Semester;
                string newpath;
                float Cgpa;
                string Name, deptt, University;
                int choice;
                Console.WriteLine("Enter the respective number");
                Console.WriteLine("1: STUDENT PROFILE");
                Console.WriteLine("2: STUDENT SEARCH");
                Console.WriteLine("3: DELETE STUDENT RECORD");
                Console.WriteLine("4: LIST TOP 3 OF CLASS");
                Console.WriteLine("5: MARK ATTENDANCE");
                Console.WriteLine("6: VIEW ATTENDANCE");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the path make file to enter student record e.g(E:/record.txt)");
                    path = Console.ReadLine();
                    Console.WriteLine("please Enter the ID of the student");
                    Id = int.Parse(Console.ReadLine());
                    try
                    {
                        StreamReader match = new StreamReader(path);
                        string line;
                        while ((line = match.ReadLine()) != null)
                        {
                            int temp;
                            int.TryParse(line, out temp);
                            if (int.TryParse(line, out temp))
                            {
                                if (Id == temp)
                                {
                                    Console.WriteLine("This ID is already accomodated to a student");
                                    Console.WriteLine("please choose another one");
                                    Console.WriteLine("please Enter the ID of the student");
                                    Id = int.Parse(Console.ReadLine());
                                    match.Close();
                                }
                            }
                        }
                        Console.WriteLine("Enter the name of the student");
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter the cgpa of the student");
                        Cgpa = float.Parse(Console.ReadLine());
                        if (Cgpa > 4.0 || Cgpa < 0.0)
                        {
                            Console.WriteLine("invalid cgpa please enter from 0 to 4");
                            Console.WriteLine("Enter the cgpa of the student");
                            Cgpa = float.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the Semester of the student");
                        Semester = int.Parse(Console.ReadLine());
                        if (Semester < 1 || Semester > 12)
                        {
                            Console.WriteLine("invalid semester number please enter between 1 to 12");
                            Console.WriteLine("Enter the Semester of the student");
                            Semester = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the department of the student");
                        deptt = Console.ReadLine();
                        Console.WriteLine("Enter the university of the student");
                        University = Console.ReadLine();
                        Console.WriteLine("WRITING IN FILE DONE");
                        match.Close();
                        obj.getdata(path, Id, Name, Cgpa, Semester, deptt, University);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Enter the name of the student");
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter the cgpa of the student");
                        Cgpa = float.Parse(Console.ReadLine());
                        if (Cgpa > 4.0 || Cgpa < 0.0)
                        {
                            Console.WriteLine("invalid cgpa please enter between 0 to 4");
                            Console.WriteLine("Enter the cgpa of the student");
                            Cgpa = float.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the Semester of the student");
                        Semester = int.Parse(Console.ReadLine());
                        if (Semester < 1 || Semester > 12)
                        {
                            Console.WriteLine("invalid semester number please enter between 1 to 12");
                            Console.WriteLine("Enter the Semester of the student");
                            Semester = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the department of the student");
                        deptt = Console.ReadLine();
                        Console.WriteLine("Enter the university of the student");
                        University = Console.ReadLine();
                        Console.WriteLine("WRITING IN FILE DONE");
                        obj.getdata(path, Id, Name, Cgpa, Semester, deptt, University);
                    }

                }
                else if (choice == 2)
                {
                    Console.WriteLine("please Enter the path of file to search the record e.g (E:/record.txt)");
                    path = Console.ReadLine();
                    int choice1;
                    Console.WriteLine("how do you want to search the record");
                    Console.WriteLine("press 1 to search by ID");
                    Console.WriteLine("press 2 to search by Name");
                    Console.WriteLine("press 3 to search by Semester");
                    choice1 = int.Parse(Console.ReadLine());
                    if (choice1 == 1)
                    {
                        Console.WriteLine("enter the ID to search the record ");
                        int nid = int.Parse(Console.ReadLine());
                        obj.searchbyid(path, nid);
                    }
                    else if (choice1 == 2)
                    {
                        Console.WriteLine("enter the name to search the record ");
                        string newname = Console.ReadLine();
                        obj.searchbyname(path, newname);
                    }
                    else if (choice1 == 3)
                    {
                        Console.WriteLine("enter the semester to search the record ");
                        string id = Console.ReadLine();
                        obj.searchbysem(path, id);
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("enter the path of file from where you want to delete the record e.g (C:/record.txt)");
                    path = Console.ReadLine();
                    int nid;
                    Console.WriteLine("enter the ID to delete its record");
                    nid = int.Parse(Console.ReadLine());
                    obj.deletion(nid, path);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("please give the path of the file for which top 3 will be shown e.g (E:/gpa.txt)");
                    path = Console.ReadLine();
                   
                    //obj.top3ofclass(key1,path);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("please Enter the path of file to search the record e.g (E:/record.txt)");
                    path = Console.ReadLine();
                    Console.WriteLine("now enter the next file to store marked students e.g(E:/markattendance.txt)");
                    filepath = Console.ReadLine();
                    Console.WriteLine(" NOW Enter the semester to mark the attendance");
                    string seme = Console.ReadLine();
                    obj.markAttendance(filepath, path, seme);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Enter the path of file to view Attendance e.g (E:/marked.txt)");
                    filepath = Console.ReadLine();
                    if (File.Exists(filepath))
                    {
                        StreamReader view = new StreamReader(filepath);
                        string line;
                        while ((line = view.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File doesn't exists because you haven't marked the attendance");
                    }

                }
            }
        }
    }
}