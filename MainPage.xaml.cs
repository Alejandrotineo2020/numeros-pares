namespace numero8
{
    public partial class MainPage : ContentPage
    {
       public List<int> MisNumeros { get; set; }

        public MainPage()
        {
            InitializeComponent();
            GenerarNumeros(100);
         


        }

      


        private void GenerarNumeros (int limite)
        {
            List<int> listaNumeros = new List<int>();

            int i = 2;

            while (i <= limite)
            {
                listaNumeros.Add(i);

                i += 2;
            }


            NumerosListView.ItemsSource = listaNumeros;
        }



    }
}
