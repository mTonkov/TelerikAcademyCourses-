using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The entered first name is invalid!");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The entered last name is invalid!");
            }
            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get
        {
            return new List<Exam>(this.exams);
        }
        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot set a null value to the collection holding the exams");
            }
        }
    }

    public Student(string firstName, string lastName, IList<Exam> exams /*= null*/)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        //if (this.Exams == null)
        //{
        //    throw new Exception("Wow! Error happened!!!");
        //}

        if (this.Exams.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
            //return null;
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        //if (this.Exams == null)
        //{
        //    // Cannot calculate average on missing exams
        //    throw new Exception();
        //}  
        //there is a check to prevent the setting of null to the exams

        if (this.Exams.Count == 0)
        {
            // No exams --> return -1;
            return -1;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
