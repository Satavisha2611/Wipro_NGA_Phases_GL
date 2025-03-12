using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day10RefactorAssignment
{
    //Single Responsibility implementation in ReportGenerator and ReportSaver
    //Each class has its own responsibilty
    internal class ReportGenerator :IGenerate
    {
        public string Generate()
        {
            return "Report Content and Information."; //Generating report
        }  
    }

    internal class ReportSaver : ISave
    {
        public void Save(string content)
        {
            Console.WriteLine($"Report is saved: {content}"); // saving report
        }

    }

    //Open/Closed implementation in PdfFormat and ExcelFormat
    //Each class extends an interface other classes can be implemented for other
    //purposes but not the classes already catering to one need
    internal class PdfFormat : IReportFormatter
    {
        public void Format(string content)
        {
            Console.WriteLine("Report in pdf:" + content); // Converting content to pdf
        }
    }
    internal class ExcelFormat : IReportFormatter
    {
        public void Format(string content)
        {
            Console.WriteLine("Report in excel:" + content); // Converting content to excel
        }
    }

    //Liskov implementation
    // the child class summary does not change the initial nature of the base class report
    internal class Summary : Report
    {
        public override void Display()
        {
            Console.WriteLine("Summary of the content.");
        }
    }
    
    //Interfaces seggretions implemented 
    // print and export are two different functionalities that cannot be derived from a single interface
    //thus both have different interfaces catering to their needs
    internal class Print : IPrint
    {
        public void Printing(string content)
        { Console.WriteLine("Printing.." + content); }
    }
    internal class Export : IExport
    {
        public void Exporting(string content)
        { Console.WriteLine("Exporting.." + content); }
    }

    //Dependency is lessened here by using abstraction for high level modules and low level modules for loose coupling
    internal class ReportService
    {
        private IGenerate _generate;
        private ISave _save;
        private IPrint _print;

        public ReportService(IGenerate generate, ISave save, IPrint print)
        {
            _generate = generate;
            _save = save;
            _print = print;
        }

        public void Report()
        {
            string content = _generate.Generate();
            _save.Save(content);
            _print.Printing(content);
        }
    }

}
