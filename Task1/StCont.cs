using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class StCont:Collection<Student>
    {
        //private Collection<Student> Students=new Collection<Student>();

        public new void Add(Student student)
        {
            this.Add(student);
        }

       /* public void Remove(int index) {
               this.RemoveAt(index);
            
        }*/

       // public new void Clear() { this.Clear(); }

       // public Collection<Student> Output() { return this; }

        public Collection <Student> Search(Student student) 
        {
            Collection<Student> searchedstudents = new Collection<Student>();
            foreach (Student s in this)
            {
                if (
                    ((student.FIO != null & s.FIO == student.FIO) | student.FIO == null)
               & ((student.receipt_date != DateTime.MinValue & s.receipt_date == student.receipt_date) | student.receipt_date == DateTime.MinValue)
                & ((student.speciality != null & s.speciality == student.speciality) | student.speciality == null)
                & ((student.group != null & s.group == student.group) | student.group == null)
                & ((student.faculty != null & s.faculty == student.faculty)|student.faculty==null)
                & ((student.mid_mark != 0 & s.mid_mark == student.mid_mark)|student.mid_mark==0)
                )
                searchedstudents.Add(s);
            }
            return searchedstudents;
        }
    }
}
