using Microsoft.Office.Interop.Excel;

namespace Carriculums.MainWork
{
    public static class Search
    {
        public static int RowByWord(Worksheet page, string word)
        {
            Range range = page.Cells.Find(word);
            
            if (range != null) return range.Row;
            return 0;
        }

        public static int ColumnByWord(Worksheet page, string word)
        {
            Range range = page.Cells.Find(word);

            if (range != null) return range.Column;
            return 0;
        }

        public static string GetCellValue(Worksheet page, int row, int column)
        {
            if (page.Cells[row, column] != null)
            {
                Range range = page.Cells[row, column];

                return range.Text;
            }
            else return null;
        }

        public static string FindWordAtRow(Worksheet page, string word, int num)
        {
            if (word == null) return null;

            for (int i = 0; i < num; i++)
            {
                word = FindNextAt(page, word, 0, 1);
            }

            return word;
        }

        public static string FindWordAtColumn(Worksheet page, string word, int num)
        {
            if (word == null) return null;

            for (int i = 0; i < num; i++)
            {
                word = FindNextAt(page, word, 1, 0);
            }

            return word;
        }




        public static string FindNextAt(Worksheet page, string word, int rows, int columns)
        {
            if (word == null || page == null) return null;

            Range range = page.Cells.Find(word);
            int row = range.Row;
            int column = range.Column;

            while (row < 200 && column < 40)
            {
                row += rows;
                column += columns;

                if (page.Cells[row, column] != null
                    && page.Cells[row, column].Text != "")
                {
                    return page.Cells[row, column].Text;
                }
                //if (GetCellValue(page, range.Row + row, range.Column + column) != "") break;
            }
            return null;
        }

        //
        //Поиск слова за порядковым номером после указанного
        //
        public static string FindWordAt(Worksheet page, string word, int num)
        {
            Range range = page.Cells.Find(word);

            if (range != null)
            {
                for (int i = 0; i < num; i++)
                {
                    range = FindNextWord(range);
                }

                if (range != null) return range.Text;
            }
            return null;
        }

        //
        //Поиск следующего слова в документе
        //
        public static Range FindNextWord(Range range)
        {
            if (range != null)
            {
                int column = range.Column;

                while (true)
                {
                    if (column == 100)
                    {
                        column = 0;

                        range = range.Offset[1, -99];
                        if (range.Text != "") break;
                    }
                    else
                    {
                        range = range.Offset[0, 1];
                        if (range.Text != "") break;

                        column++;
                    }
                }
            }

            return range;
        }
    }
}
