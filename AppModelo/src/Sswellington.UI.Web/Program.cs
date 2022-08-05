//INTRO: meio de acesso de todos os recursos
var builder = WebApplication.CreateBuilder(args);

//INTRO: contrui a aplicação
var app = builder.Build(); 

//INTRO: define a rota raíz
app.MapGet("/", () => "Hello World!");

//INTRO: roda a aplicação
app.Run();
