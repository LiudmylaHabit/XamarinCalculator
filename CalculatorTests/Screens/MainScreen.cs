using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CalculatorTests.Screens
{
    public class MainScreen
    {
        public Query textField = x => x.Id("input");
        public Query btnDEL = x => x.Marked("DEL");

        public Query btnZero = x => x.Marked("0");
        public Query btnOne = x => x.Marked("1");
        public Query btnTwo = x => x.Marked("2");
        public Query btnThree = x => x.Marked("3");
        public Query btnFour = x => x.Marked("4");
        public Query btnFive = x => x.Marked("5");
        public Query btnSix = x => x.Marked("6");
        public Query btnSeven = x => x.Marked("7");
        public Query btnEight = x => x.Marked("8");
        public Query btnNine = x => x.Marked("9");
        public Query btnComma = x => x.Marked(",");

        public Query btnPlus = x => x.Marked("+");
        public Query btnMinus = x => x.Marked("-");
        public Query btnMultiply = x => x.Marked("x");
        public Query btnDivide = x => x.Marked("÷");
        public Query btnEquel = x => x.Marked("=");       

        public static IApp App => AppInitializer.App;

        public static void Repl()
        {
            App.Repl();
        }

        public MainScreen TapOnOne()
        {
            App.Tap(btnOne);
            return this;
        }
        
        public MainScreen TapOnTwo()
        {
            App.Tap(btnTwo);
            return this;
        }        

        public MainScreen TapOnThree()
        {
            App.Tap(btnThree);
            return this;
        }

        public MainScreen TapOnFour()
        {
            App.Tap(btnFour);
            return this;
        }

        public MainScreen TapOnFive()
        {
            App.Tap(btnFive);
            return this;
        }

        public MainScreen TapOnSix()
        {
            App.Tap(btnSix);
            return this;
        }

        public MainScreen TapOnSeven()
        {
            App.Tap(btnSeven);
            return this;
        }

        public MainScreen TapOnEight()
        {
            App.Tap(btnEight);
            return this;
        }

        public MainScreen TapOnNine()
        {
            App.Tap(btnNine);
            return this;
        }

        public MainScreen TapOnZero()
        {
            App.Tap(btnZero);
            return this;
        }

        public MainScreen TapOnMinus()
        {
            App.Tap(btnMinus);
            return this;
        }

        public MainScreen TapOnMultiply()
        {
            App.Tap(btnMultiply);
            return this;
        }

        public MainScreen TapOnDivision()
        {
            App.Tap(btnDivide);
            return this;
        }

        public MainScreen TapOnEquel()
        {
            App.Tap(btnEquel);
            return this;
        }

        public MainScreen TapOnPlus()
        {
            App.Tap(btnPlus);
            return this;
        }

        public string GetTextFromField()
        {
            return App.Query(textField)[0].Text.Trim();
        }    
        
        public MainScreen TapOnOperator(string sign)
        {
            Query btn = btnPlus;
            switch (sign)
            {
                case "-":
                    {
                        btn = btnMinus;
                        break;
                    }
                case "x":
                    {
                        btn = btnMultiply;
                        break;
                    }
                case "÷":
                    {
                        btn = btnDivide;
                        break;
                    }            
            }
            App.Tap(btn);
            return this;
        }

        public MainScreen DivisionOperand(string num)
        {
            switch (num)
            {
                case "0":
                    TapOnZero();
                    break;
                case "12":
                    TapOnOne().TapOnTwo();
                    break;
                case "9":
                    TapOnNine();
                    break;
                case "2":
                    TapOnTwo();
                    break;
            }
            return this;
        }
    }
}
