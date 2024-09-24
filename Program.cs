/*using Software_Project;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SQLiteConnection sqlite_conn = CreateConnection();
                CreateTable(sqlite_conn);
                InsertData(sqlite_conn);

                Application.EnableVisualStyles();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during application startup: " + ex.Message);
                MessageBox.Show("An error occurred during application startup. Please see log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= Software Project DB.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

           *//* SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE TEST (Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();*//*

        }

        static void InsertData(SQLiteConnection conn)
        {
           *//* SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO TEST (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            conn.Close();*//*
        }
    }
}


*/