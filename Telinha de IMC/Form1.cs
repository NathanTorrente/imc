namespace Telinha_de_IMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // Título IMC
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e) // Tela Background
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // Botão Calcular
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            double altura = Convert.ToDouble(tx_altura.Text);
            double peso = Convert.ToDouble(tx_peso.Text);
            string sexo = tx_sexo.Text;
            int idade = Convert.ToInt32(tx_idade.Text);

            Pessoa p = new Pessoa(nome, cpf, idade, sexo, peso, altura);

            (double a, string b, string c) = p.CalcularIMC();
            lb_resultado.Text = $"O IMC é: {a.ToString("F2")} \n A Classificação é: {b} \nGrau de Obesidade: {c}";

            bool chamarCPF = Validacion.ValidarCPF(cpf);
            MessageBox.Show(chamarCPF.ToString());

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // CPF
        {


        }
    }
}
