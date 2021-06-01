namespace AspNetCore_API_Mapper.DTOs
{
    public class FuncionarioDTO
    {
        public string NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public bool IsAtivo { get; set; }
    }
}
