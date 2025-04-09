/*Phillip Foster
 * CPT206-A80S
 * Lab 5
 * 
 * Something is not connecting correctly: I've done everything 'by the book' and I've rewatched class a few times and 
 * I cannot figure it out. Razor will not load my cshtml document. When you run the program, all you get is the static 
 * page. My message to myself will probably give you a laugh.
 */

using phillip_foster_cpt206_lab_5; // Startup
Host.CreateDefaultBuilder(args)
  .ConfigureWebHostDefaults(webBuilder =>
  {
      webBuilder.UseStartup<Startup>();

  }).Build().Run();
Console.WriteLine("This executes after the web server has stopped!");