using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-------------------------------------------------------------
 - TEAM:        BRAINSTORM
 - AUTHORS:     xfudor00 <František Fúdor>
 -              xrazus00 <Andrej Rázus>
 -              xmalik22 <Oto Malík>
 -------------------------------------------------------------*/

namespace ivs_proj_2_calc
{
    /// <summary>
    /// Matematická kninica
    /// </summary>
    public class MathHead
    {
        /// <summary>
        /// Add metóda, ktorá berie dva parametre "x" a "y", tieto parametre sèíta
        /// </summary>
        /// <param name="x">Hodnota pred znamienkom sèítania</param>
        /// <param name="y">Hodnota za znamienkom sèítania</param>
        /// <returns>Vracia súèet hodnôt "x" a "y"</returns>
        public double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Sub metóda, ktorá berie dva parametre "x" a "y", tieto parametre odèíta
        /// </summary>
        /// <param name="x">Hodnota pred znamienkom odèitania</param>
        /// <param name="y">Hodnota za znamienkom odèítania</param>
        /// <returns>Vracia rozdiel hodnôt "x" a "y"</returns>
        public double Sub(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Mul metóda, ktorá berie dva parametre "x" a "y", tieto parametre vynásobí
        /// </summary>
        /// <param name="x">Hodnota pred znamienkom násobenia</param>
        /// <param name="y">Hodnota za znamienkom násobenia</param>
        /// <returns>Vracia súèin hondôt "x" a "y"</returns>
        public double Mul(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Div metóda, ktorá berie dva parametre "x" a "y", tieto parametre vydelí.
        /// Ak je hodnota "y" (delite¾) rovnı nule, vyhodí vınimku "DivideByZero".
        /// </summary>
        /// <param name="x">Hodnota nad zlomkovou èiarou (èitate¾)</param>
        /// <param name="y">Hodnota pod zlomkovou èiarou (delite¾)</param>
        /// <returns>Vracia podiel hodnôt "x" a "y"</returns>
        public double Div(double x, double y)
        {
            if (y == 0.0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        /// <summary>
        /// Exp metóda, ktorá berie dva parametre "x" a "exp". Metóda poèíta všeobecnú mocninu.
        /// Ak je vısledkom nekoneèno alebo "NaN", vyhodí vınimku "NotFiniteNumber".
        /// </summary>
        /// <param name="x">Základ monciny (moncenec)</param>
        /// <param name="exp">Hodnota exponentu (mocnite¾) - je prirodzené èíslo (hodnota väèšia ako 0)</param>
        /// <returns>Vracia mocninu</returns>
        public double Exp(double x, int exp)
        {
            if (exp > 0)
            {
                double oldR = x;
                for (int i = 1; i < exp; i++)
                {

                    x = x * oldR;
                }
            }
            if(exp == 0)
            {
                x = 1;
            }

            if (double.IsInfinity(x) || double.IsNaN(x))
            {
                throw new NotFiniteNumberException();
            }
            return x;
        }

        /// <summary>
        /// Sqrt metóda, ktorá berie jeden parameter "x". Metóda poèíta druhú mocninu zadaného parametru.
        /// </summary>
        /// <param name="x">Hodnota, ktorú chceme umocni na druhú</param>
        /// <returns>Vracia druhú mocninu hodnoty "x"</returns>
        public double Sqrt(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Fact metóda, ktorá berie jeden parameter "x". Metóda poèíta faktoriál zo zadaného parametru.
        /// Ak je parameter rovnı 0 alebo 1, vısledkom je hodnota 1. Vyuíva rekurziu.
        /// </summary>
        /// <param name="x">Hodnota, z ktorej chceme získa faktoriál</param>
        /// <returns>Vracia faktoriál z hodnoty "x" a vynásobí ho so znova zavolanou funkciou, kde sa hodnota "x" zníi o 1, a dokım nie je hodnota "x" rovná 1</returns>
        public UInt64 Fact(UInt64 x)
        {
            if (x == 1 || x == 0)
                return 1;
            else
                return x * Fact(x - 1);
        }

        /// <summary>
        /// Root metóda, berie dva parametre "x" a "n". Metóda poèíta "n"-tú odmocninu z èísla "x".
        /// Ak je hodnota "n" rovná nule, vyhodí vınimku "DivideByZero".
        /// Ak je hodnota "x" záporná, vyhodí vınimku "NotFiniteNumber", pretoe "n"-tá odmocnina zo záporného èísla sa nedá vyjadri.
        /// </summary>
        /// <param name="x">Hodnota, z ktorej chceme získa "n"-tú odmocninu</param>
        /// <param name="n">Hodnota "n" (exponent)</param>
        /// <returns>Vracia vypoèítanú "n"-tú odmocninu z èísla "x"</returns>
        public double Root(double x , double n)
        {
            if (n == 0.0)
            {
                throw new DivideByZeroException();
            }
            if(x < 0)
            {
                throw new NotFiniteNumberException();
            }
            return Math.Pow(x, 1.0 / n);
        }

        /// <summary>
        /// Neg metóda, berie jeden parameter "x". Metóda obráti znamienko hodnoty "x".
        /// </summary>
        /// <param name="x">Hodnota, ktorú chceme znegova (obráti znamienko)</param>
        /// <returns>Vracia znegovanú hodnotu "x"</returns>
        public double Neg(double x)
        {
            return x * (-1.0); 
        }
    }   
}
