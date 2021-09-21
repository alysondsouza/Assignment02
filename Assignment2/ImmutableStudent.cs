namespace Assignment2
{
    record ImmutableStudent
    {
        public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate) => 
        (id, givenName, surname, status, startDate, endDate, graduationDate) = 
        (id, givenName, surname, status, startDate, endDate, graduationDate);

        public int id { get; init; }
        public string givenName { get; init; }
        public string surname { get; init; }
        readonly Status status { get; init; }
        public DateTime startDate { get; init; }
        public DateTime endDate { get; init; }
        public DateTime graduationDate { get; init; }

        public Status getStatus(DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
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
        }

        public override string immutableToString()
        {
            return $"Id: {id}, given name: {givenName}, surname: {surname}, start date: {startDate}, end date: {endDate}, graduation date: {graduationDate}";
        } 
    } 
}