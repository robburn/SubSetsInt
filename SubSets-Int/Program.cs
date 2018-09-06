using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSets_Int
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Subsets(nums, 0, (List<IList<int>>)result);
            return (IList<IList<int>>) result;
        }

        void Subsets(int[] nums, int curNum, List<IList<int>> subs)
        {
            List<int> curList = new List<int>();
            if (curNum < nums.Length)
            {
                curList.Add(nums[curNum]);
                Subsets(nums, ++curNum, subs);
                int nCount = subs.Count;
                for (int i = 0; i < nCount; i++)
                {
                    List<int> cur = new List<int>(subs[i]);
                    cur.Add(curList[0]);
                    subs.Add(cur);
                }
            }
            else
            {
                subs.Add(curList);
            }
        }

        public void PrintStringList(List<string> list)
        {
            Console.WriteLine();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintListofListInt(List<IList<int>> list)
        {
            foreach(List<int>l in list)
            {
                int count = l.Count - 1;
                Console.Write("[");
                for(int i = 0; i < count; i++)
                {
                    Console.Write("{0},", l[i]);
                }
                if(count > -1)
                {
                    Console.Write("{0}", l[count]);
                }
                Console.WriteLine("]");
            }
        }

        public void Continue()
        {
            Console.WriteLine("Press any key and Enter to continue...");
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            Solution sol = new Solution();
            List<IList<int>> subSets = (List<IList<int>>)sol.Subsets(nums);
            sol.PrintListofListInt(subSets);
            sol.Continue();
        }
    }
}
