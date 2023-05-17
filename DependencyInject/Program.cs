using DependencyInject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<NumGenerator>(); // NumGenerator sýnýfýný servis olarak ekledik
builder.Services.AddControllers(); // Controllers'ý ekledik
//builder.Services.AddScoped<INumGenerator, NumGenerator>(); // INumGenerator interface'ini servis olarak ekledik
//builder.Services.AddTransient<INumGenerator, NumGenerator>(); // INumGenerator interface'ini servis olarak ekledik
builder.Services.AddSingleton<INumGenerator, NumGenerator>(); // INumGenerator interface'ini servis olarak ekledik


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Controllers'ý eþleþtirin
});

app.Run();

