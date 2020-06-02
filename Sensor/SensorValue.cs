using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Sensor
{
	//public delegate void BindingSource(SensorValue SensorValueBindingSource);
	public enum SensorType
	{
		None,
		SkinTemperature,
		HearhRate,
		BloodGlucose
	}
	public class SensorValue
	{
		private SensorType type;
		private double value;
		private DateTime timeStamp;
		private string pacientCode;


		#region properties
		public string PacientCode
		{
			get { return pacientCode; }
			set { pacientCode = value; }
		}

		public SensorType Type 
		{
			get { return type; }
			set { type = value; }
		}
		public double Value {
			get { return this.value; }
			set { this.value = value; }
		}
		public DateTime TimeStamp {
			get { return timeStamp; }
			set { timeStamp = value; }
		}
		public string TimeStampString {
			get { return timeStamp.ToString("dd-MMMMMMMMM-yyyy HH:mm:ss"); }
			set { timeStamp = DateTime.ParseExact(value, "dd-MMMMMMMMM-yyyy HH:mm:ss", CultureInfo.InvariantCulture); }
		}
		#endregion
		#region constructors
		public SensorValue()
		{
			type = SensorType.None;
		}
		
		public SensorValue(string pacientCode,SensorType type, double value, DateTime timeStamp)
		{
			this.pacientCode = pacientCode;
			this.type = type;
			this.value = value;
			this.timeStamp = timeStamp;
		}
		public SensorValue(SensorType type, double value, DateTime timeStamp) {
			this.type = type;
			this.value = value;
			this.timeStamp = timeStamp;
		}
		public SensorValue(SensorType type, double value, string timeStamp)
		{
			this.type = type;
			this.value = value;
			this.TimeStampString = timeStamp;
		}
		#endregion
	}
}
