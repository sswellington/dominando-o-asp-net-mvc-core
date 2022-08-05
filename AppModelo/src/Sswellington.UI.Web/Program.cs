//INTRO: meio de acesso de todos os recursos
var builder = WebApplication.CreateBuilder(args);

//INTRO: Adicionar MVC ao container
builder.Services.AddControllersWithViews();

//INTRO: contruir a aplicao
var app = builder.Build();

//INTRO: Ativar a pagina de erros caso seja ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

//INTRO: definir a rota padrao
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

//INTRO: rodar a aplicacao
app.Run();