using System.Windows.Forms;

namespace HashChecker.Interface
{
    internal interface IDesign
    {
        void ButtonDesign(Button button);
        void RichTextBoxDesign(RichTextBox richTextBox);
        void LabelDesign(Label label);
        void TabPageDesign(TabPage tabpage);
        void ComboBoxDesign(ComboBox comboBox);
        void TabControlDesign(TabControl tabcontrol);
        void ApplyDesignToAllControls(Control control);
    }
}
