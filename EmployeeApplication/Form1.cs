using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee emp = new PartTimeEmployee();

            emp.FirstName = textBox1.Text;
            emp.LastName = textBox2.Text;
            emp.Department = textBox3.Text;
            emp.JobTitle = textBox4.Text;
            emp.RatePerHour = Convert.ToDouble(textBox5.Text);
            emp.TotalHoursWorked = Convert.ToDouble(textBox6.Text);

            emp.ComputeSalary();

            label7.Text = "First Name: " + emp.FirstName;
            label8.Text = "Last Name: " + emp.LastName;
            label9.Text = "Basic Salary: " + emp.BasicSalary.ToString("C");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
