using CompanyEmployees;
using LicenseManager;
using Microsoft.AspNetCore.HttpOverrides;


var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureGoogleSheetsWrapper();
builder.Services.AddControllers();

//----------------------
var app = builder.Build();

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
    IssuedTreads,
    CurrentThreads,
}
public enum PcInfoCellName
{
    FingerPrint,
    WinName,
    WinVer,
    DeviceCode,
    Name,
    Manufacture,
    Model,
    CpuName,
    CpuCode,
    Cpus,
    BoardName,
    BoaedCode,
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
    IssuedTreads,
    CurrentThreads,
    FingerPrint,
    WinName,
    WinVer,
    DeviceCode,
    Name,
    Manufacture,
    Model,
    CpuName,
    CpuCode,
    Cpus,
    BoardName,
    BoaedCode,
    Boards,
    HddCode
}
