var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


//Routing uygulamalarýnýzýn, adreslerine kýsa isim vermek demektir.

// örnegin /Home/Index isimli bir sayfanýz var ve browser adres çubuðundan direk olarak bu action'a gitmek istiyorsunuz

// bu durumda rouing yaparak, bu adrese bir kýsa yol ekleyebilirsiniz.
// Aþaðýdaki örnekte, pre yazýldýðýnda, Home/Privacy action'ina yönlenmektedir.

app.MapControllerRoute(
	name: "pre",
	pattern: "home",
	defaults: new { controller = "home", action = "Privacy" });

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Test}/{id?}");

app.Run();
