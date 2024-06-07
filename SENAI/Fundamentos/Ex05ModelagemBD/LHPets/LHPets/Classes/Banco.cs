namespace LHPets.Classes
{
    public class Banco
    {
        // instanciada
        private List<Cliente> lista = new List<Cliente>();

        // Criado o método para pegar a lista
        public List<Cliente> GetLista()
        {
            return lista;
        }

        public string GetListaString()
        {
            string enviar = "<!DOCTYPE html>\n<html>\n<head>\n<meta charset='utf-8'/>\n" +
                            "<title>Cadastro de Cliente</title>\n" +
                            "<style>table{border-spacing: 0; border-collapse: collapse;} th, td{border: 1px solid black; padding: 0 10px;} tbody tr:nth-child(even){background: #ccc}</style>" +
                            "</head>\n<body>" +
                            "<h1>Lista de Cliente</h1>" +
                            "<table><thead><tr>" +
                                "<th>CPF/CNPJ</th>" +
                                "<th>Nome</th>" +
                                "<th>Endereço</th>" +
                                "<th>RG/IE</th>" +
                                "<th>Tipo</th>" +
                                "<th>Valor</th>" +
                                "<th>Valor Imposto</th>" +
                                "<th>Total</th>" +
                            "</thead><tbody>";

            foreach (Cliente cli in GetLista())
            {
                enviar += "<tr>" +
                    $"<td>{cli.cpf_cnpj}</td>" +
                    $"<td>{cli.nome}</td>" +
                    $"<td>{cli.endereco}</td>" +
                    $"<td>{cli.rg_ie}</td>" +
                    $"<td>{cli.tipo}</td>" +
                    $"<td>{cli.valor.ToString("C")}</td>" +
                    $"<td>{cli.valor_imposto.ToString("C")}</td>" +
                    $"<td>{cli.total.ToString("C")}</td>" +
                    "</tr>";
            }

            enviar += "</tbody></table></body></html";
            return enviar;
        }
    }
}
