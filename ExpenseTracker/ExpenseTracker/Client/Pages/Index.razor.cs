using ExpenseTracker.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace ExpenseTracker.Client.Pages
{
    public partial class Index
    {
        [Inject] HttpClient client { get;set; }
        List<Expense>? expenses;

        protected override async Task OnInitializedAsync()
        {

             expenses = await client.GetFromJsonAsync<List<Expense>>("api/expenses");
        }
    }
}
