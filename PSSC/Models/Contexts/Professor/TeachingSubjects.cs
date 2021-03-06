﻿using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Professor
{
    //Aggregate Root al Profesorului cu toate optiunile pe care poate sa le faca acesta
    public class Subjects
    {
        private List<Contexts.Professor.Subject> _subjects;
        public ReadOnlyCollection<Contexts.Professor.Subject> AllSubjects { get { return _subjects.AsReadOnly(); } }

        public Subjects(List<Contexts.Professor.Subject> subjects)
        {
            _subjects = subjects;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddExamGrade(grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddActivityGrade(grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddAttendance(attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName).SubjectInfo.SetActivityProportion(proportion);
        }
    }
}
