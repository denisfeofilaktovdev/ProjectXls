using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Carriculums.Forms;
using Carriculums.MainWork.PlanData;
using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;


namespace Carriculums.MainWork
{
    public class WorkExcel
    {
        /// <summary>
        /// Приложение Excel
        /// </summary>
        public Application App;
        
        /// <summary>
        /// Главная книга для экспорта данных
        /// </summary>
        public XLWorkbook XlWorkbook;
        
        /// <summary>
        /// Название главной книги
        /// </summary>
        public string FileMainName;
        
        /// <summary>
        /// Книга для выгрузки данных
        /// </summary>
        public Workbook EditBook;

        /// <summary>
        /// Список планов загруженых в программу
        /// </summary>
        public List<Plan> Plans;

        /// <summary>
        /// Форма для редактирования предметов
        /// </summary>
        private FrmSubjectInfo frmSubject;

        /// <summary>
        /// Форма для редактирования информации по семестрам
        /// </summary>
        private TermsInfo frmTermsInfo;

        /// <summary>
        /// Конструктор
        /// </summary>
        public WorkExcel()
        {
            Plans = new List<Plan>();
            App = new Application();
            frmSubject = new FrmSubjectInfo();
            frmTermsInfo = new TermsInfo();
        }

        #region Основная работа. Пункт "ФАЙЛ"
        /// <summary>
        /// Открытие файла для извлечения информации
        /// </summary>
        public void Open(string[] fileNames)
        {
            Kernel.WaitPrint("Открытие книги");
            foreach (string file in fileNames)
            {
                if (OpenEditBook(file)) DefPlan();
                else MessageBox.Show(@"Не удалось открыть книгу " + file);
            }
        }

        /// <summary>
        /// Открытие файла для извлечения информации
        /// </summary>
        public void OpenMain(string fileName)
        {
            OpenMainBook(fileName);
        }

        /// <summary>
        /// Сохранение данных в отдельном учебном плане
        /// </summary>
        public void Save(int index)
        {
            if (index < Plans.Count && index >= 0) 
                Plans[index].Book.Save();
        }

        /// <summary>
        /// Сохранение данных в учебном плане в новую книгу
        /// </summary>
        public void SaveAs(int index)
        {
            if (index < Plans.Count && index >= 0) 
                Plans[index].Book.SaveAs("Новый учебный файл", "xls");
        }

        /// <summary>
        /// Очистить данные о плане
        /// </summary>
        public void Clear(int index)
        {
            if (index < Plans.Count && index >= 0) 
                Plans[index].ClearInformation();
        }

        /// <summary>
        /// Закрытие выбраного учебного плана
        /// </summary>
        public void Close(int index)
        {
            Plans[index].Book.Close(false);
            Plans.RemoveAt(index);
        }

        /// <summary>
        /// Закрытие всех используемых программой документов
        /// </summary>
        public void CloseAll()
        {
            foreach (Plan plan in Plans)
            {
                if (plan != null) plan.Book.Close(false);
            }
            Plans.Clear();
        }

        /// <summary>
        /// Прекращение работы программы
        /// </summary>
        public void Exit()
        {
            CloseAll();
            App.Quit();
        }
        
        #endregion
        
        #region Редактирование данных. Пункт "ПРАВКА"

        /// <summary>
        /// Редактирование учебного плана
        /// </summary>
        public void Edit(int index)
        {
            frmSubject.DefData(Plans[index]);
            if (frmSubject.ShowDialog() == DialogResult.OK)
            {
                Plans[index] = frmSubject.GetPlan();
            }
        }

        /// <summary>
        /// Сохранить изменения в выбраном документе
        /// </summary>
        public void SaveEdit()
        {
            
        }

        /// <summary>
        /// Отмена изменений в выбраном документе
        /// </summary>
        public void CancelEdit()
        {

        }

        /// <summary>
        /// Добавить предмет в выбраный учебный план
        /// </summary>
        public void AddSubject()
        {

        }

        /// <summary>
        /// Удалить предмет из учебного плана
        /// </summary>
        public void DeleteSubject()
        {

        }

        /// <summary>
        /// Редактирование предмета в учебном плане
        /// </summary>
        public void EditSubject()
        {

        }

#endregion

        #region Импорт данных. Пункт "ИМПОРТ"
        /// <summary>
        /// Импорт данных в главную книгу
        /// </summary>
        public void Import(int index)
        {
            LoadToMain(index);
        }

        /// <summary>
        /// Импорт данных в указаную книгу
        /// </summary>
        /// <param name="index">Индекс плана</param>
        /// <param name="mainBookName">Имя главной книги, включая путь к файлу</param>
        public void Import(int index, string mainBookName)
        {
            XlWorkbook = new XLWorkbook(mainBookName);
            LoadToMain(index);
        }

        /// <summary>
        /// Изъятие плана из открытой книги
        /// </summary>
        public void ExportPlanFrom()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainBookName"></param>
        public void ExportPlanFrom(string mainBookName)
        {
            
        }

        /// <summary>
        /// Закрытие главной книги
        /// </summary>
        public void CloseMainBook()
        {
            
        }
#endregion

        #region Помощь. Пункт "ПОМОЩЬ"

        /// <summary>
        /// Помощь
        /// </summary>
        public void Help()
        {
            
        }
        #endregion

        #region Параметры. Пункт "ПАРАМЕТРЫ"
        #endregion

        #region Приватные методы
        
        /// <summary>
        /// Открытие основного файла
        /// </summary>
        /// <param name="fileName"></param>
        private void OpenMainBook(string fileName)
        {
            XlWorkbook = new XLWorkbook(fileName);
        }

        /// <summary>
        /// Открытие файла для выгрузки данных
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool OpenEditBook(string fileName)
        {
            Kernel.WaitPrint("OpenBook");
            
            if (fileName != null) EditBook = App.Workbooks.Open(fileName, 0, false);
            if (EditBook != null) return true;
            
            return false;
        }

        /// <summary>
        /// Загрузка информации о плане в главную книгу
        /// </summary>
        /// <param name="index"></param>
        private void LoadToMain(int index)
        {
            if (XlWorkbook != null)
            {
                bool saved = true;
                Plans[index].LoadToExcel(XlWorkbook.Worksheet(1));
                try
                {
                    XlWorkbook.Save();
                }
                catch (Exception ex)
                {
                    saved = false;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (saved)
                    {
                        MessageBox.Show(@"Данные успешно сохранены.");
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Главная книга не открыта!");
            }
        }

        /// <summary>
        /// Отображение формы для редактирования данных
        /// </summary>
        /// <param name="index"></param>
        public void ShowTermsInfo(int index)
        {
            frmTermsInfo.SetPlan(Plans[index]);
            frmTermsInfo.ShowDialog();
        }

        /// <summary>
        /// Загрузка информации на основную форма
        /// </summary>
        /// <param name="table"></param>
        /// <param name="index"></param>
        public void LoadToListView(ListView table, int index)
        {
            Plans[index].LoadToListView(table);
        }

        /// <summary>
        /// Инициализация плана
        /// </summary>
        private void DefPlan()
        {
            Plan plan = new Plan();
            plan.Book = EditBook;
            //plan.XLBook = new XLWorkbook(EditBook.FullName);
            int index;

            Kernel.WaitPrint("DefPLan");
            if (plan.SetData())
            {
                Plans.Add(plan);
                index = Plans.IndexOf(plan);

                plan.Index = index;
                Debug.WriteLine("DefPlanEnd");
            }
            else
            {
                MessageBox.Show(@"Не удалось загрузить данные!");
            }
        }
        #endregion
    }
}