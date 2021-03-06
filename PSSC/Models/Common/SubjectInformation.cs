﻿using Models.Generics;

namespace Models.Common
{
    /*Clasa Subiect care e generala in toate cele 3 contextele*/
    public class SubjectInformation
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Common.Professor Professor { get; internal set; }
        public Proportion ActivityProportion { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        {
            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity, Common.Professor professor) 
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }
        public void SetActivityProportion(Proportion activity)
        {
            ActivityProportion = activity;
        }
    }
}
