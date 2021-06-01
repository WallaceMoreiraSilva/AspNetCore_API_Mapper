namespace AspNetCore_API_Mapper.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public decimal Salario { get; set; }
    }
}
