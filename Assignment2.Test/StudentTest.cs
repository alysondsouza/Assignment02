using System;
using Xunit;
using Assignment2;

namespace Assignment2.Test
{
    public class StudentTest
    {
        [Fact]
        public void Student_getStatus_givenDateBeforeStart_returnEnumNew()
        {
            DateTime start = new DateTime(2021, 09, 19);
            DateTime end = new DateTime(2022, 09, 21);
            DateTime graduation = new DateTime(2023, 09, 21);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            //Student ali = new Student();
            //ali.id = 1;
            //ali.givenName = "Ali";
            //ali.surname = "De Souza";
            //ali.startDate = 2021/09/21;
            //ali.endDate = 21/09/2022;
            //ali.graduationDate = 21/09/2021;

            Status expectedNEW = Status.New;

            Assert.Equal(expectedNEW, ali.getStatus(start, end, graduation));
            //Assert.Equal("1", "2");
        }
    }
}
