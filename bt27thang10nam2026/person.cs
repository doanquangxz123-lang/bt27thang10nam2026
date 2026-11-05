using bt27thang10nam2026;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt27thang10nam2026
{
    internal class person
    {
        private string name;
        public int height;
        public int weight;
        public bool ismale;
        public person(string name, int height, int weight, bool ismale)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.ismale = ismale;
        }
        public virtual void showMyIdentity()
        {
            Console.WriteLine("Ten toi la: " + this.name +",Toi la con nguoi.");
        }
        public void showPersonalInformation()
        {
            Console.WriteLine("Ten toi la: " + this.name+".");
            Console.WriteLine("Chieu cao: " + this.height+" cm.");
            Console.WriteLine("Can nang: " + this.weight+" kg.");
            if(this.ismale==true)
            {
                Console.WriteLine("Gioi tinh nam");
            }
            else
            {
                Console.WriteLine("Gioi tinh nu");
            }
        }
    }
}
class student : person
{
    public string studentID;
    public student(string name, int height, int weight, bool ismale, string studentID) : base(name, height, weight, ismale)
    {
        this.studentID = studentID;
    }
    public override void showMyIdentity()
    {
        Console.WriteLine("Ten toi la: " + this.studentID + ",Toi la sinh vien.");
    }
}
class teacher : person
{
    public string facultyID;
    public teacher(string name, int height, int weight, bool ismale, string facultyID) : base(name, height, weight, ismale)
    {
        this.facultyID = facultyID ;
    }
    public override void showMyIdentity()
    {
        Console.WriteLine("Ten toi la: " + this.facultyID + ",Toi la giang vien.");
    }
}