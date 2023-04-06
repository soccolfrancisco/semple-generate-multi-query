using semple_generate_multi_query.Main;

try
{
    Console.WriteLine("Initializing process...\n");

    new Main().Initial();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Finished process!");
}