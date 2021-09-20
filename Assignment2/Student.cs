using System;

namespace Assignment2
{
    public class Student
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now); // 20/09/2021 12.23.32
        }

        int id {get;}
        string givenName {get; set;}
        string surname {get; set;}
 
        readonly Status status;//{ get => getStatus();}

        DateTime startDate;
        DateTime endDate;
        DateTime graduationDate;
  
        public Student(){}

        public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate){
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            //this.status = getStatus();
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
        }

        public Status getStatus(DateTime startDate, DateTime endDate, DateTime graduationDate){
            
            DateTime rightNow = DateTime.Now;
            Status s = new Status();
            //NEW
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
        
    }
}
