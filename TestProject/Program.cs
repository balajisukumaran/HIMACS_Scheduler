using System;
using IMAPFeeSolution;
namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IMAPFeeSolution();
        }
        public static void IMAPFeeSolution()
        {
            IMAPFeeSolutionService imapFeeSolutionService = new IMAPFeeSolutionService();
            imapFeeSolutionService.Service(1);
        }
    }
}
