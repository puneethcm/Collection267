using System;
using System.Collections.Generic;

namespace Collection267
{
	public class RemainingChapters
	{
		public void CountRemainingChapters()
		{
            Console.WriteLine("Please Enter Number of chapter present in Your Book");
            int chapterCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNow Enter starting page and end page of each chapters");
            List<Tuple<int, int>> chaptersPage = new List<Tuple<int, int>>();
            for (int i = 0; i < chapterCount; i++)
            {
                int[] pages = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                chaptersPage.Add(new Tuple<int, int>(pages[0], pages[1]));
            }
            Console.WriteLine("\nNow Enter current page you are reading");
            int currentPage = Convert.ToInt32(Console.ReadLine());

            int currentChapter = 0;
            for (int i = 0; i < chapterCount; i++)
            {
                if (chaptersPage[i].Item1 <= currentPage && currentPage <= chaptersPage[i].Item2)
                {
                    currentChapter = i;
                }
            }

            int remainingChapters = chapterCount - currentChapter;
            Console.WriteLine("\nThe number of chapters yet to read is " + remainingChapters);
        }
	}
}

