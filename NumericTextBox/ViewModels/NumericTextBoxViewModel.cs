using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NumericTextBox.ViewModels 
{
    /// <summary>
    /// NumericBox ViewModel
    /// </summary>
    public class NumericTextBoxViewModel: PropertyChangedBase
    {
        #region Privates
        private double _value;
        private string _textValue;
        private string previousTextValue;
        #endregion

        #region Constructor
        /// <summary>
        /// NumericBox ViewModel
        /// </summary>
        public NumericTextBoxViewModel(double initialValue, int postDecDigits = 3)
        {
            PostDecDigits = postDecDigits;
            Value = Math.Round(initialValue, postDecDigits);
            TextValue = Value.ToString();
        }


        #endregion

        #region Proerties
        /// <summary>
        /// PostDecDigits
        /// </summary>
        public int PostDecDigits { get; set; }

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyOfPropertyChange(() => Value);
            }
        }
        
        /// <summary>
        /// TextValue
        /// </summary>
        public string TextValue
        {
            get { return _textValue; }
            set
            {
                _textValue = value;
                NotifyOfPropertyChange(() => TextValue);
            }
        }
        #endregion

        #region Methods
        public void HandleKeyDown(KeyEventArgs e)
        {
            Debug.WriteLine(TextValue);
            previousTextValue = TextValue;
        }

        public void VerifyKey(KeyEventArgs e)
        {
            Debug.WriteLine(TextValue);
            //var kea = (KeyEventArgs)e;
            var key = e.Key;
            if (!IsDigit(e.Key))
            {
                TextValue = previousTextValue;
            }
            Debug.WriteLine($"");
        }

        public void Cancel()
        {
            TextValue = Math.Round(Value, PostDecDigits).ToString();
        }

        bool IsDigit(Key keyCode)
        {
            bool retval = false;
            if (keyCode >= Key.D0 && keyCode <= Key.D9)
            { retval = true; }

            return retval;
        } 


        #endregion
    }
}
