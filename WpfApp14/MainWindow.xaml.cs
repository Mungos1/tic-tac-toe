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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool playerstate = true;
        Button TicButton = new Button();
        WrapPanel Gameboard = new WrapPanel();
        



        public void CheckWinner ()
        {
            var btn = GameBoard.Children.Cast<Button>();
            foreach (Button TicButton in btn)
            {
                if (TicButton.Tag.Equals("0") && TicButton.Tag.Equals("1") && TicButton.Tag.Equals("2"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("3") && TicButton.Tag.Equals("4") && TicButton.Tag.Equals("5"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("6") && TicButton.Tag.Equals("7") && TicButton.Tag.Equals("8"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("0") && TicButton.Tag.Equals("3") && TicButton.Tag.Equals("6"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("1") && TicButton.Tag.Equals("4") && TicButton.Tag.Equals("7"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("2") && TicButton.Tag.Equals("5") && TicButton.Tag.Equals("8"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("0") && TicButton.Tag.Equals("4") && TicButton.Tag.Equals("8"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                if (TicButton.Tag.Equals("2") && TicButton.Tag.Equals("4") && TicButton.Tag.Equals("6"))
                { WinnerLbl.Content = "Congratulations, You win!"; }
                else { WinnerLbl.Content = ""; }
            }
        }
        public MainWindow()
        {
            InitializeComponent();


            string winner = String.Format ("");
            int buttonCounter = 0;
            for (int i=0; i<9; i++ )
            {
                Button TicButton = new Button ();
                TicButton.Background = new SolidColorBrush(Colors.White);
                TicButton.Tag = buttonCounter++;
                TicButton.Height = 100;
                TicButton.Width = 100;

                TicButton.Click += new RoutedEventHandler (ButtonClicked);

                GameBoard.Children.Add(TicButton);

                

            }
                  
            
            
        }

        public void ButtonClicked (Object sender, EventArgs e)
        {
            Button TicButton = (Button)sender;
            
            if (playerstate) {
                TicButton.Content = "X";
                playerstate = false;

                    
                    }
            
            else { TicButton.Content = "O";
                playerstate = true;
            }

            CheckWinner();
            var Buttons = GameBoard.Children.Cast<Button>();
        }
        
        

    }
}

