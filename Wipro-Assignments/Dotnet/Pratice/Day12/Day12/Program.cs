

using System;
using System.Collections.Generic;


    internal class Program
{
    static void Main(string[] args)
    {

        List<Job> jobs = new List<Job>();

        Job j1 = new Job('A', 50, 2);
        Job j2 = new Job('B', 40, 2);
        Job j3 = new Job('C', 90, 1);
        Job j4 = new Job('D', 10, 3);
        Job j5 = new Job('E', 5, 3);
        Job j6 = new Job('F', 11, 2);
        Job j7 = new Job('G', 70, 1);
        Job j8 = new Job('H', 15, 4);

        jobs.Add(j1);
        jobs.Add(j2);
        jobs.Add(j3);
        jobs.Add(j4);
        jobs.Add(j5);
        jobs.Add(j6);
        jobs.Add(j7);
        jobs.Add(j8);


        Job job = new Job();
        job.GetMaxProfit(jobs, 4);

    }
}

public class SortJob : IComparer<Job>
{
    public int Compare(Job x, Job y)
    {
        if (x == null || y == null)
            throw new ArgumentException("Arguments cannot be null");

        return y.Profit.CompareTo(x.Profit);
    }
}

public class Job
{
    public char JobId { get; set; }
    public int Profit { get; set; }
    public int Deadline { get; set; }

    public Job() { }

    public Job(char id, int pro, int dead)
    {
        this.JobId = id;
        this.Profit = pro;
        this.Deadline = dead;
    }

    public void GetMaxProfit(List<Job> jobs, int maxDeadline)
    {

        jobs.Sort(new SortJob());


        char[] result = new char[maxDeadline];

        bool[] slot = new bool[maxDeadline];


        int totalProfit = 0;


        foreach (Job job in jobs)
        {

            for (int j = Math.Min(maxDeadline, job.Deadline) - 1; j >= 0; j--)
            {

                if (!slot[j])
                {
                    result[j] = job.JobId;
                    slot[j] = true;
                    totalProfit += job.Profit;
                    break;
                }
            }
        }


        Console.WriteLine("jobs  maximum profit:");
        for (int i = 0; i < maxDeadline; i++)
        {
            if (slot[i])
            {
                Console.Write(result[i] + " ");
            }
        }
        Console.WriteLine("\nTotal Profit: " + totalProfit);
    }
}


