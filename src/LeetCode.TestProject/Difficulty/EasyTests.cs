using LeetCode.Domain.Difficulty;

namespace LeetCode.TestProject.Difficulty
{
    public class EasyTests
    {

        private readonly Easy easy;

        public EasyTests()
        {
            this.easy = new Easy();  
        }

        [Fact]
        public void Problem1_Example1()
        {
            /*
             * Example 1:
             * Input: nums = [2,7,11,15], target = 9
             * Output: [0,1]
             * Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
             */

            var nums = new[] { 2, 7, 11, 15 };
            var target = 9;
            var expectedOutput = new[] { 0, 1 };

            var output = easy.Excercice1_TwoSum(nums, target);


            Assert.Equal(expectedOutput, output);

        }
        [Fact]
        public void Problem1_Example2()
        {
            /*
             * Example 2:
             * Input: nums = [3,2,4], target = 6
             * Output: [1,2]
             */

            var nums = new[] { 3, 2, 4 };
            var target = 6;
            var expectedOutput = new[] { 1, 2 };

            var output = easy.Excercice1_TwoSum(nums, target);

            Assert.Equal(expectedOutput, output);
        }
        [Fact]
        public void Problem1_Example3()
        {
            /*
             * Example 3:
             * Input: nums = [3,3], target = 6
             * Output: [0,1]
             */

            var nums = new[] { 3, 3 };
            var target = 6;
            var expectedOutput = new[] { 0, 1 };

            var output = easy.Excercice1_TwoSum(nums, target);

            Assert.Equal(expectedOutput, output);
        }
    }
}