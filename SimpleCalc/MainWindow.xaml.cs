using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Data;

namespace SimpleCalc
{

    public partial class MainWindow : Window
    {
        char Sign;
        bool SignFlag = true;


        void SetSign()
        {

            switch (Sign)
            {
                case '+':
                    if (SignFlag)
                    {
                        TxtCurent.Text += "+";
                        SignFlag = false;
                    }
                    break;


                case '-':
                    if (SignFlag)
                    {
                        TxtCurent.Text += "-";
                        SignFlag = false;
                    }
                    break;


                case '*':
                    if (SignFlag)
                    {
                        TxtCurent.Text += "*";
                        SignFlag = false;
                    }
                    break;


                case '/':
                    if (SignFlag)
                    {
                        TxtCurent.Text += "/";
                        SignFlag = false;
                    }
                    break;
            }
        }

        string Score(string operation)
        {
            TryAgain:
            try
            {
                DataTable Resoult = new DataTable();
                var x = Resoult.Compute(operation, "");
                return Convert.ToString(x);
            }
            catch (SyntaxErrorException)
            {
                var TestText = operation;
                var TestText2 = new StringBuilder(TestText);
                TestText2.Remove(TestText2.Length - 1, 1);
                operation = TestText2.ToString();
                goto TryAgain;
            }
        }

        string Delete(string CurentText)
        {
            try
            {
                var Text = new StringBuilder(CurentText);
                Text.Remove(Text.Length - 1, 1);
                return Text.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0.ToString();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "1";
            SignFlag = true;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "2";
            SignFlag = true;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "3";
            SignFlag = true;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "4";
            SignFlag = true;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "5";
            SignFlag = true;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "6";
            SignFlag = true;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "7";
            SignFlag = true;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "8";
            SignFlag = true;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "9";
            SignFlag = true;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "0";
            SignFlag = true;
        }

        private void BtnPoint_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += ".";
        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            Sign = '+';
            SetSign();
        }

        private void BtnSubstraction_Click(object sender, RoutedEventArgs e)
        {
            Sign = '-';
            SetSign();
        }

        private void BtnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            Sign = '*';
            SetSign();
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            Sign = '/';
            SetSign();
        }

        private void BtnScore_Click(object sender, RoutedEventArgs e)
        {
            TxtScore.Text = Score(TxtCurent.Text);
            TxtCurent.Text = "";

        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text = "";
            TxtScore.Text = "";
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text = Delete(TxtCurent.Text);
        }

        private void BtnBracketOpen_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += "(";
        }

        private void BtnBracketClose_Click(object sender, RoutedEventArgs e)
        {
            TxtCurent.Text += ")";
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1)
            {
                TxtCurent.Text += "1";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad2)
            {
                TxtCurent.Text += "2";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad3)
            {
                TxtCurent.Text += "3";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad4)
            {
                TxtCurent.Text += "4";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad5)
            {
                TxtCurent.Text += "5";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad6)
            {
                TxtCurent.Text += "6";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad7)
            {
                TxtCurent.Text += "7";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad8)
            {
                TxtCurent.Text += "8";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad9)
            {
                TxtCurent.Text += "9";
                SignFlag = true;
            }
            if (e.Key == Key.NumPad0)
            {
                TxtCurent.Text += "0";
                SignFlag = true;
            }
            if (e.Key == Key.Decimal)
            {
                TxtCurent.Text += ",";
                SignFlag = true;
            }
            if (e.Key == Key.Add)
            {
                Sign = '+';
                SetSign();
            }
            if (e.Key == Key.Subtract)
            {
                Sign = '-';
                SetSign();
            }
            if (e.Key == Key.Multiply)
            {
                Sign = '*';
                SetSign();
            }
            if (e.Key == Key.Divide)
            {
                Sign = '/';
                SetSign();
            }
            if (e.Key == Key.D9)
            {
                TxtCurent.Text += "(";
                SignFlag = true;
            }
            if (e.Key == Key.D0)
            {
                TxtCurent.Text += ")";
                SignFlag = true;
            }
            if (e.Key == Key.Enter)
            {
                TxtScore.Text = Score(TxtCurent.Text);
                TxtCurent.Text = "";
            }
            if (e.Key == Key.Delete)
            {
                TxtCurent.Text = "";
                TxtScore.Text = "";
            }
            if (e.Key == Key.Back)
            {
                TxtCurent.Text = Delete(TxtCurent.Text);
                SignFlag = true;
            }
        }
    }
}
