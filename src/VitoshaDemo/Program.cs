﻿using Microsoft.Extensions.Configuration;
using Refit;
using Skyware.Vitosha.Model;
using Skyware.Vitosha.Model.Demo;

Console.WriteLine("Vitosha Model Demo");

// App settings and user secrets
IConfiguration configuration = ConfigHelper.BuildConfig();

IVitoshaClient client = RestService.For<IVitoshaClient>(configuration.GetSection("BaseUrl").Value);

Message message = new()
{
    Recipient = "0000000000", // TODO: Replace with a valid phone number
    Text = "Test message.",
    IsViber = false,
};

MessageResponse response = await client.SendMessage(message, configuration.GetSection("ApiKey").Value);

Console.WriteLine($"Status code: {response.StatusCode}");
Console.WriteLine($"Message Id: {response.MessageId}");

//Console.WriteLine("When you receive the message, press Enter to check the status...");
//Console.ReadLine();

