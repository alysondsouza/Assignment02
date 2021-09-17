using System;

namespace Assignment2{
    public class Students
    {
        int id {get;}
        string givenName {get; set;}
        string surname {get; set;}

        readonly Status status{ get => getStatus();}

        DateTime startDate;
        DateTime endDate;
        DateTime graduationDate;
    } 

    public void getStatus(){
        var rightNow = DateTime.Now;


        //IF
        // NOW > START          .... NEW   
        // START >  NOW > END   ....ACTIVE   
        // START > END > NOW    ....DROPOUT
        // GRADUATED > NOW      ...GRADUATED
        
        
    }
}