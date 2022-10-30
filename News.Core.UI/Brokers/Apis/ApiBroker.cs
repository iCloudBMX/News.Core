using News.Core.UI.Brokers.Apis.Exceptions;
using System;
using System.Text.Json;

namespace News.Core.UI.Brokers.Apis;

public partial class ApiBroker : IApiBroker
{
	private readonly HttpClient httpClient;
	
	public ApiBroker()
	{
		httpClient = new HttpClient();
    }

	public async ValueTask<T> GetAsync<T>(string relativeUrl)
	{
		var response = await httpClient.GetAsync(relativeUrl);
		var content = await response.Content.ReadAsStringAsync();

		if (content is null)
			throw new ContentNullException();

		var jsonDeserializeOption = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true
		};

		return JsonSerializer.Deserialize<T>(content, jsonDeserializeOption);
	}
}