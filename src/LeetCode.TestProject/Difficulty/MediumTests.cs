using LeetCode.Domain.Difficulty;

namespace LeetCode.TestProject.Difficulty
{
    public class MediumTests
    {
        private readonly Medium medium;
        public MediumTests()
        {
            medium = new Medium();
        }

        [Fact]
        public void Excercice2_Example1()
        {
            /*
            * Example 1:
            * Input: l1 = [2,4,3], l2 = [5,6,4]
            * Output: [7,0,8]
            * Explanation: 342 + 465 = 807.
            */
            var listNode1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var listNode2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var ExpectedOutput = new ListNode(7, new ListNode(0, new ListNode(8)));

            var output = medium.Excercice2_AddTwoNumbers(listNode1, listNode2);

            Assert.Equivalent(ExpectedOutput, output);
        }
        [Fact]
        public void Excercice2_Example2()
        {
            /*
             * Example 2:
             * Input: l1 = [0], l2 = [0]
             * Output: [0]
             */
            var listNode1 = new ListNode(0);
            var listNode2 = new ListNode(0);

            var ExpectedOutput = new ListNode(0);

            var output = medium.Excercice2_AddTwoNumbers(listNode1, listNode2);

            Assert.Equivalent(ExpectedOutput, output);
        }
        [Fact]
        public void Excercice2_Example3()
        {
            /*
            * Example 3:
            * Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            * Output: [8,9,9,9,0,0,0,1]
            */
            ListNode listNode1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode listNode2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            var expectedOutput = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));

            var output = medium.Excercice2_AddTwoNumbers(listNode1, listNode2);

            Assert.Equivalent(expectedOutput, output);
        }
    }
}