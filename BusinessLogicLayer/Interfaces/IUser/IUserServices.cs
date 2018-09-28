﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Interfaces.IUser
{
    public interface IUserServices
    {
        int? GetTestByKey(string testKey);
       
         

        IEnumerable<Question> GetQuestionsByTestId(int id);
        


        GivenAnswer CreateGivenAnswer(int testID, int questionID, string answer);
        

        void AddGivenAnswer(GivenAnswer givenAnswer);
        

        GivenAnswer EditGivenAnswer(GivenAnswer givenAnswer, string newAnswer);



        void FinalizingTest(int testID);//, TimeSpan completionTime);
        IEnumerable<Answer> GetAnswersForQuestion(int questionID);

        QuestionType GetQuestionType(int questionTypeID);

        int GetQuestionTypeID(int questionID);
    }
}
