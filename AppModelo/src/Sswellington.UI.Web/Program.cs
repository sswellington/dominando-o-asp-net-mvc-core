//INTRO: meio de acesso de todos os recursos
var builder = WebApplication.CreateBuilder(args);

//INTRO: contrui a aplica��o
var app = builder.Build(); 

//INTRO: define a rota ra�z
app.MapGet("/", () => "Hello World!");

//INTRO: roda a aplica��o
app.Run();
