using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PasswordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string password = "";
        private string chars = "abcdefghijklmnopqrstuvwxyz&é(§è!çà^$ùµABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            cbUpperCaseLetters.IsChecked = true;
            cbLowerCaseLetters.IsChecked = true;
            cbNumbers.IsChecked = true;
            cbSymbols.IsChecked = true;
            lblPassword.Content = RefreshPassword();
 
        }

        // change checkbox colors
        private void ChangeBackgroundcolor(CheckBox cb, string color)
        {
            BrushConverter bc = new BrushConverter();
            cb.Background = (Brush)bc.ConvertFrom(color);
        }
        // passwordLength
        private void slCharLength_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblCharLength.Content = e.NewValue.ToString("F0");
        }
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {

            lblPassword.Content = RefreshPassword();
        }
        private string RefreshPassword()
        {
            password = "";
            for (int i = 0; i < (int)slCharLength.Value; i++)
            {
                char cc = chars[random.Next(1, chars.Length)]; 
                if ((bool)cbUpperCaseLetters.IsChecked &&
               (bool)cbLowerCaseLetters.IsChecked &&
               (bool)cbNumbers.IsChecked &&
               (bool)cbSymbols.IsChecked)
                {

                    password += cc;
                }
                else if (!(bool)cbUpperCaseLetters.IsChecked &&
                    (bool)cbLowerCaseLetters.IsChecked &&
                    (bool)cbNumbers.IsChecked &&
                    (bool)cbSymbols.IsChecked)
                {
                    if(char.IsUpper(cc))
                    {
                        i--;
                       
                    } else
                    {
                        password += cc;
                    }
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                  !(bool)cbLowerCaseLetters.IsChecked &&
                  (bool)cbNumbers.IsChecked &&
                  (bool)cbSymbols.IsChecked)
                {
                    if (char.IsLower(cc))
                    {
                        i--;

                    }
                    else
                    {
                        password += cc;
                    }
               
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                         (bool)cbLowerCaseLetters.IsChecked &&
                         !(bool)cbNumbers.IsChecked &&
                         (bool)cbSymbols.IsChecked)
                {
                    if (char.IsNumber(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                         (bool)cbLowerCaseLetters.IsChecked &&
                         (bool)cbNumbers.IsChecked &&
                         !(bool)cbSymbols.IsChecked)
                {
                    if (char.IsSymbol(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if (!(bool)cbUpperCaseLetters.IsChecked &&
                         !(bool)cbLowerCaseLetters.IsChecked &&
                         (bool)cbNumbers.IsChecked &&
                         (bool)cbSymbols.IsChecked)
                {
                    if (char.IsUpper(cc) || char.IsLower(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if (!(bool)cbUpperCaseLetters.IsChecked &&
                         (bool)cbLowerCaseLetters.IsChecked &&
                         !(bool)cbNumbers.IsChecked &&
                         (bool)cbSymbols.IsChecked)
                {
                    if (char.IsUpper(cc) || char.IsNumber(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                         !(bool)cbLowerCaseLetters.IsChecked &&
                         !(bool)cbNumbers.IsChecked &&
                         (bool)cbSymbols.IsChecked)
                {
                    if (char.IsLower(cc) || char.IsNumber(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if (!(bool)cbUpperCaseLetters.IsChecked &&
                          (bool)cbLowerCaseLetters.IsChecked &&
                          (bool)cbNumbers.IsChecked &&
                         !(bool)cbSymbols.IsChecked)
                {
                    if (char.IsUpper(cc) || char.IsSymbol(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                        !(bool)cbLowerCaseLetters.IsChecked &&
                        (bool)cbNumbers.IsChecked &&
                        !(bool)cbSymbols.IsChecked)
                {
                    if (char.IsLower(cc) || char.IsSymbol(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                        (bool)cbLowerCaseLetters.IsChecked &&
                        !(bool)cbNumbers.IsChecked &&
                       !(bool)cbSymbols.IsChecked)
                {
                    if (char.IsNumber(cc) || char.IsSymbol(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if ((bool)cbUpperCaseLetters.IsChecked &&
                        !(bool)cbLowerCaseLetters.IsChecked &&
                        (bool)cbNumbers.IsChecked &&
                       !(bool)cbSymbols.IsChecked)
                {
                    if (char.IsLower(cc) || char.IsSymbol(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
                else if(!(bool)cbUpperCaseLetters.IsChecked &&
                     (bool)cbLowerCaseLetters.IsChecked &&
                     (bool)cbNumbers.IsChecked &&
                    !(bool)cbSymbols.IsChecked)
                {
                    if (char.IsUpper(cc) || char.IsSymbol(cc))
                    {
                        i--;
                    }
                    else
                    {
                        password += cc;
                    }
                }
            }
            lblPassword.Content = password;
            slCharLength.Value = password.Length;
            return password;
        }

        private void imgCopy_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Clipboard.SetText(lblPassword.Content.ToString());
            MessageBox.Show("Password saved to clipboard");
        }
    }
}
