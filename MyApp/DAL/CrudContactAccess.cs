namespace MYAPP.DAL;
using MYAPP.Models;
using System.Data;
using MySql.Data.MySqlClient;

public class CrudContactAccess
{
    public static string conString = @"server=localhost;port=3306;user=root;password=welcome@123;database=crud_contact";

    public static List<Crud_Contact> GetAllContact()
    {
        List<Crud_Contact> allContact = new List<Crud_Contact>();
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            string query = "select * from contact_db";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                Crud_Contact contact = new Crud_Contact
                {
                    name = row["name"].ToString(),
                    email = row["email"].ToString(),
                    contact = row["contact"].ToString()
                };
                allContact.Add(contact);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return allContact;
    }

    public static Crud_Contact GetContactById(int id)
    {
        Crud_Contact contact = null;
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "select * from contact_db where id=" +id;
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                contact = new Crud_Contact
                {
                    name = reader["name"].ToString(),
                    email = reader["email"].ToString(),
                    contact = reader["contact"].ToString()
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return contact;
    }

    public static void SaveNewContact(Crud_Contact cont)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = $"insert into contact_db(name,email,contact) values('{cont.name}' , '{cont.email}' , '{cont.contact}')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public static void DeleteContactById(int id)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "delete from contact_db where id = "+id;
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
}