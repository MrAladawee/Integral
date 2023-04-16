namespace Integral
{
    public partial class Form1 : Form
    {
        private Painter painter;

        public Form1()
        {
            InitializeComponent();
            painter = new Painter(mainPanel.CreateGraphics());

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void resize(object sender, EventArgs e)
        {
            mainPanel.Height = this.Height;
            mainPanel.Width = this.Width - 103;
            painter = new Painter(mainPanel.CreateGraphics());
            painter.paint();
        }

        private void push_Click(object sender, EventArgs e)
        {
            painter.maxOX = Convert.ToDouble(val_maxOX.Text);
            painter.maxOY = Convert.ToDouble(val_maxOY.Text);
            painter.minOX = Convert.ToDouble(val_minOX.Text);
            painter.minOY = Convert.ToDouble(val_minOY.Text);
            painter.accuracy = (int)Convert.ToInt64(val_step.Text);
            painter.functionIntegral = val_func.Text;
            painter.paint();
            res.Text = Convert.ToString(Math.Round(painter.S, 5));
            painter.S = 0;
        }
    }
}