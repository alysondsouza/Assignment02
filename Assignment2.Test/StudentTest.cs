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
            DateTime today = DateTime.Now;
            DateTime start = today.AddMonths(1);
            DateTime end = today.AddMonths(2);
            DateTime graduation = today.AddMonths(3);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            Status expectedNEW = Status.New;

            Assert.Equal(expectedNEW, ali.getStatus(start, end, graduation));
        }

        [Fact]
        public void Student_getStatus_givenDateAfterStartAndBeforeEnd_returnEnumActive()
        {
            DateTime today = DateTime.Now;
            DateTime start = today.AddMonths(-1);
            DateTime end = today.AddMonths(1);
            DateTime graduation = today.AddMonths(2);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            Status expectedACTIVE = Status.Active;

            Assert.Equal(expectedACTIVE, ali.getStatus(start, end, graduation));
        }

        [Fact]
        public void Student_getStatus_givenDateAfterStartAndAfterEnd_returnEnumDropout()
        {
            DateTime today = DateTime.Now;
            DateTime start = today.AddMonths(-2);
            DateTime end = today.AddMonths(-1);
            DateTime graduation = today.AddMonths(1);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            Status expectedDROPOUT = Status.Dropout;

            Assert.Equal(expectedDROPOUT, ali.getStatus(start, end, graduation));
        }

        [Fact]
        public void Student_getStatus_givenDateAfterGraduation_returnEnumGraduated()
        {
            DateTime today = DateTime.Now;
            DateTime start = today.AddMonths(-3);
            DateTime end = today.AddMonths(-2);
            DateTime graduation = today.AddMonths(-1);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            Status expectedGRAD = Status.Graduated;

            Assert.Equal(expectedGRAD, ali.getStatus(start, end, graduation));
        }

        [Fact]
        public void Student_toString_givenStudent_returnString()
        {
            DateTime start = new DateTime(2021, 09, 22);
            DateTime end = new DateTime(2021, 09, 22);
            DateTime graduation = new DateTime(2021, 09, 22);
            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);

			string expected = "Id: 1, given name: Ali, surname: De Souza, status: Graduated, start date: 22/09/2021 00.00.00, end date: 22/09/2021 00.00.00, graduation date: 22/09/2021 00.00.00";

            Assert.Equal(expected, ali.ToString());
        }
    }
}
