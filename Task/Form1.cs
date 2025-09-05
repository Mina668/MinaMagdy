using Task.businessLayer;
using Task.CoreLayer.UnitOfWork;
using Task.DataAccessLayer.Models;
using System.Drawing.Imaging;

namespace Task
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IEmployeeServices _employeeService;
        private readonly IUnitOfWork _unitOfWork;


        public Form1(IEmployeeServices employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = _employeeService.GetEmployees().ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // ID
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Job", HeaderText = "Job" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Salary", HeaderText = "Salary" });

            // Photo as Image
            var imgCol = new DataGridViewImageColumn
            {
                DataPropertyName = "displayphoto",
                HeaderText = "Photo",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imgCol);

            dataGridView1.DataSource = employees;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex].DataBoundItem as Employee;
                if (row != null)
                {
                    txtid.Text = row.Id.ToString();
                    txtName.Text = row.Name;
                    txtJob.Text = row.Job;
                    txtSalary.Text = row.Salary.ToString();
                    pictureBox1.Image = row.displayphoto;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            double salary = 0;
            if (!double.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid salary!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop saving
            }

            var emp = new Employee
            {
                Name = txtName.Text,
                Job = txtJob.Text,
                Salary = salary, // safe value
                displayphoto = pictureBox1.Image
            };


            _employeeService.AddEmployee(emp);
            LoadEmployees();
            MessageBox.Show("Employee added successfully!");
            txtid.Text = "";
            txtName.Clear();
            txtJob.Clear();
            txtSalary.Clear();
            pictureBox1.Image = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text) || !int.TryParse(textBox5.Text, out _))
            {
                MessageBox.Show("Please enter a valid Employee ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(textBox5.Text);
            txtid.Text = id.ToString();
            txtName.Text = _employeeService.GetEmployeeById(id)?.Name;
            txtJob.Text = _employeeService.GetEmployeeById(id)?.Job;
            txtSalary.Text = _employeeService.GetEmployeeById(id)?.Salary.ToString();
            pictureBox1.Image = _employeeService.GetEmployeeById(id)?.displayphoto;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var emp = dataGridView1.CurrentRow.DataBoundItem as Employee;
                if (emp != null)
                {
                    emp.Name = txtName.Text;
                    emp.Job = txtJob.Text;

                    double salary;
                    if (!double.TryParse(txtSalary.Text, out salary))
                    {
                        MessageBox.Show("Please enter a valid salary!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    emp.Salary = salary;
                    
                    emp.displayphoto = pictureBox1.Image;

                    

                    _employeeService.UpdateEmployee(emp);
                    LoadEmployees();
                    MessageBox.Show("Employee updated successfully!");
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(txtid.Text);
                _employeeService.DeleteEmployee(id);
                LoadEmployees();
                MessageBox.Show("Employee deleted successfully!");
                txtid.Clear();
                txtName.Clear();
                txtJob.Clear();
                txtSalary.Clear(); 
                pictureBox1.Image = null;
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                      pictureBox1.Image = Image.FromFile(dlg.FileName) as Image;
                    
                }
            }
        }

        private void txtJob_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
