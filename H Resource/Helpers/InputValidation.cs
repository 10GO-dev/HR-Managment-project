using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Utilities
{
    public static class InputValidation
    {
        public static void NumberOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool ValidateEmail(string email)
        {
            try
            {
                var Email = new System.Net.Mail.MailAddress(email);
                return Email.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
