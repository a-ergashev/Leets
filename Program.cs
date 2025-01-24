// ReSharper disable SuggestVarOrType_BuiltInTypes
namespace LeetCoding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] nums1 = [3, 2, 2, 3];
            int val = 3;

            var ni = nums1.Length;
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] != val) continue;
                while (ni > -1 && nums1[--ni] == val) { }
                if (i + ni == nums1.Length) {} // return nums1, i
                //swap
            }
        }
    }
}