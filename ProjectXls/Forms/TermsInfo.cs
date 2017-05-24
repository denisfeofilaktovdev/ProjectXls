using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carriculums.MainWork.PlanData;

namespace Carriculums.Forms
{
    public partial class TermsInfo : Form
    {
        private Plan plan;

        public TermsInfo()
        {
            InitializeComponent();
        }

        public void SetPlan(Plan data)
        {
            plan = data;
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.Substring(6));


            if (plan != null)
            {
                foreach (Subject subject in plan.Subjects)
                {
                    if (subject.IsSubject)
                    {
                        if (subject.ListTerms != null)
                        {
                            Subject.Term term = subject.ListTerms[index - 1];

                            listView1.Items.Add(subject.SubjectName).SubItems.AddRange(new[]
                            {
                                term.AmountInAll,
                                term.Lectures,
                                term.Practices,
                                term.LabWorks,
                                term.CustomLessons,
                                term.TestWorks
                            });
                        }
                    }
                    else
                    {
                        listView1.Items.Add(subject.Paragraph);
                    }
                }
            }
        }

    }
}
