using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public int Grade
    {
        get
        { 
            return this.grade; 
        }
        private set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade cannot be less than zero");
            }
            this.grade = value; 
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Minimum grade cannot be less than zero");
            }
            this.minGrade = value;
        }
    }
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Maximum grade cannot be less than zero");
            }
            else if (value < this.MinGrade) 
            {
                throw new ArgumentException("Maximum grade cannot be less than the minimum grade");
            }
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (string.IsNullOrEmpty(value) && value.Length<200)
            {
                throw new ArgumentException("Comments should be at least 200 symbols");
            }
            this.comments = value;
        }
    }
    
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        //if (grade < 0)
        //{
        //    throw new Exception();
        //}
        //if (minGrade < 0)
        //{
        //    throw new Exception();
        //}
        //if (maxGrade <= minGrade)
        //{
        //    throw new Exception();
        //}
        //if (comments == null || comments == "")
        //{
        //    throw new Exception();
        //}

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
