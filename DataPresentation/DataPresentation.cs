using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sensor;


namespace DataPresentation
{
	public delegate void VoidFunctionDelegate();
	public partial class DataPresentation : Form
	{

		Dictionary<PacientCodeEnum, PumpSensorValues> dictPacientPump = new Dictionary<PacientCodeEnum, PumpSensorValues>();
		List<SensorValue> sensorValueList = new List<SensorValue>();
		public DataPresentation()
		{
			InitializeComponent();
			cbPacientCodeStart.DataSource = Enum.GetValues(typeof(PacientCodeEnum));

		}
		public enum PacientCodeEnum
		{
			pacient_01,
			pacient_02,
			pacient_03,
			pacient_04,
			pacient_05,
			pacient_06,
			pacient_07,
			pacient_08,
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		void OnNewSensorValueHandler(SensorValue sensorBaseArg)
		{
			DataStore.DAL_PacientData.AddData(sensorBaseArg);

			sensorValueList.Insert(0, sensorBaseArg);
			this.BeginInvoke(new VoidFunctionDelegate(BindDataGridToListOfValues));
		
		}



		private void sensorValueBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}
		private void BindDataGridToListOfValues()
		{
			dgSensorValueList.DataSource = null;
			dgSensorValueList.DataSource = sensorValueList;
		}

		private void bStartPumping_Click(object sender, EventArgs e)
		{
			int timePeriodSecounds = 1;
			if (cbPacientCodeStart.SelectedItem != null && tbTimePeriod.Text != string.Empty)
			{
				try
				{
					timePeriodSecounds = Convert.ToInt32(tbTimePeriod.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Time period input cannot be converted to int ->" + ex.Message);
				}
				PacientCodeEnum currPacient = (PacientCodeEnum)cbPacientCodeStart.SelectedItem;
				startPumping(currPacient, timePeriodSecounds);

			}
		}

		private void bStopPumping_Click(object sender, EventArgs e)
		{
			PacientCodeEnum currPacientStop = (PacientCodeEnum)cbPacientCodeStart.SelectedItem;
			if (dictPacientPump.ContainsKey(currPacientStop))
			{
				PumpSensorValues pumpToBeStoped = dictPacientPump[currPacientStop];
				pumpToBeStoped.StopPumping();
				dictPacientPump.Remove(currPacientStop);
			}
			else
			{
				MessageBox.Show("The selected pacient has no pump values started");
			}
		}
		private void startPumping(PacientCodeEnum patCodeEnum, int periodSecounds)
		{
			if (dictPacientPump.ContainsKey(patCodeEnum))
			{
				MessageBox.Show("The selecteed pacient has the pump already started");
				return;
			}
			PumpSensorValues sensorValuesPump = new PumpSensorValues(patCodeEnum.ToString(), periodSecounds);
			sensorValuesPump.StartPumping();
			sensorValuesPump.newSensorValueEvent += new OnNewSensorValue(OnNewSensorValueHandler);
			dictPacientPump.Add(patCodeEnum, sensorValuesPump);
		}

		private void dgSensorValueList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
