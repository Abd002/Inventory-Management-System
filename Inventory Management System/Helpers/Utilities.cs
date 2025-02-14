using System.Windows.Forms;
using System;

namespace Inventory_Management_System
{
    // utility methods that can be used in the application
    internal static class Utilities
    {
        public static void ChangeForm(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
            newForm.FormClosed += (s, args) => currentForm.Close();

        }

    }
}