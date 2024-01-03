namespace ExamPrepLibrary;

public class Exam
{
    public string Name { get; set; }
    public string Code { get; set; }

    public Exam(string name, string code)
    {
        Name = name;
        Code = code;
    }

    
    public bool PassExam()
    {
        return true;
    }
}