
namespace School
{
    using System;

    public class Discipline
    {
        private string name;
        private int lecturesCount;
        private int exercisesCount;

        public Discipline(string name)
        {
            this.Name = name;
        }
        public Discipline(string name, int lectures, int exercises):this (name)
        {
            this.lecturesCount = lectures;
            this.exercisesCount = exercises;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int LecturesCount
        {
            get
            {
                return this.lecturesCount;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("There is no point of a discipline with less than 1 lecture!");
                }
                this.lecturesCount = value;
            }
        }
        public int ExercisesCount
        {
            get
            {
                return this.exercisesCount;
            }
            private set
            {
                if (value<lecturesCount)
                {
                    throw new ArgumentException("Every lecture should have at least one exercise!");
                }
                this.exercisesCount = value;
            }
        }
        public string Comments { get; set; }
    }
}
