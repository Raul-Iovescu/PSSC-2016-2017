using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common;
namespace Models.Contexts.Student
{
    public class SubjectSituation
    {
        public SubjectInformation SubjectInformation { get; internal set; }
        public Attendance Attendance { get; internal set; }
        public List<Grade> ExamGrades { get; internal set; }
        public Grade ActivityGrade { get; internal set; }

        public SubjectSituation()
        {

        }

        public SubjectSituation(SubjectInformation subjectInformation, Attendance attendance, List<Grade> examGrades, Grade activityGrade)
        {
            SubjectInformation = subjectInformation;
            Attendance = attendance;
            ExamGrades = examGrades;
            ActivityGrade = activityGrade;
        }

        

        public decimal GetExamAverage()
        {
            Grade examAverage,average;
            average = new Grade(0);

            if (SubjectInformation.Evaluation.Equals(EvaluationType.Distributed))
            {
                examAverage = new Grade((ExamGrades[0].Value + ExamGrades[1].Value) / 2);
            }
            else
            {
                examAverage = new Grade(ExamGrades[0].Value);
            }
            if(SubjectInformation.ActivityProportion.Fraction == (1/2))
            {
                average = new Grade((examAverage.Value + ActivityGrade.Value) / 2);
            }
            else if (SubjectInformation.ActivityProportion.Fraction == (1 / 3))
            {
                average = new Grade((2 * examAverage.Value + ActivityGrade.Value) / 3);
            }
            return average.Value;
        }
    }
}