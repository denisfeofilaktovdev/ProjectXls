using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;

namespace Carriculums.MainWork.PlanData
{
    public class Subject : ICloneable
    {
        [DisplayName(@"Пункт"), Category("Основні данні")] 
        public string Paragraph { get; set; }
        [DisplayName(@"Назва дисципліни"), Category("Основні данні")] 
        public string SubjectName { get; set; }

        [DisplayName(@"Іспити"), Category("Основні данні")] 
        public string Exams { get; set; }
        [DisplayName(@"Заліки"), Category("Основні данні")] 
        public string Credits { get; set; }
        [DisplayName(@"Розрахунково-графічні роботи"), Category("Основні данні")] 
        public string CalcGraphicWorks { get; set; }
        [DisplayName(@"Домашні завдання"), Category("Основні данні")] 
        public string Homeworks { get; set; }
        [DisplayName(@"Контрольні роботи"), Category("Основні данні")] 
        public string Tests { get; set; }
        [DisplayName(@"Курсові роботи"), Category("Основні данні")] 
        public string CourseWorks { get; set; }
        [DisplayName(@"Курсові проекти"), Category("Основні данні")] 
        public string CourseProjects { get; set; }
        [DisplayName(@"Модуль"), Category("Основні данні")] 
        public string Modules { get; set; }
        [DisplayName(@"Вього"), Category("Основні данні")] 
        public string AmountInAll { get; set; }
        [DisplayName(@"Всього аудиторних занять"), Category("Основні данні")] 
        public string Lessons { get; set; }
        [DisplayName(@"Лекції"), Category("Основні данні")] 
        public string Lectures { get; set; }
        [DisplayName(@"Практичні заняття"), Category("Основні данні")] 
        public string Practices { get; set; }
        [DisplayName(@"Лабораторні роботи"), Category("Основні данні")] 
        public string LabWorks { get; set; }
        [DisplayName(@"Індивідуальні заняття"), Category("Основні данні")] 
        public string CustomLessons { get; set; }
        [DisplayName(@"Самостійна роботи"), Category("Основні данні")] 
        public string TestWorks { get; set; }

        public List<Term> ListTerms = new List<Term>();

        [Browsable(false)] 
        public bool IsSubject { get; set; }
        [Browsable(false)] 
        public int SubjectIndex { get; set; }

        /// <summary>
        /// Изъятие данных для предмета
        /// </summary>
        /// <returns>true, если установка успешна, в инном случае - false</returns>
        public void SetData(Worksheet page)
        {
            if (Paragraph.Length < 10 && Paragraph != "")
            {
                IsSubject = true;
                Range range = page.Cells.Find(Paragraph);

                int row = range.Row;
                int column = range.Column;

                SubjectName = page.Cells[row, column + 1].Text;
                if (SubjectName.Contains("Військова підготовка"))
                {
                    IsSubject = false;
                }
                Exams = page.Cells[row, column + 2].Text;
                Credits = page.Cells[row, column + 3].Text;
                CalcGraphicWorks = page.Cells[row, column + 4].Text;
                Homeworks = page.Cells[row, column + 5].Text;
                Tests = page.Cells[row, column + 6].Text;
                CourseWorks = page.Cells[row, column + 7].Text;
                CourseProjects = page.Cells[row, column + 8].Text;
                Modules = page.Cells[row, column + 9].Text;
                AmountInAll = page.Cells[row, column + 10].Text;
                Lessons = page.Cells[row, column + 11].Text;
                Lectures = page.Cells[row, column + 12].Text;
                Practices = page.Cells[row, column + 13].Text;
                LabWorks = page.Cells[row, column + 14].Text;
                CustomLessons = page.Cells[row, column + 15].Text;
                TestWorks = page.Cells[row, column + 16].Text;

                int counter = 16;
                for (int index = 0; index < 8; index++)
                {
                    Term term = new Term()
                    {
                        Number = (index + 1).ToString(),
                        AmountInAll = page.Cells[row, column + counter + 1].Text,
                        Lectures = page.Cells[row, column + counter + 2].Text,
                        Practices = page.Cells[row, column + counter + 3].Text,
                        LabWorks = page.Cells[row, column + counter + 4].Text,
                        CustomLessons = page.Cells[row, column + counter + 5].Text,
                        TestWorks = page.Cells[row, column + counter + 6].Text
                    };

                    counter += 6;
 
                    ListTerms.Add(term);
                }
            }
            
        }

        /// <summary>
        /// Сохранение данных в XML-документ
        /// </summary>
        /// <param name="mainDoc"></param>
        public void SaveXml(XElement mainDoc)
        {
            XElement subjectElem = new XElement("subject" + SubjectIndex);

            subjectElem.Add(new XElement("Paragraph", Paragraph));
            subjectElem.Add(new XElement("SubjectName", SubjectName));
            subjectElem.Add(new XElement("Exams", Exams));
            subjectElem.Add(new XElement("Credits", Credits));
            subjectElem.Add(new XElement("CalcGraphicWorks", CalcGraphicWorks));
            subjectElem.Add(new XElement("Homeworks", Homeworks));
            subjectElem.Add(new XElement("Tests", Tests));
            subjectElem.Add(new XElement("CourseWorks", CourseWorks));
            subjectElem.Add(new XElement("CourseProjects", CourseProjects));
            subjectElem.Add(new XElement("Modules", Modules));
            subjectElem.Add(new XElement("AmountInAll", AmountInAll));
            subjectElem.Add(new XElement("Lessons", Lessons));
            subjectElem.Add(new XElement("Lectures", Lectures));
            subjectElem.Add(new XElement("Practices", Practices));
            subjectElem.Add(new XElement("LabWorks", LabWorks));
            subjectElem.Add(new XElement("CustomLessons", CustomLessons));
            subjectElem.Add(new XElement("TestWorks", TestWorks));

            mainDoc.Add(subjectElem);
        }

        public void WriteLine(Worksheet page, int row)
        {
            if(IsSubject) page.Cells[row, 1] = SubjectName;
            else page.Cells[row, 1] = Paragraph;
        }

        public class Term : ICloneable
        {
            public string Number { get; set; }
            [DisplayName(@"Всього")] 
            public string AmountInAll { get; set; }
            [DisplayName(@"Лекції")] 
            public string Lectures { get; set; }
            [DisplayName(@"Практичні заняття")] 
            public string Practices { get; set; }
            [DisplayName(@"Лабораторні роботи")] 
            public string LabWorks { get; set; }
            [DisplayName(@"Індивідуальні заняття")] 
            public string CustomLessons { get; set; }
            [DisplayName(@"Самостійні роботи")] 
            public string TestWorks { get; set; }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}