using Xunit;
using Xunit.Sdk;

namespace BootCamp.Chapter.Tests
{
    public class AtoiTests
    {
        [Fact]
        public void MyAtoi_Given_String_With_Spaces_Return_Zero() 
        {
            var solution = new Solution();
            var expected = 0;

            var actual = solution.MyAtoi("      ");

            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void MyAtoi_Given_String_With_Spaces_And_Negative_Number_Return_Number()
        {
            var solution = new Solution();
            var expected = -2;

            var actual = solution.MyAtoi("      -2");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_With_1_Digit_Return_Digit()
        {
            var solution = new Solution();
            var expected = 2;

            var actual = solution.MyAtoi("2");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_With_Multiple_Digits_Return_Digit()
        {
            var solution = new Solution();
            var expected = 234;

            var actual = solution.MyAtoi("234");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Begins_With_Letter_Return_Zero()
        {
            var solution = new Solution();
            var expected = 0;

            var actual = solution.MyAtoi("b");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Begins_With_Negative_Sign_And_Number_Return_Number()
        {
            var solution = new Solution();
            var expected = -98;

            var actual = solution.MyAtoi("-98");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Contains_Number_Bigger_Then_IntMax_Return_IntMax()
        {
            var solution = new Solution();
            var expected = int.MaxValue; 

            var actual = solution.MyAtoi("91283472332");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Contains_Number_Smaller_Then_IntMin_Return_IntMin()
        {
            var solution = new Solution();
            var expected = int.MinValue;

            var actual = solution.MyAtoi("-91283472332");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Begins_Plus_Sign_And_Number_Return_Number()
        {
            var solution = new Solution();
            var expected = 3;

            var actual = solution.MyAtoi("+3");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Begins_Plus_Sign_And_Letter_Return_Zero()
        {
            var solution = new Solution();
            var expected = 0;

            var actual = solution.MyAtoi("+w");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyAtoi_Given_String_Has_Number_Negative_Sign_Number_Return_Zero()
        {
            var solution = new Solution();
            var expected = 0;

            var actual = solution.MyAtoi("0+1");
                 

            Assert.Equal(expected, actual);
        }
    }
}