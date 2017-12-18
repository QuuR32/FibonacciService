using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        public MainForm()
        {
            InitializeComponent();

            mClient = new ServiceSoapClient();
        }

        /// <summary><c>ComputeFibonacci</c> is a function preparing the task that will call the
        /// "Fibonacci" function on the webservice. This function also handles the display of the
        /// BusyForm.
        /// </summary>
        public async void ComputeFibonacci()
        {
            BusyForm mBusyForm = new BusyForm();
            mBusyForm.Show(this);

            Task<decimal> fibonacciTask = FibonacciAsync(decimal.ToInt32(nudNumber.Value));
            decimal fibonacci = await fibonacciTask;

            mBusyForm.Close();
            MessageBox.Show(this, fibonacci.ToString());
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

        /// <summary>
        /// Function called when the form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mClient.Close();
        }
    }
}
