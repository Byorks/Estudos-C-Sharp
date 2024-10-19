using Microsoft.Data.SqlClient;

namespace LHPets.Classes
{   // Classes
    public class Banco
    {
        // instanciada
        // Lista para armazenar os clientes
        private List<Cliente> lista = new List<Cliente>();

        // Criado o método para pegar a lista
        public List<Cliente> GetLista()
        {
            return lista;
        }

        // Gerando HTML a partir da lista
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

    // Método para criar a conexão
    public Banco()
    {
        try
        {   // Dentro vamos montar uma string de conexão, vamos colocar as informações e ele fará a conexão com o BD
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
                // Coloca o link do servidor
                "Server= < Link do servidor > " +
                // Selecionando o banco
                "Database=vendas" +
                // Colocando que vamos logar pelo sistema do windows
                "Integrated Security = true" +
                "Trusted_Connection = true" +
                );

            // using serve para proteger os comandos
            // instanciando um objeto
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string sql = "SELECT * FROM tblclientes";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader tabela = cmd.ExecuteReader())
                    {
                        while (tabela.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                cpf_cnpj = tabela["cpf_cnpj"].ToString(),
                                nome = tabela["nome"].ToString(),
                                endereco = tabela["endereco"].ToString(),
                                rg_ie = tabela[rg_ie].ToString(),
                                tipo = (char)tabela["tipo"],
                                valor = (float)Convert.ToDecimal(tabela["valor"]),
                                valor_imposto = (float)Convert.ToDecimal(tabela["valor_imposto"]),
                                total = (float)Convert.ToDecimal(tabela["total"])
                            });
                        }
                    }
                }

            }
        }
        // Pegará o erro, isso caso aconteça
        catch (Exception)
        {
            Console.WriteLine(Exception);
        }
    }
}
