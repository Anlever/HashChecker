using HashChecker.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HashChecker.Data
{
    internal class Design : IDesign
    {
        public void ButtonDesign(Button button)
        {
            // Настройки для кнопки
            button.BackColor = Color.DarkBlue;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.Size = new Size(150, 50);
        }

        public void RichTextBoxDesign(RichTextBox richTextBox)
        {
            // Настройки для RichTextBox
            richTextBox.BackColor = Color.Blue;
            richTextBox.ForeColor = Color.Red;
            richTextBox.Font = new Font("Arial", 12);
        }

        public void LabelDesign(Label label)
        {
            // Настройки для Label
            label.ForeColor = Color.Red;
            label.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        public void ComboBoxDesign(ComboBox comboBox)
        {
            // Настройки для ComboBox
            comboBox.BackColor = Color.LightGray;
            comboBox.ForeColor = Color.Black;
            comboBox.Font = new Font("Arial", 12);
        }

        public void ApplyDesignToAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button button)
                {
                    ButtonDesign(button);
                }
                else if (control is RichTextBox richTextBox)
                {
                    RichTextBoxDesign(richTextBox);
                }
                else if (control is Label label)
                {
                    LabelDesign(label);
                }
                else if (control is ComboBox comboBox)
                {
                    ComboBoxDesign(comboBox);
                }
            }
        }

    }
}
