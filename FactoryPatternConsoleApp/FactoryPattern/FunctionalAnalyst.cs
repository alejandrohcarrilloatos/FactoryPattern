namespace FactoryPattern
    {
        class FunctionalAnalyst : User
        {
            private readonly string _userType;
            private int _id;
            private string _userName;
            private string _nombre;
            private string _apellidoPaterno;
            private string _apellidoMaterno;

            public FunctionalAnalyst(int id, string userName, string nombre, string apellidoPaterno, string apellidoMaterno)
            {
                _userType = "FunctionalAnalyst";
                _id = id;
                _userName = userName;
                _nombre = nombre;
                _apellidoPaterno = apellidoPaterno;
                _apellidoMaterno = apellidoMaterno;

            }

            public override string UserType { get => _userType; }
            public override int Id { get => _id; set => _id = value; }
            public override string UserName { get => _userName; set => _userName = value; }
            public override string Nombre { get => _nombre; set => _nombre = value; }
            public override string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
            public override string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
        }
    }
