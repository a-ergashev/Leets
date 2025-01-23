// ReSharper disable SuggestVarOrType_BuiltInTypes
namespace LeetCoding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;

            int[] nums2 = [2, 5, 6]; //Array.Empty<int>();
            int n = 3;

            int mi = 0, ni = 0;
            int[] copynums1 = nums1.ToArray();

            for (var i = 0; i < nums1.Length; i++)
            {
                if (mi < m && ni < n)
                {
                    nums1[i] = copynums1[mi] <= nums2[ni] ? copynums1[mi++] : nums2[ni++];
                }
                else if (mi < m)
                {
                    nums1[i] = copynums1[mi++];
                }
                else if (ni < n)
                {
                    nums1[i] = nums2[ni++];
                }
            }
        }
    }
}