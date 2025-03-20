using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml.Permissions;

namespace WpfMath4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaskNumberTextBox.Text, out int z))
            {
                switch (z)
                {
                    case 1:
                        double x = 3.5;
                        double b = 0.4;

                        Number1 number1 = new Number1(x, b);
                        ResultTextBlock.Text = number1.DisplayResults();
                        break;
                    case 2:
                        double x2 = 1.3;
                        double k = 4;

                        Number2 number2 = new Number2(x2, k);
                        ResultTextBlock.Text = number2.DisplayResults();
                        break;
                    case 3:
                        double x3 = 2.1;
                        double p = 1;

                        Number3 number3 = new Number3(x3, p);
                        ResultTextBlock.Text = number3.DisplayResults();
                        break;
                    case 4:
                        double x4 = 2.7;
                        double t = -6;

                        Number4 number4 = new Number4(x4, t);
                        ResultTextBlock.Text = number4.DisplayResults();
                        break;
                    case 5:
                        double t5 = 4.1;
                        double p5 = 3;

                        Number5 number5 = new Number5(t5, p5);
                        ResultTextBlock.Text = number5.DisplayResults();
                        break;
                    case 6:
                        double m = 2;
                        double x6 = 1.1;

                        Number6 number6 = new Number6(m, x6);
                        ResultTextBlock.Text = number6.DisplayResults();
                        break;
                    case 7:
                        double k7 = 8.2;
                        double x7 = 5;

                        Number7 number7 = new Number7(k7, x7);
                        ResultTextBlock.Text = number7.DisplayResults();
                        break;
                    case 8:
                        double b8 = 2.2;
                        double c8 = 3.7;

                        Number8 number8 = new Number8(b8, c8);
                        ResultTextBlock.Text = number8.DisplayResults();
                        break;
                    case 9:
                        double k9 = 1;
                        double m9 = 1.8;

                        Number9 number9 = new Number9(k9, m9);
                        ResultTextBlock.Text = number9.DisplayResult();
                        break;
                    case 10:
                        double x10 = 2.8;
                        double b10 = 1.3;

                        Number10 number10 = new Number10(x10, b10);
                        ResultTextBlock.Text = number10.DisplayResult();
                        break;
                    case 11:
                        double x11 = 2;
                        double b11 = 7;

                        Number11 number11 = new Number11(x11, b11);
                        ResultTextBlock.Text = number11.DisplayResult();
                        break;
                    case 12:
                        double q12 = 2;
                        double b12 = 1.8;

                        Number12 number12 = new Number12(q12, b12);
                        ResultTextBlock.Text = number12.DisplayResult();
                        break;
                    case 13:
                        double x13 = 1.9;
                        double a13 = -0.9;

                        Number13 number13 = new Number13(x13, a13);
                        ResultTextBlock.Text = number13.DisplayResult();
                        break;
                    case 14:
                        double b14 = 6;
                        double k14 = 3.4;

                        Number14 number14 = new Number14(b14, k14); 
                        ResultTextBlock.Text = number14.DisplayResult();
                        break;
                    case 15:
                        double a15 = 5.5;
                        double p15 = 4;

                        Number15 number15 = new Number15(a15, p15);
                        ResultTextBlock.Text = number15.DisplayResult();
                        break;
                    case 16:
                        double x16 = 8.52;
                        double c16 = 9;

                        Number16 number16 = new Number16(x16, c16);
                        ResultTextBlock.Text = number16.DisplayResult();
                        break;
                    case 17:
                        double x17 = 0.9;
                        double t17 = 2;

                        Number17 number17 = new Number17(x17, t17);
                        ResultTextBlock.Text = number17.DisplayResult();
                        break;
                    case 18:
                        double x18 = 8;
                        double b18 = 9.5;

                        Number18 number18 = new Number18(x18, b18);
                        ResultTextBlock.Text = number18.DisplayResult();
                        break;
                    case 19:
                        double x19 = 4;
                        double a19 = 3.7;

                        Number19 number19 = new Number19(x19, a19);
                        ResultTextBlock.Text = number19.DisplayResult();
                        break;
                    case 20:
                        double x20 = 1.4;
                        double p20 = 1.6;

                        Number20 number20 = new Number20(x20, p20);
                        ResultTextBlock.Text = number20.DisplayResult();
                        break;
                    case 21:
                        double n21 = 8.1;
                        double b21 = 1.6;

                        Number21 number21 = new Number21(n21, b21);
                        ResultTextBlock.Text = number21.DisplayResult();
                        break;
                    case 22:
                        double m22 = 5.7;
                        double p22 = 4;

                        Number22 number22 = new Number22(m22, p22);
                        ResultTextBlock.Text = number22.DisplayResult();
                        break;
                    case 23:
                        double b23 = 0.3;
                        double x23 = 5.2;

                        Number23 number23 = new Number23(b23, x23);
                        ResultTextBlock.Text = number23.DisplayResult();
                        break;
                    case 24:
                        double t24 = 6.2;
                        double b24 = 1.8;

                        Number24 number24 = new Number24(t24, b24);
                        ResultTextBlock.Text = number24.DisplayResult();
                        break;
                    case 25:
                        double a25 = 2;
                        double p25 = 2.6;

                        Number25 number25 = new Number25(a25, p25);
                        ResultTextBlock.Text = number25.DisplayResult();
                        break;
                    case 26:
                        double b26 = 8.1;
                        double t26 = 2;

                        Number26 number26 = new Number26(b26, t26);
                        ResultTextBlock.Text = number26.DisplayResult();
                        break;
                    case 27:
                        double t27 = -3;
                        double a27 = 76;

                        Number27 number27 = new Number27(t27, a27);
                        ResultTextBlock.Text = number27.DisplayResult();
                        break;
                    case 28:
                        double b28 = 2.19;
                        double k28 = 1.7;

                        Number28 number28 = new Number28(k28, b28);
                        ResultTextBlock.Text = number28.DisplayResult();
                        break;
                    case 29:
                        double a29 = 6;
                        double b29 = 4.3;

                        Number29 number29 = new Number29(a29, b29);
                        ResultTextBlock.Text = number29.DisplayResult();
                        break;
                    case 30:
                        double t30 = 3;
                        double b30 = 4.2;

                        Number30 number30 = new Number30(t30, b30);
                        ResultTextBlock.Text = number30.DisplayResult();
                        break;
                    default:
                        ResultTextBlock.Text = "Неверный номер задания.";
                        break;
                }
            }
            else
            {
                ResultTextBlock.Text = "Введите корректный номер задания.";
            }
        }
    }
