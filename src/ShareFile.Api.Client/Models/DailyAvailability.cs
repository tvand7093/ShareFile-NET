// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	public class DailyAvailability : ODataObject 
	{
		public string Days { get; set; }
		public int StartHour { get; set; }
		public int StartMin { get; set; }
		public int EndHour { get; set; }
		public int EndMin { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as DailyAvailability;
			if(typedSource != null)
			{
				Days = typedSource.Days;
				StartHour = typedSource.StartHour;
				StartMin = typedSource.StartMin;
				EndHour = typedSource.EndHour;
				EndMin = typedSource.EndMin;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Days", out token) && token.Type != JTokenType.Null)
				{
					Days = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("StartHour", out token) && token.Type != JTokenType.Null)
				{
					StartHour = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("StartMin", out token) && token.Type != JTokenType.Null)
				{
					StartMin = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("EndHour", out token) && token.Type != JTokenType.Null)
				{
					EndHour = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("EndMin", out token) && token.Type != JTokenType.Null)
				{
					EndMin = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
			}
		}
	}
}