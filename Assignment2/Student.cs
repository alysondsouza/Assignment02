using System;

namespace Assignment2
{
    public class Student
    {
        public static void Main(string[] args)
        {
            DateTime t = DateTime.Now;
            Student ali = new Student(1, "Ali", "De Souza", t.AddMonths(-1), t.AddMonths(1), t.AddMonths(2));
            Console.WriteLine(ali.ToString());
            Student immutableAli = new Student(2, "Alyson", "De Souza", t.AddMonths(-2), t.AddMonths(-1), t.AddMonths(1));
            Console.WriteLine(immutableAli.ToString());
            Console.WriteLine(DateTime.Now);
        }

        int id {get;}
        string givenName {get; set;}
        string surname {get; set;}

        Status status; //{ get => getStatus();}

        DateTime startDate;
        DateTime endDate;
        DateTime graduationDate;
  
        public Student(){}

        public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate){
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = getStatus(startDate, endDate, graduationDate);
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
        }

        public Status getStatus(DateTime startDate, DateTime endDate, DateTime graduationDate){
            
            DateTime rightNow = DateTime.Now;
            Status s = new Status();

            int nowStart = DateTime.Compare(rightNow, startDate); //-1, 0, 1  <0 id date1 < date2
            int nowEnd = DateTime.Compare(rightNow, endDate); 
            int graduateNow = DateTime.Compare(rightNow, graduationDate); 

            if(nowStart == -1){
                s = Status.New;
            } else if(graduateNow == 1){
                s =  Status.Graduated;
            } else if(nowStart == 1 && nowEnd == -1){
                s =  Status.Active;
            } else if(nowStart == 1 && nowEnd == 1){
                s =  Status.Dropout;
            } 

            return s;
            //IF
            // NOW - START          .... NEW   
            // START -  NOW - END   ....ACTIVE   
            // START - END - NOW    ....DROPOUT
            // GRADUATED - NOW      ...GRADUATED
        }
        
        public string ToString()
        {
            return "Student :" + id + ", Name: " + givenName + " " + surname + ". Status: " + status + ". Start: " + startDate + " End: " + endDate + " Graduation: " + graduationDate;
        }
        
        
    }
}
