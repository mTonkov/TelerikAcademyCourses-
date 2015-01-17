using System;

public class CSharpExam : Exam
{
    //public int Score { get; private set; }
    private int score;

    public int Score
    {
        get
        {
            return score;
        }
        private set 
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Invalid value for score - should be between 0 and 100");
            }
            this.score = value; 
        }
    }
    public CSharpExam(int score)
    {
        //if (score < 0)
        //{
        //    throw new NullReferenceException();
        //}
        this.Score = score;
    }

    public override ExamResult Check()
    {
        //if (Score < 0 || Score > 100)
        //{
        //    throw new InvalidOperationException();
        //}
        //else
        //{
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        //}
    }
}
