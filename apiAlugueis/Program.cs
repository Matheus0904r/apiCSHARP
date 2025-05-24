using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models;
using apiAlugueis.Rotas;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Alugueis>(options => options.UseSqlite("Data Source=alugueis.db"));
