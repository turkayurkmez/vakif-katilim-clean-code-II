namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        //[Fact]
        //public void IsExists()
        //{
        //    /*
        //     * Nesne ihtiyaçları
        //     */
        //    var game = new FizzBuzz.Game();
        //    string output = game.GetWord(3);
        //}

        [Fact]
        public void When_send_3_then_return_Fizz()
        {
            //AAA
            //Arrange
            var game = new Game();
            var value = 3;
            //Act
            string output = game.GetWord(value);

            //Assert
            Assert.Equal(output, "Fizz");
        }

        [Fact]
        public void When_Send_5_then_return_buzz()
        {
            var game = new Game();
            var value = 5;
            string output = game.GetWord(value);
            Assert.Equal("Buzz", output);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void when_send_multiply_three_return_Fizz(int value)
        {
            var game = new Game();
            string actual = game.GetWord(value);

            Assert.Equal("Fizz", actual);
        }


        [Theory]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(20)]
        public void when_send_multiply_five_return_Fizz(int value)
        {
            var game = new Game();
            string actual = game.GetWord(value);

            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void when_send_multiply_fifteen_return_Fizz(int value)
        {
            var game = new Game();
            string actual = game.GetWord(value);

            Assert.Equal("FizzBuzz", actual);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void when_send_literally_numbers_return_number_string(int value)
        {
            var game = new Game();
            string actual = game.GetWord(value);
            Assert.Equal(value.ToString(), actual);
        }

    }
}