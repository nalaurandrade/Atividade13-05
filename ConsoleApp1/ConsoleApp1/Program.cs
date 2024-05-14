using ConsoleApp1;

Telefone _tel = new Telefone();
_tel.ddd = "34";
_tel.numero = "99950505";

Cliente _cliente = new Cliente();
_cliente.Nome = "Jose";
_cliente.Codigo = 5050;
_cliente.AdicionarTelefone(_tel);

_tel.ddd = "34";
_tel.numero = "9090";
_cliente.AdicionarTelefone(_tel);

_tel.ddd = "35";
_tel.numero = "9091";
_cliente.AdicionarTelefone(_tel);

_cliente.ImprimirTelefones();