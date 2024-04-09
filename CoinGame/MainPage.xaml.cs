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

            int escolha = Convert.ToInt32(picker.SelectedIndex);
            moedaValor = new Random().Next(0, 2);
           
            if 
                (moedaValor == 0)
            {
                string Cara = " Cara!";
                ValueCoin.Text = Cara.ToString();
                ImageCoin.Source = "dotnet_bot.png";
            }

            else

            {
                string Coroa = " Coroa!";
                ValueCoin.Text = Coroa.ToString();
                ImageCoin.Source = "dotnet_bat.png";
            }

            if
                (escolha == moedaValor)
            {
                string Cara = " Parabens";
                value.Text = Cara.ToString();
              

            }

            else

            {
                string Coroa = " oh não!";
                value.Text = Coroa.ToString();
            }
        }
    }

}
