using semple_generate_multi_query.Queries;

namespace semple_generate_multi_query.Sceneries
{
    public class Scenery01
    {
        public bool status = true;

        public ReadFile _readFile;

        public Scenery01()
        {
            _readFile = new ReadFile();
        }

        private List<string> Plates()
        {
            var file = new StreamReader(new FileStream($"C:\\Users\\146202\\Desktop\\semple-generate-multi-query\\semple-generate-multi-query\\Changes\\Change01Scenery01.txt", FileMode.Open));
            var plates = new List<string>();
            string line;

            while ((line = file.ReadLine()) != null)
                plates.Add($"{line}");

            file.Close();

            return plates;
        }

        private string? Query()
        {
            return new Query().Scenery01;
        }

        public void Create()
        {
            var plates = Plates();
            var query = Query();
            var platesNews = new List<string>();
            var numberScenery = 0;
            var quantity = 0;
            var quantityPlate = Convert.ToInt32(plates.LongCount());

            foreach (var plate in plates)
            {
                platesNews.Add(plate);

                if (quantity < 499)
                {
                    quantity++;
                    --quantityPlate;
                }
                else
                {
                    _readFile.Reader(platesNews, query, $"1.{numberScenery}");

                    platesNews = new List<string>();
                    quantity = 0;
                    numberScenery++;
                }
            }

            _readFile.Reader(platesNews, query, $"1.{numberScenery}");
        }
    }
}
