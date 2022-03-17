namespace exercise01
{
    public class Colaborador
    {
        public string Name { get; set; }
        public int Matricula { get; set; }
        public string Escola { get; set; }
        public string Universidade { get; set; }

        public Colaborador(string name, int matricula)
        {
            Name = name;
            Matricula = matricula;
        }

        public Colaborador(string name, int matricula, string escola) : this(name, matricula)
        {
            Escola = escola;
        }

        public Colaborador(string name, int matricula, string escola, string universidade) : this(name, matricula, escola)
        {
            Universidade = universidade;
        }

        public override string ToString()
        {
            return $"{Name}, {Matricula}, {Escola}, {Universidade}";
        }
    }
}