
namespace AlarmOperator.Models.DataView
{
	public class NumContract
	{
		public string? Numb { get; set; }
		public string? Status { get; set; }
		public override string? ToString()
		{
			return Numb;
		}
	}

	internal class DetalModel
	{
		public int Idn3 { get; set; }
		public string? Statusn3 { get; set; }
		public string? Nbn3 { get; set; }
		public string? Otvn3 { get; set; }
		public string? Otn3 { get; set; }
		public string? Adrn3 { get; set; }
		public string? Fnn3 { get; set; }
		public string? Psn3 { get; set; }
		public string? Psn7 { get; set; }
		public short? Numzn7 { get; set; }
		public string? Nzn7 { get; set; }
		public string? Tdan7 { get; set; }
		public string? Snn2 { get; set; }
		public string? Nin22 { get; set; }
		public string? Fnn6 { get; set; }
		public string? Statusn4 { get; set; }
		public string? Numbn4 { get; set; }
		//*******************************************
		public string? Tcentral { get; set; }
		//**************ZonObj************************
		public string? ZGru { get; set; }
		public short? ZZone { get; set; }
		public string? ZNZone { get; set; }
		public string? ZInzen { get; set; }
		public string? ZTda { get; set; }
		public string? ZReserve { get; set; }
		public string? Psn07 { get; set; }
		public string? Model { get; set; }
	}

}
