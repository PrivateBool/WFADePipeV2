namespace WFADePipeV2
{
    public partial class FormInterface : Form
    {
        private Controleur controleur;
        public FormInterface()
        {
            InitializeComponent();
            controleur = new Controleur();
        }

        private void buttonBrasser_Click(object sender, EventArgs e)
        {
            controleur.GenererDe();
            
            labelTypeDeDe.Text = controleur.TrouverTypeDeDe(controleur.Hasard);
            textBoxValeurDe.Text = controleur.Brasser(controleur.Hasard).ToString();
            textBoxTotalObtenu.Text = controleur.TotalObtenu.ToString();
        }
    }
}