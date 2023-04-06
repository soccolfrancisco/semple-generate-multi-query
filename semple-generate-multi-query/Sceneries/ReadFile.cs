using System.Text;

namespace semple_generate_multi_query.Sceneries
{
    public class ReadFile
    {
        public void Reader(List<string> plates, string? query, string scenery)
        {
            var sw = new StreamWriter($"C:\\Projetos\\Results\\scenery-{scenery}.sql", true, Encoding.ASCII);

            foreach (var plate in plates)
            {
                sw.Write(query.Replace("@plate", plate.Trim()));
            }

            sw.Close();
        }
    }
}
