using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*-------------------------------------------------------------
 - TEAM:        BRAINSTORM
 - AUTHORS:     xfudor00 <František Fúdor>
 -              xrazus00 <Andrej Rázus>
 -              xmalik22 <Oto Malík>
 -------------------------------------------------------------*/

namespace ivs_proj_2_calc
{
    /// <summary>
    /// Trieda Calculator
    /// </summary>
    public partial class Calculator : Form
    {

        String operation = "";
        String oldOperation = "";
        String historyString = "";
        Double historyStringValue = 0;
        Double historyValue = 0;
        Double resultValue = 0;
        Double betweenValue = 0;
        bool enterPressed = false;
        bool operationPressed = false;
        bool funcPressed = false;
        bool maxChar = false;
        int errorCode = 0;


        /// <summary>
        /// Metóda NewFont, ktorá nastavuje veľkosť fontu v textBoxe výsledku a zaručuje jeho dynamickosť.
        /// </summary>
        public void NewFont()
        {
            if (resultBox.Text.Count() > 13)
            {
                resultBox.Font = new Font(resultBox.Font.FontFamily, 28);
                if (resultBox.Text.Count() > 17)
                {
                    resultBox.Font = new Font(resultBox.Font.FontFamily, 24);
                    if (resultBox.Text.Count() > 21)
                    {
                        resultBox.Font = new Font(resultBox.Font.FontFamily, 20);
                        if (resultBox.Text.Count() > 25)
                        {
                            resultBox.Font = new Font(resultBox.Font.FontFamily, 18);
                            if (resultBox.Text.Count() > 29)
                            {
                                resultBox.Font = new Font(resultBox.Font.FontFamily, 14);
                                if (resultBox.Text.Count() == 36)
                                {
                                    maxChar = true;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                resultBox.Font = new Font(resultBox.Font.FontFamily, 36);
            }
        }

        /// <summary>
        /// Metóda Error, ktorá je volaná vždy vo funkciách, kde sa zachytila výnimka.
        /// Metóda slúži na vypísanie chybového hlásenia do textBoxu výsledku na základe číselnej reprezentácie chybového stavu.
        /// </summary>
        /// <param name="errCode">Číslo, ktoré reprezentuje daný chybový stav.</param>
        public void Error(int errCode) {

            resultBox.Font = new Font(resultBox.Font.FontFamily, 20);
            switch (errCode)
            {
                case 1:
                    resultBox.Text = "Neplatný vstup";
                    break;
                case 2:
                    resultBox.Text = "Exponent musí byť prirodzené číslo";
                    break;
                case 3:
                    resultBox.Text = "Pretečenie";
                    break;
                case 4:
                    resultBox.Text = "Nulou nemožno deliť";
                    break;
                default:
                    break;
            }
            lbl_history.Text = "";
            historyStringValue = 0;
            historyValue = 0;
            errorCode = 1;
            funcPressed = false;
            operationPressed = false;
            enterPressed = true;
            operation = "";
        }

        /// <summary>
        /// Metóda Calculator, ktorá konštruuje a inicializuje komponenty pre GUI interface. 
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metóda Calculator_KeyDown, ktorá je volaná vždy pri stlačení tlačidla na klávesnici.
        /// Metóda podľa stlačeného tlačidla vykoná zavolanie príslušnej metódy pre dané tlačidlo.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn_num_7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btn_num_8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn_num_9.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn_num_4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btn_num_5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn_num_6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn_num_1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn_num_2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btn_num_3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn_num_0.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btn_div.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btn_mul.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btn_sub.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                btn_add.PerformClick();
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btn_enter.PerformClick();
            }
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal)
            {
                btn_comma.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                btn_backspace.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                btn_del.PerformClick();
            }


        }

        /// <summary>
        /// Metóda btn_backspace_Click, ktorá je volaná pri stlačení tlačidla backspace. Metóda odstráni posledný znak v textBoxe výsledku.
        /// Ak ostane posledný znak, nahradí ho nulou. Priebežne nastavuje font výsledku.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 1)
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
            }
            else
            {
                resultBox.Font = new Font(resultBox.Font.FontFamily, 36);
                resultBox.Text = "0";
            }
            maxChar = false;
            NewFont();
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_del_Click, ktorá je volaná pri stlačení tlačidla "C". Metóda nastaví všetko (ako napríklad medzivýpočty) do defaultných nastavení.
        /// Vymaže výsledok z textBoxu výsledku a vymaže aj históriu.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_del_Click(object sender, EventArgs e)
        {
            operation = "";
            oldOperation = "";
            historyString = "";
            historyStringValue = 0;
            historyValue = 0;
            resultValue = 0;
            betweenValue = 0;
            enterPressed = false;
            operationPressed = false;
            funcPressed = false;
            resultBox.Font = new Font(resultBox.Font.FontFamily, 36);
            lbl_history.Text = "";
            resultBox.Text = "0";
            NewFont();
            maxChar = false;
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_ce_Click, ktorá je volaná pri stlačení tlačidla "CE". Metóda vymaže výsledok z textBoxu výsledku, nastaví defaultný font ale nevymaže históriu.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_ce_Click(object sender, EventArgs e)
        {
            resultBox.Font = new Font(resultBox.Font.FontFamily, 36);
            resultBox.Text = "0";
            historyStringValue = historyValue;
            NewFont();
            maxChar = false;
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_sqrt_Click, ktorá je volaná pri stlačení tlačidla "x2". Metóda počíta druhú mocninu čísla pomocou metódy Sqrt() volanej z matematickej knižnice.
        /// Ošetruje chybové stavy, pridá funkciu do histórie a výsledok vypíše do textBoxu výsledku. 
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            MathHead mh = new MathHead();
            if (enterPressed == true)
            {
                lbl_history.Text = "";
                enterPressed = false;
            }

            try
            {
                Double.Parse(resultBox.Text);
            }
            catch (FormatException)
            {
                Error(1);
                return;
            }
            catch (OverflowException)
            {
                Error(3);
                return;
            }

            if (double.IsInfinity(historyValue) || double.IsInfinity(double.Parse(resultBox.Text)))
            {
                Error(3);
                return;
            }
            switch (operation)
            {
                case "+":
                    lbl_history.Text = lbl_history.Text + "sqrt(" + Double.Parse(resultBox.Text) + ")";
                    resultValue = historyValue + mh.Sqrt(Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                case "-":
                    lbl_history.Text = lbl_history.Text + "sqrt(" + Double.Parse(resultBox.Text) + ")";
                    resultValue = historyValue - mh.Sqrt(Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                case "*":
                    lbl_history.Text = lbl_history.Text + "sqrt(" + Double.Parse(resultBox.Text) + ")";
                    resultValue = historyValue * mh.Sqrt(Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                case "/":
                    lbl_history.Text = lbl_history.Text + "sqrt(" + Double.Parse(resultBox.Text) + ")";
                    resultValue = historyValue / mh.Sqrt(Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                default:
                    if (funcPressed == true)
                    {
                        lbl_history.Text = "sqrt(" + historyString + ")";
                    }
                    else
                    {
                        lbl_history.Text = lbl_history.Text + "sqrt(" + Double.Parse(resultBox.Text) + ")";
                    }

                    resultValue = mh.Sqrt(Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;
                    break;
            }
            if (double.IsInfinity(resultValue))
            {
                Error(3);
                return;
            }
            historyString = lbl_history.Text;
            operationPressed = false;
            operation = "";
            funcPressed = true;
            NewFont();
            maxChar = false;
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_fact_Click, ktorá je volaná pri stlačení tlačidla "x!". Metóda počíta faktorial čísla pomocou metódy Fact() volanej z matematickej knižnice
        /// Ošetruje chybové stavy, pridá funkciu do histórie a výsledok vypíše do textBoxu výsledku. 
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_fact_Click(object sender, EventArgs e)
        {
            MathHead mh = new MathHead();
            if (enterPressed == true)
            {
                lbl_history.Text = "";
                enterPressed = false;
            }

            double x;
            if(Double.TryParse(resultBox.Text, out x))
            {
                if(x < 0)
                {
                    lbl_history.Text = "";
                    historyStringValue = 0;
                    historyValue = 0;
                    resultBox.Font = new Font(resultBox.Font.FontFamily, 20);
                    resultBox.Text = "Neplatný vstup";
                    errorCode = 1;
                    funcPressed = false;
                    operationPressed = false;
                    enterPressed = true;
                    operation = "";
                    return;
                }
            }

            try
            {
                UInt64.Parse(resultBox.Text);
            }
            
            catch (FormatException)
            {
                Error(1);
                return;
            }

            catch (OverflowException)
            {
                Error(3);
                return;
            }

            switch (operation)
            {
                case "+":

                    lbl_history.Text = lbl_history.Text + "fact(" + UInt64.Parse(resultBox.Text) + ")";
                    resultValue = historyValue + mh.Fact(UInt64.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                case "-":
                    lbl_history.Text = lbl_history.Text + "fact(" + UInt64.Parse(resultBox.Text) + ")";
                    resultValue = historyValue - mh.Fact(UInt64.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                case "*":
                    lbl_history.Text = lbl_history.Text + "fact(" + UInt64.Parse(resultBox.Text) + ")";
                    resultValue = historyValue * mh.Fact(UInt64.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                case "/":
                    lbl_history.Text = lbl_history.Text + "fact(" + UInt64.Parse(resultBox.Text) + ")";
                    resultValue = historyValue / mh.Fact(UInt64.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;

                    break;
                default:
                    if (funcPressed == true)
                    {
                        lbl_history.Text = "fact(" + historyString + ")";
                    }
                    else
                    {
                        lbl_history.Text = lbl_history.Text + "fact(" + UInt64.Parse(resultBox.Text) + ")";
                    }

                    resultValue = mh.Fact(UInt64.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;
                    break;
            }
            if(resultValue == 0)
            {
                Error(3);
                return;
            }
            historyString = lbl_history.Text;
            operationPressed = false;
            operation = "";
            funcPressed = true;
            NewFont();
            maxChar = false;
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_enter_Click, ktorá je volaná pri stlačení tlačidla "rovná sa". Má za úlohu zistiť naposledy kliknutú operáciu 
        /// a na základe nej vypočítať výsledok a ukončiť sekvenciu operácií. Tento výsledok sa následne vypíše do textBox výsledku a do histórie sa vypíše história operácií 
        /// zakončená posledným číslom a znaminekom rovnosti. Ošetruje aj chybové stavy.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_enter_Click(object sender, EventArgs e)
        {
            MathHead mh = new MathHead();

            try
            {
                Double.Parse(resultBox.Text);
            }
            catch (FormatException)
            {
                Error(0);
                return;
            }

            historyStringValue = Double.Parse(resultBox.Text);

            switch (operation)
            {
                case "+":
                    resultValue = mh.Add(historyValue, Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;
                    lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                    break;
                case "-":
                    resultValue = mh.Sub(historyValue, Double.Parse(resultBox.Text));
                    resultBox.Text = resultValue.ToString();
                    historyValue = resultValue;
                    lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                    break;
                case "*":
                    switch (oldOperation)
                    {
                        case "+":
                            resultValue = betweenValue + mh.Mul(historyValue, Double.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "-":
                            resultValue = betweenValue - mh.Mul(historyValue, Double.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "/":
                            resultValue = betweenValue / mh.Mul(historyValue, Double.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        default:
                            resultValue = mh.Mul(historyValue, Double.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            oldOperation = "";
                            break;
                    }
                    break;

                case "^":
                    try
                    {
                        Int32.Parse(resultBox.Text);
                    }
                    catch (FormatException)
                    {
                        Error(2);
                        return;
                    }

                    if (Int32.Parse(resultBox.Text) < 0)
                    {
                        Error(2);
                        return;
                    }

                    switch (oldOperation)
                    {
                        case "+":
                            resultValue = betweenValue + mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "-":
                            resultValue = betweenValue - mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "*":
                            resultValue = betweenValue * mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "/":
                            resultValue = betweenValue / mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        default:
                            resultValue = mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            oldOperation = "";
                            break;
                    }
                    break;
                case "\u221A":

                    if(historyValue == 0)
                    {
                        Error(4);
                        return;
                    }
                    if (Double.Parse(resultBox.Text) < 0)
                    {
                        Error(1);
                        return;
                    }
                    switch (oldOperation)
                    {
                        case "+":
                            resultValue = betweenValue + mh.Root(Double.Parse(resultBox.Text), historyValue);
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "-":
                            resultValue = betweenValue - mh.Root(Double.Parse(resultBox.Text), historyValue);
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "*":
                            resultValue = betweenValue * mh.Root(Double.Parse(resultBox.Text), historyValue);
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        case "/":
                            resultValue = betweenValue / mh.Root(Double.Parse(resultBox.Text), historyValue);
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            betweenValue = 0;
                            oldOperation = "";
                            break;
                        default:
                            resultValue = mh.Root(historyValue, Int32.Parse(resultBox.Text));
                            resultBox.Text = resultValue.ToString();
                            historyValue = resultValue;
                            lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                            oldOperation = "";
                            break;
                    }
                    break;
                case "/":
                    if (Double.Parse(resultBox.Text) == 0)
                    {
                        Error(4);
                        return;
                    }
                    else
                    {
                        switch (oldOperation)
                        {
                            case "+":
                                resultValue = betweenValue + mh.Div(historyValue, Double.Parse(resultBox.Text));
                                resultBox.Text = resultValue.ToString();
                                historyValue = resultValue;
                                lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                                betweenValue = 0;
                                oldOperation = "";
                                break;
                            case "-":
                                resultValue = betweenValue - mh.Div(historyValue, Double.Parse(resultBox.Text));
                                resultBox.Text = resultValue.ToString();
                                historyValue = resultValue;
                                lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                                betweenValue = 0;
                                oldOperation = "";
                                break;
                            case "*":
                                resultValue = betweenValue * mh.Div(historyValue, Double.Parse(resultBox.Text));
                                resultBox.Text = resultValue.ToString();
                                historyValue = resultValue;
                                lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                                betweenValue = 0;
                                oldOperation = "";
                                break;
                            default:
                                resultValue = mh.Div(historyValue, Double.Parse(resultBox.Text));
                                resultBox.Text = resultValue.ToString();
                                historyValue = resultValue;
                                lbl_history.Text = lbl_history.Text + historyStringValue + "=";
                                oldOperation = "";
                                break;
                        }
                        
                    }
                break;
                    
            }
            if (double.IsInfinity(resultValue))
            {
                Error(2);
                return;
            }
            NewFont();
            enterPressed = true;
            operationPressed = false;
            operation = "";
            maxChar = false;
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_num_Click, ktorá je volaná pri stlačení tlačidla číslice alebo decimálnej čiarky.
        /// Metóda zabezpečuje výpis číslice alebo decimálnej čiarky do textBoxu výsledku, z ktorého sa neskôr berú aj medzivýpočty.
        /// Pomocou (Button)sender.text získa číslicu zo stlačeného tlačidla. Ošetruje chybové stavy.
        /// Nastavuje font podľa velkosti a prioritu kliknutia na tlačidlo enter.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(maxChar == false)
            {
                if (resultBox.Text == "0" || (operationPressed) || (enterPressed) || errorCode == 1 || resultBox.Text.Count() == 37)
                {

                    if (errorCode == 1)
                    {
                        resultBox.Font = new Font(resultBox.Font.FontFamily, 36);
                    }

                    if (resultBox.Text == "0" && button.Text == ",")
                    {
                        if (!resultBox.Text.Contains(","))
                        {
                            resultBox.Text = resultBox.Text + button.Text;
                        }
                    }
                    else
                    {
                        resultBox.Text = "";
                    }

                    if (enterPressed == true)
                    {
                        lbl_history.Text = "";
                        if (button.Text == ",")
                        {
                            resultBox.Text = "0" + button.Text;
                        }

                    }
                    NewFont();

                }


                enterPressed = false;
                operationPressed = false;
                enterPressed = false;

                if (button.Text == ",")
                {
                    if (!resultBox.Text.Contains(","))
                    {
                        resultBox.Text = resultBox.Text + button.Text;
                    }
                }
                else
                {
                    resultBox.Text = resultBox.Text + button.Text;
                }

                NewFont();
                errorCode = 0;
            }
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_neg_Click, ktorá je volaná pri stlačení tlačidla negácie. 
        /// Metóda obráti znamienko čísla nachádzajúceho sa v textBoxe výsledoku pomocou metódy volanej z matematickej knižnice.
        /// Nastaví sa font podľa velkosti výsledku a priorita kliknutia na tlačidlo enter.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_neg_Click(object sender, EventArgs e)
        {
            MathHead mh = new MathHead();
            resultBox.Text = mh.Neg(Double.Parse(resultBox.Text)).ToString();
            resultValue = Double.Parse(resultBox.Text);
            NewFont();
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda Calculator_Load, ktorá pri spustení aplikácie načíta defaultné nastavenia.
        /// Zavolá metódu vymazania výsledku a histórie, nastaví font podľa velkosti výsledku (defaultne 36pt).
        /// Nastaví prioritu kliknutia na tlačidlo enter.
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void Calculator_Load(object sender, EventArgs e)
        {
            btn_del.PerformClick();
            NewFont();
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_op_Click, ktorá je volaná pri stlačení tlačidla operácie. Metóda vykoná predchádzajúcu operáciu (pokiaľ existuje).
        /// Vypočíta operáciu pomocou metód volaných z matematickej knižnice. Ošetruje chybové stavy.
        /// Nastavuje nadchádzajúcu operáciu na základe aktuálne kliknutej operácie. Pokiaľ bola operácia stlačená bezprostredne pred akutálnou operáciou, 
        /// stará operácie je prepísaná novou (aktuálne stlačenou operáciou).
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_op_Click(object sender, EventArgs e)
        {
            MathHead mh = new MathHead();
            
            Button button = (Button)sender;

            if (operationPressed == true && (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "^" || operation == "\u221A"))
            {
                operation = button.Text;
                lbl_history.Text = lbl_history.Text.Remove(lbl_history.Text.Length - 1) + operation;
            }

            else
            {
                if (enterPressed == true)
                {
                    operation = button.Text;

                    lbl_history.Text = historyValue.ToString() + operation;
                    enterPressed = false;

                }
                else
                {

                    try
                    {
                        Double.Parse(resultBox.Text);
                    }
                    catch (FormatException)
                    {
                        Error(0);
                        return;
                    }
                    historyStringValue = Double.Parse(resultBox.Text);

                    switch (operation)
                    {
                        case "+":
                            if (button.Text == "^" || button.Text == "\u221A" || button.Text == "*" || button.Text == "/")
                            {
                                betweenValue = historyValue;
                                historyValue = Double.Parse(resultBox.Text);
                                oldOperation = operation;
                                operation = button.Text;
                            }

                            else
                            {
                                resultValue = mh.Add(historyValue, Double.Parse(resultBox.Text));
                                resultBox.Text = resultValue.ToString();
                                historyValue = resultValue;
                            }
                            break;
                        case "^":
                            try
                            {
                                Int32.Parse(resultBox.Text);
                            }
                            catch (FormatException)
                            {
                                Error(2);
                                return;
                            }

                            if (Int32.Parse(resultBox.Text) < 0)
                            {
                                Error(2);
                                return;
                            }

                            switch (oldOperation)
                            {

                                case "+":
                                    resultValue = betweenValue + mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                case "-":
                                    resultValue = betweenValue - mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                case "*":
                                    resultValue = betweenValue * mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                case "/":
                                    resultValue = betweenValue / mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                default:
                                    resultValue = mh.Exp(historyValue, Int32.Parse(resultBox.Text));
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    oldOperation = "";
                                    break;
                            }

                            break;
                        case "\u221A":
                            if (historyValue == 0)
                            {
                                Error(4);
                                return;
                            }
                            if (Double.Parse(resultBox.Text) < 0)
                            {
                                Error(1);
                                return;
                            }
                            switch (oldOperation)
                            {
                                case "+":
                                    resultValue = betweenValue + mh.Root(Double.Parse(resultBox.Text), historyValue);
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                case "-":
                                    resultValue = betweenValue - mh.Root(Double.Parse(resultBox.Text), historyValue);
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                case "*":
                                    resultValue = betweenValue * mh.Root(Double.Parse(resultBox.Text), historyValue);
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                case "/":
                                    resultValue = betweenValue / mh.Root(Double.Parse(resultBox.Text), historyValue);
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    betweenValue = 0;
                                    oldOperation = "";
                                    break;
                                default:
                                    resultValue = mh.Root(Double.Parse(resultBox.Text), historyValue);
                                    resultBox.Text = resultValue.ToString();
                                    historyValue = resultValue;
                                    oldOperation = "";
                                    break;
                            }

                            break;
                        case "-":
                            if (button.Text == "^" || button.Text == "\u221A" || button.Text == "*" || button.Text == "/")
                            {
                                betweenValue = historyValue;
                                historyValue = Double.Parse(resultBox.Text);
                                oldOperation = operation;
                                operation = button.Text;
                            }

                            else
                            {
                                resultValue = mh.Sub(historyValue, Double.Parse(resultBox.Text));
                                resultBox.Text = resultValue.ToString();
                                historyValue = resultValue;
                            }

                            break;
                        case "*":
                            
                            if (button.Text == "^" || button.Text == "\u221A" || button.Text == "/")
                            {
                                betweenValue = historyValue;
                                historyValue = Double.Parse(resultBox.Text);
                                oldOperation = operation;
                                operation = button.Text;
                            }
                            else
                            {
                                switch (oldOperation)
                                {
                                    case "+":
                                        resultValue = betweenValue + mh.Mul(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        betweenValue = 0;
                                        oldOperation = "";
                                        break;
                                    case "-":
                                        resultValue = betweenValue - mh.Mul(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        betweenValue = 0;
                                        oldOperation = "";
                                        break;
                                    case "/":
                                        resultValue = betweenValue / mh.Mul(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        betweenValue = 0;
                                        oldOperation = "";
                                        break;
                                    default:
                                        if (historyValue == 0)
                                        {
                                            historyValue = 1;
                                        }
                                        resultValue = mh.Mul(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        oldOperation = "";
                                        break;
                                }
                            }
                            

                            break;
                        case "/":
                            if (button.Text == "^" || button.Text == "\u221A" || button.Text == "*")
                            {
                                betweenValue = historyValue;
                                historyValue = Double.Parse(resultBox.Text);
                                oldOperation = operation;
                                operation = button.Text;
                            }
                            else
                            {
                                if (Double.Parse(resultBox.Text) == 0)
                                {
                                    Error(4);
                                    return;
                                }
                                switch (oldOperation)
                                {
                                    case "+":
                                        resultValue = betweenValue + mh.Div(historyValue,Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        betweenValue = 0;
                                        oldOperation = "";
                                        break;
                                    case "-":
                                        resultValue = betweenValue - mh.Div(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        betweenValue = 0;
                                        oldOperation = "";
                                        break;
                                    case "*":
                                        resultValue = betweenValue * mh.Div(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        betweenValue = 0;
                                        oldOperation = "";
                                        break;
                                    default:
                                        resultValue = mh.Div(historyValue, Double.Parse(resultBox.Text));
                                        resultBox.Text = resultValue.ToString();
                                        historyValue = resultValue;
                                        oldOperation = "";
                                    break;
                                }
                            }

                            break;
                        default:
                            historyValue = historyStringValue;
                        break;
                    }
                    if (funcPressed == true)
                    {

                        lbl_history.Text = historyStringValue.ToString() + button.Text;
                    }
                    else
                    {
                        lbl_history.Text = lbl_history.Text + historyStringValue.ToString() + button.Text;
                    }
                    
                    operation = button.Text;
                }
            }
            funcPressed = false;
            enterPressed = false;
            operationPressed = true;
            NewFont();
            maxChar = false;
            btn_enter.Focus();
        }

        /// <summary>
        /// Metóda btn_napoveda_Click, ktorá je volaná pri stlačení tlačidla nápoveda.
        /// Metóda otvorí súbor s nápovedou. Ekvivalent je stlačenie klávesi "f1".
        /// </summary>
        /// <param name="sender">Objekt, ktorý sa posiela do danej metódy</param>
        /// <param name="e">Dáta udalosti, ktoré sa posielajú do danej metódy</param>
        private void btn_napoveda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
            btn_enter.Focus();
        }
    }



}
