using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-------------------------------------------------------------
 - TEAM:        BRAINSTORM
 - AUTHORS:     xfudor00 <Franti�ek F�dor>
 -              xrazus00 <Andrej R�zus>
 -              xmalik22 <Oto Mal�k>
 -------------------------------------------------------------*/

namespace ivs_proj_2_calc
{
    /// <summary>
    /// Matematick� kni�nica
    /// </summary>
    public class MathHead
    {
        /// <summary>
        /// Add met�da, ktor� berie dva parametre "x" a "y", tieto parametre s��ta
        /// </summary>
        /// <param name="x">Hodnota pred znamienkom s��tania</param>
        /// <param name="y">Hodnota za znamienkom s��tania</param>
        /// <returns>Vracia s��et hodn�t "x" a "y"</returns>
        public double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Sub met�da, ktor� berie dva parametre "x" a "y", tieto parametre od��ta
        /// </summary>
        /// <param name="x">Hodnota pred znamienkom od�itania</param>
        /// <param name="y">Hodnota za znamienkom od��tania</param>
        /// <returns>Vracia rozdiel hodn�t "x" a "y"</returns>
        public double Sub(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Mul met�da, ktor� berie dva parametre "x" a "y", tieto parametre vyn�sob�
        /// </summary>
        /// <param name="x">Hodnota pred znamienkom n�sobenia</param>
        /// <param name="y">Hodnota za znamienkom n�sobenia</param>
        /// <returns>Vracia s��in hond�t "x" a "y"</returns>
        public double Mul(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Div met�da, ktor� berie dva parametre "x" a "y", tieto parametre vydel�.
        /// Ak je hodnota "y" (delite�) rovn� nule, vyhod� v�nimku "DivideByZero".
        /// </summary>
        /// <param name="x">Hodnota nad zlomkovou �iarou (�itate�)</param>
        /// <param name="y">Hodnota pod zlomkovou �iarou (delite�)</param>
        /// <returns>Vracia podiel hodn�t "x" a "y"</returns>
        public double Div(double x, double y)
        {
            if (y == 0.0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        /// <summary>
        /// Exp met�da, ktor� berie dva parametre "x" a "exp". Met�da po��ta v�eobecn� mocninu.
        /// Ak je v�sledkom nekone�no alebo "NaN", vyhod� v�nimku "NotFiniteNumber".
        /// </summary>
        /// <param name="x">Z�klad monciny (moncenec)</param>
        /// <param name="exp">Hodnota exponentu (mocnite�) - je prirodzen� ��slo (hodnota v��ia ako 0)</param>
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
        /// Sqrt met�da, ktor� berie jeden parameter "x". Met�da po��ta druh� mocninu zadan�ho parametru.
        /// </summary>
        /// <param name="x">Hodnota, ktor� chceme umocni� na druh�</param>
        /// <returns>Vracia druh� mocninu hodnoty "x"</returns>
        public double Sqrt(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Fact met�da, ktor� berie jeden parameter "x". Met�da po��ta faktori�l zo zadan�ho parametru.
        /// Ak je parameter rovn� 0 alebo 1, v�sledkom je hodnota 1. Vyu��va rekurziu.
        /// </summary>
        /// <param name="x">Hodnota, z ktorej chceme z�ska� faktori�l</param>
        /// <returns>Vracia faktori�l z hodnoty "x" a vyn�sob� ho so znova zavolanou funkciou, kde sa hodnota "x" zn�i o 1, a� dok�m nie je hodnota "x" rovn� 1</returns>
        public UInt64 Fact(UInt64 x)
        {
            if (x == 1 || x == 0)
                return 1;
            else
                return x * Fact(x - 1);
        }

        /// <summary>
        /// Root met�da, berie dva parametre "x" a "n". Met�da po��ta "n"-t� odmocninu z ��sla "x".
        /// Ak je hodnota "n" rovn� nule, vyhod� v�nimku "DivideByZero".
        /// Ak je hodnota "x" z�porn�, vyhod� v�nimku "NotFiniteNumber", preto�e "n"-t� odmocnina zo z�porn�ho ��sla sa ned� vyjadri�.
        /// </summary>
        /// <param name="x">Hodnota, z ktorej chceme z�ska� "n"-t� odmocninu</param>
        /// <param name="n">Hodnota "n" (exponent)</param>
        /// <returns>Vracia vypo��tan� "n"-t� odmocninu z ��sla "x"</returns>
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
        /// Neg met�da, berie jeden parameter "x". Met�da obr�ti znamienko hodnoty "x".
        /// </summary>
        /// <param name="x">Hodnota, ktor� chceme znegova� (obr�ti� znamienko)</param>
        /// <returns>Vracia znegovan� hodnotu "x"</returns>
        public double Neg(double x)
        {
            return x * (-1.0); 
        }
    }   
}
