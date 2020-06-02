using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Devart.Data.SQLite;
using Sensor;

namespace DataStore
{
    public class DAL_PacientData
    {

        public static void AddData(Sensor.SensorValue SensorData)
        {
            SQLiteConnection conn = new SQLiteConnection(Properties.Settings.Default.ConnStringSQLite);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "INSERT INTO pacientdata(id, pacient_code, sensor_type, timestamp, value)" +
                               "VALUES('"+Guid.NewGuid().ToString()+"','"+SensorData.PacientCode+"','" + SensorData.Type+"','"+SensorData.TimeStamp+"'," + SensorData.Value+")";
            cmd.Connection = conn;
            conn.Open();
            Console.WriteLine(SensorData.PacientCode);
            try
            {
                int aff = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Error adding PacientData");

            }
            finally
            {
                cmd.Connection.Close();
            }


        }


        /*public static List<SensorValue> GetData(PacientCodeEnum patCode, DateTime currDay)
        {
            List<SensorValue> sensorValueList = new List<SensorValue>();

            SQLiteConnection conn = new SQLiteConnection(Properties.Settings.Default.ConnStringSQLite);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, patient_code, sensor_type, timestamp, value from PacientData " +
              " where pacient_code = :pacient_code and timestamp >= :minTime and timestamp < :maxTime ";
            cmd.Parameters.Add(":pacient_code", DbType.String).Value = patCode;
            cmd.Parameters.Add(":minTime", DbType.DateTime).Value = currDay.Date;
            cmd.Parameters.Add(":maxTime", DbType.DateTime).Value = currDay.Date.AddDays(1);

            SQLiteDataReader reader = null;
            try
            {
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SensorValue pItem = new SensorValue();
                    if (reader["pacient_code"] != DBNull.Value) pItem.PacientCode = (String)reader["patient_code"];
                    if (reader["sensor_type"] != DBNull.Value)
                    {
                        string strType = (string)reader["sensor_type"];
                        pItem.Type = (SensorType)Enum.Parse(typeof(SensorType), strType);
                    }
                    if (reader["timestamp"] != DBNull.Value) pItem.TimeStamp = (DateTime)reader["timestamp"];
                    if (reader["value"] != DBNull.Value) pItem.Value = Convert.ToDouble(reader["value"]);
                    sensorValueList.Add(pItem);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error on reading from PatienData table " + ex.Message, ex);
            }
            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                cmd.Connection.Close();
            }
            return sensorValueList;
            }
         */
    }
}
