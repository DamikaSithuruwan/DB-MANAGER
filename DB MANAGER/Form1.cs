using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Data.Odbc;

namespace DB_MANAGER
{
    public partial class Form1 : Form
    {
        private const string Key = "h7Ui63Mzqj61G87j";
        private const string FileName = "UserCredentials.txt";
        //private const string BatchFilePath = "C:\\RestartServices.bat";
        private string server;
        private string password;
        private string cPassword;
        private string dbName;
        private string mdfPath;
        private string ldfPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "*Please Enter a Valid Password and Database Name to Register to the System.";

            if (File.Exists(FileName))
            {
                openBtnForm();
            }
            txtPassword.Select();

        }

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openBtnForm()
        {
            txtPassword.Select();
            lblCpassword.Visible = false;
            lblDbName.Visible = false;
            txtCpassword.Visible=false;
            lblServer.Visible = false;
            txtServer.Visible = false;
            txtDbName.Visible=false;
            pnlButtons.Visible = true;
            lblInfo2.Visible = true;
            lblInfo2.Text = "*Please Enter the Password to Login to the System." +
                "Then you can Attach and Detach your \nDatabase." +
                "Press Setup to Change Database Name";

            btnRegister.Text = "LOGIN";
            btnAttach.Enabled = false;
            btnDetach.Enabled = false;
            btnSetup.Enabled = false;
            //btnReset.Enabled = false;
            //btnReset.Visible = false;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(btnRegister.Text.Equals("REGISTER"))
            {
                if(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCpassword.Text) || string.IsNullOrEmpty(txtDbName.Text))
                {
                    MessageBox.Show("Please Fill in the Blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!txtPassword.Text.Equals(txtCpassword.Text))
                {
                    MessageBox.Show("Passwords are not matching. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                         server = txtServer.Text.Trim();  
                         dbName =txtDbName.Text.Trim();
                        

                        if (DatabaseExists(dbName,server))
                        {
                            //string connectionString = $"Data Source='{server}';Initial Catalog=master;Integrated Security=True";
                            string connectionString = $"Data Source='{server}';Initial Catalog=master;User id=sa;Password=tstc123";
                            string query = $"SELECT type_desc, physical_name FROM sys.master_files WHERE DB_NAME(database_id) = '{dbName}'";

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        using (StreamWriter writer = new StreamWriter(FileName))
                                        {
                                            password = EncryptString(txtPassword.Text);
                                            cPassword = EncryptString(txtCpassword.Text);
                                            server = EncryptString(txtServer.Text);
                                            string EdbName = EncryptString(dbName);


                                            writer.WriteLine(password);
                                            writer.WriteLine(cPassword);
                                            writer.WriteLine(server);
                                            writer.WriteLine(EdbName);


                                            while (reader.Read())
                                            {
                                                string typeDesc = reader["type_desc"].ToString();
                                                string filepath = reader["physical_name"].ToString();

                                                if (typeDesc.Equals("ROWS", StringComparison.OrdinalIgnoreCase))
                                                {
                                                    mdfPath = filepath;
                                                    string EmdfPath = EncryptString(mdfPath);
                                                    writer.WriteLine(EmdfPath);
                                                }
                                                else if (typeDesc.Equals("LOG", StringComparison.OrdinalIgnoreCase))
                                                {
                                                    ldfPath = filepath;
                                                    string EldfPath = EncryptString(ldfPath);
                                                    writer.WriteLine(EldfPath);
                                                }

                                                
                                            }
                                            writer.Close();
                                            
                                        }



                                    }
                                }
                            }
                            MessageBox.Show("Credentials saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Text = "";
                            txtCpassword.Text = "";
                            txtServer.Text = "";
                            txtDbName.Text="";
                            openBtnForm();
                        }
                        else
                        {
                            MessageBox.Show($"Database '{dbName}' does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }else if (btnRegister.Text.Equals("LOGIN"))
            {


                if(!string.IsNullOrEmpty(txtPassword.Text))
                {
                    GetDataFromText();
                    if (txtPassword.Text.Equals(password))
                    {
                        txtPassword.Text = "";
                        btnAttach.Enabled = true;
                        btnDetach.Enabled = true;
                        btnSetup.Enabled = true;
                        //btnReset.Enabled = true;
                        //btnConnect.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private bool DatabaseExists(string dbName,string server)
        {
            // Replace with your actual connection string
            //string connectionString = $"Data Source='{server}';Initial Catalog=master;Integrated Security=True";
            string connectionString = $"Data Source='{server}';Initial Catalog=master;User id=sa;Password=tstc123";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT database_id FROM sys.databases WHERE name = '{dbName}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteScalar() != null;
                }
            }
        }

        private void GetDataFromText()
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                password = DecryptString(reader.ReadLine());
                cPassword = DecryptString(reader.ReadLine());
                server = DecryptString(reader.ReadLine());
                dbName = DecryptString(reader.ReadLine());
                mdfPath = DecryptString(reader.ReadLine());
                ldfPath = DecryptString(reader.ReadLine());
            }
        }

        private void attachDatabase(string dbName,string server,string mdfPath,string ldfPath)
        {
            Cursor.Current = Cursors.WaitCursor;
            //string connectionString = $"Data Source='{server}';Initial Catalog=master;Integrated Security=True";
            string connectionString = $"Data Source='{server}';Initial Catalog=master;User id=sa;Password=tstc123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string attachQuery = $"CREATE DATABASE {dbName} ON (FILENAME = '{mdfPath}'), (FILENAME = '{ldfPath}') FOR ATTACH";
                    using (SqlCommand command = new SqlCommand(attachQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Database attached successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error attaching database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void detachDatabase(string dbName,string server)
        {
            Cursor.Current = Cursors.WaitCursor;
            //string connectionString = $"Data Source='{server}';Initial Catalog=master;Integrated Security=True";
            string connectionString = $"Data Source='{server}';Initial Catalog=master;User id=sa;Password=tstc123";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Set the database offline
                    string setOfflineQuery = $"ALTER DATABASE [{dbName}] SET OFFLINE WITH ROLLBACK IMMEDIATE;";
                    SqlCommand setOfflineCommand = new SqlCommand(setOfflineQuery, connection);
                    setOfflineCommand.ExecuteNonQuery();

                    // Set the database to single-user mode
                    string setSingleUserQuery = $"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    SqlCommand setSingleUserCommand = new SqlCommand(setSingleUserQuery, connection);
                    setSingleUserCommand.ExecuteNonQuery();

                    // Detach Database
                    string detachQuery = $"sp_detach_db '{dbName}','true'";
                    using (SqlCommand command = new SqlCommand(detachQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Database detached successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error detaching database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openLoginForm()
        {
            txtPassword.Select();
            pnlButtons.Visible = false;
            lblInfo2.Visible = false;
            lblCpassword.Visible = true;
            txtCpassword.Visible = true;
            lblServer.Visible = true;
            txtServer.Visible = true;
            lblDbName.Visible = true;
            txtDbName.Visible = true;
            btnRegister.Text = "REGISTER";
           
        }

        private string EncryptString(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[16]; // Use a random IV for additional security

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        private string DecryptString(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[16]; // Use the same IV used during encryption

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(input)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

 /*
        private void ExecuteBatchFile(string batchFilePath)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c \"{batchFilePath}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;

                process.Start();
                process.WaitForExit();

                MessageBox.Show("Services Restarted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Restarting Services: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        */

        private void btnAttach_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Attach Database", "Attach Database", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GetDataFromText();
                attachDatabase(dbName,server, mdfPath, ldfPath);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Detach Database", "Detach Database", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GetDataFromText();
                detachDatabase(dbName, server);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            openLoginForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CreateOdbcConnection();
        }

        private void CreateOdbcConnection()
        {

            string connectionString = $"Driver={{SQL Server}};Server=localhost;Database=Glolanka;Uid=sa;Pwd=tstc123;";

            try
            {
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    connection.ChangeDatabase("master");
                    MessageBox.Show("ODBC Connection Created Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

