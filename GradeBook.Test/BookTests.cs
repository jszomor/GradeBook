using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(88.5);
			book.AddGrade(90.5);
			book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // asser
            Assert.Equal(85.4, result.Average, 1);
            // Assert.Equal(85.4, book.grades[0], 1);
            Assert.Equal(90.5, result.High, 1);
            // Assert.Equal(90.5, book.grades[1], 1);
            Assert.Equal(77.3, result.Low, 1);
            // Assert.Equal(77.3, book.grades[2], 1);
            Assert.Equal('B', result.Letter);
      
        }
        
    }
}
