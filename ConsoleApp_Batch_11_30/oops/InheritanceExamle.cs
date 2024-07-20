using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.oops
{
    //class GoldLoan
    //{
    //    private string _AccountNumber;
    //    private string _AccounntHolder;
    //    private float _Weight;
    //    private float _LoanAmount;
    //    private float _ROI;
    //    private int _NumbersOfOrnements;

    //}

    //class PersonalLoan
    //{
    //    private string _AccountNumber;
    //    private string _AccounntHolder;
    //    //private float _Weight;
    //    private float _LoanAmount;
    //    private float _ROI;
    //   // private int _NumbersOfOrnements;
    //}

    class Loan
    {
        private string _AccountNumber;
        private string _AccounntHolder;
        private float _LoanAmount;
        private float _ROI;
        private int _Tenure;
    }

    class GoldLoan : Loan
    {
        private float _Weight;
        private int _NumbersOfOrnements;
    }

    class HomeLoan : Loan
    {
        private PropetyInfo Propertidetaisl;
    }

    class PropetyInfo
    {

    }
    internal class InheritanceExamle
    {
       
    }
}
