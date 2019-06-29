using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    { 
         [Fact]      
        public void CsharpPassByValue()
        {
            var book1 = GetBook("Book 1");      
            GetBookSetName(book1,"New Name");
            
            Assert.Equal("Book 1", book1.Name); 
                      
        }
        public void GetBookSetName(Book book, string name)
        {
            book = new Book(name);          
        }

         [Fact]      
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");      
            SetName(book1,"New Name");
            
            Assert.Equal("New Name", book1.Name); 
           
            
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]      
        public void GetBookReturnDifferentObject()
        {
           var book1 = GetBook("Book 1");      
           var book2 = GetBook("Book 2");       
           
           Assert.Equal("Book 1",book1.Name);
           Assert.Equal("Book 2",book2.Name);
           Assert.NotSame(book1, book2);
            
        }

        [Fact]
        public void TwoVarCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");      
            var book2 = book1;       
           
           Assert.Equal("Book 1",book1.Name);
           Assert.Equal("Book 1",book2.Name);
           Assert.Same(book1, book2);
           Assert.True(object.ReferenceEquals(book1,book2));
            
        }

        private Book GetBook(string name)       {


            return new Book(name);
           
        }
    }
}
