using Application.Services;
using Core.Interface;
using NovaPostManagerr.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddScoped<ISearchSettlementService, SearchSettlementService>();
builder.Services.AddScoped<IInternetDocumentService, InternetDocumentService>();
builder.Services.AddScoped<IOrderPostService, OrderPostService>();

builder.Services.AddDevExpressBlazor(
    configure => configure.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5);
builder.Services.AddDevExpressBlazor();

builder.Services.AddDevExpressBlazorWasmMasks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(NovaPostManagerr.Client._Imports).Assembly);
app.MapControllers();

app.UseDevExpressBlazorWasmMasksStaticFiles();
app.Run();
