using semple_generate_multi_query.Sceneries;

namespace semple_generate_multi_query.Main
{
    public class Main
    {
        public Scenery01 _scenery01;

        public Main()
        {
            _scenery01 = new Scenery01();
        }

        public void Initial()
        {
            if (_scenery01.status)
                _scenery01.Create();
        }
    }
}
