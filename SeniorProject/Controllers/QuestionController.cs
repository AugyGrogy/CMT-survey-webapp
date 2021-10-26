using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Controllers
{
    public class QuestionController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var questions = from e in GetQuestionList()
                            orderby e.Id
                            select e;
            return View(questions);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Models.Question> GetQuestionList()
        {
            return new List<Models.Question>
            {
                new Models.Question
                {
                    Id = 1,
                    QuestionText = "How are you?",
                    QuestionType = 0,
                    AnswerA = "Bad",
                    AnswerB = "Not good",
                    AnswerC = "Ok",
                    AnswerD = "Good",
                    AnswerE = "Great",
                },

                new Models.Question
                {
                    Id = 2,
                    QuestionText = "Sample question",
                    QuestionType = 0,
                    AnswerA = "Answer 1",
                    AnswerB = "Answer 2",
                    AnswerC = "Answer 3",
                },

                new Models.Question
                {
                    Id = 3,
                    QuestionText = "Do you know about Musical Therapy?",
                    QuestionType = 2,
                    AnswerA = "True",
                    AnswerB = "False",
                },
            };
        }
    }
}
