using Microsoft.AspNetCore.Mvc.Razor;

//INTRO: meio de acesso de todos os recursos
var builder = WebApplication.CreateBuilder(args);

//INTRO: Adicionar MVC ao container
builder.Services.AddControllersWithViews();

//INTRO: contruir a aplicao
var app = builder.Build();

//INTRO: Ativar a pagina de erros caso seja ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

//INTRO: carregar os arquivos estaticos (css, js, etc)
app.UseStaticFiles();

//INTRO: definir a rota padrao
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

//INTRO: Rota de área genérica (não necessário no caso da demo)
app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//INTRO: rodar a aplicacao
app.Run();