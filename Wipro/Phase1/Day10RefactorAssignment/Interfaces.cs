using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10RefactorAssignment
{
    //interfaces and abstraction used for abstraction
     abstract class Report
    {
        public abstract void Display();
    }

    internal interface IReportFormatter
    {
         void Format(string content);
    }
    internal interface IPrint
    {
        void Printing(string content);
    }
    internal interface IExport
    {
        void Exporting(string content);
    }
    internal interface IGenerate
    {
        string Generate();
    }
    internal interface ISave
    {
        void Save(string content);
    }
}
