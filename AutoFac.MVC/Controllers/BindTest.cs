namespace AutoFac.MVC.Controllers
{
    public class BindTest
    {
        private string _name;

        public string Getir()
        {
            return _name;
        }

        public string ChangeName(string name)
        {
            _name = name;
            return _name;
        }

    }
}