using CompanyEmployees;
using LicenseManager;
using LicenseManager.Extentions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Logging;


var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureGoogleSheetsWrapper();
builder.Services.AddControllers();

//----------------------
var app = builder.Build();
app.UseExceptionHandler(c => c.Run(async context =>
{
    var exception = context.Features
        .Get<IExceptionHandlerPathFeature>()
        .Error;
    var response = new { error = exception.Message };
    await context.Response.WriteAsJsonAsync(response);
}));

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

public enum LicenseInfoCellName
{
    Key,
    TG,
    StartDate,
    EndDate,
    IssuedDays,
    LastDays,
    IssuedThreads,
    CurrentThreads,
}
public enum PcInfoCellName
{
    FingerPrint,
    WinName,
    WinVer,
    DeviceCode,
    Name,
    Manufacturer,
    Model,
    CpuName,
    CpuCode,
    Cpus,
    BoardName,
    BoardCode,
    Boards,
    HddCode
}
public enum CredentialsCellName
{
    Key,
    TG,
    StartDate,
    EndDate,
    IssuedDays,
    LastDays,
    IssuedThreads,
    CurrentThreads,
    FingerPrint,
    WinName,
    WinVer,
    DeviceCode,
    Name,
    Manufacturer,
    Model,
    CpuName,
    CpuCode,
    Cpus,
    BoardName,
    BoardCode,
    Boards,
    HddCode
}
