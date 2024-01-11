
using Newtonsoft.Json;
using System;
using System.Windows;

namespace AlarmOperator.Models.DataView
{
	internal class DataPackage : IEquatable<DataPackage>
	{
		[JsonProperty("tcentral")]
		public string? Tcentral { get; set; }
		[JsonProperty("description")]
		public string? Description { get; set; }

		[JsonProperty("q")]
		public char Q { get; set; }

		[JsonProperty("Code")]
		public string? Code { get; set; }

		[JsonProperty("gru")]
		public short? Gru { get; set; }

		[JsonProperty("nunz")]
		public short? NumZ { get; set; }

		[JsonProperty("time")]
		public DateTime Time { get; set; }

		[JsonProperty("rec")]
		public int Rec { get; set; }
		[JsonProperty("Line")]
		public byte? Line { get; set; }

		[JsonProperty("nzone")]
		public string? NZone { get; set; }
		[JsonProperty("color")]
		public byte? Color { get; set; }
		//********************************
		[JsonProperty("status")]
		public byte Status { get; set; }
			
		[JsonProperty("note")]
		public string? Note { get; set ; }
		//********************************


		#region IEquatable method
		public bool Equals(DataPackage other)
		{
			if (this.Tcentral == other.Tcentral)
				return true;
			return false;
		}
		#endregion

		public override int GetHashCode()
		{
			return Rec.GetHashCode();
		}

	}
}
