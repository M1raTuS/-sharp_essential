/* События

Используя Visual Studio, создайте проект по шаблону WPF Application.  
Создайте программу секундомер. Требуется выводить показания секундомера в окне. 
Окно имеет кнопки запуска, останова и сброса секундомера. Для реализации секундомера используйте паттерн MVP */

using System;
using System.Windows;

//View

namespace Lesson_12._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;

        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }
        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }
        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            stop.Invoke(sender, e);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            reset.Invoke(sender, e);
        }
    }
}
