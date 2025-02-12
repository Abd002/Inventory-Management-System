using System.Windows.Forms;
using System;

namespace Inventory_Management_System
{
    internal static class Utilities
    {
        public static void ChangeForm(Form currentForm, Form newForm)
        {
            
            currentForm.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => currentForm.Close(); 

        }

    }
}