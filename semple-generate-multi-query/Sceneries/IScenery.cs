namespace semple_generate_multi_query.Sceneries
{
    public interface IScenery
    {
        void Create();

        void Reader(List<string> plates, string query, string scenery);
    }
}
