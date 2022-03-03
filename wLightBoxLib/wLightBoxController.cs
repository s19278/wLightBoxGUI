using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using wLightBoxGUI.wLightBoxLib.Models;

namespace wLightBoxGUI
{
	public class wLightBoxController
	{
		public Device device;
		public RootRgbw settings;
		public HttpClient client;
		private wLightBoxController() {

			 
		}

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

		public async Task GetExtState() {

			HttpResponseMessage response = await client.GetAsync("/api/rgbw/extended/state");


			if (response.IsSuccessStatusCode)
			{
				string responseBody = await response.Content.ReadAsStringAsync();
				settings = JsonConvert.DeserializeObject<RootRgbw>(responseBody);
			}

		}

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
