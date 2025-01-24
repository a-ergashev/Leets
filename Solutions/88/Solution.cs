namespace LeetCoding.Solutions._88;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
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