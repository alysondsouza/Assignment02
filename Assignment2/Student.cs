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

        //readonly 
        Status status;//{ get => getStatus();}

        DateTime startDate;
        DateTime endDate;
        DateTime graduationDate;

        Status s;

    
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

            if(rightNow < startDate){
                Status s = Status.New;
            }


            //IF
            // NOW - START          .... NEW   
            // START -  NOW - END   ....ACTIVE   
            // START - END - NOW    ....DROPOUT
            // GRADUATED - NOW      ...GRADUATED
            

            return s;
        }
        
    }
}
