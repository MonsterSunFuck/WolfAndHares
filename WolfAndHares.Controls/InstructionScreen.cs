namespace WolfAndHares.Controls
{
    using System.Drawing;

    public partial class InstructionScreen : BaseWolfAndHaresControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
        }

        public override void SetFont(Font font)
        {
            base.SetFont(font);
            lblInstruction.Font = btnOk.Font = font;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
