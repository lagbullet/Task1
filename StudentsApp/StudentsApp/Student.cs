using System;

public class Student
{
    public String SurName;
    public String FirstName;
    public String Patronymic;
    public String Birthdate;
    public Mark[] Mark = new Mark[20];
    private int Mcount = 0;

    public Student(String Sname, String Fname,String patronymic, String BthDate, String Subj, int mark)
    {
        SurName = Sname;
        FirstName = Fname;
        Birthdate = BthDate;
        Patronymic = patronymic;
        Mark[Mcount++] = new Mark(Subj, mark);
    }

    public Student(String Sname, String Fname, String patronymic, String BthDate)
    {
        SurName = Sname;
        FirstName = Fname;
        Birthdate = BthDate;
        Patronymic = patronymic;
    }

    public float GetAvgMark()
    {
        float SumMarks = 0;
        for (int i = 0; i < Mcount; i++)
            SumMarks += Mark[i].mark;
        return SumMarks / Mcount;
    }

    public void ResetAllMarks()
    {
        for (int i = 0; i < Mcount; i++)
            Mark[i].mark = 0;
    }

    public void Show()
    {
        Console.WriteLine("Second Name -> " + SurName);
        Console.WriteLine("First Name -> " + FirstName);
        Console.WriteLine("Patronymic -> " + Patronymic);
        Console.WriteLine("Birthdate -> " + Birthdate);
        Console.WriteLine("  Marks  ");
        for (int i = 0; i < Mcount; i++)
        {
            Console.WriteLine("Subject -> " + Mark[i].Subject);
            Console.WriteLine("Mark -> " + Mark[i].mark);
        }
    }

    public String GetSurName()
    {
        return SurName;
    }

    public String GetFirstName()
    {
        return FirstName;
    }

    public String GetPatronymic()
    {
        return Patronymic;
    }

    public String GetBirthdate()
    {
        return Birthdate;
    }

    public void SetSurName(String Sname) => SurName = Sname;

    public void SetFirstName(String Fname) => FirstName = Fname;

    public void SetPatronymic(String patronymic) => Patronymic = patronymic;

    public void SetBirthDate(String Bdate) => Birthdate = Bdate;

    public void SetMark(String Subj, int mark)
    {
        if (Mcount < Mark.Length)
            Mark[Mcount++] = new Mark(Subj, mark);
        else
        {
            Array.Resize(ref Mark, Mcount+10);
            Mark[Mcount++] = new Mark(Subj, mark);
        }
    }

}