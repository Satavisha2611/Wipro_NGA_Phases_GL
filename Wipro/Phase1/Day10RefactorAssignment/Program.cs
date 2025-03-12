// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Day10RefactorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Report Manipulation");
            ReportService reportService = new ReportService(new ReportGenerator(), new ReportSaver(), new Print());
            reportService.Report();
        }
    }
}
