namespace FactoryPattern
{
    class FunctionalAnalystFactory : UserFactory
    {
        private int _id;
        private string _userName;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;

        public FunctionalAnalystFactory(int id, string userName, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            _id = id;
            _userName = userName;
            _nombre = nombre;
            _apellidoPaterno = apellidoPaterno;
            _apellidoMaterno = apellidoMaterno;

        }

        public override User CreateUser()
        {
            return new FunctionalAnalyst(_id, _userName, _nombre, _apellidoPaterno, _apellidoMaterno);
        }

    }
}
