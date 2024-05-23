using System;
using System.Windows.Forms;

namespace SimpleUIDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateCustomUI();
        }

        private void CreateCustomUI()
        {
            // Panel oluştur
            Panel mainPanel = new Panel();
            mainPanel.Size = new System.Drawing.Size(200, 100);
            mainPanel.Location = new System.Drawing.Point(50, 50);
            mainPanel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(mainPanel);

            // Yes düğmesi oluştur
            Button yesButton = new Button();
            yesButton.Size = new System.Drawing.Size(75, 23);
            yesButton.Location = new System.Drawing.Point(10, 30);
            yesButton.Text = "Yes";
            yesButton.Click += new EventHandler(YesButton_Click);
            mainPanel.Controls.Add(yesButton);

            // No düğmesi oluştur
            Button noButton = new Button();
            noButton.Size = new System.Drawing.Size(75, 23);
            noButton.Location = new System.Drawing.Point(100, 30);
            noButton.Text = "No";
            noButton.Click += new EventHandler(NoButton_Click);
            mainPanel.Controls.Add(noButton);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes clicked!");
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No clicked!");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
