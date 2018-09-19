using Caliburn.Micro;
using NumericTextBox.ViewModels;

namespace NumericTextBox
{
    public class ShellViewModel : Screen, IShell
    {
        #region Constructor
        public ShellViewModel()
        {
            NumericTextBoxVM = new NumericTextBoxViewModel(0.0011);
        }
        #endregion

        #region Properties
        /// <summary>
        /// NumericTextBoxVM
        /// </summary>
        public NumericTextBoxViewModel NumericTextBoxVM { get; }
        #endregion
    }
}