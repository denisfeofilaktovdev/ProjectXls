using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Carriculums.MainWork.PlanData;

namespace Carriculums.Forms
{
    public partial class FrmSubjectInfo : Form
    {
        private Plan _plan;
        private List<Subject> _subjects;

        public FrmSubjectInfo()
        {
            InitializeComponent();
        }

        public void DefData(Plan oPlan)
        {
            _plan = (Plan) oPlan.Clone();

            _subjects = new List<Subject>();
            _plan.Subjects = _subjects;
            
            Text = _plan.FileName;
            generalPropeties.SelectedObject = _plan;
            listSubjects.Items.Clear();
            
            foreach (Subject subject in oPlan.Subjects)
            {
                _subjects.Add((Subject) subject.Clone());
                
                if(subject.IsSubject) listSubjects.Items.Add(subject.SubjectName);
                else listSubjects.Items.Add(subject.Paragraph);
            }
        }

        public Plan GetPlan()
        {
            return _plan;
        }

        private void listSubjects_Click(object sender, EventArgs e)
        {
            subjectPropeties.SelectedObject = _plan.Subjects[listSubjects.SelectedIndices[0]];
        }
    }
}