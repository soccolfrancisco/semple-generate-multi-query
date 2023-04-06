namespace semple_generate_multi_query.Queries
{
    public class Query
    {
        public string Scenery01 = "BEGIN TRANSACTION \r\n\r\nUPDATE tabela.placa\r\nSET ativa = true\r\nWHERE placa = '@plate'\r\n\t\r\nIF @@ERROR != 0\r\n   BEGIN \r\n\t ROLLBACK TRANSACTION\r\n   END\r\n\r\nCOMMIT TRANSACTION\r\n--\n\n";
    }
}
