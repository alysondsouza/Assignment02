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
            //Student ali = new Student(1, "Ali", "De Souza", Students.getStatus(), 21/09/2021, 21/09/2022, 21/09/2023);
            Student ali = new Student();
            //ali.id = 1;
            //ali.givenName = "Ali";
            //ali.surname = "De Souza";
            //ali.status = Student.getStatus();

            Status expected = new Status();

            Assert.Equal(expected, ali.getStatus());
            //Assert.Equal("1", "2");
        }
    }
}
