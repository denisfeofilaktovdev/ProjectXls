using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;

namespace Carriculums.MainWork.PlanData
{
    public class Plan : ICloneable
    {
        [Browsable(false)] 
        public int Index { get; set; }

        [DisplayName(@"Ім'я папки")] 
        public string FileName { get; set; }
        [DisplayName(@"Спеціальність")] 
        public string Specialty { get; set; }
        [DisplayName(@"Спеціалізація")] 
        public string Specialization { get; set; }
        [DisplayName(@"Номер")] 
        public string Number { get; set; }

        public List<Subject> Subjects;
        public Workbook Book;

        private string _fileNameXml;
        //public XLWorkbook XLBook;

        public Plan()
        {
            Subjects = new List<Subject>();
        }

        ///<summary>
        /// Загрузка данных в ListView
        ///</summary>
        public void LoadToListView(ListView table)
        {
            foreach (Subject subject in Subjects)
            {
                if (subject.IsSubject)
                {
                    table.Items.Add(FileName).SubItems.AddRange(new[]
                    {
                        Specialty, 
                        Specialization, 
                        Number, 
                        subject.Paragraph, 
                        subject.SubjectName,
                        subject.Exams,
                        subject.Credits,
                        subject.CalcGraphicWorks,
                        subject.Homeworks, 
                        subject.Tests,
                        subject.CourseWorks,
                        subject.CourseProjects,
                        subject.Modules,
                        subject.AmountInAll
                    });
                }
                else
                {
                    table.Items.Add(FileName).SubItems.AddRange(new[]
                    {
                        Specialty, 
                        Specialization, 
                        Number, 
                        subject.Paragraph
                    });
                }
            }
        }

        /// <summary>
        /// Загрузка данных в основную таблицу
        /// </summary>
        public void LoadToExcel(IXLWorksheet page)
        {
            foreach (Subject subject in Subjects)
            {
                int row = subject.SubjectIndex;
                
                page.Cell(row + 1, 1).SetValue(FileName);
                page.Cell(row + 1, 2).SetValue(Specialty);
                page.Cell(row + 1, 3).SetValue(Specialization);
                page.Cell(row + 1, 4).SetValue(Number);
                page.Cell(row + 1, 5).SetValue(subject.Paragraph);
                page.Cell(row + 1, 6).SetValue(subject.SubjectName);
                page.Cell(row + 1, 7).SetValue(subject.Exams);
                page.Cell(row + 1, 8).SetValue(subject.Credits);
                page.Cell(row + 1, 9).SetValue(subject.CalcGraphicWorks);
                page.Cell(row + 1, 10).SetValue(subject.Homeworks);
                page.Cell(row + 1, 11).SetValue(subject.Tests);
                page.Cell(row + 1, 12).SetValue(subject.CourseWorks);
                page.Cell(row + 1, 13).SetValue(subject.CourseProjects);
                page.Cell(row + 1, 14).SetValue(subject.Modules);
                page.Cell(row + 1, 15).SetValue(subject.AmountInAll);
                page.Cell(row + 1, 16).SetValue(subject.Lessons);
                page.Cell(row + 1, 17).SetValue(subject.Lectures);
                page.Cell(row + 1, 18).SetValue(subject.Practices);
                page.Cell(row + 1, 19).SetValue(subject.LabWorks);
                page.Cell(row + 1, 20).SetValue(subject.CustomLessons);
                page.Cell(row + 1, 21).SetValue(subject.TestWorks);

                Kernel.WaitPrint("Waiting");
            }
        }

        /// <summary>
        /// Очистка информации
        /// </summary>
        public void ClearInformation()
        {
            
        }

        ///<summary>
        ///Установка значений из таблицы Excel
        ///</summary>
        public bool SetData()
        {
            Kernel.WaitPrint("Идет загрузка данных");
            
            if (Book != null && Book.Worksheets[1] != null && Book.Worksheets[2] != null)
            {
                FileName = Book.Name;
                if (SetGeneralData(Book.Worksheets[1]) && SetSubjectData(Book.Worksheets[2]))
                {
                    CreateXml();
                    return true;
                }
            }
            
            if (Book != null) Book.Close(false, FileName);
            return false;
        }

        /// <summary>
        /// Утановка основной информации
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private bool SetGeneralData(Worksheet page)
        {
            Kernel.WaitPrint("Поиск основной информации...");
            
            Specialty = Search.FindWordAt(page, "Спеціальність", 2);
            Specialization = Search.FindWordAt(page, "Спеціалізація", 1);
            Number = Search.FindWordAt(page, "підготовки здобувачів вищої освіти", 2);
            
            if (Specialty == null && Specialization == null && Number == null) return false;
            return true;
        }

        /// <summary>
        /// Установка информации о предметах
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private bool SetSubjectData(Worksheet page)
        {
            Debug.WriteLine("Поиск первого параграфа");
            string firstParagraph = FirstParagraph(page);
            int paragraphColumn = Search.ColumnByWord(page, firstParagraph);
            int paragraphRow = Search.RowByWord(page, firstParagraph);

            int max = Search.RowByWord(page, "Кількість") - Search.RowByWord(page, firstParagraph) - 1;
            
            Kernel.WaitStart(max);
            Kernel.WaitPrint("Поиск данных по предметам: ");
            
            for (int i = 0; i < max; i++)
            {
                Subject subject = new Subject
                { 
                    Paragraph = page.Cells[paragraphRow + i, paragraphColumn].Text,
                    SubjectIndex = i
                };
                
                subject.SetData(page);
                
                if (subject.IsSubject || subject.Paragraph.Contains("Цикл"))
                {
                    Subjects.Add(subject);
                }

                Kernel.WaitPrint("Поиск данных по предметам: " + subject.SubjectName);
            }
            
            if (Subjects.Count == 0) return false;
            return true;
        }

        /// <summary>
        /// Поиск первого параграфа
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private string FirstParagraph(Worksheet page)
        {
            string word = "№";

            while (!word.Contains("1."))
            {
                word = Search.FindNextAt(page, word, 1, 0);
            }

            return word;
        }

        /// <summary>
        /// Создание XML-документа на основе считанных данных
        /// </summary>
        private void CreateXml()
        {
            _fileNameXml = FileName + ".xml";

            XDocument planDoc = new XDocument();
            XElement data = new XElement("Plan");
            XElement mainInfo = new XElement("MainData");

            mainInfo.Add(new XElement("FileName", FileName));
            mainInfo.Add(new XElement("Specialty", Specialty));
            mainInfo.Add(new XElement("Specialization", Specialization));
            mainInfo.Add(new XElement("Number", Number));

            XElement subjectInfo = new XElement("SubjectInfo");

            foreach (Subject subject in Subjects)
            {
                subject.SaveXml(subjectInfo);
            }

            data.Add(mainInfo);
            data.Add(subjectInfo);

            planDoc.Add(data);
            planDoc.Save(_fileNameXml);
        }

        /// <summary>
        /// Клонирование объекта
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}