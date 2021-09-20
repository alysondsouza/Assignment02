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
            Status expectedNEW = Status.Active;

            Assert.Equal(expectedNEW, ali.getStatus(start, end, graduation));
        }

        [Fact]
        public void Student_getStatus_givenDateAfterStartAndAfterEnd_returnEnumDropout()
        {
            DateTime today = DateTime.Now;
            DateTime start = today.AddMonths(-2);
            DateTime end = today.AddMonths(-1);
            DateTime graduation = today.AddMonths(1);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            Status expectedNEW = Status.Dropout;

            Assert.Equal(expectedNEW, ali.getStatus(start, end, graduation));
        }

        [Fact]
        public void Student_getStatus_givenDateAfterGraduation_returnEnumGraduated()
        {
            DateTime today = DateTime.Now;
            DateTime start = today.AddMonths(-3);
            DateTime end = today.AddMonths(-2);
            DateTime graduation = today.AddMonths(-1);

            Student ali = new Student(1, "Ali", "De Souza", start, end, graduation);
            Status expectedNEW = Status.Graduated;

            Assert.Equal(expectedNEW, ali.getStatus(start, end, graduation));
        }


    }
}
