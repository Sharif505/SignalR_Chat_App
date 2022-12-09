using Mid_10_Exam.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapHub<ChatingAndSharingHub>("/chatingAndSharingHub");
app.Run();
