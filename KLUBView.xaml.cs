using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KLUB
{
    /// <summary>
    /// Логика взаимодействия для KLUBView.xaml
    /// </summary>
    public partial class KLUBView : Window
    {
        private string _commandLine;
        private int? _commandNum;
        private string _commandMode;
        private bool _dt;
        private bool _color;

        public KLUBView()
        {
            InitializeComponent();
            DispatcherTimer dtClockTime = new DispatcherTimer {Interval = new TimeSpan(0, 0, 1)};
            dtClockTime.Tick += dtClockTime_Tick;
            dtClockTime.Start();
        }

        private void dtClockTime_Tick(object sender, EventArgs e)
        {
            TimeBox.Text = DateTime.Now.ToLongTimeString();
            if (_dt)
                if (_color)
                {
                    P.Foreground = Brushes.LimeGreen;
                    _color = false;
                }
                else
                {
                    P.Foreground = Brushes.White;
                    _color = true;
                }
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10;
            if (_commandLine.Equals(""))
            {
                _commandLine = "0";
            }

            if (!(_commandNum > 0)) return;
            _commandLine = _commandLine + "0";
            CommandString.Text = CommandString.Text + "0";

        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 1;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "1";
            CommandString.Text = CommandString.Text + "1";
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 2;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "2";
            CommandString.Text = CommandString.Text + "2";
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 3;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "3";
            CommandString.Text = CommandString.Text + "3";
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 4;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "4";
            CommandString.Text = CommandString.Text + "4";
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 5;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "5";
            CommandString.Text = CommandString.Text + "5";
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 6;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "6";
            CommandString.Text = CommandString.Text + "6";
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 7;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "7";
            CommandString.Text = CommandString.Text + "7";
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 8;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "8";
            CommandString.Text = CommandString.Text + "8";
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = _commandNum * 10 + 9;
            if (_commandLine.Equals("")) return;
            _commandLine = _commandLine + "9";
            CommandString.Text = CommandString.Text + "9";
        }

        private void Button_P_Click(object sender, RoutedEventArgs e)
        {
            _commandLine = "p";
            CommandString.Text = "НОМЕР ПУТИ    ";
        }

        private void Button_L_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_I_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_K_Click(object sender, RoutedEventArgs e)
        {
            CommandString.Text = "ВВЕДИТЕ КОММАНДУ  ";
            _commandLine = "k";
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            //int? temp = _commandNum;
            _commandNum++;
            //if (!_commandLine.Equals("")) _commandLine = _commandLine.Remove(1) + _commandNum.ToString();
            //CommandString.Text = CommandString.Text.Remove(temp.ToString().Length) + _commandNum.ToString();
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            if (_commandNum > 0)
            {
                //int? temp = _commandNum;
                _commandNum--;
                //if (!_commandLine.Equals("")) _commandLine = _commandLine.Remove(1) + _commandNum.ToString();
                //CommandString.Text = CommandString.Text.Remove(temp.ToString().Length) + _commandNum.ToString();
            }
        }

        private void Button_toZero_Click(object sender, RoutedEventArgs e)
        {
            _commandNum = 0;
        }

        private void Button_up_Click(object sender, RoutedEventArgs e)
        {
            if (_commandLine.StartsWith("p"))
            {
                if (_commandLine.Equals("p") || _commandLine.Equals("p0"))
                    KlubModel.PathNum = "НЕОП";
                else
                {
                    _commandMode = "put";
                    CommandString.Text = "ПРАВИЛЬНОСТЬ 1-ПР/0-НР  ";
                    KlubModel.PathNum = _commandLine.Substring(1);

                    _commandLine = " ";
                    _commandNum = null;
                }
            } else if (_commandLine.StartsWith("k"))
            {
                _commandLine = "";
                _commandNum = null;
            } else if (_commandMode == "put")
            {
                if (_commandLine.Substring(_commandLine.Length-1) == "1")
                    KlubModel.PathNum = KlubModel.PathNum + "ПР";
                else
                    KlubModel.PathNum = KlubModel.PathNum + "НР";

                PathBox.Text = KlubModel.PathNum;
                CommandString.Text = "";

                _commandLine = "";
                _commandNum = null;
            }

            
        }

        private void Button_down_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_F_Click(object sender, RoutedEventArgs e)
        {
            switch (KlubModel.ALSN)
            {
                case 25:
                    KlubModel.ALSN = 50;
                    ALSBox.Text = "50";
                    break;
                case 50:
                    KlubModel.ALSN = 75;
                    ALSBox.Text = "75";
                    break;
                case 75:
                    KlubModel.ALSN = 25;
                    ALSBox.Text = "25";
                    break;
                default:
                    KlubModel.ALSN = 25;
                    ALSBox.Text = "25";
                    break;
            }
        }

        private void Button_BK_Click(object sender, RoutedEventArgs e)
        {

        }
    
        
        private void Button_RMP_Click(object sender, RoutedEventArgs e)
        {
            switch (KlubModel.RMPMode)
            {
                case "M":
                    KlubModel.RMPMode = "DT";
                    M.Foreground = Brushes.White;
                    _dt = true;
                    break;
                case "DT":
                    _dt = false;
                    KlubModel.RMPMode = "P";
                    P.Foreground = Brushes.LimeGreen;
                    break;
                default:
                    KlubModel.RMPMode = "M";
                    M.Foreground = Brushes.LimeGreen;
                    P.Foreground = Brushes.White;
                    break;

            }
        }

        private void Button_podtag_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_otpr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_OC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_k20_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
