using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ElevatorControl_sem3
{ 
    class DatabaseClass:Elevator
    {
        String ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;data source=./AppData/LogTable.accdb";
        String item;
        string[] st = new string[3];
        String queryString;
        OleDbCommand command;
        DataSet dataSet;
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        OleDbCommandBuilder builder;

        public void UnsavedLog(ListBox listBox, string Log)
        {
            string date = DateTime.Now.ToString("M/d/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string list = date + "\t\t" + time + "\t\t" + Log;
            listBox.Items.Add(list);
        }

        public void SaveLog(ListBox LogBox)
        {
            queryString = "SELECT * FROM Log";
            dataSet = new DataSet();
            using (connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                adapter = new OleDbDataAdapter();
                adapter.SelectCommand = new OleDbCommand(queryString, connection);
                builder = new OleDbCommandBuilder(adapter);

                adapter.Fill(dataSet, "Logs");
                DataTable LogTable = dataSet.Tables["Logs"];

                //int c = LogBox.Items.Count;

                while (!(LogBox.Items.Count == 0))
                {
                    item = LogBox.Items[0].ToString();
                    st = item.Split(new string[] { "\t\t" }, StringSplitOptions.None);
                    DataRow row = LogTable.NewRow();
                    int count = 0;
                    foreach (String word in st)
                    {
                        count++;
                        if (count <= 3)
                        {
                            row[count] = word;
                        }
                    }
                    LogTable.Rows.Add(row);
                    LogBox.Items.Remove(LogBox.Items[0]);
                }
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(LogTable);
            }
        }

        public void Delete()
        {

        }

        public void displaySavedLog(ListBox ListBox)
        {
            connection = new OleDbConnection(ConnectionString);
            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Log";
            adapter = new OleDbDataAdapter(command);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            try
            {
                connection.Open();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string list = "   " + row["ID"] + "\t" + row["Time_Log"] + "\t\t" + row["Date_Log"] + "\t\t\t" + row["Event_Log"];
                    if (!ListBox.Items.Contains(list))
                    {
                        ListBox.Items.Add(list);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Opps! Something went Wrong");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();
            }
        }
        // // // // 

        //public void record(ListBox display)
        //{
        //    String commandText = "select * from Log";
        //    OleDbConnection oleDb = new OleDbConnection(ConnectionString);
        //    OleDbCommand comm = new OleDbCommand(commandText, oleDb);
        //    OleDbDataAdapter da = new OleDbDataAdapter(comm);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
            
        //    foreach (DataRow row in ds.Tables[0].Rows)
        //    {
                
        //        string listDisplay = row["ID"] + "\t\t" + row["Time_log"].ToString() +  "\t\t" + row["Date_log"].ToString() + "\t\t" + @row["Event_log"];
        //        if (!display.Items.Contains(listDisplay))
        //        {
        //            display.Items.Add(listDisplay);

        //        }

        //    }
        //}
        //public void AddEvent(String action)
        //{
        //    string date = DateTime.Now.ToString("M/d/yyyy");
        //    string time = DateTime.Now.ToString("HH:mm:ss");
        //    string entryCommand = "INSERT INTO Log(Time_log, Date_log, Event_log) VALUES(date, time, action)";
        //    using (OleDbConnection dbConnection = new OleDbConnection(ConnectionString))
        //    {
        //        OleDbCommand comm_insert = new OleDbCommand(entryCommand, dbConnection);
        //        comm_insert.Parameters.AddWithValue("@date", date);
        //        comm_insert.Parameters.AddWithValue("@time", time);
        //        comm_insert.Parameters.AddWithValue("@action", action);
        //        try
        //        {
        //            dbConnection.Open();

        //            comm_insert.ExecuteReader();

        //            dbConnection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }

        //    }

        //}
       
       

    }
}
