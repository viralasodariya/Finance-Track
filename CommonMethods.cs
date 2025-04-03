namespace WinForms_Expense_Manager;

public class CommonMethods
{

    /// <summary>
    /// UpdateThemes Method theme update and pass the object as the argument of that class
    /// </summary>
    /// <param name="theme"></param>
    /// <param name="form"></param>
    public static void UpdateTheme(string theme, Form form)
    {
        try
        {
            if (theme == "Dark")
            {
                form.BackColor = Color.FromArgb(45, 45, 48);
                form.ForeColor = Color.White;
            }
            else // Light theme
            {
                form.BackColor = SystemColors.ControlLight;
                form.ForeColor = SystemColors.ControlText;
            }

            foreach (Control control in form.Controls)
            {
                UpdateControlTheme(control, theme);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private static void UpdateControlTheme(Control control, string theme)
    {
        if (theme == "Dark")
        {
            control.BackColor = Color.FromArgb(45, 45, 48);
            control.ForeColor = Color.White;
        }
        else
        {
            if (control.GetType().FullName == "System.Windows.Forms.Button")
            {
                control.BackColor = Color.FromArgb(255, 153, 180, 209);
            }
            else if (control.GetType().FullName == "System.Windows.Forms.TextBox")
            {
                control.BackColor = Color.FromArgb(255, 255, 255, 255);
            }
            else
            {
                control.BackColor = SystemColors.ControlLight;
            }
            control.ForeColor = SystemColors.ControlText;
        }

        foreach (Control childControl in control.Controls)
        {
            UpdateControlTheme(childControl, theme);
        }
    }
}
