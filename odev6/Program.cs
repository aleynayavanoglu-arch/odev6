using System;

class Course
{
    public string Code { get; init; }
    public string Name { get; set; }

    private int credits;
    public int Credits
    {
        get { return credits; }
        set
        {
            if (value >= 1 && value <= 10) credits = value;
            else Console.WriteLine("Credits must be between 1 and 10!");
        }
    }

    public Course(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }

    public string Info()
    {
        return Code + " " + Name + " (" + Credits + " cr)";
    }
}

class Program
{
    static void Main()
    {
        Course[] courses = new Course[5];
        courses[0] = new Course("CENG211", "Object Oriented Programming", 4);
        courses[1] = new Course("MATH101", "Calculus", 5);
        courses[2] = new Course("EE243", "Digital Logic Design", 4);
        courses[3] = new Course("PHYS101", "Physics", 3);
        courses[4] = new Course("ENG101", "English", 2);

        foreach (Course c in courses)
            Console.WriteLine(c.Info());

        int total = 0;
        foreach (Course c in courses)
            total += c.Credits;
        Console.WriteLine("Total credits: " + total);

        string[] names = new string[courses.Length];
        for (int i = 0; i < courses.Length; i++)
            names[i] = courses[i].Name;

        Array.Sort(names);
        Console.WriteLine("Names in alphabetical order:");
        foreach (string n in names)
            Console.WriteLine(n);
    }
}
