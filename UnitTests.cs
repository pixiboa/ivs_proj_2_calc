using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ivs_proj_2_calc;
using MathHeadFunctiones = ivs_proj_2_calc.MathHead;



namespace MathHeadTest
{
    [TestFixture]
    public class UnitTests
    {
        // presnost pri vypoctoch s hodnotou double
        private const double esp = 1e-3;
        [Test]
        
        //testovanie MathHead scitavanie
        public void Function_Sum() 
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(-1,mh.Sum(1,-2));
            Assert.AreNotEqual(10, mh.Sum(5, 6));
            Assert.AreEqual(984, mh.Sum(983, 1));
            Assert.AreEqual(2000, mh.Sum(1965, 35));
            Assert.AreEqual(-100, mh.Sum(-50, -50));
            Assert.AreEqual(0, mh.Sum(-659, 659));
            Assert.AreEqual(0, mh.Sum(0, 0));
            Assert.AreEqual(-50, mh.Sum(-78, 28));
            Assert.AreEqual(450000000, mh.Sum(400000000, 50000000));
            Assert.AreEqual(-300000000, mh.Sum(-150000000, -150000000));

        }
        [Test]

        //testovanie MathHead Delenie
        public void Function_Div()
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(39, mh.Div(156, 4));
            Assert.AreEqual(1.8, mh.Div(9, 5));
            Assert.AreEqual(-2, mh.Div(-6, 3));
            Assert.AreEqual(129301, mh.Div(129301, 1));
            Assert.AreEqual(2.25, mh.Div(9, 4));
            Assert.AreEqual(2.25, mh.Div(-9, -4));
            Assert.AreEqual(1000000, mh.Div(10000000, 10));
            Assert.AreEqual(0.5, mh.Div(800, 1600));
            Assert.AreEqual(-8, mh.Div(72, -9));


            Assert.AreNotEqual(12, mh.Div(698, 68));
            Assert.AreNotEqual(145, mh.Div(100000000, 78000000));

            // pridat delenie 0 !!!
            
        }
        [Test]

        //testovanie MathHead Krat
        public void Function_Ml() 
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(2, mh.Mul(2, 1));
            Assert.AreEqual(-81, mh.Mul(9, -9));
            Assert.AreEqual(60, mh.Mul(-6, -10));
            Assert.AreEqual(-42, mh.Mul(-42,1));
            Assert.AreEqual(0, mh.Mul(0, 1987));
            Assert.AreEqual(400000000, mh.Mul(20000, 20000));
            Assert.AreEqual(-100000000, mh.Mul(-100000000, 1));
            Assert.AreEqual(44.1, mh.Mul(6.3, 7));
           
        }
        [Test]

        //testovanie MathHead vypocet s exponentom
        public void Function_Exp()
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(9, mh.Exp(3, 2));
            Assert.AreEqual(42875, mh.Exp(35, 3));
            Assert.AreEqual(147008443, mh.Exp(43, 5));
            Assert.AreEqual(25, mh.Exp(-5, 2));
            Assert.AreEqual(-125, mh.Exp(-5, 3));
            Assert.AreEqual(0.729, mh.Exp(0.9, 3),esp);
            Assert.AreEqual(3.652264, mh.Exp(1.54, 3));

            Assert.AreNotEqual(745, mh.Exp(9, 5));
            Assert.AreNotEqual(0.56, mh.Exp(1.26, 4));
            Assert.AreNotEqual(654, mh.Exp(7, 6));
            Assert.AreNotEqual(1231456, mh.Exp(53, 2));

        }
        [Test]

        //testovanie MathHead negacie
        public void Function_Neg() 
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(-1, mh.Negacia(1));
            Assert.AreEqual(-100000000, mh.Negacia(100000000));
            Assert.AreEqual(0, mh.Negacia(0));
            Assert.AreEqual(5000, mh.Negacia(-5000));
            Assert.AreNotEqual(-500, mh.Negacia(-500));
            Assert.AreNotEqual(48, mh.Negacia(48));
            Assert.AreNotEqual(1, mh.Negacia(1));
            Assert.AreEqual(4.5, mh.Negacia(-4.5));
            Assert.AreEqual(-9.6, mh.Negacia(9.6));
           

        } 
        [Test]

        //testovanie MathHead Odmocnina
        public void Function_Root() 
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(3, mh.Root(9, 2));
            Assert.AreEqual(9, mh.Root(81, 2));
            Assert.AreEqual(0, mh.Root(0, 5));
            Assert.AreEqual(60000000, mh.Root(60000000, 1));
            Assert.AreEqual(3.9, mh.Root(59.319, 3), esp);
            Assert.AreEqual(12, mh.Root(144, 2));
            Assert.AreEqual(1000, mh.Root(1000000, 2));

            Assert.AreNotEqual(45, mh.Root(456, 9));
            Assert.AreNotEqual(74, mh.Root(978, 2));
            // pridat osetrenie pre vstup mensi ako 0
        }
        [Test]

        //testovanie MathHead scitavanie
        public void Function_Sub() 
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(0, mh.Sub(1, 1));
            Assert.AreEqual(-1, mh.Sub(0, 1));
            Assert.AreEqual(1, mh.Sub(1, 0));
            Assert.AreEqual(0, mh.Sub(-5, -5));
            Assert.AreEqual(150000000, mh.Sub(150000001, 1));
            Assert.AreEqual(-189000000, mh.Sub(-300000000,-111000000));
            Assert.AreEqual(687, mh.Sub(743, 56));
            Assert.AreEqual(-42, mh.Sub(-40, 2));
            Assert.AreEqual(5.364, mh.Sub(6, 0.636));
            Assert.AreEqual(-765.315, mh.Sub(-1000, -234.685));
            Assert.AreEqual(897, mh.Sub(800, -97));
            Assert.AreEqual(0, mh.Sub(0, 0));

        }
        [Test]

        //testovanie MathHead Faktorial
        public void Function_Fakt() 
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(120, mh.Fact(5));
            Assert.AreEqual(1, mh.Fact(1));
            Assert.AreEqual(1, mh.Fact(0));
            Assert.AreEqual(479001600, mh.Fact(12));
            
            // Doplnit osetrenie ak faqtorial sa == zaporne cislo

        }
        [Test]

        //testovanie MathHead ^2
        public void Function_SQRT()
        {
            MathHeadFunctiones mh = new MathHeadFunctiones();
            Assert.AreEqual(144, mh.Sqrt(12));
            Assert.AreEqual(64000000, mh.Sqrt(8000));
            Assert.AreEqual(4, mh.Sqrt(2));
            Assert.AreEqual(1, mh.Sqrt(1));

            Assert.AreNotEqual(-9, mh.Sqrt(-3));
            Assert.AreNotEqual(-64, mh.Sqrt(-8));
            Assert.AreNotEqual(-64000000, mh.Sqrt(-8000));

        }
    }
}
