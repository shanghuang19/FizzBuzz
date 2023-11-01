using FizzBuzz;
using System.Diagnostics;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        // case 1: normal case
        [Fact]
        public void Should_get_num_string_when_CheckFizzBuzz_given_normal_case()
        {
            // given
            int normal_case = 1;
            FizzBuzzGame game = new FizzBuzzGame();

            // when
            string result = game.CheckFizzBuzz(normal_case);

            //then
            //Assert.NotNull(game);
            Assert.Equal("1", result);
        }

        // case 2: multiple of 3
        [Fact]
        public void Should_get_Fizz_when_CheckFizzBuzz_given_multiple_of_3()
        {
            // given
            int multiple_of_three = 3;
            FizzBuzzGame game = new FizzBuzzGame();

            // when
            string result = game.CheckFizzBuzz(multiple_of_three);

            //then
            //Assert.NotNull(game);
            Assert.Equal("Fizz", result);
        }

        // case 3: multiple of 5
        [Fact]
        public void Should_get_Buzz_when_checkFizzBuzz_given_multiple_of_5()
        {
            // given
            int multiple_of_five = 5;
            FizzBuzzGame game = new FizzBuzzGame();

            // when
            string result = game.CheckFizzBuzz(multiple_of_five);

            //then
            //Assert.NotNull(game);
            Assert.Equal("Buzz", result);
        }

        // case 4: common multiple of 3 and 5
        [Fact]
        public void Should_get_FizzBuzz_when_checkFizzBuzz_given_multiple_of_3_5()
        {
            // given
            int multiple_of_three_five = 15;
            FizzBuzzGame game = new FizzBuzzGame();

            // when
            string result = game.CheckFizzBuzz(multiple_of_three_five);

            //then
            //Assert.NotNull(game);
            Assert.Equal("FizzBuzz", result);
        }
    }
}