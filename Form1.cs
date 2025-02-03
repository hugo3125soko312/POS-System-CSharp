using System.Runtime.CompilerServices;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public static bool darkThemeBool = false;
    public Form1() //core first update
    {
        InitializeComponent();
        string dateTimeString = DateTime.Now.ToString();
        labelTime.Text = dateTimeString;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        int dateTimeDay = DateTime.Now.Day;
        int dateTimeMonth = DateTime.Now.Month;
        int merged = dateTimeDay + dateTimeMonth;
        string mergedString = merged.ToString();
        string userInput = textBoxUser.Text;
        string passwordInput = textBoxPassword.Text;
        string sessionInput = textBoxSession.Text;
        System.Diagnostics.Debug.WriteLine($"user: {userInput}, pass: {passwordInput}, session: {sessionInput}");
        bool userInputBool = false;
        bool passwordInputBool = false;
        bool sessionInputBool = false;
        if (sessionInput == mergedString)
        {
            sessionInputBool = true;
        }
        if (userInput == "admin9" && passwordInput == "admin9")
        {
            userInputBool = true;
            passwordInputBool = true;
        }
        if (userInputBool && passwordInputBool && sessionInputBool)
        {
            MessageBox.Show($"Succesfully logged in as \"{userInput}\".", "logged in");
            Form mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("invalid credentials", "error");
            //please dleete this
            Form mainForm = new Form2();
            mainForm.Show();
            this.Hide();
            // end of this

        }
    }

    private void button2_Click(object sender, EventArgs e)
    {

        MessageBox.Show("contact owner and admin", "Forgot details...");
    }

    private void labelTime_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (darkThemeBool == false)
        {
            darkThemeBool = true;
            // set dark theme
        } else if (darkThemeBool == true)
        {
            darkThemeBool = false;
            //set white theme (remove dark theme)
        }
        
    }
}