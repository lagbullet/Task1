using System;

public class Mark
{
    public String Subject;
    public int mark;

	public Mark(String subj, int mrk)
	{
        Subject = subj;
        mark = mrk;
	}

    public void SetMark(int mrk) => mark = mrk;

    public void SetSubject(string Subj) => Subject = Subj;

    public String GetSubject()
    {
        return Subject;
    }

    public int GetMark()
    {
        return mark;
    }
}