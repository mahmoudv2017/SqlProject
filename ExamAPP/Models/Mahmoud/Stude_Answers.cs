

namespace ExamAPP.Models.Mahmoud;

public class Stude_Answers
{
    public int Stud_id { get; set; }
    public int Ex_id { get; set; }
    public int Q_id { get; set; }
    public int ch_id { get; set; }

    public Student? Student { get; set; }
    public Exam? Exam { get; set; }
    public Question? Question { get; set; }
    public Choices? Answer { get; set; }
}
