using System;

public class Marks
{
    public String Subject;
    public int Mark;

	public Marks(String subj, int mark)
	{
        Subject = subj;
        Mark = mark;
	}

    public void SetMark(int mark) => Mark = mark;

    public void SetSubject(string Subj) => Subject = Subj;

    public String GetSubject()
    {
        return Subject;
    }

    public int GetMark()
    {
        return Mark;
    }
}