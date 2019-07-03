using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTest
    { 
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            //log = new WriteLogDelegate(ReturnMessage);
            log += ReturnMessage;
            log += IncrementCount;
            var result = log("Hello!");
            Assert.Equal(3,count);
            Assert.Equal("hello!", result);
        }
        public string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }
        public string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Jani";
            var upper = MakeUpperCase(name);
            Assert.Equal("Jani", name);
            Assert.Equal("JANI", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]      
        public void CsharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");      
            GetBookSetNameRef(out book1,"New Name");
            
            Assert.Equal("New Name", book1.Name); 
                      
        }
        public void GetBookSetNameRef(out InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);          
        }
         [Fact]      
        public void CsharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");      
            GetBookSetName(book1,"New Name");
            
            Assert.Equal("Book 1", book1.Name); 
                      
        }
        public void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);          
        }

         [Fact]      
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");      
            SetName(book1,"New Name");
            
            Assert.Equal("New Name", book1.Name); 
           
            
        }

        private void SetName(InMemoryBook book, string name)
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

        private InMemoryBook GetBook(string name)       {


            return new InMemoryBook(name);
           
        }
    }
}
