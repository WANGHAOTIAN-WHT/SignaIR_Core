using Microsoft.AspNetCore.SignalR;
using SignalR_Core_Learn.Service;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR_Core_Learn
{
    public class CountHub : Hub
    {
        private readonly CountService _countService;
        public CountHub(CountService countService)
        {
            _countService = countService;
        }

        public async Task GetLatestCount(string random)
        {
            int count;
            do
            {
                count = _countService.GetLatestCount();
                Thread.Sleep(1000);

                await Clients.All.SendAsync("RecelveUpdate", count);
            } while (count < 10);
            await Clients.All.SendAsync("Finished");
        }
    }
}
