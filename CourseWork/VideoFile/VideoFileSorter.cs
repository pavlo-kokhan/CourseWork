using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VideoFileClass;

namespace SecondaryClasses
{
    internal class VideoFileSorter
    {
        private static void Merge(List<VideoFile> leftList, List<VideoFile> rightList, List<VideoFile> list)
        {
            int leftSize = leftList.Count;
            int rightSize = rightList.Count;
            int i = 0, l = 0, r = 0;

            while (l < leftSize && r < rightSize)
            {
                if (leftList[l] < rightList[r])
                {
                    list[i] = leftList[l];
                    l++;
                }
                else
                {
                    list[i] = rightList[r];
                    r++;
                }
                i++;
            }

            while (l < leftSize)
            {
                list[i] = leftList[l];
                l++;
                i++;
            }

            while (r < rightSize)
            {
                list[i] = rightList[r];
                r++;
                i++;
            }
        }

        public static void Sort(List<VideoFile> list)
        {
            int length = list.Count;

            if (length <= 1) return;

            int middle = length / 2;
            var leftList = list.GetRange(0, middle);
            var rightList = list.GetRange(middle, length - middle);

            Sort(leftList);
            Sort(rightList);
            Merge(leftList, rightList, list);
        }
    }
}
