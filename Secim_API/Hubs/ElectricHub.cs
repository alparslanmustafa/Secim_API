using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Secim_API.Hubs
{
	public class ElectricHub:Hub
	{
        private readonly ElectricService _service;
        public ElectricHub(ElectricService service)
        {
            _service = service;
        }

        public async Task GetElectricConsumeList()
        {
            await Clients.All.SendAsync("ReceiveElectricList", _service.GetElectricChartsList());
        }
    }
}
