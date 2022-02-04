namespace FactoryPattern
{
    class DeveloperFactory : UserFactory
    {
        private int _id;
        private string _userName;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;

        public DeveloperFactory(int id, string userName, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            _id = id;
            _userName = userName;
            _nombre = nombre;
            _apellidoPaterno = apellidoPaterno;
            _apellidoMaterno = apellidoMaterno;

        }

        public override User CreateUser()
        {
            return new Developer(_id, _userName, _nombre, _apellidoPaterno, _apellidoMaterno);
        }
    }
}
