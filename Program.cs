using ecommerce_music_back.Repository;
using ecommerce_music_back.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using pi_4.Models;
using pi_4.Repository;
using pi_4.service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddCors();
builder.Services.AddAutoMapper(typeof(AutoMapperPerfil));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUsuarioRepository, UsuarioService>();
builder.Services.AddScoped<IUsuarioAdmRepository, UsuarioAdmService>();
builder.Services.AddScoped<IRegistroRepository, RegistroService>();
builder.Services.AddScoped<IUsuarioProdutoRepository, UsuarioProdutoService>();

//Fazendo conexão com o banco de dados





var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
