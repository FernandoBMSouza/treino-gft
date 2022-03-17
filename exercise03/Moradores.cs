namespace exercise03
{
    public class Moradores
    {
        private int _telefone;
        private int _numero;

        public int LerTelefone()
        {
            return _telefone;
        }
        public int LerNumero()
        {
            return _numero;
        }
        public void ArmazenaTelefone(int telefone)
        {
            _telefone = telefone;
        }
        public void ArmazenaNumero(int numero)
        {
            _numero = numero;
        }
    }
}