namespace MauiApp1
{
    public partial class NewPage1 : ContentPage
    {
        int count = 0;

        public NewPage1()
        {
            InitializeComponent();
        }
        
        private void Vpered()
        {
            Dog.Source = "dog1.jpg";
        }
        private void Nazad()
        { 
            Dog.Source = "dog.jpg";         
        }
    }
}