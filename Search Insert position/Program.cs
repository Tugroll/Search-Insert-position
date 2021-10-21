using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_position
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a sorted array of distinct integers and a target value,
            //return the index if the target is found.If not, return the index where it would be if it were inserted in order.
            int[] instance = new int[5]
            {
                 6,
                 2,
                 1,
                 4,
                 5,
            };

            int instance1 = Convert.ToInt32(Console.ReadLine());
            
            insert(instance, instance1);




        }
        public static int insert(int[] nums, int target)
        {
            Array.Sort(nums);

            
            

            if (nums.Contains(target))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if(nums[i] == target)
                    {
                        Console.WriteLine(i);
                        return i;
                        

                    }
                    
                }
            }else
            {


                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > target)
                    {
                        Console.WriteLine(i);

                    } else if (target > nums[i] && i == nums.Length - 1)
                    {  
                       return(i + 1);
                    }
                }
            }
            return 0;

        }
        
    }
}
