using System.Net;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;


namespace HermaPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UploadHandler uploadHandler;


        private HttpListener httpListener;

        private void uploadFilesBtn_Click(object sender, EventArgs e)
        {
            int portNumber = 8080;
            HostUploadWebsite(portNumber, $"http://localhost:{portNumber}/");
            StartUploadListener();
        }

        private void HostUploadWebsite(int portNumber, string baseAddress)
        {
            httpListener = new HttpListener();
            httpListener.Prefixes.Add(baseAddress);

            try
            {
                httpListener.Start();

                // Start listening for incoming requests
                Task.Run(async () =>
                {
                    while (httpListener.IsListening)
                    {
                        try
                        {
                            HttpListenerContext context = await httpListener.GetContextAsync();
                            // Handle the incoming request and generate the appropriate response

                            // sending a index.html file as response
                            string htmlFilePath = "./Resources/index.html";
                            string responseString = File.ReadAllText(htmlFilePath);
                            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                            context.Response.ContentLength64 = buffer.Length;
                            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                            context.Response.OutputStream.Close();
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions that occur during request handling
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                });

                // Display the URL to the user
                string websiteUrl = baseAddress;
                MessageBox.Show($"The website is hosted at:\n\n{websiteUrl}");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during web server startup
                MessageBox.Show($"Error starting the web server: {ex.Message}");
            }
        }

        private void StartUploadListener()
        {
            string uploadUrl = $"http://localhost:8080/upload/"; // Specify the desired URL for the upload endpoint
            string uploadFolderPath = "./Resources/uploads"; // Specify the folder path where you want to save the uploaded files

            uploadHandler = new UploadHandler(uploadUrl, uploadFolderPath);
            uploadHandler.StartListening();

            MessageBox.Show("Upload listener started");
        }
        private void StopUploadListener() // use when the complete button is pressed
        {
            if (uploadHandler != null)
            {
                uploadHandler.StopListening();
                MessageBox.Show("Upload listener stopped");
            }
        }

    }
}