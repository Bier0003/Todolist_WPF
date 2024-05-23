using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;


namespace Todolist_WPF
{
    public class DB_Operation
    {
        private static SqlConnection _connection = DBConnect.GetConnection();
           

        

        public void InsertList(Todo list)
        {


            try
            {
                _connection.Open();

                SqlCommand cmd = _connection.CreateCommand();
                string sql = "INSERT INTO Todo(TodoText,Dato,isCheck) values (@TodoText,@Dato,@isCheck)";


                cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@TodoText", list.TodoText);
                cmd.Parameters.AddWithValue("@Dato", DateTime.Now);
                cmd.Parameters.AddWithValue("@isCheck", false);



                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                
                _connection.Close();
            }

            
        }

        internal void InsertList(string add)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Todo Item)
        {
            try
            {
                _connection.Open();
                SqlCommand cmd = _connection.CreateCommand();
                String SQL = "DELETE FROM todo WHERE  ID = @id";
                cmd = new SqlCommand(SQL, _connection);
                cmd.Parameters.AddWithValue("@Id", Item.id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _connection.Close();
            }

        }


        public int EditItem(Todo item)
        {
            try
            {
                _connection.Open();

                SqlCommand cmd = _connection.CreateCommand();
                //string sql = "UPDATE todo SET todoText = @NewText WHERE ID = @TodoID;";
                //string sql = "UPDATE todo SET todoText = " + list.TodoText + " WHERE ID = " + list.id + ";";
                string sql = "UPDATE todo SET todoText = @noteText,  isCheck = @isCheck WHERE ID = @Id";

                cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@noteText", item.TodoText);
                cmd.Parameters.AddWithValue("@isCheck", item.isCheck);
                cmd.Parameters.AddWithValue("@Id", item.id);





                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;  // Return the number of rows affected by the update
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;  // Return a value indicating an error, for example, -1
            }
            finally
            {
                _connection.Close();
            }
        }

      /*  public int MarkList(Todo list)
        {
            try
            {
                _connection.Open();

                SqlCommand cmd = _connection.CreateCommand();
                //string sql = "UPDATE todo SET todoText = @NewText WHERE ID = @TodoID;";

                //string sql = "UPDATE todo SET todoText = " + list.TodoText + " WHERE ID = " + list.id + ";";
                string Sql = "UPDATE Todo SET isCheck = 1 WHERE ID = @Id";

                cmd = new SqlCommand(Sql, _connection);

                cmd.Parameters.AddWithValue("@Id", list.id);


                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;  // Return the number of rows affected by the update
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;  // Return a value indicating an error, for example, -1
            }
            finally
            {
                _connection.Close();
            }
        }

        internal void MarkList(RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        internal void DeleteList()
        {
            throw new NotImplementedException();
        }

        internal void InsertList()
        {
            throw new NotImplementedException();
        }
    }
}
