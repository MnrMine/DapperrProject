using Dapperr.Context;
using Dapperr.Services.AgentService;
using Dapperr.Services.CategoryService;
using Dapperr.Services.LocationService;
using Dapperr.Services.ProductService;
using Dapperr.Services.ProductService.ProductService;
using Dapperr.Services.PropertyService;
using Dapperr.Services.PropertyTypeService;
using Dapperr.Services.SliderService;
using Dapperr.Services.StatusService;
using Dapperr.Services.TagService;
using Dapperr.Services.TestimonialService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<DapperContext>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IPropertyService, PropertyService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IAgentService, AgentService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IPropertyTypeService, PropertyTypeService>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<ITagService, TagService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
