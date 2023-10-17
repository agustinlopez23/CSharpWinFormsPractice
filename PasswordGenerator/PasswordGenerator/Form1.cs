using System.Net.NetworkInformation;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        static string upperCaseList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowerCaseList = "abcdefghijklmnopqrstuvwxyz";
        static string numbersList = "1234567890";
        static string symbolsList = "!@#$%^&*(){}[]=<>/,.";

        string allCharsList = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtPasswordLength.Text = "20";
        }
        private void BuildCharsList()
        {
            allCharsList = string.Empty;
            if (chkIncludeLowerCase.Checked)
            {
                allCharsList += lowerCaseList;
            }
            if (chkIncludeUppercase.Checked)
            {
                allCharsList += upperCaseList;
            }
            if (chkIncludeNumbers.Checked)
            {
                allCharsList += numbersList;
            }
            if (chkIncludeSymbols.Checked)
            {
                allCharsList += symbolsList;
            }

            if (string.IsNullOrEmpty(allCharsList))
            {
                allCharsList = lowerCaseList + upperCaseList + numbersList + symbolsList;
            }
        }
        private string GeneratePassword(int length)
        {
            string newPassword = string.Empty;
            if (length < 6)
            {
               
                throw new Exception("A strong password needs to have more than 6 characters");

            }
            for (int i = 0; i < length; i++)
            {
                newPassword += GetRandomChar();
            }
            return newPassword;
        }
        private string GetRandomChar()
        {
            return allCharsList.ToCharArray()[(int)Math.Floor(_random.NextDouble() * allCharsList.Length)].ToString();
        }
        private void btnGeneratorPassword_Click(object sender, EventArgs e)
        {
            try
            {
                 BuildCharsList();
                            txtNewPassword.Text = GeneratePassword(int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtPasswordLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!='.'))
            {
                e.Handled = true;
            }
        }
    }
}