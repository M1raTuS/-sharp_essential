using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Presenter

namespace Lesson_12._4
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow main)
        {
            model = new Model();
            mainWindow = main;

            this.mainWindow.AddEvent += mainWindowAdd;
            this.mainWindow.SubEvent += mainWindowSub;
            this.mainWindow.MulEvent += mainWindowMul;
            this.mainWindow.DivEvent += mainWindowDiv;
        }

        private void mainWindowAdd(object sender, EventArgs e)
        {
            string variable = model.Add(Convert.ToInt32(mainWindow.Operand1_textBox.Text), 
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        
        private void mainWindowSub(object sender, EventArgs e)
        {
            string variable = model.Sub(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }

        private void mainWindowMul(object sender, EventArgs e)
        {
            string variable = model.Mul(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        private void mainWindowDiv(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
    }
}
