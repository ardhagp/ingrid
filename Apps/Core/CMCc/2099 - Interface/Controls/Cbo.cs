namespace CMCc.UI.Controls
{
    public partial class CboCs : System.Windows.Forms.ComboBox
    {
        public CboCs()
        {
            InitializeComponent();
            this.Font = CMCc.Component.Properties.Global.globalFontLbl;
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleBuffered = true;
        }

    }
}
