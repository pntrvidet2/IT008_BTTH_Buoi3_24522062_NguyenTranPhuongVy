using System.Windows.Forms;

namespace BT04
{
    public partial class FormBT04 : Form
    {
      
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem colorMenu;
        private ColorDialog colorDialog;
        public FormBT04()
        {
            InitializeComponent();
        }

        private void FormBT04_Load(object sender, EventArgs e)
        {
            this.Text = "BT04 - Minh họa Menu & ColorDialog";
            this.Width = 600;
            this.Height = 400;
            this.BackColor = Color.White;

            menuStrip = new MenuStrip();

            formatMenu = new ToolStripMenuItem("Format");
            colorMenu = new ToolStripMenuItem("Color");

          
            formatMenu.DropDownItems.Add(colorMenu);

           
            menuStrip.Items.Add(formatMenu);

        
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

         
            colorDialog = new ColorDialog();

          
            colorMenu.Click += ColorMenu_Click;

        }
        private void ColorMenu_Click(object sender, EventArgs e)
        {
          
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
            
                this.BackColor = colorDialog.Color;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
