using System.Windows.Forms;

namespace HashChecker.Interface
{
    internal interface IDesign
    {
        void ButtonDesign(Button button);
        void RichTextBoxDesign(RichTextBox richTextBox);
        void LabelDesign(Label label);
        void ComboBoxDesign(ComboBox comboBox);
        void ApplyDesignToAllControls(Control control);
    }
}
