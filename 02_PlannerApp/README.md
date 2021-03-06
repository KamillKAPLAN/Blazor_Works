# PlannerApp

- https://www.youtube.com/playlist?list=PLFJQnCcZXWjtftgq0KID4oHk6wfJrRL1r kanalı ile geliştirilen uygulama
- **Radzen UI** Componentini kullanarak geliştirildi ve `https://blazor.radzen.com/` resmi sitesidir.

## Layout Tanımlama

Razor Kod Örneği (**AuthLayout.razor**): 

```C#
@inherits LayoutComponentBase

<div class="middle-box">
    <h1>Welcome to PlannerApp</h1>
    @Body
</div>
```

- layout'un uygulandığı sayfa (**Index.razor**)

```C#
@page "/"
@layout AuthLayout

<div class="row">
    <div class="col-12">
        <h3>Simple login</h3>
    </div>
</div>
<SurveyPrompt Title="How is Blazor working for you?" />

@code {
    
}
```

## Store User Info in Local Storage
- **PlannerApp.Client/Models/** klasörünün içine LocalUserInfo modeli oluşturuldu
- `Blazor.LocalStorage` paketi yüklendi
- **Program.cs** içine `builder.Services.AddBlazoredLocalStorage();` eklendi.
- **_Imports.razor** dosyasının içine `@using Blazored.LocalStorage` eklendi. 
- **Login.razor** dosyasının içine aşağıdaki `code`bloğunu yerleştiriyoruz.

```C#
@inject ILocalStorageService storageService
@code {
  var userInfo = new LocalUserInfo()
  {
    AccessToken = result.Message,
    Email = result.UserInfo["Email"],
    FirstName = result.UserInfo["FirstName"],
    LastName = result.UserInfo["LastName"],
    Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier],
  };
}
```

## Authenticate User In Browser
- PlannerApp.Client.csproj dosyasında <PropertGroup> içine `<BlazorLinkOnBuild>false</BlazorLinkOnBuild>` eklendi.
- Paket yüklemek için `NuGet` açıldı ve `Microsoft.AspNetCore.Components.Authoriaztion` paketi yüklendi.
- `Program.cs` dosyasının içine

```C#
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
```
- **PlannerApp.Client** içinde LoaclAuthenticatinStateProvider.cs dosyası oluşturuldu.
- **_Imports.razor** içinde `@using Microsoft.AspNetCore.Components.Authorization` tanımlama yapıldı.
- **App.razor** dosyasında  düzenleme yapıldı.
- Authentication işlemi **Index.razor** sayfasında uygulandı.

## Notify Auth State & Redirection
- **Index.razor** dosyasında `@attribute [Authorize]` tanımlaması yapıldı.
- `@attribute [Authorize]` global olması için **_Import.razor** dosyasında `@using Microsoft.AspNetCore.Authorization`  tanımlaması yapıldı.
- **Login.razor** dosyasında login olduğunda yönlendirme için `navigationManager.NavigateTo("/");` tanımlaması yapıldı.
- **LocalAuthenticationStateProvider.cs** dosyasında aşağıdaki kod düzenlemesi yapıldı.

```C#
var state = new AuthenticationState(user); ;
NotifyAuthenticationStateChanged(Task.FromResult(state));

return state;
```
- Yapılan düzenlemenin görülebilmesi için **Login.razor** içine `await authenticationStateProvider.GetAuthenticationStateAsync();` düzenlemsi getirildi.
- Yetkisiz girişlere karşın `RedirectToLogin.razor` dosyası oluşturuldu ve **App.razor** içinde kullanıldı. 

## User & Logout Component
- **LocalAuthenticationStateProvider.cs** dosyasının içinde aşağıdaki metod tanımlandı.

```C#
public async Task LogOutAsync()
{
   await _storageService.RemoveItemAsync("User");
   NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));
}
```

- **Shared\UserStatus.razor** dosyası oluşturuldu.
- **MainLayout.razor** dosyasında `UserStatus` componenti tanımlandı.

## Initialize Main Layout & The Menu
- **app.cs** dosyasında `.sidebar` class'ında background düzenlemesi yapıldı. (yapılan değişiklik browser'da görünmüyorsa 'cache' leme olmuştur. Bundan 
       dolayı  `Ctlr + F5` kombinasyonu ile refresh'lememiz gerekmektedir.)
- ** NavMenu.razor** dosyasında menu düzenlemesine gidildi.

## Creating Plan Models
-**02_PlannerApp\PlannerApp.Shared\Models** içinde model dosyaları oluşturuldu

## Creating Plans Service
- **PlannerApp.Shared/Services/PlansService.cs** service'i oluşturuldu.
- **PlannerApp.Client/Program.cs** içinde `PlansService` tanımlama yapıldı.

## Plans Component Get & Show Plans
- **PlannerApp.Client\Pages\Plans\Plan.razor** dosyası oluşturuldu.

## Plans Component - Paging
- **Plans.razor** dosyasında `pagination` işlemi gerçekleştirildi

## Plans Component Search Plans
- **Plans.razor** dosyasında  `search` işlemi gerçekleştirikdi.

## AddPlan Component Init & Design
- **PlannerApp.Shared\Model\PlanRequest.cs** modeli oluşturuldu.
- **PlannerApp.Shared\Services\PlansService.cs** içinde `PostPlanAsync` metodu yazıldı.
- NuGet Package Manager ile `Tewr.Blazor.FileReader` yüklendi. Dosya okumak için yüklendi.
- **Program.cs** dosyasının içinde `FileReader` tanımlaması yapıldı.
```C#
builder.Services.AddFileReaderService(options =>
{
   options.UseWasmSharedBuffer = true;
});
```
- **_Imports.razor** dosyasında `@using Blazor.FileReader;` tanımlaması yapıldı.
- **PlannerApp.Client\Pages\Plans\AddPlan.razor** component'i tanımlandı.

## Add Plan - Choose & Preview File
- **PlannerApp.Client\Pages\Plans\AddPlan.razor** component'inde`@code` bölümü içinde tanımlamalar ve `chooseFileAsync()` metodu yazıldı.

## Add Plan - Send the Request
- **PlannerApp.Client\Pages\Plans\AddPlan.razor** component'inde `@code` bölümü içinde `postPlanAsync()` metodu yazıldı.

## Edit Plan Component - Full
- **PlannerApp.Shared\Services\Planner.Service.cs** içinde `GetPlanByIdAsync()` ve `PutPlanAsync()` metodları yazıldı.
- **PlannerApp.Client\Pages\Plans\EditPlan.razor** component'i tanımlandı.
- **PlannerApp.Client\Pages\Plans\Plans.razor** dosyasında `Edit` metodunda `Edit.razor` yönlendirme işlemi gerçekleştirildi.

## Delete Plan - Full
- **PlannerApp.Shared\Services\Planner.Service.cs** içinde DeletePlanAsync()` metodu yazıldı.
- **PlannerApp.Client\Pages\Plans\Plans.razor** dosyasında `Delete` düzenlemesi ve `selectPlan()` ve `deletedPlanAsync()` metodları yazıldı.

## To-Do Items Models & Service
- **PlannerApp.Shared\Models\ToDoItemRequest.cs** modeli oluşturuldu.
- **PlannerApp.Shared\Services\PlansService.cs** service'i oluşturuldu ve içinde `CreateItemAsync()`, `EditItemAsync()`, `ChangeItemsStateAsync()` ve `DeleteItemAsync()` metodları yazıldı.
- **Program.cs** dosyasında `ToDoItemService`  tanımlaması yapıldı.

```C#
builder.Services.AddScoped<ToDoItemsService>(s =>
{
   return new ToDoItemsService(URL);
});
```

## To-Do Items - Show & Create
- **PlannerApp.Client\Pages\Plans\EditPlan.razor** component'inde `#region Items` yazıldı.  

## To-Do Items Check/Uncheck
- **PlannerApp.Client\Pages\Plans\EditPlan.razor** component'inde düzenlemeler yapıldı.

## To-Do Items - Edit & Delete
- **PlannerApp.Client\Pages\Plans\EditPlan.razor** component'inde düzenlemeler yapıldı.

## Deploy to Azure Storage
- Proje **Publish** edildi. Adımları aşağıda sıralanmıştır.
  -> Öncelikle proje üzerinde sağ clik yapıyoruz. Ardından **`Publish...`** 'e tıklıyoruz.
  -> Karşımıza gelen ekranda **`Start`** 'a tıklıyoruz.
  -> Gelen menüden **`Folder`** 'ı seçiyoruz.
  -> `Choose a folder` bölümü sabit geliyor, adresi `bin\Release\netstandard2.1\publish\` istersek değiştirebiliriz. 
  -> Eğer sabit yerde `publish` etmek istiyorsak **`Create Profile`** 'a tıklıyoruz.
  -> Bizi seçli klasör bölümüne atar ve **`Publish`** ile devam diyoruz.
  -> Projemiz'i `Publish` ettikten sonra `C:\Users\userName\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\bin\Release\netstandard2.1\publish\wwwroot` adresindeki dosyaları `Server` 'a veya `IIS` 'imize atabiliriz.

## Proje Tamamlandı.