using System;

namespace Assignment2
{
    record ImmutableStudent
    {
        int id { get; init; }
        string givenName { get; init; }
        string surname { get; init; }
        Status status { get => getStatus(startDate, endDate, graduationDate);}

        DateTime startDate;
        DateTime endDate;
        DateTime graduationDate;
    
        public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate){
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            //this.status = getStatus(startDate, endDate, graduationDate);
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
        }

        public override string ToString()
        {
            //return "Student :" + id + ", Name: " + givenName + " " + surname + ". Status: " + status + ". Start: " + startDate + " End: " + endDate + " Graduation: " + graduationDate;
			return $"Id: {id}, given name: {givenName}, surname: {surname}, status: {status}, start date: {startDate}, end date: {endDate}, graduation date: {graduationDate}";
		}

    }
}
