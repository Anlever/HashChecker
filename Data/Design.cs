using HashChecker.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HashChecker.Data
{
    public static class ControlExtensionMethods
    {
        public static IEnumerable<Control> GetOffsprings(this Control @this)
        {
            foreach (Control child in @this.Controls)
            {
                yield return child;
                foreach (var offspring in GetOffsprings(child))
                    yield return offspring;
            }
        }
    }
    public static class MenuStripExtensionMethods
    {
        public static IEnumerable<ToolStripItem> GetSubItems(this ToolStrip @this)
        {
            foreach (ToolStripItem child in @this.Items)
            {
                yield return child;
                foreach (var offspring in child.GetSubItems())
                    yield return offspring;
            }
        }

        public static IEnumerable<ToolStripItem> GetSubItems(this ToolStripItem @this)
        {
            if (!(@this is ToolStripDropDownItem))
                yield break;

            foreach (ToolStripItem child in ((ToolStripDropDownItem)@this).DropDownItems)
            {
                yield return child;
                foreach (var offspring in child.GetSubItems())
                    yield return offspring;
            }
        }
    }

    internal class Design : IDesign
    {

        public void ButtonDesign(Button button)
        {
            // Настройки для кнопки

        }

        public void RichTextBoxDesign(RichTextBox richTextBox)
        {
            // Настройки для RichTextBox

        }

        public void LabelDesign(Label label)
        {
            // Настройки для Label

        }

        public void ComboBoxDesign(ComboBox comboBox)
        {
            // Настройки для ComboBox

        }
        public void TabPageDesign(TabPage tabpage)
        {
            
        }
        public void TabControlDesign(TabControl tabcontrol)
        {
            
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
                else if (control is TabPage tabPage)
                {
                    TabPageDesign(tabPage);
                }
                else if (control is TabControl tabcontrol)
                {
                    TabControlDesign(tabcontrol);
                }
            }
        }


    }
}
