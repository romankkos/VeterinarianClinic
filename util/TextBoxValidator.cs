using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.util
{
    class TextBoxValidator
    {
        public static readonly String nullFieldMessage = "Поле не может быть пустым";

        // private  void append(StringBuilder builder,String value)
        //{


        //if (value == null) return;
        //builder.Append(value);

        // }

        public void append(StringBuilder builder, String value)
        {
            if (String.IsNullOrEmpty(value)) return;
            builder.Append(value + "\n");
        }

        public string checkValidLength(String value, long length, String fieldCaption)
        {
            StringBuilder builder = new StringBuilder();
            append(builder, isStringValid(value, fieldCaption));
            append(builder, isValidLength(value, length, fieldCaption));
            return builder.ToString();

        }

        public string isStringValid(String value, String fieldCaption)
        {
            if (String.IsNullOrEmpty(value))
            {
                return "Поле \"" + fieldCaption + "\" не может быть пустым";
            }
            return null;

        }

        public string isValidLength(String text, long length, String fieldCaption)
        {
            if (text.Length <= length) return null;
            return "Длина поля \"" + fieldCaption + "\" должна быть не больше " + length + " символов";


        }

        public string isValidDoubleValue(String value, String fieldCaption)
        {
            StringBuilder builder = new StringBuilder();

            try
            {

                double d = Convert.ToDouble(value);

            }
            catch (FormatException)
            {

                append(builder, "Поле " + "\"" + fieldCaption + "\" " + "может принимать только цифровые значения и не может быть пустым");
            }


            return builder.ToString();
        }



        public string PhoneNumberValidate(String phone)
        {
            StringBuilder builder = new StringBuilder();
            append(builder, isStringValid(phone, "Номер телефона"));

            if (String.IsNullOrEmpty(builder.ToString()))
            {
                Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$");
                if (!regex.IsMatch(phone))
                {
                    append(builder, "Номер телефона не соответствует формату \n");
                }
                
                
            }
            

            return builder.ToString();
        }
    }
}
