namespace CoinGame
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int moedaValor = 0;
        int escolha = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             
            
            moedaValor = new Random().Next(1, 2+1);
            if 
                (moedaValor == 1)
            {
                string Cara = " Cara!, Parabens";
                value.Text = Cara.ToString();
            }

            else

            {
                string Coroa = " Coroa, Happy!";
                value.Text = Coroa.ToString();
            }
        }
    }

}
