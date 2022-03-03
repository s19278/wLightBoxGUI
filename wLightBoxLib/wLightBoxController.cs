using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using wLightBoxGUI.wLightBoxLib.Models;

namespace wLightBoxGUI
{
	//whole class represent a connection with 1 device, its written this way so we can handle multiple devices in one gui if we want toii
	public class wLightBoxController
	{
		//Container for GET /info
		public Device device;
		//Container for GET /api/rgbw/extended/state
		public RootRgbw settings;
		//Instance of HttpClient for api requests
		public HttpClient client;
		//Private constructor to prevent creating instance of class without correct connection to device
		private wLightBoxController() {

			 
		}
		//Static method to ensure that given adress is correct. Return instance of class
		public static async Task<wLightBoxController> wLightBoxConnect(string url) {
			HttpClient client = new HttpClient();
			RootRgbw settings = null;
			if (!url.ToLower().StartsWith("https"))
			{

				url = "https://" + url;
				Console.WriteLine(url);
			}

			client.BaseAddress = new Uri(url);

			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			HttpResponseMessage response = await client.GetAsync("/info");

			if (response.IsSuccessStatusCode)
			{
				string responseBody = await response.Content.ReadAsStringAsync();
				RootDevice r = JsonConvert.DeserializeObject<RootDevice>(responseBody);

				return new wLightBoxController
					{
						device = r.device,
						client = client
					};
				
			}
			else
			{
				return null;
			}

		}
		//Handling Get /api/rgbw/extended/state request
		public async Task GetExtState() {

			HttpResponseMessage response = await client.GetAsync("/api/rgbw/extended/state");


			if (response.IsSuccessStatusCode)
			{
				string responseBody = await response.Content.ReadAsStringAsync();
				settings = JsonConvert.DeserializeObject<RootRgbw>(responseBody);
			}

		}
		//Handling POST /api/rgbw/extended/set request
		public async Task<Boolean> UpdateSettings(RootRgbw _settings) {

			var message = new StringContent(JsonConvert.SerializeObject(_settings), Encoding.UTF8, "application/json");
			HttpResponseMessage response = await client.PostAsync("/api/rgbw/extended/set", message);
			if (response.IsSuccessStatusCode)
			{
				settings = _settings;
				return true;
			}
			else
				return false;

		}

	}
}
