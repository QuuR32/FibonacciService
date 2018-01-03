using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBService;
using WindowsFormsApp1.ServiceReference;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Main Form
    /// </summary>
    public partial class MainForm : Form
    {
        // The webservice client, built on constructor and closed during the "FormClosing" event
        private ServiceSoapClient mClient;

        private static ServiceClient mClientDB;
        public ServiceClient ClientDB {
            get
            {
                if (mClientDB == null)
                    mClientDB = new ServiceClient();

                if (mClientDB.State != System.ServiceModel.CommunicationState.Opened)
                    mClientDB.Open();

                return mClientDB;
            }
        }

        public MainForm()
        {
            mClient = new ServiceSoapClient();

            RetrieveEmployees();
            RetrieveDepartments();

            InitializeComponent();
        }

        private async void RetrieveEmployees()
        {
            Task<List<Employees>> listEmployeesTask = ClientDB.GetEmployeesAsync();
            List<Employees> listEmployees = await listEmployeesTask;

            foreach (Employees e in listEmployees)
            {
                e.EmployeesDetails = await ClientDB.GetEmployeeDetailsAsync(e.Id);
            }

            cbEmployees.DataSource = listEmployees;
            cbEmployees.DisplayMember = "FirstName";

            employeesBindingSource.DataSource = await listEmployeesTask;
        }

        private async void RetrieveDepartments()
        {
            Task<List<Departments>> listDepartmentsTask = ClientDB.GetDepartmentsAsync();
            List<Departments> listDepartments = await listDepartmentsTask;

            cbDepartments.DataSource = listDepartments;
            cbDepartments.DisplayMember = "Name";

            departmentsBindingSource.DataSource = listDepartments;
        }

        /// <summary><c>ComputeFibonacci</c> is a function preparing the task that will call the
        /// "Fibonacci" function on the webservice. This function also handles the display of the
        /// BusyForm.
        /// </summary>
        public async void ComputeFibonacci()
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            try
            { 
                Task<decimal> fibonacciTask = FibonacciAsync(decimal.ToInt32(nudNumber.Value));
                decimal fibonacci = await fibonacciTask;

                mBusyForm.Close();
                MessageBox.Show(this, fibonacci.ToString());
            }
            catch(Exception ex)
            {
                mBusyForm.Close();
                MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary><c>FibonacciAsync</c> is an async function used to start the asynchronous<c>Task</c>
        /// in charge of calling the "Fibonacci" function on the webservice
        /// </summary>
        public async Task<decimal> FibonacciAsync(int n)
        {
            return await Task.Factory.StartNew(() => mClient.Fibonacci(n));
        }

        /// <summary>
        /// Function raised after a click on the <c>bComputeFibonancci</c> button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bComputeFibonancci_Click(object sender, EventArgs e)
        {
            ComputeFibonacci();
        }

        /// <summary><c>ComputeXmlToJson</c> is an function preparing the task that will call the
        /// "XmlToJson" function on the webservice.
        /// This function also handles the display of the BusyForm
        /// </summary>
        public async void ComputeXmlToJson()
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            Task<string> xmlToJsonTask = XmlToJsonAsync(tbEntryXml.Text);
            string result = await xmlToJsonTask;

            tbResult.Text = result;
            BuildTreeView(result);

            mBusyForm.Close();
        }

        /// <summary><c>XmlToJsonAsync</c> is an async function used to start the asynchronous<c>Task</c>
        /// in charge of calling the "XmlToJson" function on the webservice
        /// </summary>
        /// <param name="s">The string to compute</param>
        public async Task<string> XmlToJsonAsync(string s)
        {
            return await Task.Factory.StartNew(() => mClient.XmlToJson(s));
        }

        /// <summary>
        /// Function raised after a click on the <c>bComputeXmlToJson</c> button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bComputeXmlToJson_Click(object sender, EventArgs e)
        {
            ComputeXmlToJson();
        }

        /// <summary>
        /// Function used to populate the <c>tvResult</c> TreeView from a json string
        /// </summary>
        /// <param name="json"></param>
        private void BuildTreeView(string json)
        {
            tvResult.BeginUpdate();
            try
            {
                tvResult.Nodes.Clear();

                JObject obj = JObject.Parse(json);
                var tNode = tvResult.Nodes[tvResult.Nodes.Add(new TreeNode("Root"))];

                AddNode(obj, tNode);

                tvResult.ExpandAll();
            }
            catch { }
            finally
            {
                tvResult.EndUpdate();
            }
        }

        /// <summary>
        /// Function used by <c>BuildTreeView</c> to populate the <c>tvResult</c> TreeView from a json token
        /// </summary>
        /// <param name="token">The json token</param>
        /// <param name="inTreeNode">The starting node</param>
        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
                }
            }
        }

        private async void cbEmployees_SelectedIndexChanged(object sender, EventArgs ev)
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            try
            {
                Employees e = (Employees) cbEmployees.SelectedItem;
                EmployeesDetails ed = await ClientDB.GetEmployeeDetailsAsync((int)cbEmployees.SelectedValue);
                if (ed != null)
                {
                    tbFirstName.Text = e.FirstName;
                    tbLastName.Text = e.LastName;
                    tbGender.Text = e.Gender;
                    tbJobTitle.Text = ed.JobTitle;
                    tbSalary.Text = ed.Salary.ToString();
                    cbDepartments.SelectedValue = ed.DepartmentId;

                    Departments d = await ClientDB.GetDepartmentAsync(ed.DepartmentId);
                    cbDepartments.SelectedValue = d.Id;
                }
                mBusyForm.Close();
            }
            catch (Exception ex)
            {
                mBusyForm.Close();
                MessageBox.Show(this, ex.Message);
            }
        }

        private async void bSave_Click(object sender, EventArgs e)
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            try
            {
                Employees employee = new Employees()
                {
                    Id = (int)cbEmployees.SelectedValue,
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Gender = tbGender.Text,
                    EmployeesDetails = new EmployeesDetails()
                    {
                        JobTitle = tbJobTitle.Text,
                        Salary = int.Parse(tbSalary.Text),
                        Id = (int)cbEmployees.SelectedValue,
                        DepartmentId = (int)cbDepartments.SelectedValue
                    }
                };
                int result = await ClientDB.SaveEmployeeAsync(employee);
                mBusyForm.Close();
            }
            catch (Exception ex)
            {
                mBusyForm.Close();
                MessageBox.Show(this, ex.Message);
            }
        }

        private async void departmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            try
            {
                foreach (Departments departments in (List<Departments>)departmentsBindingSource.DataSource)
                {
                    Departments department = new Departments()
                    {
                        Id = departments.Id,
                        Name = departments.Name,
                        Location = departments.Location
                    };
                    int result = await ClientDB.SaveDepartmentAsync(department);
                }
                mBusyForm.Close();
            }
            catch (Exception ex)
            {
                mBusyForm.Close();
                MessageBox.Show(this, ex.Message);
            }
        }

        private async void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            try
            {
                foreach (Employees employees in (List<Employees>)employeesBindingSource.DataSource)
                {
                    Employees employee = new Employees()
                    {
                        Id = employees.Id,
                        FirstName = employees.FirstName,
                        LastName = employees.LastName,
                        Gender = employees.Gender,
                        EmployeesDetails = new EmployeesDetails()
                        {
                            JobTitle = employees.EmployeesDetails.JobTitle,
                            Salary = employees.EmployeesDetails.Salary,
                            Id = employees.Id,
                            DepartmentId = employees.EmployeesDetails.DepartmentId
                        }
                    };
                    int result = await ClientDB.SaveEmployeeAsync(employee);
                }
                mBusyForm.Close();
            }
            catch (Exception ex)
            {
                mBusyForm.Close();
                MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary>
        /// Function called when the form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mClient.Close();
            ClientDB.Close();
        }
    }
}
