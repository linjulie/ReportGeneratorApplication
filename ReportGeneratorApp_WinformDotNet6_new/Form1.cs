namespace ReportGeneratorApp_WinformDotNet6_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportGeneratorApp_WinformDotNet6_new.ReportDefenitions.demoReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}