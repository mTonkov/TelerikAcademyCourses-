using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public int ProblemsSolved
    {
        get 
        { 
            return problemsSolved; 
        }
       private set 
        {
            if (value<0)
            {
                throw new ArgumentException("The number of the solved problems cannot be negative");
            }

            this.problemsSolved = value;
        }
    }
    
    public SimpleMathExam(int problemsSolved)
    {
        //if (problemsSolved < 0)
        //{
        //    problemsSolved = 0;
        //}
        //if (problemsSolved > 10)
        //{
        //    problemsSolved = 10;
        //}

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        //return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        throw new ArgumentException("Invalid exam parameters! Please enter a valid number of solved problems");
    }
}