public class Number1
    {
        private double _x;
        private double _b;

        public Number1(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double CalculateA()
        {
            return Math.Log10(_x);
        }

        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(_b * _x);
        }

        public double CalculateY()
        {
            double c = CalculateC();
            return Math.Exp(2 * _x) + 9.7 * c;
        }

        public string DisplayResults()
        {
            double a = CalculateA();
            double c = CalculateC();
            double y = CalculateY();

            return $"a = {a}\nc = {c}\ny = {y}";
        }
    }
    public class Number2
    {
        private double _x;
        private double _k;

        public Number2(double x, double k)
        {
            _x = x;
            _k = k;
        }

        public double CalculateA()
        {
            return Math.Log(Math.Abs(_x));
        }

        public double CalculateB()
        {
            double a = CalculateA();
            return Math.Exp(2 * _x) + a * _x;
        }

        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return _x * Math.Pow(a, 3) + Math.Pow(b, 2);
        }

        public string DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            return $"a = {a}\nb = {b}\ny = {y}";
        }
    }
    public class Number3
    {
        private double _x;
        private double _p;

        public Number3(double x, double p)
        {
            _x = x;
            _p = p;
        }

        public double CalculateA()
        {
            return Math.Pow(Math.E, Math.Sqrt(Math.Abs(_x)));
        }

        public double CalculateB()
        {
            return Math.Sin(Math.Pow(_p, 2)) + Math.Pow(_x, 3);
        }

        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(a, 3) / Math.Pow(b, 2);
        }

        public string DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            return $"a = {a}\nb = {b}\ny = {y}";
        }
    }
    public class Number4
    {
        private double _x;
        private double _t;

        public Number4(double x, double t)
        {
            _x = x;
            _t = t;
        }
        public double CalculateA()
        {
            return Math.Log10(_x);
        }
        public double CalculateB()
        {
            return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_t, 2));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Sqrt(Math.Abs(a - b * _x)), 5);
        }
        public string DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            return $"a = {a}\nb = {b}\ny = {y}";
        }
    }
    public class Number5
    {
        private double _t;
        private double _p;

        public Number5(double t, double p)
        {
            _t = t;
            _p = p;
        }
        public double CalculateK()
        {
            return Math.Sqrt(_p * _t);
        }
        public double CalculateX()
        {
            double k = CalculateK();
            return _p * Math.Pow(_t, 2) + Math.Sqrt(k);
        }
        public double CalculateY()
        {
            double k = CalculateK();
            double x = CalculateX();
            return Math.Pow(Math.Tan(Math.Pow(x, 2)), 3) + k * _t;
        }
        public string DisplayResults()
        {
            double k = CalculateK();
            double x = CalculateX();
            double y = CalculateY();

            return $"k = {k}\nx = {x}\ny = {y}";
        }
    }
    public class Number6
    {
        private double _m;
        private double _x;

        public Number6(double m, double x)
        {
            _m = m;
            _x = x;
        }
        public double CalculateA()
        {
            return Math.Sqrt(Math.Abs(_x));
        }
        public double CalculateB()
        {
            return Math.Pow(_x, 4) + Math.Pow(_m, 2);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);
        }
        public string DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            return $"a = {a}\nb = {b}\ny = {y}";
        }
    }
    public class Number7
    {
        private double _k;
        private double _x;

        public Number7(double k, double x)
        {
            _k = k;
            _x = x;
        }
        public double CalculateC()
        {
            return Math.Sqrt(Math.Abs(_x));
        }
        public double CalculateA()
        {
            double c = CalculateC();
            return Math.Pow(c, 4) + Math.Pow(_k, 3);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Pow(Math.Log(a), 3) + Math.Pow(Math.Cos(_x), 5);
        }
        public string DisplayResults()
        {
            double c = CalculateC();
            double a = CalculateA();
            double y = CalculateY();

            return $"c = {c}\na = {a}\ny = {y}";
        }
    }
    public class Number8
    {
        private double _b;
        private double _c;

        public Number8(double b, double c)
        {
            _b = b;
            _c = c;
        }
        public double CalculateA()
        {
            return Math.Sin(_b);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return a + Math.Pow((_b + _c), 3);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double x = CalculateX();
            return 7 * Math.Pow(Math.E, Math.Sqrt(Math.Abs(x))) + Math.Pow(Math.Cos(x), 4);
        }
        public string DisplayResults()
        {
            double a = CalculateA();
            double x = CalculateX();
            double y = CalculateY();

            return $"a = {a}\nx = {x}\ny = {y}";
        }
    }
    public class Number9
    {
        private double _k;
        private double _m;

        public Number9(double k, double m)
        {
            _k = k;
            _m = m;
        }
        public double CalculateX()
        {
            return Math.Pow(Math.E, _m + _k);
        }
        public double CalculateC()
        {
            return Math.Pow(Math.Cos(_m), 2) + Math.Pow(_k, 2);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double c = CalculateC();
            return Math.Pow(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(c, 2)), 3);
        }
        public string DisplayResult()
        {
            double x = CalculateX();
            double c = CalculateC();
            double y = CalculateY();

            return $"x = {x}\nc = {c}\ny = {y}";
        }
    }
    public class Number10
    {
        private double _x;
        private double _b;

        public Number10(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateA()
        {
            return Math.Pow(_b, 3) + Math.Log(Math.Abs(_b));
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(_b);
        }
        public double CalculateY()
        {
            double c = CalculateC();
            return Math.Pow(Math.E, _x) + Math.Pow(5.8, c);
        }
        public string DisplayResult()
        {
            double a = CalculateA();
            double c = CalculateC();
            double y = CalculateY();

            return $"a = {a}\nc = {c}\ny = {y}";
        }
    }
    public class Number11
    {
        private double _b;
        private double _x;

        public Number11(double b, double x)
        {
            _b = b;
            _x = x;
        }
        public double CalculateY()
        {
            double c = CalculateC();
            double a = CalculateA();
            return Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
        }
        public double CalculateC()
        {
            return Math.Log(Math.Abs(_b));
        }
        public double CalculateA()
        {
            return Math.Pow((_b + _x), 3);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double c = CalculateC();
            double a = CalculateA();

            return $"y = {y}\nc = {c}\na = {a}";
        }
    }
    public class Number12
    {
        private double _q;
        private double _b;

        public Number12(double q, double b)
        {
            _q = q;
            _b = b;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Pow(Math.Atan(Math.Abs(x)), 2);
        }
        public double CalculateX()
        {
            double t = CalculateT();
            return Math.Pow(t, 3) + Math.Pow(_b, 2);
        }
        public double CalculateT()
        {
            return Math.Pow(_b, 3) + Math.Pow(Math.E, Math.Sqrt(_q));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double t = CalculateT();

            return $"y = {y}\nx = {x}\nt = {t}";
        }
    }
    public class Number13
    {
        private double _x;
        private double _a;

        public Number13(double x, double a)
        {
            _x = x;
            _a = a;
        }
        public double CalculateY()
        {
            double z = CalculateZ();    
            double w = CalculateW();
            return _a * Math.Pow(z, 7) + Math.Pow(Math.Sin(w), 2);
        }
        public double CalculateZ()
        {
            double w = CalculateW();
            return Math.Pow(Math.Cos(_a), 2) + Math.Pow(w, 2);
        }
        public double CalculateW()
        {
            return Math.Pow(_x, 2) * Math.Sqrt(Math.Abs(_a + _x));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double z = CalculateZ();
            double w = CalculateW();

            return $"y = {y}\nz = {z}\nw = {w}";
        }
    }
    public class Number14
    {
        private double _b;
        private double _k;

        public Number14(double b, double k)
        {
            _b = b;
            _k = k;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(_b, 2)), 4);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return Math.Sqrt(_b + t);
        }
        public double CalculateT()
        {
            return Math.Pow(_b, 2) + Math.Pow(_k, 2);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double t = CalculateT();

            return $"y = {y}\na = {a}\nt = {t}";
        }
    }
    public class Number15
    {
        private double _a;
        private double _p;

        public Number15(double a, double p)
        {
            _a = a;
            _p = p;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Pow(Math.Cos(x), 3) + Math.Abs(_a);
        }
        public double CalculateX()
        {
            double b = CalculateB();
            return Math.Pow(Math.E, b);
        }
        public double CalculateB()
        {
            return Math.Abs(_a) + Math.Sqrt(_a + Math.Pow(_p, 2));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double b = CalculateB();

            return $"y = {y}\nx = {x}\nb = {b}";
        }
    }
    public class Number16
    {
        private double _x;
        private double _c;

        public Number16(double x, double c)
        {
            _x = x;
            _c = c;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)), 4);
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return Math.Pow(Math.Sqrt(b + _c), 3);
        }
        public double CalculateB()
        {
            return _x + Math.Pow(_c, 2);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double b = CalculateB();

            return $"y = {y}\na = {a}\nb = {b}";
        }
    }
    public class Number17
    {
        private double _x;
        private double _t;

        public Number17(double x, double t)
        {
            _x= x;
            _t = t;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3);
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return _t * _x + Math.Abs(Math.Sqrt(b));
        }
        public double CalculateB()
        {
            return Math.Pow(Math.Log(Math.Abs(_x)), 2);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double b = CalculateB();

            return $"y = {y}\na = {a}\nb = {b}";
        }
    }
    public class Number18
    {
        private double _x;
        private double _b;

        public Number18(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double c = CalculateC();
            return Math.Pow(a, 3) / Math.Cos(c);
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Log(a) + Math.Pow(_b, 2);
        }
        public double CalculateA()
        {
            return Math.Sqrt(Math.Abs(_x)) + Math.Pow(Math.E, _b);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double c = CalculateC();
            double a = CalculateA();

            return $"y = {y}\nc = {c}\na = {a}";
        }
    }
    public class Number19
    {
        private double _x;
        private double _a;

        public Number19(double x, double a)
        {
            _x = x;
            _a = a;
        }
        public double CalculateY()
        {
            double p = CalculateP();
            double t = CalculateT();
            return _x * Math.Pow(p, 2) + Math.Pow(t, 5);
        }
        public double CalculateP()
        {
            return Math.Pow(_x, 2) - Math.Sqrt(Math.Abs(_x));
        }
        public double CalculateT()
        {
            return Math.Pow(_x, 2) + Math.Pow(_a, 2);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double p = CalculateP();
            double t = CalculateT();

            return $"y = {y}\np = {p}\nt = {t}";
        }
    }
    public class Number20
    {
        private double _x;
        private double _p;

        public Number20(double x, double p)
        {
            _x = x;
            _p = p;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Sin(a), 3) * _x + Math.Sqrt(b) * Math.Cos(Math.Pow(_x, 2));
        }
        public double CalculateA()
        {
            return Math.Log(Math.Abs(_x));
        }
        public double CalculateB()
        {
            return Math.Pow(_x, 4) + Math.Log(Math.Pow(_p, 3));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double b = CalculateB();

            return $"y = {y}\na = {a}\nb = {b}";
        }
    }
    public class Number21
    {
        private double _n;
        private double _b;

        public Number21(double n, double b)
        {
            _n = n;
            _b = b;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Log(a) / Math.Log(Math.Pow(_b, 3));
        }
        public double CalculateA()
        {
            double x = CalculateX();
            return Math.Sin(Math.Pow(x, 2) + Math.Pow(_b, 2));
        }
        public double CalculateX()
        {
            return Math.Pow(_n, _b) + Math.Pow(_b, 2);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double x = CalculateX();

            return $"y = {y}\na = {a}\nx = {x}";
        }
    }
    public class Number22
    {
        private double _m;
        private double _p;

        public Number22(double m, double p)
        {
            _m = m;
            _p = p;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double t = CalculateT();
            return Math.Pow(Math.Log(Math.Abs(x + t)), 4);
        }
        public double CalculateX()
        {
            double t = CalculateT();
            return Math.Pow(_p, 2) + t;
        }
        public double CalculateT()
        {
            return Math.Sin(Math.Pow(_m, 3));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double t = CalculateT();

            return $"y = {y}\nx = {x}\nt = {t}";
        }
    }
    public class Number23
    {
        private double _b;
        private double _x;

        public Number23(double b, double x)
        {
            _b = b;
            _x = x;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double t = CalculateT();
            return Math.Pow(Math.Log(1), a + _b) + Math.Pow(a, 2) / a + t;
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return Math.Log(Math.Abs(t * _x + Math.Pow(_b, 2)));
        }
        public double CalculateT()
        {
            return _x * Math.Pow(_b, 2) + Math.Sqrt(_x);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double t = CalculateT();

            return $"y = {y}\na = {a}\nt = {t}";
        }
    }
    public class Number24
    {
        private double _t;
        private double _b;

        public Number24(double t, double b)
        {
            _t = t;
            _b = b;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Cos(Math.Pow(x, 5)) - _b * Math.Pow(Math.Sin(x), 2);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(a, 3) + Math.Sqrt(_t + _b);
        }
        public double CalculateA()
        {
            return Math.Pow(_t, 2) * _b;
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double a = CalculateA();

            return $"y = {y}\nx = {x}\na = {a}";
        }
    }
    public class Number25
    {
        private double _a;
        private double _p;

        public Number25(double a, double p)
        {
            _a = a; 
            _p = p;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double t = CalculateT();
            return Math.Pow(x, 3) / Math.Pow(t, 2);
        }
        public double CalculateX()
        {
            return Math.Pow(Math.E, Math.Sqrt(_p + _a));
        }
        public double CalculateT()
        {
            return Math.Pow(_p, 3) + Math.Pow(_a, 3);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double t = CalculateT();

            return $"y = {y}\nx = {x}\nt = {t}";
        }
    }
    public class Number26
    {
        private double _b;
        private double _t;

        public Number26(double b, double t)
        {
            _b = b;
            _t = t;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Pow(x, 2) + Math.Pow(Math.Sqrt(Math.Abs(x)), 3);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(Math.Cos(_b), 2) + Math.Pow(Math.Sin(a), 2);
        }
        public double CalculateA()
        {
            return Math.Sqrt(_b + Math.Pow(_t, 2));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double a = CalculateA();

            return $"y = {y}\nx = {x}\na = {a}";
        }
    }
    public class Number27
    {
        private double _t;
        private double _a;

        public Number27(double t, double a)
        {
            _t = t;
            _a = a;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Tan(4 * x) + Math.Sin(Math.Pow(x, 2));
        }
        public double CalculateX()
        {
            double c = CalculateC();
            return Math.Log(Math.Abs(c * _t)) + Math.Pow(_a, 2);
        }
        public double CalculateC()
        {
            return Math.Pow(_t, 2) + Math.Sqrt(_a);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double c = CalculateC();

            return $"y = {y}\nx = {x}\nc = {c}";
        }
    }
    public class Number28
    {
        private double _b;
        private double _k;

        public Number28(double b, double k)
        {
            _b = b;
            _k = k;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Pow(Math.Cos(Math.Pow(a, 3) + _b), 4);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return _b + Math.Pow(t, 2) * Math.Pow(Math.E, t);
        }
        public double CalculateT()
        {
            return Math.Pow(_k, 2) + Math.Sqrt(_b);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double a = CalculateA();
            double t = CalculateT();

            return $"y = {y}\na = {a}\nt = {t}";
        }
    }
    public class Number29
    {
        private double _a;
        private double _b;

        public Number29(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public double CalculateY()
        {
            double p = CalculateP();
            double x = CalculateX();
            return Math.Pow(Math.Log(p), 3) + x;
        }
        public double CalculateX()
        {
            return Math.Pow(Math.E, 2 * _a) + Math.Sqrt(_b);
        }
        public double CalculateP()
        {
            double x = CalculateX();
            return x * (_a + Math.Pow(_b, 3));
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double p = CalculateP();

            return $"y = {y}\nx = {x}\np = {p}";
        }
    }
    public class Number30
    {
        private double _b;
        private double _t;

        public Number30(double b, double t)
        {
            _b = b;
            _t = t;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double a = CalculateA();
            return Math.Pow(Math.Log(Math.Abs(x + Math.Pow(a, 2))), 5);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(_t, 2) * Math.Sqrt(Math.Abs(a + _b));
        }
        public double CalculateA()
        {
            return _t + Math.Pow(_b, 3);
        }
        public string DisplayResult()
        {
            double y = CalculateY();
            double x = CalculateX();
            double a = CalculateA();

            return $"y = {y}\nx = {x}\na = {a}";
        }
    }
}